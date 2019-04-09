' Program..: FrmEastronDSM360.vb
' Author...: G. Wassink
' Design...: 
' Date.....: 08/04/2019 Last revised:08/04/2019
' Notice...: Copyright 1994-2016 All Rights Reserved
' Notes....: VB 16.0 .Net Framework 4.7.2
' Files....: None
' Programs.:
' Reserved.:This SOFTWARE PRODUCT is provided by THE PROVIDER "as is" and "with all faults." THE PROVIDER makes no representations or warranties of any kind concerning the safety,
'          : suitability, lack Of viruses, inaccuracies, typographical errors, Or other harmful components Of this SOFTWARE PRODUCT.
'          : There are inherent dangers In the use Of any software, And you are solely responsible For determining whether this SOFTWARE PRODUCT Is compatible With your equipment
'          : And other software installed On your equipment.
'          : You are also solely responsible For the protection Of your equipment And backup Of your data, And THE PROVIDER will Not be liable For any damages you may suffer In connection
'          : With Using, modifying, Or distributing this SOFTWARE PRODUCT.
'          : Free To use 

Public Class FrmEastronDSM360
   Private WithEvents ModBus As ModBusClient

   Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnReadApply.Click
      Me.ModBus.ReadInputRegisters(NudModBusID.Value, If(RbtInput.Checked, ModBusDSM360.ModBusFun.Input, ModBusDSM360.ModBusFun.Holding), NudAddress.Value, NudQuantity.Value)
      TsStatus.Text = "Read"
   End Sub

   Private Sub BtnWriteApply_Click(sender As Object, e As EventArgs) Handles BtnWriteApply.Click
      Me.ModBus.WriteHoldingRegisters(NudModBusID.Value, ModBusDSM360.ModBusFun.HoldingWrite, NudAddress.Value, NudQuantity.Value, NudWriteValue.Value)
      TsStatus.Text = "Write"
   End Sub

   Private Sub FrmModBus_Load(sender As Object, e As EventArgs) Handles Me.Load
      ModBus = New ModBusClient(My.Settings.ComPort, My.Settings.BaudRate, My.Settings.DataBits, My.Settings.StopBits, My.Settings.Parity, My.Settings.ReadTimeOut, My.Settings.WriteTimeOut)
      ModBus.Open()

      Me.ContextMenuStrip = CmsMain
   End Sub

   Private Sub ModBus_ReceiveDataChanged(value As Single,
                                         unit As ModBusDSM360.Unit,
                                         fun As ModBusDSM360.ModBusFun,
                                         message As String) Handles ModBus.Receive_Data_Changed
      Me.BeginInvoke(Sub()
                        If fun = ModBusDSM360.ModBusFun.Input Then
                           LblOutput.Text = $"{value:##0.00} {unit}"
                        Else
                           LblOutput.Text = $"{value:#} {unit}"
                           NudWriteValue.Value = value
                        End If

                        TsStatus.Text = message
                     End Sub)
   End Sub

   Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles MnuExit.Click
      Close()
   End Sub

   Private Sub ModBus_Port_Status_Changed(isOpen As Boolean, message As String) Handles ModBus.Port_Status_Changed
      Me.BeginInvoke(Sub()
                        BtnReadApply.Enabled = isOpen
                        TsStatus.Text = message
                        lblControlunitPowerValue.BackColor = If(isOpen, Color.Green, Color.Red)
                     End Sub)
   End Sub

   Private Sub MnuSettings_Click(sender As Object, e As EventArgs) Handles MnuSettings.Click
      Dim frm = New FrmSettings(Me)
      frm.Show()
   End Sub

   Private Sub ModBus_Device_Status_Changed(status As Boolean, message As String) Handles ModBus.Device_Status_Changed
      Me.BeginInvoke(Sub()
                        LblOutput.Text = $"{0:##0.00} {ModBusDSM360.Unit.Unkwown}"
                        TsStatus.Text = message
                     End Sub)
      TlsStatus.Text = message
   End Sub

   Private Sub RbtInput_CheckedChanged(sender As Object, e As EventArgs) Handles RbtInput.CheckedChanged
      NudAddress.Minimum = 30001
      NudAddress.Maximum = 30345
      NudAddress.Value = 30001
      GrpWrite.Enabled = False
   End Sub

   Private Sub RbtHolding_CheckedChanged(sender As Object, e As EventArgs) Handles RbtHolding.CheckedChanged
      NudAddress.Minimum = 40001
      NudAddress.Maximum = 40089
      NudAddress.Value = 40001
      GrpWrite.Enabled = True
   End Sub


End Class