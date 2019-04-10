' Program..: FrmSettings.vb
' Author...: G. Wassink
' Design...: 
' Date.....: 08/04/2019 Last revised:10/04/2019
' Notice...: Copyright 2019 All Rights Reserved
' Notes....: VB 16.0.1 .Net Framework 4.7.2
' Files....: None
' Programs.:
' Reserved.: 

Public Class FrmSettings
   ReadOnly frm As Form

   Public Sub New(frm As Form)
      InitializeComponent() ' This call is required by the designer.
      ' Add any initialization after the InitializeComponent() call.
      Me.frm = frm
   End Sub

   Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
      CmbComPort.Text = My.Settings.ComPort
      CmbBPS.Text = My.Settings.BaudRate
      CmbBits.Text = My.Settings.DataBits
      CmbParity.SelectedIndex = My.Settings.Parity
      CmbStopBits.Text = My.Settings.StopBits

      Me.Location = Me.frm.Location
   End Sub

   Private Sub BtnApply_Click(sender As Object, e As EventArgs) Handles BtnApply.Click
      My.Settings.ComPort = CmbComPort.Text
      My.Settings.BaudRate = CmbBPS.Text
      My.Settings.DataBits = CmbBits.Text
      My.Settings.StopBits = CmbStopBits.Text
      My.Settings.Parity = CmbParity.SelectedIndex

      Close()
   End Sub
End Class