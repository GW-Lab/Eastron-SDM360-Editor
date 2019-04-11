<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
      Me.GrpUSB = New System.Windows.Forms.GroupBox()
      Me.Label33 = New System.Windows.Forms.Label()
      Me.Label32 = New System.Windows.Forms.Label()
      Me.Label31 = New System.Windows.Forms.Label()
      Me.Label30 = New System.Windows.Forms.Label()
      Me.Label29 = New System.Windows.Forms.Label()
      Me.CmbParity = New System.Windows.Forms.ComboBox()
      Me.CmbBits = New System.Windows.Forms.ComboBox()
      Me.CmbStopBits = New System.Windows.Forms.ComboBox()
      Me.CmbComPort = New System.Windows.Forms.ComboBox()
      Me.CmbBPS = New System.Windows.Forms.ComboBox()
      Me.BtnApply = New System.Windows.Forms.Button()
      Me.NudPassword = New System.Windows.Forms.NumericUpDown()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.PictureBox1 = New System.Windows.Forms.PictureBox()
      Me.NudReadInterval = New System.Windows.Forms.NumericUpDown()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.GrpUSB.SuspendLayout()
      CType(Me.NudPassword, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.NudReadInterval, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'GrpUSB
      '
      Me.GrpUSB.Controls.Add(Me.Label33)
      Me.GrpUSB.Controls.Add(Me.Label32)
      Me.GrpUSB.Controls.Add(Me.Label31)
      Me.GrpUSB.Controls.Add(Me.Label30)
      Me.GrpUSB.Controls.Add(Me.Label29)
      Me.GrpUSB.Controls.Add(Me.CmbParity)
      Me.GrpUSB.Controls.Add(Me.CmbBits)
      Me.GrpUSB.Controls.Add(Me.CmbStopBits)
      Me.GrpUSB.Controls.Add(Me.CmbComPort)
      Me.GrpUSB.Controls.Add(Me.CmbBPS)
      Me.GrpUSB.Location = New System.Drawing.Point(189, 2)
      Me.GrpUSB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.GrpUSB.Name = "GrpUSB"
      Me.GrpUSB.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.GrpUSB.Size = New System.Drawing.Size(213, 197)
      Me.GrpUSB.TabIndex = 12
      Me.GrpUSB.TabStop = False
      Me.GrpUSB.Text = "USB (RS485)"
      '
      'Label33
      '
      Me.Label33.AutoSize = True
      Me.Label33.Location = New System.Drawing.Point(8, 166)
      Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label33.Name = "Label33"
      Me.Label33.Size = New System.Drawing.Size(49, 17)
      Me.Label33.TabIndex = 12
      Me.Label33.Text = "Pariry:"
      '
      'Label32
      '
      Me.Label32.AutoSize = True
      Me.Label32.Location = New System.Drawing.Point(8, 135)
      Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label32.Name = "Label32"
      Me.Label32.Size = New System.Drawing.Size(73, 17)
      Me.Label32.TabIndex = 11
      Me.Label32.Text = "Stop bit(s)"
      '
      'Label31
      '
      Me.Label31.AutoSize = True
      Me.Label31.Location = New System.Drawing.Point(8, 103)
      Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label31.Name = "Label31"
      Me.Label31.Size = New System.Drawing.Size(35, 17)
      Me.Label31.TabIndex = 10
      Me.Label31.Text = "Bits:"
      '
      'Label30
      '
      Me.Label30.AutoSize = True
      Me.Label30.Location = New System.Drawing.Point(8, 66)
      Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label30.Name = "Label30"
      Me.Label30.Size = New System.Drawing.Size(39, 17)
      Me.Label30.TabIndex = 9
      Me.Label30.Text = "BPS:"
      '
      'Label29
      '
      Me.Label29.AutoSize = True
      Me.Label29.Location = New System.Drawing.Point(8, 33)
      Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label29.Name = "Label29"
      Me.Label29.Size = New System.Drawing.Size(38, 17)
      Me.Label29.TabIndex = 8
      Me.Label29.Text = "Port:"
      '
      'CmbParity
      '
      Me.CmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CmbParity.FormattingEnabled = True
      Me.CmbParity.Items.AddRange(New Object() {"None", "Odd", "Even"})
      Me.CmbParity.Location = New System.Drawing.Point(104, 161)
      Me.CmbParity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.CmbParity.Name = "CmbParity"
      Me.CmbParity.Size = New System.Drawing.Size(97, 24)
      Me.CmbParity.TabIndex = 7
      '
      'CmbBits
      '
      Me.CmbBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CmbBits.FormattingEnabled = True
      Me.CmbBits.Items.AddRange(New Object() {"8"})
      Me.CmbBits.Location = New System.Drawing.Point(104, 95)
      Me.CmbBits.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.CmbBits.Name = "CmbBits"
      Me.CmbBits.Size = New System.Drawing.Size(97, 24)
      Me.CmbBits.TabIndex = 6
      '
      'CmbStopBits
      '
      Me.CmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CmbStopBits.FormattingEnabled = True
      Me.CmbStopBits.Items.AddRange(New Object() {"1", "2"})
      Me.CmbStopBits.Location = New System.Drawing.Point(104, 128)
      Me.CmbStopBits.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.CmbStopBits.Name = "CmbStopBits"
      Me.CmbStopBits.Size = New System.Drawing.Size(97, 24)
      Me.CmbStopBits.TabIndex = 4
      '
      'CmbComPort
      '
      Me.CmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CmbComPort.FormattingEnabled = True
      Me.CmbComPort.Items.AddRange(New Object() {"com1", "com2", "com3", "com4", "com5", "com6", "com7", "com8", "com9"})
      Me.CmbComPort.Location = New System.Drawing.Point(104, 28)
      Me.CmbComPort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.CmbComPort.Name = "CmbComPort"
      Me.CmbComPort.Size = New System.Drawing.Size(97, 24)
      Me.CmbComPort.TabIndex = 5
      '
      'CmbBPS
      '
      Me.CmbBPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CmbBPS.FormattingEnabled = True
      Me.CmbBPS.Items.AddRange(New Object() {"2400", "4800", "9600", "19200", "38400"})
      Me.CmbBPS.Location = New System.Drawing.Point(104, 62)
      Me.CmbBPS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.CmbBPS.Name = "CmbBPS"
      Me.CmbBPS.Size = New System.Drawing.Size(97, 24)
      Me.CmbBPS.TabIndex = 3
      '
      'BtnApply
      '
      Me.BtnApply.Location = New System.Drawing.Point(293, 224)
      Me.BtnApply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.BtnApply.Name = "BtnApply"
      Me.BtnApply.Size = New System.Drawing.Size(97, 28)
      Me.BtnApply.TabIndex = 15
      Me.BtnApply.Text = "Apply"
      Me.BtnApply.UseVisualStyleBackColor = True
      '
      'NudPassword
      '
      Me.NudPassword.Location = New System.Drawing.Point(84, 12)
      Me.NudPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.NudPassword.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
      Me.NudPassword.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
      Me.NudPassword.Name = "NudPassword"
      Me.NudPassword.Size = New System.Drawing.Size(80, 22)
      Me.NudPassword.TabIndex = 13
      Me.NudPassword.Value = New Decimal(New Integer() {1001, 0, 0, 0})
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(5, 14)
      Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(73, 17)
      Me.Label1.TabIndex = 14
      Me.Label1.Text = "Password:"
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(9, 48)
      Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(167, 151)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 16
      Me.PictureBox1.TabStop = False
      '
      'NumericUpDown1
      '
      Me.NudReadInterval.Increment = New Decimal(New Integer() {5, 0, 0, 0})
      Me.NudReadInterval.Location = New System.Drawing.Point(111, 224)
      Me.NudReadInterval.Maximum = New Decimal(New Integer() {900, 0, 0, 0})
      Me.NudReadInterval.Name = "NumericUpDown1"
      Me.NudReadInterval.Size = New System.Drawing.Size(65, 22)
      Me.NudReadInterval.TabIndex = 17
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(12, 226)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(96, 17)
      Me.Label2.TabIndex = 18
      Me.Label2.Text = "Read interval:"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(186, 227)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(63, 17)
      Me.Label3.TabIndex = 19
      Me.Label3.Text = "Seconds"
      '
      'FrmSettings
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(409, 265)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.NudReadInterval)
      Me.Controls.Add(Me.BtnApply)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.NudPassword)
      Me.Controls.Add(Me.GrpUSB)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
      Me.Name = "FrmSettings"
      Me.Text = "Eastron SDM360-V2"
      Me.GrpUSB.ResumeLayout(False)
      Me.GrpUSB.PerformLayout()
      CType(Me.NudPassword, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.NudReadInterval, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents GrpUSB As GroupBox
   Friend WithEvents BtnApply As Button
   Friend WithEvents Label33 As Label
   Friend WithEvents Label32 As Label
   Friend WithEvents Label31 As Label
   Friend WithEvents Label30 As Label
   Friend WithEvents Label29 As Label
   Friend WithEvents CmbParity As ComboBox
   Friend WithEvents CmbBits As ComboBox
   Friend WithEvents CmbStopBits As ComboBox
   Friend WithEvents CmbComPort As ComboBox
   Friend WithEvents CmbBPS As ComboBox
   Friend WithEvents NudPassword As NumericUpDown
   Friend WithEvents Label1 As Label
   Friend WithEvents PictureBox1 As PictureBox
   Friend WithEvents NudReadInterval As NumericUpDown
   Friend WithEvents Label2 As Label
   Friend WithEvents Label3 As Label
End Class
