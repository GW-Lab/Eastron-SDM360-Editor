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
      Me.GrpUSB.SuspendLayout()
      CType(Me.NudPassword, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.GrpUSB.Location = New System.Drawing.Point(142, 2)
      Me.GrpUSB.Name = "GrpUSB"
      Me.GrpUSB.Size = New System.Drawing.Size(160, 160)
      Me.GrpUSB.TabIndex = 12
      Me.GrpUSB.TabStop = False
      Me.GrpUSB.Text = "USB (RS485)"
      '
      'Label33
      '
      Me.Label33.AutoSize = True
      Me.Label33.Location = New System.Drawing.Point(6, 135)
      Me.Label33.Name = "Label33"
      Me.Label33.Size = New System.Drawing.Size(36, 13)
      Me.Label33.TabIndex = 12
      Me.Label33.Text = "Pariry:"
      '
      'Label32
      '
      Me.Label32.AutoSize = True
      Me.Label32.Location = New System.Drawing.Point(6, 110)
      Me.Label32.Name = "Label32"
      Me.Label32.Size = New System.Drawing.Size(54, 13)
      Me.Label32.TabIndex = 11
      Me.Label32.Text = "Stop bit(s)"
      '
      'Label31
      '
      Me.Label31.AutoSize = True
      Me.Label31.Location = New System.Drawing.Point(6, 84)
      Me.Label31.Name = "Label31"
      Me.Label31.Size = New System.Drawing.Size(27, 13)
      Me.Label31.TabIndex = 10
      Me.Label31.Text = "Bits:"
      '
      'Label30
      '
      Me.Label30.AutoSize = True
      Me.Label30.Location = New System.Drawing.Point(6, 54)
      Me.Label30.Name = "Label30"
      Me.Label30.Size = New System.Drawing.Size(31, 13)
      Me.Label30.TabIndex = 9
      Me.Label30.Text = "BPS:"
      '
      'Label29
      '
      Me.Label29.AutoSize = True
      Me.Label29.Location = New System.Drawing.Point(6, 27)
      Me.Label29.Name = "Label29"
      Me.Label29.Size = New System.Drawing.Size(29, 13)
      Me.Label29.TabIndex = 8
      Me.Label29.Text = "Port:"
      '
      'CmbParity
      '
      Me.CmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CmbParity.FormattingEnabled = True
      Me.CmbParity.Items.AddRange(New Object() {"None", "Odd", "Even"})
      Me.CmbParity.Location = New System.Drawing.Point(78, 131)
      Me.CmbParity.Name = "CmbParity"
      Me.CmbParity.Size = New System.Drawing.Size(74, 21)
      Me.CmbParity.TabIndex = 7
      '
      'CmbBits
      '
      Me.CmbBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CmbBits.FormattingEnabled = True
      Me.CmbBits.Items.AddRange(New Object() {"8"})
      Me.CmbBits.Location = New System.Drawing.Point(78, 77)
      Me.CmbBits.Name = "CmbBits"
      Me.CmbBits.Size = New System.Drawing.Size(74, 21)
      Me.CmbBits.TabIndex = 6
      '
      'CmbStopBits
      '
      Me.CmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CmbStopBits.FormattingEnabled = True
      Me.CmbStopBits.Items.AddRange(New Object() {"1", "2"})
      Me.CmbStopBits.Location = New System.Drawing.Point(78, 104)
      Me.CmbStopBits.Name = "CmbStopBits"
      Me.CmbStopBits.Size = New System.Drawing.Size(74, 21)
      Me.CmbStopBits.TabIndex = 4
      '
      'CmbComPort
      '
      Me.CmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CmbComPort.FormattingEnabled = True
      Me.CmbComPort.Items.AddRange(New Object() {"com1", "com2", "com3", "com4", "com5", "com6", "com7", "com8", "com9"})
      Me.CmbComPort.Location = New System.Drawing.Point(78, 23)
      Me.CmbComPort.Name = "CmbComPort"
      Me.CmbComPort.Size = New System.Drawing.Size(74, 21)
      Me.CmbComPort.TabIndex = 5
      '
      'CmbBPS
      '
      Me.CmbBPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CmbBPS.FormattingEnabled = True
      Me.CmbBPS.Items.AddRange(New Object() {"2400", "4800", "9600", "19200", "38400"})
      Me.CmbBPS.Location = New System.Drawing.Point(78, 50)
      Me.CmbBPS.Name = "CmbBPS"
      Me.CmbBPS.Size = New System.Drawing.Size(74, 21)
      Me.CmbBPS.TabIndex = 3
      '
      'BtnApply
      '
      Me.BtnApply.Location = New System.Drawing.Point(246, 168)
      Me.BtnApply.Name = "BtnApply"
      Me.BtnApply.Size = New System.Drawing.Size(48, 23)
      Me.BtnApply.TabIndex = 15
      Me.BtnApply.Text = "Apply"
      Me.BtnApply.UseVisualStyleBackColor = True
      '
      'NudPassword
      '
      Me.NudPassword.Location = New System.Drawing.Point(63, 8)
      Me.NudPassword.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
      Me.NudPassword.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
      Me.NudPassword.Name = "NudPassword"
      Me.NudPassword.Size = New System.Drawing.Size(60, 20)
      Me.NudPassword.TabIndex = 13
      Me.NudPassword.Value = New Decimal(New Integer() {1001, 0, 0, 0})
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(4, 11)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(56, 13)
      Me.Label1.TabIndex = 14
      Me.Label1.Text = "Password:"
      '
      'PictureBox1
      '
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(7, 39)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(125, 123)
      Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
      Me.PictureBox1.TabIndex = 16
      Me.PictureBox1.TabStop = False
      '
      'FrmSettings
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(307, 197)
      Me.Controls.Add(Me.BtnApply)
      Me.Controls.Add(Me.PictureBox1)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.NudPassword)
      Me.Controls.Add(Me.GrpUSB)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "FrmSettings"
      Me.Text = "Eastron DSM360-V2"
      Me.GrpUSB.ResumeLayout(False)
      Me.GrpUSB.PerformLayout()
      CType(Me.NudPassword, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
