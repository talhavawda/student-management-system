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
        Me.grpPassword = New System.Windows.Forms.GroupBox()
        Me.txtRePassword = New System.Windows.Forms.MaskedTextBox()
        Me.txtNewPassword = New System.Windows.Forms.MaskedTextBox()
        Me.lblRePassword = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.grpSecurity = New System.Windows.Forms.GroupBox()
        Me.lblStudAdminNumber = New System.Windows.Forms.Label()
        Me.txtStudAdminNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtCell = New System.Windows.Forms.MaskedTextBox()
        Me.txtID = New System.Windows.Forms.MaskedTextBox()
        Me.lblCell = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNewStudAdminNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtNewID = New System.Windows.Forms.MaskedTextBox()
        Me.txtNewFirstname = New System.Windows.Forms.TextBox()
        Me.txtNewSurname = New System.Windows.Forms.TextBox()
        Me.txtNewCell = New System.Windows.Forms.MaskedTextBox()
        Me.txtNewEmail = New System.Windows.Forms.TextBox()
        Me.grpPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.grpNewPassword = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.tbcNewUser.SuspendLayout()
        Me.tbpNewUser.SuspendLayout()
        Me.tbpChangePassword.SuspendLayout()
        Me.grpPassword.SuspendLayout()
        Me.grpSecurity.SuspendLayout()
        Me.grpPersonalDetails.SuspendLayout()
        Me.grpNewPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcNewUser
        '
        Me.tbcNewUser.Controls.Add(Me.tbpNewUser)
        Me.tbcNewUser.Controls.Add(Me.tbpChangePassword)
        Me.tbcNewUser.Location = New System.Drawing.Point(12, 12)
        Me.tbcNewUser.Name = "tbcNewUser"
        Me.tbcNewUser.SelectedIndex = 0
        Me.tbcNewUser.Size = New System.Drawing.Size(434, 499)
        Me.tbcNewUser.TabIndex = 0
        '
        'tbpNewUser
        '
        Me.tbpNewUser.Controls.Add(Me.grpNewPassword)
        Me.tbpNewUser.Controls.Add(Me.grpPersonalDetails)
        Me.tbpNewUser.Location = New System.Drawing.Point(4, 22)
        Me.tbpNewUser.Name = "tbpNewUser"
        Me.tbpNewUser.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpNewUser.Size = New System.Drawing.Size(426, 473)
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
        Me.tbpChangePassword.Size = New System.Drawing.Size(426, 473)
        Me.tbpChangePassword.TabIndex = 1
        Me.tbpChangePassword.Text = "Change Password"
        Me.tbpChangePassword.UseVisualStyleBackColor = True
        '
        'grpPassword
        '
        Me.grpPassword.Controls.Add(Me.txtRePassword)
        Me.grpPassword.Controls.Add(Me.txtNewPassword)
        Me.grpPassword.Controls.Add(Me.lblRePassword)
        Me.grpPassword.Controls.Add(Me.lblNewPassword)
        Me.grpPassword.Location = New System.Drawing.Point(19, 208)
        Me.grpPassword.Name = "grpPassword"
        Me.grpPassword.Size = New System.Drawing.Size(389, 109)
        Me.grpPassword.TabIndex = 4
        Me.grpPassword.TabStop = False
        Me.grpPassword.Text = "New Password"
        '
        'txtRePassword
        '
        Me.txtRePassword.Location = New System.Drawing.Point(146, 71)
        Me.txtRePassword.Mask = "&&&&&&&&&&&&&&&"
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRePassword.Size = New System.Drawing.Size(102, 20)
        Me.txtRePassword.TabIndex = 3
        Me.txtRePassword.UseSystemPasswordChar = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(146, 28)
        Me.txtNewPassword.Mask = "&&&&&&&&&&&&&&&"
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(102, 20)
        Me.txtNewPassword.TabIndex = 2
        Me.txtNewPassword.UseSystemPasswordChar = True
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
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.Location = New System.Drawing.Point(19, 31)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(81, 13)
        Me.lblNewPassword.TabIndex = 0
        Me.lblNewPassword.Text = "New Password:"
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
        'lblStudAdminNumber
        '
        Me.lblStudAdminNumber.AutoSize = True
        Me.lblStudAdminNumber.Location = New System.Drawing.Point(16, 38)
        Me.lblStudAdminNumber.Name = "lblStudAdminNumber"
        Me.lblStudAdminNumber.Size = New System.Drawing.Size(87, 13)
        Me.lblStudAdminNumber.TabIndex = 5
        Me.lblStudAdminNumber.Text = "Student Number:"
        '
        'txtStudAdminNumber
        '
        Me.txtStudAdminNumber.Location = New System.Drawing.Point(146, 35)
        Me.txtStudAdminNumber.Mask = "0000000000"
        Me.txtStudAdminNumber.Name = "txtStudAdminNumber"
        Me.txtStudAdminNumber.Size = New System.Drawing.Size(88, 20)
        Me.txtStudAdminNumber.TabIndex = 0
        Me.txtStudAdminNumber.ValidatingType = GetType(Integer)
        '
        'txtCell
        '
        Me.txtCell.Location = New System.Drawing.Point(146, 116)
        Me.txtCell.Mask = "(999) 000-0000"
        Me.txtCell.Name = "txtCell"
        Me.txtCell.Size = New System.Drawing.Size(88, 20)
        Me.txtCell.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(146, 74)
        Me.txtID.Mask = "0000000000000"
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(88, 20)
        Me.txtID.TabIndex = 3
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
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(16, 77)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(61, 13)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID Number:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(367, 517)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Number: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Number: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cell Number: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Surname: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Name: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Email address: "
        '
        'txtNewStudAdminNumber
        '
        Me.txtNewStudAdminNumber.Enabled = False
        Me.txtNewStudAdminNumber.Location = New System.Drawing.Point(146, 35)
        Me.txtNewStudAdminNumber.Mask = "0000000000"
        Me.txtNewStudAdminNumber.Name = "txtNewStudAdminNumber"
        Me.txtNewStudAdminNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNewStudAdminNumber.TabIndex = 6
        '
        'txtNewID
        '
        Me.txtNewID.Location = New System.Drawing.Point(146, 74)
        Me.txtNewID.Mask = "0000000000000"
        Me.txtNewID.Name = "txtNewID"
        Me.txtNewID.Size = New System.Drawing.Size(100, 20)
        Me.txtNewID.TabIndex = 7
        '
        'txtNewFirstname
        '
        Me.txtNewFirstname.Location = New System.Drawing.Point(146, 116)
        Me.txtNewFirstname.Name = "txtNewFirstname"
        Me.txtNewFirstname.Size = New System.Drawing.Size(100, 20)
        Me.txtNewFirstname.TabIndex = 8
        '
        'txtNewSurname
        '
        Me.txtNewSurname.Location = New System.Drawing.Point(146, 157)
        Me.txtNewSurname.Name = "txtNewSurname"
        Me.txtNewSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtNewSurname.TabIndex = 9
        '
        'txtNewCell
        '
        Me.txtNewCell.Location = New System.Drawing.Point(146, 200)
        Me.txtNewCell.Mask = "(999) 000-0000"
        Me.txtNewCell.Name = "txtNewCell"
        Me.txtNewCell.Size = New System.Drawing.Size(100, 20)
        Me.txtNewCell.TabIndex = 10
        '
        'txtNewEmail
        '
        Me.txtNewEmail.Location = New System.Drawing.Point(146, 244)
        Me.txtNewEmail.Name = "txtNewEmail"
        Me.txtNewEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtNewEmail.TabIndex = 11
        '
        'grpPersonalDetails
        '
        Me.grpPersonalDetails.Controls.Add(Me.Label1)
        Me.grpPersonalDetails.Controls.Add(Me.txtNewEmail)
        Me.grpPersonalDetails.Controls.Add(Me.Label2)
        Me.grpPersonalDetails.Controls.Add(Me.txtNewCell)
        Me.grpPersonalDetails.Controls.Add(Me.Label3)
        Me.grpPersonalDetails.Controls.Add(Me.txtNewSurname)
        Me.grpPersonalDetails.Controls.Add(Me.Label4)
        Me.grpPersonalDetails.Controls.Add(Me.txtNewFirstname)
        Me.grpPersonalDetails.Controls.Add(Me.Label5)
        Me.grpPersonalDetails.Controls.Add(Me.txtNewID)
        Me.grpPersonalDetails.Controls.Add(Me.Label6)
        Me.grpPersonalDetails.Controls.Add(Me.txtNewStudAdminNumber)
        Me.grpPersonalDetails.Location = New System.Drawing.Point(19, 20)
        Me.grpPersonalDetails.Name = "grpPersonalDetails"
        Me.grpPersonalDetails.Size = New System.Drawing.Size(389, 289)
        Me.grpPersonalDetails.TabIndex = 12
        Me.grpPersonalDetails.TabStop = False
        Me.grpPersonalDetails.Text = "Personal Details"
        '
        'grpNewPassword
        '
        Me.grpNewPassword.Controls.Add(Me.MaskedTextBox2)
        Me.grpNewPassword.Controls.Add(Me.MaskedTextBox1)
        Me.grpNewPassword.Controls.Add(Me.Label8)
        Me.grpNewPassword.Controls.Add(Me.Label7)
        Me.grpNewPassword.Location = New System.Drawing.Point(19, 339)
        Me.grpNewPassword.Name = "grpNewPassword"
        Me.grpNewPassword.Size = New System.Drawing.Size(389, 113)
        Me.grpNewPassword.TabIndex = 13
        Me.grpNewPassword.TabStop = False
        Me.grpNewPassword.Text = "Create Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Enter a password: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Confirm password: "
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(146, 37)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 2
        Me.MaskedTextBox1.UseSystemPasswordChar = True
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(146, 77)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox2.TabIndex = 3
        Me.MaskedTextBox2.UseSystemPasswordChar = True
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 552)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tbcNewUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tbcNewUser.ResumeLayout(False)
        Me.tbpNewUser.ResumeLayout(False)
        Me.tbpChangePassword.ResumeLayout(False)
        Me.grpPassword.ResumeLayout(False)
        Me.grpPassword.PerformLayout()
        Me.grpSecurity.ResumeLayout(False)
        Me.grpSecurity.PerformLayout()
        Me.grpPersonalDetails.ResumeLayout(False)
        Me.grpPersonalDetails.PerformLayout()
        Me.grpNewPassword.ResumeLayout(False)
        Me.grpNewPassword.PerformLayout()
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
    Friend WithEvents txtNewStudAdminNumber As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNewID As MaskedTextBox
    Friend WithEvents txtNewEmail As TextBox
    Friend WithEvents txtNewCell As MaskedTextBox
    Friend WithEvents txtNewSurname As TextBox
    Friend WithEvents txtNewFirstname As TextBox
    Friend WithEvents grpPersonalDetails As GroupBox
    Friend WithEvents grpNewPassword As GroupBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
