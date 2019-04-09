<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEastronDSM360
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
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEastronDSM360))
      Me.BtnReadApply = New System.Windows.Forms.Button()
      Me.NudAddress = New System.Windows.Forms.NumericUpDown()
      Me.LblAddress = New System.Windows.Forms.Label()
      Me.NudQuantity = New System.Windows.Forms.NumericUpDown()
      Me.LblQuatity = New System.Windows.Forms.Label()
      Me.LblOutput = New System.Windows.Forms.Label()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.NudModBusID = New System.Windows.Forms.NumericUpDown()
      Me.lblControlunitPowerValue = New System.Windows.Forms.Label()
      Me.CmsMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.MnuSettings = New System.Windows.Forms.ToolStripMenuItem()
      Me.MnuExit = New System.Windows.Forms.ToolStripMenuItem()
      Me.TmrMain = New System.Windows.Forms.Timer(Me.components)
      Me.StsMain = New System.Windows.Forms.StatusStrip()
      Me.TsStatus = New System.Windows.Forms.ToolStripStatusLabel()
      Me.TlsStatus = New System.Windows.Forms.ToolStripStatusLabel()
      Me.RbtInput = New System.Windows.Forms.RadioButton()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.GroupBox2 = New System.Windows.Forms.GroupBox()
      Me.GrpWrite = New System.Windows.Forms.GroupBox()
      Me.NudWriteValue = New System.Windows.Forms.NumericUpDown()
      Me.BtnWriteApply = New System.Windows.Forms.Button()
      Me.RbtHolding = New System.Windows.Forms.RadioButton()
      CType(Me.NudAddress, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.NudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.NudModBusID, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.CmsMain.SuspendLayout()
      Me.StsMain.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      Me.GroupBox2.SuspendLayout()
      Me.GrpWrite.SuspendLayout()
      CType(Me.NudWriteValue, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'BtnReadApply
      '
      Me.BtnReadApply.Location = New System.Drawing.Point(107, 10)
      Me.BtnReadApply.Name = "BtnReadApply"
      Me.BtnReadApply.Size = New System.Drawing.Size(60, 23)
      Me.BtnReadApply.TabIndex = 0
      Me.BtnReadApply.Text = "Apply"
      Me.BtnReadApply.UseVisualStyleBackColor = True
      '
      'NudAddress
      '
      Me.NudAddress.Increment = New Decimal(New Integer() {2, 0, 0, 0})
      Me.NudAddress.Location = New System.Drawing.Point(105, 17)
      Me.NudAddress.Maximum = New Decimal(New Integer() {30345, 0, 0, 0})
      Me.NudAddress.Minimum = New Decimal(New Integer() {30001, 0, 0, 0})
      Me.NudAddress.Name = "NudAddress"
      Me.NudAddress.Size = New System.Drawing.Size(75, 20)
      Me.NudAddress.TabIndex = 1
      Me.NudAddress.Value = New Decimal(New Integer() {30001, 0, 0, 0})
      '
      'LblAddress
      '
      Me.LblAddress.AutoSize = True
      Me.LblAddress.Location = New System.Drawing.Point(9, 20)
      Me.LblAddress.Name = "LblAddress"
      Me.LblAddress.Size = New System.Drawing.Size(48, 13)
      Me.LblAddress.TabIndex = 2
      Me.LblAddress.Text = "Address:"
      '
      'NudQuantity
      '
      Me.NudQuantity.Location = New System.Drawing.Point(105, 40)
      Me.NudQuantity.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
      Me.NudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
      Me.NudQuantity.Name = "NudQuantity"
      Me.NudQuantity.Size = New System.Drawing.Size(75, 20)
      Me.NudQuantity.TabIndex = 3
      Me.NudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'LblQuatity
      '
      Me.LblQuatity.AutoSize = True
      Me.LblQuatity.Location = New System.Drawing.Point(9, 44)
      Me.LblQuatity.Name = "LblQuatity"
      Me.LblQuatity.Size = New System.Drawing.Size(49, 13)
      Me.LblQuatity.TabIndex = 4
      Me.LblQuatity.Text = "Quantity:"
      '
      'LblOutput
      '
      Me.LblOutput.AutoSize = True
      Me.LblOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.LblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.LblOutput.Location = New System.Drawing.Point(10, 15)
      Me.LblOutput.Name = "LblOutput"
      Me.LblOutput.Size = New System.Drawing.Size(14, 13)
      Me.LblOutput.TabIndex = 5
      Me.LblOutput.Text = "0"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(5, 13)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(60, 13)
      Me.Label4.TabIndex = 7
      Me.Label4.Text = "ModBusID:"
      '
      'NudModBusID
      '
      Me.NudModBusID.Location = New System.Drawing.Point(108, 10)
      Me.NudModBusID.Maximum = New Decimal(New Integer() {247, 0, 0, 0})
      Me.NudModBusID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
      Me.NudModBusID.Name = "NudModBusID"
      Me.NudModBusID.Size = New System.Drawing.Size(75, 20)
      Me.NudModBusID.TabIndex = 6
      Me.NudModBusID.Value = New Decimal(New Integer() {2, 0, 0, 0})
      '
      'lblControlunitPowerValue
      '
      Me.lblControlunitPowerValue.BackColor = System.Drawing.Color.Red
      Me.lblControlunitPowerValue.Location = New System.Drawing.Point(0, 1)
      Me.lblControlunitPowerValue.Name = "lblControlunitPowerValue"
      Me.lblControlunitPowerValue.Size = New System.Drawing.Size(8, 8)
      Me.lblControlunitPowerValue.TabIndex = 8
      '
      'CmsMain
      '
      Me.CmsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuSettings, Me.MnuExit})
      Me.CmsMain.Name = "CmsMain"
      Me.CmsMain.Size = New System.Drawing.Size(117, 48)
      '
      'MnuSettings
      '
      Me.MnuSettings.Image = CType(resources.GetObject("MnuSettings.Image"), System.Drawing.Image)
      Me.MnuSettings.Name = "MnuSettings"
      Me.MnuSettings.Size = New System.Drawing.Size(116, 22)
      Me.MnuSettings.Text = "Settings"
      '
      'MnuExit
      '
      Me.MnuExit.Image = CType(resources.GetObject("MnuExit.Image"), System.Drawing.Image)
      Me.MnuExit.Name = "MnuExit"
      Me.MnuExit.Size = New System.Drawing.Size(116, 22)
      Me.MnuExit.Text = "Exit"
      '
      'TmrMain
      '
      Me.TmrMain.Enabled = True
      Me.TmrMain.Interval = 10000
      '
      'StsMain
      '
      Me.StsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsStatus})
      Me.StsMain.Location = New System.Drawing.Point(0, 224)
      Me.StsMain.Name = "StsMain"
      Me.StsMain.Size = New System.Drawing.Size(190, 22)
      Me.StsMain.TabIndex = 9
      '
      'TsStatus
      '
      Me.TsStatus.Name = "TsStatus"
      Me.TsStatus.Size = New System.Drawing.Size(39, 17)
      Me.TsStatus.Text = "Status"
      '
      'TlsStatus
      '
      Me.TlsStatus.Name = "TlsStatus"
      Me.TlsStatus.Size = New System.Drawing.Size(23, 17)
      Me.TlsStatus.Text = "OK"
      '
      'RbtInput
      '
      Me.RbtInput.AutoSize = True
      Me.RbtInput.Checked = True
      Me.RbtInput.Location = New System.Drawing.Point(28, 66)
      Me.RbtInput.Name = "RbtInput"
      Me.RbtInput.Size = New System.Drawing.Size(49, 17)
      Me.RbtInput.TabIndex = 10
      Me.RbtInput.TabStop = True
      Me.RbtInput.Text = "Input"
      Me.RbtInput.UseVisualStyleBackColor = True
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.GroupBox2)
      Me.GroupBox1.Controls.Add(Me.GrpWrite)
      Me.GroupBox1.Controls.Add(Me.RbtHolding)
      Me.GroupBox1.Controls.Add(Me.RbtInput)
      Me.GroupBox1.Controls.Add(Me.NudAddress)
      Me.GroupBox1.Controls.Add(Me.LblAddress)
      Me.GroupBox1.Controls.Add(Me.NudQuantity)
      Me.GroupBox1.Controls.Add(Me.LblQuatity)
      Me.GroupBox1.Location = New System.Drawing.Point(2, 35)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(185, 186)
      Me.GroupBox1.TabIndex = 11
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Registers"
      '
      'GroupBox2
      '
      Me.GroupBox2.Controls.Add(Me.LblOutput)
      Me.GroupBox2.Controls.Add(Me.BtnReadApply)
      Me.GroupBox2.Location = New System.Drawing.Point(6, 89)
      Me.GroupBox2.Name = "GroupBox2"
      Me.GroupBox2.Size = New System.Drawing.Size(173, 38)
      Me.GroupBox2.TabIndex = 15
      Me.GroupBox2.TabStop = False
      Me.GroupBox2.Text = "Read"
      '
      'GrpWrite
      '
      Me.GrpWrite.Controls.Add(Me.NudWriteValue)
      Me.GrpWrite.Controls.Add(Me.BtnWriteApply)
      Me.GrpWrite.Location = New System.Drawing.Point(5, 127)
      Me.GrpWrite.Name = "GrpWrite"
      Me.GrpWrite.Size = New System.Drawing.Size(175, 44)
      Me.GrpWrite.TabIndex = 14
      Me.GrpWrite.TabStop = False
      Me.GrpWrite.Text = "Write"
      '
      'NudWriteValue
      '
      Me.NudWriteValue.Location = New System.Drawing.Point(8, 16)
      Me.NudWriteValue.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
      Me.NudWriteValue.Name = "NudWriteValue"
      Me.NudWriteValue.Size = New System.Drawing.Size(75, 20)
      Me.NudWriteValue.TabIndex = 13
      Me.NudWriteValue.Value = New Decimal(New Integer() {1, 0, 0, 0})
      '
      'BtnWriteApply
      '
      Me.BtnWriteApply.Location = New System.Drawing.Point(109, 15)
      Me.BtnWriteApply.Name = "BtnWriteApply"
      Me.BtnWriteApply.Size = New System.Drawing.Size(60, 23)
      Me.BtnWriteApply.TabIndex = 12
      Me.BtnWriteApply.Text = "Apply"
      Me.BtnWriteApply.UseVisualStyleBackColor = True
      '
      'RbtHolding
      '
      Me.RbtHolding.AutoSize = True
      Me.RbtHolding.Location = New System.Drawing.Point(83, 67)
      Me.RbtHolding.Name = "RbtHolding"
      Me.RbtHolding.Size = New System.Drawing.Size(61, 17)
      Me.RbtHolding.TabIndex = 11
      Me.RbtHolding.Text = "Holding"
      Me.RbtHolding.UseVisualStyleBackColor = True
      '
      'FrmEastronDSM360
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(190, 246)
      Me.ControlBox = False
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.StsMain)
      Me.Controls.Add(Me.lblControlunitPowerValue)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.NudModBusID)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "FrmEastronDSM360"
      Me.Text = "Eastron DSM360-V2"
      CType(Me.NudAddress, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.NudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.NudModBusID, System.ComponentModel.ISupportInitialize).EndInit()
      Me.CmsMain.ResumeLayout(False)
      Me.StsMain.ResumeLayout(False)
      Me.StsMain.PerformLayout()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.GroupBox2.ResumeLayout(False)
      Me.GroupBox2.PerformLayout()
      Me.GrpWrite.ResumeLayout(False)
      CType(Me.NudWriteValue, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents BtnReadApply As Button
   Friend WithEvents NudAddress As NumericUpDown
   Friend WithEvents LblAddress As Label
   Friend WithEvents NudQuantity As NumericUpDown
   Friend WithEvents LblQuatity As Label
   Friend WithEvents LblOutput As Label
   Friend WithEvents Label4 As Label
   Friend WithEvents NudModBusID As NumericUpDown
   Friend WithEvents lblControlunitPowerValue As Label
   Friend WithEvents CmsMain As ContextMenuStrip
   Friend WithEvents MnuSettings As ToolStripMenuItem
   Friend WithEvents MnuExit As ToolStripMenuItem
   Friend WithEvents TmrMain As Timer
   Friend WithEvents StsMain As StatusStrip
   Friend WithEvents TlsStatus As ToolStripStatusLabel
   Friend WithEvents RbtInput As RadioButton
   Friend WithEvents GroupBox1 As GroupBox
   Friend WithEvents RbtHolding As RadioButton
   Friend WithEvents TsStatus As ToolStripStatusLabel
   Friend WithEvents GrpWrite As GroupBox
   Friend WithEvents NudWriteValue As NumericUpDown
   Friend WithEvents BtnWriteApply As Button
   Friend WithEvents GroupBox2 As GroupBox
End Class
