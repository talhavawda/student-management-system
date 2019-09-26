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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminHome))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbxCourses = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbxRegistration = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbxMarks = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbxDetails = New System.Windows.Forms.PictureBox()
        Me.DisciplineTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.DISCIPLINETableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxCourses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxRegistration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.pbxCourses)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.pbxRegistration)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.pbxMarks)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbxDetails)
        Me.Panel1.Location = New System.Drawing.Point(12, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 356)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 32)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Courses"
        '
        'pbxCourses
        '
        Me.pbxCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCourses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxCourses.Image = Global.StudentManagementSystem.My.Resources.Resources.EDIT
        Me.pbxCourses.Location = New System.Drawing.Point(37, 187)
        Me.pbxCourses.Name = "pbxCourses"
        Me.pbxCourses.Size = New System.Drawing.Size(120, 96)
        Me.pbxCourses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxCourses.TabIndex = 11
        Me.pbxCourses.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(374, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 64)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "View Student " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registration"
        '
        'pbxRegistration
        '
        Me.pbxRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxRegistration.Image = Global.StudentManagementSystem.My.Resources.Resources.RESULTS
        Me.pbxRegistration.Location = New System.Drawing.Point(381, 187)
        Me.pbxRegistration.Name = "pbxRegistration"
        Me.pbxRegistration.Size = New System.Drawing.Size(120, 96)
        Me.pbxRegistration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxRegistration.TabIndex = 9
        Me.pbxRegistration.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Marks and Reports"
        '
        'pbxMarks
        '
        Me.pbxMarks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxMarks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxMarks.Image = CType(resources.GetObject("pbxMarks.Image"), System.Drawing.Image)
        Me.pbxMarks.Location = New System.Drawing.Point(381, 25)
        Me.pbxMarks.Name = "pbxMarks"
        Me.pbxMarks.Size = New System.Drawing.Size(120, 96)
        Me.pbxMarks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMarks.TabIndex = 7
        Me.pbxMarks.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Details"
        '
        'pbxDetails
        '
        Me.pbxDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxDetails.Image = Global.StudentManagementSystem.My.Resources.Resources.EDIT
        Me.pbxDetails.Location = New System.Drawing.Point(37, 25)
        Me.pbxDetails.Name = "pbxDetails"
        Me.pbxDetails.Size = New System.Drawing.Size(120, 96)
        Me.pbxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxDetails.TabIndex = 5
        Me.pbxDetails.TabStop = False
        '
        'DisciplineTableAdapter1
        '
        Me.DisciplineTableAdapter1.ClearBeforeFill = True
        '
        'frmAdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 401)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdminHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home | Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxCourses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxRegistration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents pbxDetails As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents pbxRegistration As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents pbxMarks As PictureBox
	Friend WithEvents Label4 As Label
	Friend WithEvents pbxCourses As PictureBox
    Friend WithEvents DisciplineTableAdapter1 As SMSDataSetTableAdapters.DISCIPLINETableAdapter
End Class
