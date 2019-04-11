' Program..: FrmSDM360.vb
' Author...: G. Wassink
' Design...: 
' Date.....: 08/04/2019 Last revised:10/04/2019
' Notice...: Copyright 2019 All Rights Reserved
' Notes....: VB 16.0.1 .Net Framework 4.7.2
' Files....: None
' Programs.:
' Reserved.:This SOFTWARE PRODUCT is provided by THE PROVIDER "as is" and "with all faults." THE PROVIDER makes no representations or warranties of any kind concerning the safety,
'          : suitability, lack Of viruses, inaccuracies, typographical errors, Or other harmful components Of this SOFTWARE PRODUCT.
'          : There are inherent dangers In the use Of any software, And you are solely responsible For determining whether this SOFTWARE PRODUCT Is compatible With your equipment
'          : And other software installed On your equipment.
'          : You are also solely responsible For the protection Of your equipment And backup Of your data, And THE PROVIDER will Not be liable For any damages you may suffer In connection
'          : With Using, modifying, Or distributing this SOFTWARE PRODUCT.
'          : Free To use 

Public Class FrmSDM360
   Private WithEvents SDM360 As SDM360Client

   Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnReadApply.Click
      Me.SDM360.ReadRegisters(NudModBusID.Value, If(RbtInput.Checked, EastronSDM360.SDM360.ModBusFun.Input, EastronSDM360.SDM360.ModBusFun.Holding), NudAddress.Value, NudQuantity.Value)

      If ChkReadTimer.Checked Then
         Me.SDM360.ReadTimer = True
      End If

      TsStatus.Text = "Read"
   End Sub

   Private Sub BtnWriteApply_Click(sender As Object, e As EventArgs) Handles BtnWriteApply.Click
      Me.SDM360.WriteHoldingRegisters(NudModBusID.Value, NudAddress.Value, NudQuantity.Value, NudWriteValue.Value)
      TsStatus.Text = "Write"
   End Sub

   Private Sub FrmModBus_Load(sender As Object, e As EventArgs) Handles Me.Load
      SDM360 = New SDM360Client(My.Settings.ComPort, My.Settings.BaudRate, My.Settings.DataBits, My.Settings.StopBits, My.Settings.Parity, My.Settings.ReadTimeOut, My.Settings.WriteTimeOut)
      SDM360.Open()

      Me.ContextMenuStrip = CmsMain
   End Sub

   Private Sub ModBus_ReceiveDataChanged(value As Single,
                                         unit As SDM360.Unit,
                                         fun As SDM360.ModBusFun,
                                         message As String) Handles SDM360.Receive_Data_Changed
      Me.BeginInvoke(Sub()
                        Select Case fun
                           Case EastronSDM360.SDM360.ModBusFun.Input
                              LblOutput.Text = $"{value:##0.00} {unit}"
                           Case EastronSDM360.SDM360.ModBusFun.Holding
                              LblOutput.Text = $"{value:0.#} {unit}"
                              NudWriteValue.Value = value
                           Case EastronSDM360.SDM360.ModBusFun.HoldingWrite
                              If message = "Ok" Then
                                 LblOutput.Text = $"{NudWriteValue.Value:##0.00} {unit}"
                              End If
                        End Select

                        TsStatus.Text = message
                     End Sub)
   End Sub

   Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles MnuExit.Click
      Close()
   End Sub

   Private Sub ModBus_Port_Status_Changed(isOpen As Boolean, message As String) Handles SDM360.Port_Status_Changed
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

   Private Sub ModBus_Device_Status_Changed(status As Boolean, message As String) Handles SDM360.Device_Status_Changed
      Me.BeginInvoke(Sub()
                        LblOutput.Text = $"{0:##0.00} {EastronSDM360.SDM360.Unit.Unkwown}"
                        TsStatus.Text = message
                     End Sub)
      TlsStatus.Text = message
   End Sub

   Private Sub RbtInput_CheckedChanged(sender As Object, e As EventArgs) Handles RbtInput.CheckedChanged
      NudAddress.Minimum = 30001
      NudAddress.Maximum = 30345
      NudAddress.Value = 30001
      GrpRead.Enabled = True
      GrpWrite.Enabled = False
   End Sub

   Private Sub RbtHolding_CheckedChanged(sender As Object, e As EventArgs) Handles RbtHolding.CheckedChanged
      NudAddress.Minimum = 40001
      NudAddress.Maximum = 40089
      NudAddress.Value = 40001

      ChkReadTimer.Checked = False
      GrpRead.Enabled = False
      GrpWrite.Enabled = True
   End Sub

   Private Sub ChkReadTimer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkReadTimer.CheckedChanged
      If Not ChkReadTimer.Checked Then Me.SDM360.ReadTimer = False
   End Sub
End Class