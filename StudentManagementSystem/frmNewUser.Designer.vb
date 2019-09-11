<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewUser
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
		Me.tbcNewUser = New System.Windows.Forms.TabControl()
		Me.tbpNewUser = New System.Windows.Forms.TabPage()
		Me.tbpChangePassword = New System.Windows.Forms.TabPage()
		Me.tbcNewUser.SuspendLayout()
		Me.SuspendLayout()
		'
		'tbcNewUser
		'
		Me.tbcNewUser.Controls.Add(Me.tbpNewUser)
		Me.tbcNewUser.Controls.Add(Me.tbpChangePassword)
		Me.tbcNewUser.Location = New System.Drawing.Point(12, 12)
		Me.tbcNewUser.Name = "tbcNewUser"
		Me.tbcNewUser.SelectedIndex = 0
		Me.tbcNewUser.Size = New System.Drawing.Size(434, 404)
		Me.tbcNewUser.TabIndex = 0
		'
		'tbpNewUser
		'
		Me.tbpNewUser.Location = New System.Drawing.Point(4, 22)
		Me.tbpNewUser.Name = "tbpNewUser"
		Me.tbpNewUser.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpNewUser.Size = New System.Drawing.Size(426, 378)
		Me.tbpNewUser.TabIndex = 0
		Me.tbpNewUser.Text = "New User"
		Me.tbpNewUser.UseVisualStyleBackColor = True
		'
		'tbpChangePassword
		'
		Me.tbpChangePassword.Location = New System.Drawing.Point(4, 22)
		Me.tbpChangePassword.Name = "tbpChangePassword"
		Me.tbpChangePassword.Padding = New System.Windows.Forms.Padding(3)
		Me.tbpChangePassword.Size = New System.Drawing.Size(407, 392)
		Me.tbpChangePassword.TabIndex = 1
		Me.tbpChangePassword.Text = "Change Password"
		Me.tbpChangePassword.UseVisualStyleBackColor = True
		'
		'frmNewUser
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(458, 455)
		Me.Controls.Add(Me.tbcNewUser)
		Me.Name = "frmNewUser"
		Me.tbcNewUser.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents tbcNewUser As TabControl
	Friend WithEvents tbpNewUser As TabPage
	Friend WithEvents tbpChangePassword As TabPage
End Class
