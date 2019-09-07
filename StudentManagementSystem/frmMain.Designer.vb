<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Me.tbcMain = New System.Windows.Forms.TabControl()
		Me.tbpDetails = New System.Windows.Forms.TabPage()
		Me.tbpRegistration = New System.Windows.Forms.TabPage()
		Me.tbpResultsStudent = New System.Windows.Forms.TabPage()
		Me.tbpResultsAdmin = New System.Windows.Forms.TabPage()
		Me.tbpReports = New System.Windows.Forms.TabPage()
		Me.tbcMain.SuspendLayout()
		Me.SuspendLayout()
		'
		'tbcMain
		'
		Me.tbcMain.Controls.Add(Me.tbpDetails)
		Me.tbcMain.Controls.Add(Me.tbpRegistration)
		Me.tbcMain.Controls.Add(Me.tbpResultsStudent)
		Me.tbcMain.Controls.Add(Me.tbpResultsAdmin)
		Me.tbcMain.Controls.Add(Me.tbpReports)
		Me.tbcMain.Location = New System.Drawing.Point(12, 12)
		Me.tbcMain.Name = "tbcMain"
		Me.tbcMain.SelectedIndex = 0
		Me.tbcMain.Size = New System.Drawing.Size(810, 459)
		Me.tbcMain.TabIndex = 0
		'
		'tbpDetails
		'
		Me.tbpDetails.Location = New System.Drawing.Point(4, 22)
		Me.tbpDetails.Name = "tbpDetails"
		Me.tbpDetails.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpDetails.Size = New System.Drawing.Size(802, 433)
		Me.tbpDetails.TabIndex = 0
		Me.tbpDetails.Text = "Details"
		Me.tbpDetails.UseVisualStyleBackColor = True
		'
		'tbpRegistration
		'
		Me.tbpRegistration.Location = New System.Drawing.Point(4, 22)
		Me.tbpRegistration.Name = "tbpRegistration"
		Me.tbpRegistration.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpRegistration.Size = New System.Drawing.Size(802, 433)
		Me.tbpRegistration.TabIndex = 1
		Me.tbpRegistration.Text = "Registration"
		Me.tbpRegistration.UseVisualStyleBackColor = True
		'
		'tbpResultsStudent
		'
		Me.tbpResultsStudent.Location = New System.Drawing.Point(4, 22)
		Me.tbpResultsStudent.Name = "tbpResultsStudent"
		Me.tbpResultsStudent.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpResultsStudent.Size = New System.Drawing.Size(802, 433)
		Me.tbpResultsStudent.TabIndex = 2
		Me.tbpResultsStudent.Text = "View Results"
		Me.tbpResultsStudent.UseVisualStyleBackColor = True
		'
		'tbpResultsAdmin
		'
		Me.tbpResultsAdmin.Location = New System.Drawing.Point(4, 22)
		Me.tbpResultsAdmin.Name = "tbpResultsAdmin"
		Me.tbpResultsAdmin.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpResultsAdmin.Size = New System.Drawing.Size(802, 433)
		Me.tbpResultsAdmin.TabIndex = 3
		Me.tbpResultsAdmin.Text = "Add Results"
		Me.tbpResultsAdmin.UseVisualStyleBackColor = True
		'
		'tbpReports
		'
		Me.tbpReports.Location = New System.Drawing.Point(4, 22)
		Me.tbpReports.Name = "tbpReports"
		Me.tbpReports.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpReports.Size = New System.Drawing.Size(802, 433)
		Me.tbpReports.TabIndex = 4
		Me.tbpReports.Text = "Reports"
		Me.tbpReports.UseVisualStyleBackColor = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(834, 511)
		Me.Controls.Add(Me.tbcMain)
		Me.Name = "frmMain"
		Me.tbcMain.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents tbcMain As TabControl
	Friend WithEvents tbpDetails As TabPage
	Friend WithEvents tbpRegistration As TabPage
	Friend WithEvents tbpResultsStudent As TabPage
	Friend WithEvents tbpResultsAdmin As TabPage
	Friend WithEvents tbpReports As TabPage
End Class
