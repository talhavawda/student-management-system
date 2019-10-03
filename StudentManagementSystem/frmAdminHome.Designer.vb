<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminHome
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminHome))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.pbxRegistration = New System.Windows.Forms.PictureBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.pbxMarks = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pbxDetails = New System.Windows.Forms.PictureBox()
		Me.DisciplineTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.DISCIPLINETableAdapter()
		Me.pnlInfo = New System.Windows.Forms.Panel()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.lblDateTime = New System.Windows.Forms.Label()
		Me.tmrAdminTime = New System.Windows.Forms.Timer(Me.components)
		Me.lblAdminName = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		CType(Me.pbxRegistration, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbxMarks, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbxDetails, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlInfo.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.pbxRegistration)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.pbxMarks)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.pbxDetails)
		Me.Panel1.Location = New System.Drawing.Point(7, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(635, 349)
		Me.Panel1.TabIndex = 0
		'
		'pbxRegistration
		'
		Me.pbxRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pbxRegistration.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pbxRegistration.Image = CType(resources.GetObject("pbxRegistration.Image"), System.Drawing.Image)
		Me.pbxRegistration.Location = New System.Drawing.Point(446, 91)
		Me.pbxRegistration.Name = "pbxRegistration"
		Me.pbxRegistration.Size = New System.Drawing.Size(150, 120)
		Me.pbxRegistration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbxRegistration.TabIndex = 9
		Me.pbxRegistration.TabStop = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
		Me.Label2.Location = New System.Drawing.Point(232, 221)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(175, 28)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Marks and Reports"
		'
		'pbxMarks
		'
		Me.pbxMarks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pbxMarks.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pbxMarks.Image = CType(resources.GetObject("pbxMarks.Image"), System.Drawing.Image)
		Me.pbxMarks.Location = New System.Drawing.Point(241, 91)
		Me.pbxMarks.Name = "pbxMarks"
		Me.pbxMarks.Size = New System.Drawing.Size(150, 120)
		Me.pbxMarks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbxMarks.TabIndex = 7
		Me.pbxMarks.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
		Me.Label1.Location = New System.Drawing.Point(69, 221)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(71, 28)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Details"
		'
		'pbxDetails
		'
		Me.pbxDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.pbxDetails.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pbxDetails.Image = CType(resources.GetObject("pbxDetails.Image"), System.Drawing.Image)
		Me.pbxDetails.Location = New System.Drawing.Point(33, 91)
		Me.pbxDetails.Name = "pbxDetails"
		Me.pbxDetails.Size = New System.Drawing.Size(150, 120)
		Me.pbxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbxDetails.TabIndex = 5
		Me.pbxDetails.TabStop = False
		'
		'DisciplineTableAdapter1
		'
		Me.DisciplineTableAdapter1.ClearBeforeFill = True
		'
		'pnlInfo
		'
		Me.pnlInfo.Controls.Add(Me.lblAdminName)
		Me.pnlInfo.Controls.Add(Me.btnExit)
		Me.pnlInfo.Controls.Add(Me.lblDateTime)
		Me.pnlInfo.Location = New System.Drawing.Point(12, 367)
		Me.pnlInfo.Name = "pnlInfo"
		Me.pnlInfo.Size = New System.Drawing.Size(620, 33)
		Me.pnlInfo.TabIndex = 6
		'
		'btnExit
		'
		Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnExit.Location = New System.Drawing.Point(542, 2)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 1
		Me.btnExit.Text = "End Session"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'lblDateTime
		'
		Me.lblDateTime.AutoSize = True
		Me.lblDateTime.Location = New System.Drawing.Point(3, 12)
		Me.lblDateTime.Name = "lblDateTime"
		Me.lblDateTime.Size = New System.Drawing.Size(89, 13)
		Me.lblDateTime.TabIndex = 0
		Me.lblDateTime.Text = "<Date and Time>"
		'
		'tmrAdminTime
		'
		Me.tmrAdminTime.Enabled = True
		'
		'lblAdminName
		'
		Me.lblAdminName.AutoSize = True
		Me.lblAdminName.Location = New System.Drawing.Point(241, 7)
		Me.lblAdminName.Name = "lblAdminName"
		Me.lblAdminName.Size = New System.Drawing.Size(76, 13)
		Me.lblAdminName.TabIndex = 2
		Me.lblAdminName.Text = "<AdminHome>"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
		Me.Label3.Location = New System.Drawing.Point(432, 223)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(190, 28)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "Student Registration"
		'
		'frmAdminHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(644, 401)
		Me.Controls.Add(Me.pnlInfo)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmAdminHome"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Home | Admin"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.pbxRegistration, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbxMarks, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbxDetails, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlInfo.ResumeLayout(False)
		Me.pnlInfo.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents pbxDetails As PictureBox
	Friend WithEvents pbxRegistration As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents pbxMarks As PictureBox
	Friend WithEvents DisciplineTableAdapter1 As SMSDataSetTableAdapters.DISCIPLINETableAdapter
	Friend WithEvents pnlInfo As Panel
	Friend WithEvents btnExit As Button
	Friend WithEvents lblDateTime As Label
	Friend WithEvents tmrAdminTime As Timer
	Friend WithEvents lblAdminName As Label
	Friend WithEvents Label3 As Label
End Class
