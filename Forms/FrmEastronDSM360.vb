Public Class FrmEastronDSM360
   Private WithEvents ModBus As ModBusClient

   Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
      Me.ModBus.ReadInputRegisters(NudModBusID.Value,
                                   If(RbtInput.Checked, ModBusEastronDSM360.ModBusFun.Input, ModBusEastronDSM360.ModBusFun.Holding),
                                   NudAddress.Value,
                                   NudQuantity.Value)
   End Sub

   Private Sub FrmModBus_Load(sender As Object, e As EventArgs) Handles Me.Load
      ModBus = New ModBusClient(My.Settings.ComPort,
                                My.Settings.BaudRate,
                                My.Settings.DataBits,
                                My.Settings.StopBits,
                                My.Settings.Parity,
                                My.Settings.ReadTimeOut,
                                My.Settings.WriteTimeOut)
      ModBus.Open()

      Me.ContextMenuStrip = CmsMain
   End Sub

   Private Sub ModBus_ReceiveDataChanged(value As Single,
                                         unit As ModBusEastronDSM360.Unit,
                                         fun As ModBusEastronDSM360.ModBusFun,
                                         message As String) Handles ModBus.Receive_Data_Changed
      Me.BeginInvoke(Sub()
                        LblOutput.Text = If(fun = ModBusEastronDSM360.ModBusFun.Input, $"{value:##0.00} {unit}", $"{value:#} {unit}")
                        TsStatus.Text = message
                     End Sub)
   End Sub

   Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles MnuExit.Click
      Close()
   End Sub

   Private Sub ModBus_Port_Status_Changed(isOpen As Boolean, message As String) Handles ModBus.Port_Status_Changed
      Me.BeginInvoke(Sub()
                        BtnRead.Enabled = isOpen
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
                        LblOutput.Text = $"{0:##0.00} {ModBusEastronDSM360.Unit.Unkwown}"
                        TsStatus.Text = message
                     End Sub)
      TlsStatus.Text = message
   End Sub

   Private Sub RbtInput_CheckedChanged(sender As Object, e As EventArgs) Handles RbtInput.CheckedChanged
      NudAddress.Minimum = 30001
      NudAddress.Maximum = 30345
      NudAddress.Value = 30001
   End Sub

   Private Sub RbtHolding_CheckedChanged(sender As Object, e As EventArgs) Handles RbtHolding.CheckedChanged
      NudAddress.Minimum = 40001
      NudAddress.Maximum = 40089
      NudAddress.Value = 40001
   End Sub
End Class