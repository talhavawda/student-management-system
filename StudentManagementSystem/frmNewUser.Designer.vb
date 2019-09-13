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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtStudAdminNumber = New System.Windows.Forms.MaskedTextBox()
        Me.grpSecurity = New System.Windows.Forms.GroupBox()
        Me.lblCell = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.MaskedTextBox()
        Me.txtCell = New System.Windows.Forms.MaskedTextBox()
        Me.grpPassword = New System.Windows.Forms.GroupBox()
        Me.lblStudAdminNumber = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.lblRePassword = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.MaskedTextBox()
        Me.txtRePassword = New System.Windows.Forms.MaskedTextBox()
        Me.tbcNewUser.SuspendLayout()
        Me.tbpChangePassword.SuspendLayout()
        Me.grpSecurity.SuspendLayout()
        Me.grpPassword.SuspendLayout()
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
        Me.tbpChangePassword.Controls.Add(Me.grpPassword)
        Me.tbpChangePassword.Controls.Add(Me.grpSecurity)
        Me.tbpChangePassword.Location = New System.Drawing.Point(4, 22)
        Me.tbpChangePassword.Name = "tbpChangePassword"
        Me.tbpChangePassword.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpChangePassword.Size = New System.Drawing.Size(426, 378)
        Me.tbpChangePassword.TabIndex = 1
        Me.tbpChangePassword.Text = "Change Password"
        Me.tbpChangePassword.UseVisualStyleBackColor = True
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
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(16, 77)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(61, 13)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID Number:"
        '
        'txtStudAdminNumber
        '
        Me.txtStudAdminNumber.Location = New System.Drawing.Point(146, 31)
        Me.txtStudAdminNumber.Mask = "0000000000"
        Me.txtStudAdminNumber.Name = "txtStudAdminNumber"
        Me.txtStudAdminNumber.Size = New System.Drawing.Size(88, 20)
        Me.txtStudAdminNumber.TabIndex = 0
        Me.txtStudAdminNumber.ValidatingType = GetType(Integer)
        '
        'grpSecurity
        '
        Me.grpSecurity.Controls.Add(Me.lblStudAdminNumber)
        Me.grpSecurity.Controls.Add(Me.txtStudAdminNumber)
        Me.grpSecurity.Controls.Add(Me.txtCell)
        Me.grpSecurity.Controls.Add(Me.txtID)
        Me.grpSecurity.Controls.Add(Me.lblCell)
        Me.grpSecurity.Controls.Add(Me.lblID)
        Me.grpSecurity.Location = New System.Drawing.Point(19, 20)
        Me.grpSecurity.Name = "grpSecurity"
        Me.grpSecurity.Size = New System.Drawing.Size(389, 158)
        Me.grpSecurity.TabIndex = 3
        Me.grpSecurity.TabStop = False
        Me.grpSecurity.Text = "Security Questions"
        '
        'lblCell
        '
        Me.lblCell.AutoSize = True
        Me.lblCell.Location = New System.Drawing.Point(16, 119)
        Me.lblCell.Name = "lblCell"
        Me.lblCell.Size = New System.Drawing.Size(67, 13)
        Me.lblCell.TabIndex = 2
        Me.lblCell.Text = "Cell Number:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(146, 70)
        Me.txtID.Mask = "0000000000000"
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(88, 20)
        Me.txtID.TabIndex = 3
        '
        'txtCell
        '
        Me.txtCell.Location = New System.Drawing.Point(146, 112)
        Me.txtCell.Mask = "(999) 000-0000"
        Me.txtCell.Name = "txtCell"
        Me.txtCell.Size = New System.Drawing.Size(88, 20)
        Me.txtCell.TabIndex = 4
        '
        'grpPassword
        '
        Me.grpPassword.Controls.Add(Me.txtRePassword)
        Me.grpPassword.Controls.Add(Me.txtNewPassword)
        Me.grpPassword.Controls.Add(Me.lblRePassword)
        Me.grpPassword.Controls.Add(Me.lblNewPassword)
        Me.grpPassword.Location = New System.Drawing.Point(19, 206)
        Me.grpPassword.Name = "grpPassword"
        Me.grpPassword.Size = New System.Drawing.Size(389, 109)
        Me.grpPassword.TabIndex = 4
        Me.grpPassword.TabStop = False
        Me.grpPassword.Text = "New Password"
        '
        'lblStudAdminNumber
        '
        Me.lblStudAdminNumber.AutoSize = True
        Me.lblStudAdminNumber.Location = New System.Drawing.Point(16, 38)
        Me.lblStudAdminNumber.Name = "lblStudAdminNumber"
        Me.lblStudAdminNumber.Size = New System.Drawing.Size(87, 13)
        Me.lblStudAdminNumber.TabIndex = 5
        Me.lblStudAdminNumber.Text = "Student Number:"
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(19, 31)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(81, 13)
        Me.lblNewPassword.TabIndex = 0
        Me.lblNewPassword.Text = "New Password:"
        '
        'lblRePassword
        '
        Me.lblRePassword.AutoSize = True
        Me.lblRePassword.Location = New System.Drawing.Point(19, 74)
        Me.lblRePassword.Name = "lblRePassword"
        Me.lblRePassword.Size = New System.Drawing.Size(101, 13)
        Me.lblRePassword.TabIndex = 1
        Me.lblRePassword.Text = "Re-Enter Password:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(146, 23)
        Me.txtNewPassword.Mask = "&&&&&&&&&&&&&&&"
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(102, 20)
        Me.txtNewPassword.TabIndex = 2
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'txtRePassword
        '
        Me.txtRePassword.Location = New System.Drawing.Point(146, 67)
        Me.txtRePassword.Mask = "&&&&&&&&&&&&&&&"
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRePassword.Size = New System.Drawing.Size(102, 20)
        Me.txtRePassword.TabIndex = 3
        Me.txtRePassword.UseSystemPasswordChar = True
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
        Me.grpSecurity.ResumeLayout(False)
        Me.grpSecurity.PerformLayout()
        Me.grpPassword.ResumeLayout(False)
        Me.grpPassword.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcNewUser As TabControl
	Friend WithEvents tbpNewUser As TabPage
	Friend WithEvents tbpChangePassword As TabPage
    Friend WithEvents btnClose As Button
    Friend WithEvents lblID As Label
    Friend WithEvents grpPassword As GroupBox
    Friend WithEvents grpSecurity As GroupBox
    Friend WithEvents lblStudAdminNumber As Label
    Friend WithEvents txtStudAdminNumber As MaskedTextBox
    Friend WithEvents txtCell As MaskedTextBox
    Friend WithEvents txtID As MaskedTextBox
    Friend WithEvents lblCell As Label
    Friend WithEvents txtRePassword As MaskedTextBox
    Friend WithEvents txtNewPassword As MaskedTextBox
    Friend WithEvents lblRePassword As Label
    Friend WithEvents lblNewPassword As Label
End Class
