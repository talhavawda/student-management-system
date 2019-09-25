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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewUser))
        Me.tbcNewUser = New System.Windows.Forms.TabControl()
        Me.tbpNewUser = New System.Windows.Forms.TabPage()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbMajor2 = New System.Windows.Forms.ComboBox()
        Me.cmbMajor1 = New System.Windows.Forms.ComboBox()
        Me.cmbCollege = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpNewPassword = New System.Windows.Forms.GroupBox()
        Me.txtConfirmPassword = New System.Windows.Forms.MaskedTextBox()
        Me.txtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewCell = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewSurname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNewFirstname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNewID = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNewUserNumber = New System.Windows.Forms.MaskedTextBox()
        Me.tbpChangePassword = New System.Windows.Forms.TabPage()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.grpPassword = New System.Windows.Forms.GroupBox()
        Me.txtRePassword = New System.Windows.Forms.MaskedTextBox()
        Me.txtNewPassword = New System.Windows.Forms.MaskedTextBox()
        Me.lblRePassword = New System.Windows.Forms.Label()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.grpSecurity = New System.Windows.Forms.GroupBox()
        Me.lblUserNumber = New System.Windows.Forms.Label()
        Me.txtStudAdminNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtCell = New System.Windows.Forms.MaskedTextBox()
        Me.txtID = New System.Windows.Forms.MaskedTextBox()
        Me.lblCell = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BSDiscipline = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmsDataSet1 = New StudentManagementSystem.SMSDataSet()
        Me.TableAdapterManager1 = New StudentManagementSystem.SMSDataSetTableAdapters.TableAdapterManager()
        Me.DisciplineTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.DISCIPLINETableAdapter()
        Me.BSFaculty = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacultyTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.FACULTYTableAdapter()
        Me.BSAdmin = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADMINTableAdapter = New StudentManagementSystem.SMSDataSetTableAdapters.ADMINTableAdapter()
        Me.StudentTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.STUDENTTableAdapter()
        Me.BSStudent = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.COURSETableAdapter()
        Me.BSCourse = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbcNewUser.SuspendLayout()
        Me.tbpNewUser.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpNewPassword.SuspendLayout()
        Me.grpPersonalDetails.SuspendLayout()
        Me.tbpChangePassword.SuspendLayout()
        Me.grpPassword.SuspendLayout()
        Me.grpSecurity.SuspendLayout()
        CType(Me.BSDiscipline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcNewUser
        '
        Me.tbcNewUser.Controls.Add(Me.tbpNewUser)
        Me.tbcNewUser.Controls.Add(Me.tbpChangePassword)
        Me.tbcNewUser.Location = New System.Drawing.Point(12, 12)
        Me.tbcNewUser.Name = "tbcNewUser"
        Me.tbcNewUser.SelectedIndex = 0
        Me.tbcNewUser.Size = New System.Drawing.Size(434, 555)
        Me.tbcNewUser.TabIndex = 0
        '
        'tbpNewUser
        '
        Me.tbpNewUser.Controls.Add(Me.btnCreateUser)
        Me.tbpNewUser.Controls.Add(Me.GroupBox1)
        Me.tbpNewUser.Controls.Add(Me.grpNewPassword)
        Me.tbpNewUser.Controls.Add(Me.grpPersonalDetails)
        Me.tbpNewUser.Location = New System.Drawing.Point(4, 22)
        Me.tbpNewUser.Name = "tbpNewUser"
        Me.tbpNewUser.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpNewUser.Size = New System.Drawing.Size(426, 529)
        Me.tbpNewUser.TabIndex = 0
        Me.tbpNewUser.Text = "New User"
        Me.tbpNewUser.UseVisualStyleBackColor = True
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(165, 488)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateUser.TabIndex = 15
        Me.btnCreateUser.Text = "Create"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbMajor2)
        Me.GroupBox1.Controls.Add(Me.cmbMajor1)
        Me.GroupBox1.Controls.Add(Me.cmbCollege)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 354)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 118)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Course"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Major 2:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Major 1:"
        '
        'cmbMajor2
        '
        Me.cmbMajor2.FormattingEnabled = True
        Me.cmbMajor2.Location = New System.Drawing.Point(146, 86)
        Me.cmbMajor2.Name = "cmbMajor2"
        Me.cmbMajor2.Size = New System.Drawing.Size(149, 21)
        Me.cmbMajor2.TabIndex = 3
        '
        'cmbMajor1
        '
        Me.cmbMajor1.FormattingEnabled = True
        Me.cmbMajor1.Location = New System.Drawing.Point(146, 54)
        Me.cmbMajor1.Name = "cmbMajor1"
        Me.cmbMajor1.Size = New System.Drawing.Size(149, 21)
        Me.cmbMajor1.TabIndex = 2
        '
        'cmbCollege
        '
        Me.cmbCollege.FormattingEnabled = True
        Me.cmbCollege.Location = New System.Drawing.Point(146, 19)
        Me.cmbCollege.Name = "cmbCollege"
        Me.cmbCollege.Size = New System.Drawing.Size(149, 21)
        Me.cmbCollege.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "College:"
        '
        'grpNewPassword
        '
        Me.grpNewPassword.Controls.Add(Me.txtConfirmPassword)
        Me.grpNewPassword.Controls.Add(Me.txtPassword)
        Me.grpNewPassword.Controls.Add(Me.Label8)
        Me.grpNewPassword.Controls.Add(Me.Label7)
        Me.grpNewPassword.Location = New System.Drawing.Point(19, 253)
        Me.grpNewPassword.Name = "grpNewPassword"
        Me.grpNewPassword.Size = New System.Drawing.Size(389, 87)
        Me.grpNewPassword.TabIndex = 13
        Me.grpNewPassword.TabStop = False
        Me.grpNewPassword.Text = "Create Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(146, 54)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmPassword.TabIndex = 3
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(146, 22)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Confirm password: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Enter a password: "
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
        Me.grpPersonalDetails.Controls.Add(Me.txtNewUserNumber)
        Me.grpPersonalDetails.Location = New System.Drawing.Point(19, 20)
        Me.grpPersonalDetails.Name = "grpPersonalDetails"
        Me.grpPersonalDetails.Size = New System.Drawing.Size(389, 218)
        Me.grpPersonalDetails.TabIndex = 12
        Me.grpPersonalDetails.TabStop = False
        Me.grpPersonalDetails.Text = "Personal Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Number: "
        '
        'txtNewEmail
        '
        Me.txtNewEmail.Location = New System.Drawing.Point(146, 188)
        Me.txtNewEmail.Name = "txtNewEmail"
        Me.txtNewEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtNewEmail.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Number: "
        '
        'txtNewCell
        '
        Me.txtNewCell.Location = New System.Drawing.Point(146, 150)
        Me.txtNewCell.Mask = "9990000000"
        Me.txtNewCell.Name = "txtNewCell"
        Me.txtNewCell.Size = New System.Drawing.Size(100, 20)
        Me.txtNewCell.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cell Number: "
        '
        'txtNewSurname
        '
        Me.txtNewSurname.Location = New System.Drawing.Point(146, 118)
        Me.txtNewSurname.Name = "txtNewSurname"
        Me.txtNewSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtNewSurname.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Surname: "
        '
        'txtNewFirstname
        '
        Me.txtNewFirstname.Location = New System.Drawing.Point(146, 85)
        Me.txtNewFirstname.Name = "txtNewFirstname"
        Me.txtNewFirstname.Size = New System.Drawing.Size(100, 20)
        Me.txtNewFirstname.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Name: "
        '
        'txtNewID
        '
        Me.txtNewID.Location = New System.Drawing.Point(146, 54)
        Me.txtNewID.Mask = "0000000000000"
        Me.txtNewID.Name = "txtNewID"
        Me.txtNewID.Size = New System.Drawing.Size(100, 20)
        Me.txtNewID.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Email address: "
        '
        'txtNewUserNumber
        '
        Me.txtNewUserNumber.Enabled = False
        Me.txtNewUserNumber.Location = New System.Drawing.Point(146, 20)
        Me.txtNewUserNumber.Mask = "0000000000"
        Me.txtNewUserNumber.Name = "txtNewUserNumber"
        Me.txtNewUserNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNewUserNumber.TabIndex = 6
        '
        'tbpChangePassword
        '
        Me.tbpChangePassword.Controls.Add(Me.btnChangePassword)
        Me.tbpChangePassword.Controls.Add(Me.grpPassword)
        Me.tbpChangePassword.Controls.Add(Me.grpSecurity)
        Me.tbpChangePassword.Location = New System.Drawing.Point(4, 22)
        Me.tbpChangePassword.Name = "tbpChangePassword"
        Me.tbpChangePassword.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpChangePassword.Size = New System.Drawing.Size(426, 529)
        Me.tbpChangePassword.TabIndex = 1
        Me.tbpChangePassword.Text = "Change Password"
        Me.tbpChangePassword.UseVisualStyleBackColor = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Location = New System.Drawing.Point(150, 354)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(117, 23)
        Me.btnChangePassword.TabIndex = 5
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
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
        Me.grpSecurity.Controls.Add(Me.lblUserNumber)
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
        'lblUserNumber
        '
        Me.lblUserNumber.AutoSize = True
        Me.lblUserNumber.Location = New System.Drawing.Point(16, 38)
        Me.lblUserNumber.Name = "lblUserNumber"
        Me.lblUserNumber.Size = New System.Drawing.Size(87, 13)
        Me.lblUserNumber.TabIndex = 5
        Me.lblUserNumber.Text = "Student Number:"
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
        Me.txtCell.Mask = "0000000000"
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
        Me.btnClose.Location = New System.Drawing.Point(367, 564)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SmsDataSet1
        '
        Me.SmsDataSet1.DataSetName = "SMSDataSet"
        Me.SmsDataSet1.EnforceConstraints = False
        Me.SmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ADMINTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Course_ModuleTableAdapter = Nothing
        Me.TableAdapterManager1.COURSETableAdapter = Nothing
        Me.TableAdapterManager1.DISCIPLINETableAdapter = Me.DisciplineTableAdapter1
        Me.TableAdapterManager1.FACULTYTableAdapter = Nothing
        Me.TableAdapterManager1.MODULE_REGISTRATIONTableAdapter = Nothing
        Me.TableAdapterManager1.MODULETableAdapter = Nothing
        Me.TableAdapterManager1.STUDENTTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = StudentManagementSystem.SMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DisciplineTableAdapter1
        '
        Me.DisciplineTableAdapter1.ClearBeforeFill = True
        '
        'BSFaculty
        '
        Me.BSFaculty.DataMember = "FACULTY"
        Me.BSFaculty.DataSource = Me.SmsDataSet1
        '
        'FacultyTableAdapter1
        '
        Me.FacultyTableAdapter1.ClearBeforeFill = True
        '
        'BSAdmin
        '
        Me.BSAdmin.DataMember = "ADMIN"
        Me.BSAdmin.DataSource = Me.SmsDataSet1
        '
        'ADMINTableAdapter
        '
        Me.ADMINTableAdapter.ClearBeforeFill = True
        '
        'StudentTableAdapter1
        '
        Me.StudentTableAdapter1.ClearBeforeFill = True
        '
        'BSStudent
        '
        Me.BSStudent.DataMember = "STUDENT"
        Me.BSStudent.DataSource = Me.SmsDataSet1
        '
        'CourseTableAdapter1
        '
        Me.CourseTableAdapter1.ClearBeforeFill = True
        '
        'BSCourse
        '
        Me.BSCourse.DataMember = "COURSE"
        Me.BSCourse.DataSource = Me.SmsDataSet1
        '
        'frmNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 599)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tbcNewUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tbcNewUser.ResumeLayout(False)
        Me.tbpNewUser.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpNewPassword.ResumeLayout(False)
        Me.grpNewPassword.PerformLayout()
        Me.grpPersonalDetails.ResumeLayout(False)
        Me.grpPersonalDetails.PerformLayout()
        Me.tbpChangePassword.ResumeLayout(False)
        Me.grpPassword.ResumeLayout(False)
        Me.grpPassword.PerformLayout()
        Me.grpSecurity.ResumeLayout(False)
        Me.grpSecurity.PerformLayout()
        CType(Me.BSDiscipline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcNewUser As TabControl
    Friend WithEvents tbpNewUser As TabPage
    Friend WithEvents tbpChangePassword As TabPage
    Friend WithEvents btnClose As Button
    Friend WithEvents lblID As Label
    Friend WithEvents grpPassword As GroupBox
    Friend WithEvents grpSecurity As GroupBox
    Friend WithEvents lblUserNumber As Label
    Friend WithEvents txtStudAdminNumber As MaskedTextBox
    Friend WithEvents txtCell As MaskedTextBox
    Friend WithEvents txtID As MaskedTextBox
    Friend WithEvents lblCell As Label
    Friend WithEvents txtRePassword As MaskedTextBox
    Friend WithEvents txtNewPassword As MaskedTextBox
    Friend WithEvents lblRePassword As Label
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtNewUserNumber As MaskedTextBox
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
    Friend WithEvents txtConfirmPassword As MaskedTextBox
    Friend WithEvents txtPassword As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents cmbMajor1 As ComboBox
	Friend WithEvents cmbCollege As ComboBox
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents cmbMajor2 As ComboBox
	Friend WithEvents Label11 As Label
	Friend WithEvents btnChangePassword As Button
	Friend WithEvents btnCreateUser As Button
    Friend WithEvents SmsDataSet1 As SMSDataSet
	Friend WithEvents TableAdapterManager1 As SMSDataSetTableAdapters.TableAdapterManager
	Friend WithEvents BSFaculty As BindingSource
    Friend WithEvents DisciplineTableAdapter1 As SMSDataSetTableAdapters.DISCIPLINETableAdapter
    Friend WithEvents BSDiscipline As BindingSource
	Friend WithEvents FacultyTableAdapter1 As SMSDataSetTableAdapters.FACULTYTableAdapter
    Friend WithEvents BSAdmin As BindingSource
    Friend WithEvents ADMINTableAdapter As SMSDataSetTableAdapters.ADMINTableAdapter
    Friend WithEvents StudentTableAdapter1 As SMSDataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents BSStudent As BindingSource
    Friend WithEvents CourseTableAdapter1 As SMSDataSetTableAdapters.COURSETableAdapter
    Friend WithEvents BSCourse As BindingSource
End Class
