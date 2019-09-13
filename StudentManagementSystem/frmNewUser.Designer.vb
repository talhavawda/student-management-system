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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewUser))
        Me.tbcNewUser = New System.Windows.Forms.TabControl()
        Me.tbpNewUser = New System.Windows.Forms.TabPage()
        Me.tbpChangePassword = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tbcNewUser.SuspendLayout()
        Me.tbpChangePassword.SuspendLayout()
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
        Me.tbpChangePassword.Controls.Add(Me.TextBox1)
        Me.tbpChangePassword.Location = New System.Drawing.Point(4, 22)
        Me.tbpChangePassword.Name = "tbpChangePassword"
        Me.tbpChangePassword.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpChangePassword.Size = New System.Drawing.Size(426, 378)
        Me.tbpChangePassword.TabIndex = 1
        Me.tbpChangePassword.Text = "Change Password"
        Me.tbpChangePassword.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(279, 95)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(367, 422)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 455)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tbcNewUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tbcNewUser.ResumeLayout(False)
        Me.tbpChangePassword.ResumeLayout(False)
        Me.tbpChangePassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcNewUser As TabControl
	Friend WithEvents tbpNewUser As TabPage
	Friend WithEvents tbpChangePassword As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnClose As Button
End Class
