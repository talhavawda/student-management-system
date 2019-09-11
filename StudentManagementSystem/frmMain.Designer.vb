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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.tbpNewRegistration = New System.Windows.Forms.TabPage()
		Me.tbpResultsStudent = New System.Windows.Forms.TabPage()
		Me.tbpResultsAdmin = New System.Windows.Forms.TabPage()
		Me.tbpReports = New System.Windows.Forms.TabPage()
		Me.tbpViewRegistration = New System.Windows.Forms.TabPage()
		Me.tbcMain.SuspendLayout()
		Me.tbpDetails.SuspendLayout()
		Me.SuspendLayout()
		'
		'tbcMain
		'
		Me.tbcMain.Controls.Add(Me.tbpDetails)
		Me.tbcMain.Controls.Add(Me.tbpNewRegistration)
		Me.tbcMain.Controls.Add(Me.tbpViewRegistration)
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
		Me.tbpDetails.Controls.Add(Me.Label1)
		Me.tbpDetails.Location = New System.Drawing.Point(4, 22)
		Me.tbpDetails.Name = "tbpDetails"
		Me.tbpDetails.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpDetails.Size = New System.Drawing.Size(802, 433)
		Me.tbpDetails.TabIndex = 0
		Me.tbpDetails.Text = "Details"
		Me.tbpDetails.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(170, 355)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(486, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "cant change password here. a separate form will deal with that which a button her" &
	"e will go to that form"
		'
		'tbpNewRegistration
		'
		Me.tbpNewRegistration.Location = New System.Drawing.Point(4, 22)
		Me.tbpNewRegistration.Name = "tbpNewRegistration"
		Me.tbpNewRegistration.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpNewRegistration.Size = New System.Drawing.Size(802, 433)
		Me.tbpNewRegistration.TabIndex = 1
		Me.tbpNewRegistration.Text = "New Registration"
		Me.tbpNewRegistration.UseVisualStyleBackColor = True
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
		'tbpViewRegistration
		'
		Me.tbpViewRegistration.Location = New System.Drawing.Point(4, 22)
		Me.tbpViewRegistration.Name = "tbpViewRegistration"
		Me.tbpViewRegistration.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpViewRegistration.Size = New System.Drawing.Size(802, 433)
		Me.tbpViewRegistration.TabIndex = 5
		Me.tbpViewRegistration.Text = "View Registration"
		Me.tbpViewRegistration.UseVisualStyleBackColor = True
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(834, 511)
		Me.Controls.Add(Me.tbcMain)
		Me.Name = "frmMain"
		Me.tbcMain.ResumeLayout(False)
		Me.tbpDetails.ResumeLayout(False)
		Me.tbpDetails.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents tbcMain As TabControl
	Friend WithEvents tbpDetails As TabPage
	Friend WithEvents tbpNewRegistration As TabPage
	Friend WithEvents tbpResultsStudent As TabPage
	Friend WithEvents tbpResultsAdmin As TabPage
	Friend WithEvents tbpReports As TabPage
	Friend WithEvents Label1 As Label
	Friend WithEvents tbpViewRegistration As TabPage
End Class
