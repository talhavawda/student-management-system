<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tbpDetails = New System.Windows.Forms.TabPage()
        Me.btnMainPassword = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.grbStudent = New System.Windows.Forms.GroupBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtFirstStudyYear = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblFirstStudyYear = New System.Windows.Forms.Label()
        Me.grbDetails = New System.Windows.Forms.GroupBox()
        Me.txtCellNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.txtAdminNumber = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblCellNumber = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tbpNewRegistration = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.lbxSem2Chosen = New System.Windows.Forms.ListBox()
        Me.lbxSem1Avail = New System.Windows.Forms.ListBox()
        Me.lbxSem2Avail = New System.Windows.Forms.ListBox()
        Me.lblSemester1Reg = New System.Windows.Forms.Label()
        Me.lblSemester2Reg = New System.Windows.Forms.Label()
        Me.lbxSem1Chosen = New System.Windows.Forms.ListBox()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.txtMajor2 = New System.Windows.Forms.TextBox()
        Me.txtMajor1 = New System.Windows.Forms.TextBox()
        Me.txtFaculty = New System.Windows.Forms.TextBox()
        Me.lblMajor2 = New System.Windows.Forms.Label()
        Me.lblMajor1 = New System.Windows.Forms.Label()
        Me.txtStudentNumber = New System.Windows.Forms.TextBox()
        Me.lblFaculty = New System.Windows.Forms.Label()
        Me.lblStudentNumberReg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbpViewRegistration = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rtxtYearView = New System.Windows.Forms.RichTextBox()
        Me.lblC = New System.Windows.Forms.Label()
        Me.cmbYearView = New System.Windows.Forms.ComboBox()
        Me.lblYearView = New System.Windows.Forms.Label()
        Me.tbpResultsStudent = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.tbpResultsAdmin = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtResult = New System.Windows.Forms.MaskedTextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCaptureMarks = New System.Windows.Forms.Button()
        Me.cmbModules = New System.Windows.Forms.ComboBox()
        Me.txtStuResult = New System.Windows.Forms.TextBox()
        Me.lblResultVal = New System.Windows.Forms.Label()
        Me.lblModResult = New System.Windows.Forms.Label()
        Me.lblStuResult = New System.Windows.Forms.Label()
        Me.tbpReports = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbpCourses = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnAddFaculty = New System.Windows.Forms.Button()
        Me.txtAddFaculty = New System.Windows.Forms.TextBox()
        Me.cmbFaculty = New System.Windows.Forms.ComboBox()
        Me.AdminTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.ADMINTableAdapter()
        Me.FacultyTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.FACULTYTableAdapter()
        Me.TableAdapterManager1 = New StudentManagementSystem.SMSDataSetTableAdapters.TableAdapterManager()
        Me.SmsDataSet1 = New StudentManagementSystem.SMSDataSet()
        Me.StudentTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.STUDENTTableAdapter()
        Me.CourseTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.COURSETableAdapter()
        Me.BSAdmin = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSStudent = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSFaculty = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSCourse = New System.Windows.Forms.BindingSource(Me.components)
        Me.DisciplineTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.DISCIPLINETableAdapter()
        Me.BSDiscipline = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModuleTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.MODULETableAdapter()
        Me.BSModule = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModulE_REGISTRATIONTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.MODULE_REGISTRATIONTableAdapter()
        Me.BSModuleRegistration = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMSDataSet = New StudentManagementSystem.SMSDataSet()
        Me.tbcMain.SuspendLayout()
        Me.tbpDetails.SuspendLayout()
        Me.grbStudent.SuspendLayout()
        Me.grbDetails.SuspendLayout()
        Me.tbpNewRegistration.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.grpDetails.SuspendLayout()
        Me.tbpViewRegistration.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tbpResultsStudent.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tbpResultsAdmin.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.tbpReports.SuspendLayout()
        Me.tbpCourses.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.SmsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSDiscipline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSModule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSModuleRegistration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbcMain.Controls.Add(Me.tbpCourses)
        Me.tbcMain.Location = New System.Drawing.Point(12, 12)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(810, 535)
        Me.tbcMain.TabIndex = 0
        '
        'tbpDetails
        '
        Me.tbpDetails.Controls.Add(Me.btnMainPassword)
        Me.tbpDetails.Controls.Add(Me.btnCapture)
        Me.tbpDetails.Controls.Add(Me.grbStudent)
        Me.tbpDetails.Controls.Add(Me.grbDetails)
        Me.tbpDetails.Location = New System.Drawing.Point(4, 22)
        Me.tbpDetails.Name = "tbpDetails"
        Me.tbpDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDetails.Size = New System.Drawing.Size(802, 509)
        Me.tbpDetails.TabIndex = 0
        Me.tbpDetails.Text = "Details"
        Me.tbpDetails.UseVisualStyleBackColor = True
        '
        'btnMainPassword
        '
        Me.btnMainPassword.Location = New System.Drawing.Point(327, 426)
        Me.btnMainPassword.Name = "btnMainPassword"
        Me.btnMainPassword.Size = New System.Drawing.Size(105, 28)
        Me.btnMainPassword.TabIndex = 9
        Me.btnMainPassword.Text = "Change Password"
        Me.btnMainPassword.UseVisualStyleBackColor = True
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(22, 426)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(187, 28)
        Me.btnCapture.TabIndex = 8
        Me.btnCapture.Text = "Capture"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'grbStudent
        '
        Me.grbStudent.Controls.Add(Me.txtCourse)
        Me.grbStudent.Controls.Add(Me.txtFirstStudyYear)
        Me.grbStudent.Controls.Add(Me.lblCourse)
        Me.grbStudent.Controls.Add(Me.lblFirstStudyYear)
        Me.grbStudent.Location = New System.Drawing.Point(22, 301)
        Me.grbStudent.Name = "grbStudent"
        Me.grbStudent.Size = New System.Drawing.Size(410, 100)
        Me.grbStudent.TabIndex = 7
        Me.grbStudent.TabStop = False
        '
        'txtCourse
        '
        Me.txtCourse.Enabled = False
        Me.txtCourse.Location = New System.Drawing.Point(147, 51)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(257, 20)
        Me.txtCourse.TabIndex = 9
        '
        'txtFirstStudyYear
        '
        Me.txtFirstStudyYear.Enabled = False
        Me.txtFirstStudyYear.Location = New System.Drawing.Point(147, 18)
        Me.txtFirstStudyYear.Name = "txtFirstStudyYear"
        Me.txtFirstStudyYear.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstStudyYear.TabIndex = 8
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(6, 59)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(46, 13)
        Me.lblCourse.TabIndex = 7
        Me.lblCourse.Text = "Course :"
        '
        'lblFirstStudyYear
        '
        Me.lblFirstStudyYear.AutoSize = True
        Me.lblFirstStudyYear.Location = New System.Drawing.Point(6, 26)
        Me.lblFirstStudyYear.Name = "lblFirstStudyYear"
        Me.lblFirstStudyYear.Size = New System.Drawing.Size(87, 13)
        Me.lblFirstStudyYear.TabIndex = 6
        Me.lblFirstStudyYear.Text = "First Study Year :"
        '
        'grbDetails
        '
        Me.grbDetails.Controls.Add(Me.txtCellNumber)
        Me.grbDetails.Controls.Add(Me.txtEmailAddress)
        Me.grbDetails.Controls.Add(Me.txtSurname)
        Me.grbDetails.Controls.Add(Me.txtName)
        Me.grbDetails.Controls.Add(Me.txtIDNumber)
        Me.grbDetails.Controls.Add(Me.txtAdminNumber)
        Me.grbDetails.Controls.Add(Me.lblUsername)
        Me.grbDetails.Controls.Add(Me.lblEmailAddress)
        Me.grbDetails.Controls.Add(Me.lblCellNumber)
        Me.grbDetails.Controls.Add(Me.lblSurname)
        Me.grbDetails.Controls.Add(Me.lblIDNumber)
        Me.grbDetails.Controls.Add(Me.lblName)
        Me.grbDetails.Location = New System.Drawing.Point(22, 6)
        Me.grbDetails.Name = "grbDetails"
        Me.grbDetails.Size = New System.Drawing.Size(410, 289)
        Me.grbDetails.TabIndex = 3
        Me.grbDetails.TabStop = False
        '
        'txtCellNumber
        '
        Me.txtCellNumber.Location = New System.Drawing.Point(147, 177)
        Me.txtCellNumber.Mask = "9999999999"
        Me.txtCellNumber.Name = "txtCellNumber"
        Me.txtCellNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCellNumber.TabIndex = 15
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(147, 222)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtEmailAddress.TabIndex = 14
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(147, 133)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(147, 94)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 11
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Enabled = False
        Me.txtIDNumber.Location = New System.Drawing.Point(147, 55)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtIDNumber.TabIndex = 10
        '
        'txtAdminNumber
        '
        Me.txtAdminNumber.Enabled = False
        Me.txtAdminNumber.Location = New System.Drawing.Point(147, 21)
        Me.txtAdminNumber.Name = "txtAdminNumber"
        Me.txtAdminNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtAdminNumber.TabIndex = 9
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(15, 28)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(82, 13)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Admin Number :"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(15, 225)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(79, 13)
        Me.lblEmailAddress.TabIndex = 5
        Me.lblEmailAddress.Text = "Email Address :"
        '
        'lblCellNumber
        '
        Me.lblCellNumber.AutoSize = True
        Me.lblCellNumber.Location = New System.Drawing.Point(15, 184)
        Me.lblCellNumber.Name = "lblCellNumber"
        Me.lblCellNumber.Size = New System.Drawing.Size(70, 13)
        Me.lblCellNumber.TabIndex = 4
        Me.lblCellNumber.Text = "Cell Number :"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(15, 140)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(55, 13)
        Me.lblSurname.TabIndex = 3
        Me.lblSurname.Text = "Surname :"
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Location = New System.Drawing.Point(15, 62)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(64, 13)
        Me.lblIDNumber.TabIndex = 1
        Me.lblIDNumber.Text = "ID Number :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(15, 101)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name :"
        '
        'tbpNewRegistration
        '
        Me.tbpNewRegistration.Controls.Add(Me.GroupBox7)
        Me.tbpNewRegistration.Controls.Add(Me.grpDetails)
        Me.tbpNewRegistration.Controls.Add(Me.GroupBox1)
        Me.tbpNewRegistration.Location = New System.Drawing.Point(4, 22)
        Me.tbpNewRegistration.Name = "tbpNewRegistration"
        Me.tbpNewRegistration.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpNewRegistration.Size = New System.Drawing.Size(802, 509)
        Me.tbpNewRegistration.TabIndex = 1
        Me.tbpNewRegistration.Text = "New Registration"
        Me.tbpNewRegistration.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnReg)
        Me.GroupBox7.Controls.Add(Me.lbxSem2Chosen)
        Me.GroupBox7.Controls.Add(Me.lbxSem1Avail)
        Me.GroupBox7.Controls.Add(Me.lbxSem2Avail)
        Me.GroupBox7.Controls.Add(Me.lblSemester1Reg)
        Me.GroupBox7.Controls.Add(Me.lblSemester2Reg)
        Me.GroupBox7.Controls.Add(Me.lbxSem1Chosen)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 160)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(770, 343)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Registration"
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(299, 313)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(152, 23)
        Me.btnReg.TabIndex = 18
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'lbxSem2Chosen
        '
        Me.lbxSem2Chosen.FormattingEnabled = True
        Me.lbxSem2Chosen.Location = New System.Drawing.Point(393, 198)
        Me.lbxSem2Chosen.Name = "lbxSem2Chosen"
        Me.lbxSem2Chosen.Size = New System.Drawing.Size(334, 95)
        Me.lbxSem2Chosen.TabIndex = 17
        '
        'lbxSem1Avail
        '
        Me.lbxSem1Avail.FormattingEnabled = True
        Me.lbxSem1Avail.Location = New System.Drawing.Point(18, 51)
        Me.lbxSem1Avail.Name = "lbxSem1Avail"
        Me.lbxSem1Avail.Size = New System.Drawing.Size(334, 95)
        Me.lbxSem1Avail.TabIndex = 10
        '
        'lbxSem2Avail
        '
        Me.lbxSem2Avail.FormattingEnabled = True
        Me.lbxSem2Avail.Location = New System.Drawing.Point(18, 198)
        Me.lbxSem2Avail.Name = "lbxSem2Avail"
        Me.lbxSem2Avail.Size = New System.Drawing.Size(334, 95)
        Me.lbxSem2Avail.TabIndex = 16
        '
        'lblSemester1Reg
        '
        Me.lblSemester1Reg.AutoSize = True
        Me.lblSemester1Reg.Location = New System.Drawing.Point(15, 25)
        Me.lblSemester1Reg.Name = "lblSemester1Reg"
        Me.lblSemester1Reg.Size = New System.Drawing.Size(63, 13)
        Me.lblSemester1Reg.TabIndex = 4
        Me.lblSemester1Reg.Text = "Semester 1:"
        '
        'lblSemester2Reg
        '
        Me.lblSemester2Reg.AutoSize = True
        Me.lblSemester2Reg.Location = New System.Drawing.Point(15, 165)
        Me.lblSemester2Reg.Name = "lblSemester2Reg"
        Me.lblSemester2Reg.Size = New System.Drawing.Size(63, 13)
        Me.lblSemester2Reg.TabIndex = 15
        Me.lblSemester2Reg.Text = "Semester 2:"
        '
        'lbxSem1Chosen
        '
        Me.lbxSem1Chosen.FormattingEnabled = True
        Me.lbxSem1Chosen.Location = New System.Drawing.Point(393, 51)
        Me.lbxSem1Chosen.Name = "lbxSem1Chosen"
        Me.lbxSem1Chosen.Size = New System.Drawing.Size(334, 95)
        Me.lbxSem1Chosen.TabIndex = 11
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.txtMajor2)
        Me.grpDetails.Controls.Add(Me.txtMajor1)
        Me.grpDetails.Controls.Add(Me.txtFaculty)
        Me.grpDetails.Controls.Add(Me.lblMajor2)
        Me.grpDetails.Controls.Add(Me.lblMajor1)
        Me.grpDetails.Controls.Add(Me.txtStudentNumber)
        Me.grpDetails.Controls.Add(Me.lblFaculty)
        Me.grpDetails.Controls.Add(Me.lblStudentNumberReg)
        Me.grpDetails.Location = New System.Drawing.Point(6, 6)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(770, 148)
        Me.grpDetails.TabIndex = 1
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        '
        'txtMajor2
        '
        Me.txtMajor2.Enabled = False
        Me.txtMajor2.Location = New System.Drawing.Point(166, 114)
        Me.txtMajor2.Name = "txtMajor2"
        Me.txtMajor2.Size = New System.Drawing.Size(186, 20)
        Me.txtMajor2.TabIndex = 14
        '
        'txtMajor1
        '
        Me.txtMajor1.Enabled = False
        Me.txtMajor1.Location = New System.Drawing.Point(166, 82)
        Me.txtMajor1.Name = "txtMajor1"
        Me.txtMajor1.Size = New System.Drawing.Size(186, 20)
        Me.txtMajor1.TabIndex = 13
        '
        'txtFaculty
        '
        Me.txtFaculty.Enabled = False
        Me.txtFaculty.Location = New System.Drawing.Point(166, 50)
        Me.txtFaculty.Name = "txtFaculty"
        Me.txtFaculty.Size = New System.Drawing.Size(186, 20)
        Me.txtFaculty.TabIndex = 12
        '
        'lblMajor2
        '
        Me.lblMajor2.AutoSize = True
        Me.lblMajor2.Location = New System.Drawing.Point(15, 117)
        Me.lblMajor2.Name = "lblMajor2"
        Me.lblMajor2.Size = New System.Drawing.Size(45, 13)
        Me.lblMajor2.TabIndex = 7
        Me.lblMajor2.Text = "Major 2:"
        '
        'lblMajor1
        '
        Me.lblMajor1.AutoSize = True
        Me.lblMajor1.Location = New System.Drawing.Point(15, 85)
        Me.lblMajor1.Name = "lblMajor1"
        Me.lblMajor1.Size = New System.Drawing.Size(45, 13)
        Me.lblMajor1.TabIndex = 6
        Me.lblMajor1.Text = "Major 1:"
        '
        'txtStudentNumber
        '
        Me.txtStudentNumber.Enabled = False
        Me.txtStudentNumber.Location = New System.Drawing.Point(166, 20)
        Me.txtStudentNumber.Name = "txtStudentNumber"
        Me.txtStudentNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentNumber.TabIndex = 3
        '
        'lblFaculty
        '
        Me.lblFaculty.AutoSize = True
        Me.lblFaculty.Location = New System.Drawing.Point(15, 53)
        Me.lblFaculty.Name = "lblFaculty"
        Me.lblFaculty.Size = New System.Drawing.Size(44, 13)
        Me.lblFaculty.TabIndex = 1
        Me.lblFaculty.Text = "Faculty:"
        '
        'lblStudentNumberReg
        '
        Me.lblStudentNumberReg.AutoSize = True
        Me.lblStudentNumberReg.Location = New System.Drawing.Point(15, 23)
        Me.lblStudentNumberReg.Name = "lblStudentNumberReg"
        Me.lblStudentNumberReg.Size = New System.Drawing.Size(90, 13)
        Me.lblStudentNumberReg.TabIndex = 0
        Me.lblStudentNumberReg.Text = "Student Number :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'tbpViewRegistration
        '
        Me.tbpViewRegistration.Controls.Add(Me.GroupBox3)
        Me.tbpViewRegistration.Location = New System.Drawing.Point(4, 22)
        Me.tbpViewRegistration.Name = "tbpViewRegistration"
        Me.tbpViewRegistration.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpViewRegistration.Size = New System.Drawing.Size(802, 509)
        Me.tbpViewRegistration.TabIndex = 5
        Me.tbpViewRegistration.Text = "View Registration"
        Me.tbpViewRegistration.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rtxtYearView)
        Me.GroupBox3.Controls.Add(Me.lblC)
        Me.GroupBox3.Controls.Add(Me.cmbYearView)
        Me.GroupBox3.Controls.Add(Me.lblYearView)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(459, 259)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'rtxtYearView
        '
        Me.rtxtYearView.Location = New System.Drawing.Point(300, 104)
        Me.rtxtYearView.Name = "rtxtYearView"
        Me.rtxtYearView.Size = New System.Drawing.Size(121, 96)
        Me.rtxtYearView.TabIndex = 3
        Me.rtxtYearView.Text = ""
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(18, 140)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(129, 13)
        Me.lblC.TabIndex = 2
        Me.lblC.Text = "Your Registration Details :"
        '
        'cmbYearView
        '
        Me.cmbYearView.FormattingEnabled = True
        Me.cmbYearView.Location = New System.Drawing.Point(300, 49)
        Me.cmbYearView.Name = "cmbYearView"
        Me.cmbYearView.Size = New System.Drawing.Size(121, 21)
        Me.cmbYearView.TabIndex = 1
        '
        'lblYearView
        '
        Me.lblYearView.AutoSize = True
        Me.lblYearView.Location = New System.Drawing.Point(18, 49)
        Me.lblYearView.Name = "lblYearView"
        Me.lblYearView.Size = New System.Drawing.Size(226, 13)
        Me.lblYearView.TabIndex = 0
        Me.lblYearView.Text = "Select which Year of Study you Wish to View :"
        '
        'tbpResultsStudent
        '
        Me.tbpResultsStudent.Controls.Add(Me.GroupBox4)
        Me.tbpResultsStudent.Location = New System.Drawing.Point(4, 22)
        Me.tbpResultsStudent.Name = "tbpResultsStudent"
        Me.tbpResultsStudent.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpResultsStudent.Size = New System.Drawing.Size(802, 509)
        Me.tbpResultsStudent.TabIndex = 2
        Me.tbpResultsStudent.Text = "View Results"
        Me.tbpResultsStudent.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RichTextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(391, 326)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(15, 19)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(353, 257)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'tbpResultsAdmin
        '
        Me.tbpResultsAdmin.Controls.Add(Me.GroupBox5)
        Me.tbpResultsAdmin.Location = New System.Drawing.Point(4, 22)
        Me.tbpResultsAdmin.Name = "tbpResultsAdmin"
        Me.tbpResultsAdmin.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpResultsAdmin.Size = New System.Drawing.Size(802, 509)
        Me.tbpResultsAdmin.TabIndex = 3
        Me.tbpResultsAdmin.Text = "Add Results"
        Me.tbpResultsAdmin.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtResult)
        Me.GroupBox5.Controls.Add(Me.btnEnter)
        Me.GroupBox5.Controls.Add(Me.btnCaptureMarks)
        Me.GroupBox5.Controls.Add(Me.cmbModules)
        Me.GroupBox5.Controls.Add(Me.txtStuResult)
        Me.GroupBox5.Controls.Add(Me.lblResultVal)
        Me.GroupBox5.Controls.Add(Me.lblModResult)
        Me.GroupBox5.Controls.Add(Me.lblStuResult)
        Me.GroupBox5.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(525, 254)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Add Marks"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(202, 136)
        Me.txtResult.Mask = "000"
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(121, 20)
        Me.txtResult.TabIndex = 9
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(359, 42)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 8
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnCaptureMarks
        '
        Me.btnCaptureMarks.Location = New System.Drawing.Point(118, 188)
        Me.btnCaptureMarks.Name = "btnCaptureMarks"
        Me.btnCaptureMarks.Size = New System.Drawing.Size(105, 26)
        Me.btnCaptureMarks.TabIndex = 7
        Me.btnCaptureMarks.Text = "Capture"
        Me.btnCaptureMarks.UseVisualStyleBackColor = True
        '
        'cmbModules
        '
        Me.cmbModules.Enabled = False
        Me.cmbModules.FormattingEnabled = True
        Me.cmbModules.Location = New System.Drawing.Point(202, 85)
        Me.cmbModules.Name = "cmbModules"
        Me.cmbModules.Size = New System.Drawing.Size(121, 21)
        Me.cmbModules.TabIndex = 6
        '
        'txtStuResult
        '
        Me.txtStuResult.Location = New System.Drawing.Point(202, 46)
        Me.txtStuResult.MaxLength = 10
        Me.txtStuResult.Name = "txtStuResult"
        Me.txtStuResult.Size = New System.Drawing.Size(121, 20)
        Me.txtStuResult.TabIndex = 3
        '
        'lblResultVal
        '
        Me.lblResultVal.AutoSize = True
        Me.lblResultVal.Location = New System.Drawing.Point(26, 143)
        Me.lblResultVal.Name = "lblResultVal"
        Me.lblResultVal.Size = New System.Drawing.Size(113, 13)
        Me.lblResultVal.TabIndex = 2
        Me.lblResultVal.Text = "Enter Result Attained :"
        '
        'lblModResult
        '
        Me.lblModResult.AutoSize = True
        Me.lblModResult.Location = New System.Drawing.Point(26, 93)
        Me.lblModResult.Name = "lblModResult"
        Me.lblModResult.Size = New System.Drawing.Size(113, 13)
        Me.lblModResult.TabIndex = 1
        Me.lblModResult.Text = "Enter a Module Code :"
        '
        'lblStuResult
        '
        Me.lblStuResult.AutoSize = True
        Me.lblStuResult.Location = New System.Drawing.Point(26, 46)
        Me.lblStuResult.Name = "lblStuResult"
        Me.lblStuResult.Size = New System.Drawing.Size(90, 13)
        Me.lblStuResult.TabIndex = 0
        Me.lblStuResult.Text = "Student Number :"
        '
        'tbpReports
        '
        Me.tbpReports.Controls.Add(Me.GroupBox6)
        Me.tbpReports.Location = New System.Drawing.Point(4, 22)
        Me.tbpReports.Name = "tbpReports"
        Me.tbpReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpReports.Size = New System.Drawing.Size(802, 509)
        Me.tbpReports.TabIndex = 4
        Me.tbpReports.Text = "Reports"
        Me.tbpReports.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'tbpCourses
        '
        Me.tbpCourses.Controls.Add(Me.GroupBox8)
        Me.tbpCourses.Location = New System.Drawing.Point(4, 22)
        Me.tbpCourses.Name = "tbpCourses"
        Me.tbpCourses.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCourses.Size = New System.Drawing.Size(802, 509)
        Me.tbpCourses.TabIndex = 6
        Me.tbpCourses.Text = "Courses"
        Me.tbpCourses.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GroupBox9)
        Me.GroupBox8.Controls.Add(Me.cmbFaculty)
        Me.GroupBox8.Location = New System.Drawing.Point(24, 16)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(238, 151)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Faculty"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.btnAddFaculty)
        Me.GroupBox9.Controls.Add(Me.txtAddFaculty)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 53)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(226, 92)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Add Faculty"
        '
        'btnAddFaculty
        '
        Me.btnAddFaculty.Location = New System.Drawing.Point(77, 55)
        Me.btnAddFaculty.Name = "btnAddFaculty"
        Me.btnAddFaculty.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFaculty.TabIndex = 1
        Me.btnAddFaculty.Text = "Add Faculty"
        Me.btnAddFaculty.UseVisualStyleBackColor = True
        '
        'txtAddFaculty
        '
        Me.txtAddFaculty.Location = New System.Drawing.Point(6, 29)
        Me.txtAddFaculty.Name = "txtAddFaculty"
        Me.txtAddFaculty.Size = New System.Drawing.Size(214, 20)
        Me.txtAddFaculty.TabIndex = 0
        '
        'cmbFaculty
        '
        Me.cmbFaculty.FormattingEnabled = True
        Me.cmbFaculty.Location = New System.Drawing.Point(6, 19)
        Me.cmbFaculty.Name = "cmbFaculty"
        Me.cmbFaculty.Size = New System.Drawing.Size(226, 21)
        Me.cmbFaculty.TabIndex = 0
        '
        'AdminTableAdapter1
        '
        Me.AdminTableAdapter1.ClearBeforeFill = True
        '
        'FacultyTableAdapter1
        '
        Me.FacultyTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.ADMINTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.Course_ModuleTableAdapter = Nothing
        Me.TableAdapterManager1.COURSETableAdapter = Nothing
        Me.TableAdapterManager1.DISCIPLINETableAdapter = Nothing
        Me.TableAdapterManager1.FACULTYTableAdapter = Nothing
        Me.TableAdapterManager1.MODULE_REGISTRATIONTableAdapter = Nothing
        Me.TableAdapterManager1.MODULETableAdapter = Nothing
        Me.TableAdapterManager1.STUDENTTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = StudentManagementSystem.SMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SmsDataSet1
        '
        Me.SmsDataSet1.DataSetName = "SMSDataSet"
        Me.SmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentTableAdapter1
        '
        Me.StudentTableAdapter1.ClearBeforeFill = True
        '
        'CourseTableAdapter1
        '
        Me.CourseTableAdapter1.ClearBeforeFill = True
        '
        'BSAdmin
        '
        Me.BSAdmin.DataMember = "ADMIN"
        Me.BSAdmin.DataSource = Me.SmsDataSet1
        '
        'BSStudent
        '
        Me.BSStudent.DataMember = "STUDENT"
        Me.BSStudent.DataSource = Me.SmsDataSet1
        '
        'BSFaculty
        '
        Me.BSFaculty.DataMember = "FACULTY"
        Me.BSFaculty.DataSource = Me.SmsDataSet1
        '
        'DisciplineTableAdapter1
        '
        Me.DisciplineTableAdapter1.ClearBeforeFill = True
        '
        'BSDiscipline
        '
        Me.BSDiscipline.DataMember = "DISCIPLINE"
        Me.BSDiscipline.DataSource = Me.SmsDataSet1
        '
        'ModuleTableAdapter1
        '
        Me.ModuleTableAdapter1.ClearBeforeFill = True
        '
        'BSModule
        '
        Me.BSModule.DataMember = "MODULE"
        Me.BSModule.DataSource = Me.SmsDataSet1
        '
        'ModulE_REGISTRATIONTableAdapter1
        '
        Me.ModulE_REGISTRATIONTableAdapter1.ClearBeforeFill = True
        '
        'BSModuleRegistration
        '
        Me.BSModuleRegistration.DataSource = Me.SMSDataSet
        Me.BSModuleRegistration.Position = 0
        '
        'SMSDataSet
        '
        Me.SMSDataSet.DataSetName = "SMSDataSet"
        Me.SMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 551)
        Me.Controls.Add(Me.tbcMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tbcMain.ResumeLayout(False)
        Me.tbpDetails.ResumeLayout(False)
        Me.grbStudent.ResumeLayout(False)
        Me.grbStudent.PerformLayout()
        Me.grbDetails.ResumeLayout(False)
        Me.grbDetails.PerformLayout()
        Me.tbpNewRegistration.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.tbpViewRegistration.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tbpResultsStudent.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.tbpResultsAdmin.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tbpReports.ResumeLayout(False)
        Me.tbpCourses.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.SmsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSCourse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSDiscipline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSModule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSModuleRegistration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcMain As TabControl
	Friend WithEvents tbpDetails As TabPage
	Friend WithEvents tbpNewRegistration As TabPage
	Friend WithEvents tbpResultsStudent As TabPage
	Friend WithEvents tbpResultsAdmin As TabPage
	Friend WithEvents tbpReports As TabPage
	Friend WithEvents tbpViewRegistration As TabPage
	Friend WithEvents lblFirstStudyYear As Label
	Friend WithEvents grbDetails As GroupBox
	Friend WithEvents lblEmailAddress As Label
	Friend WithEvents lblCellNumber As Label
	Friend WithEvents lblSurname As Label
	Friend WithEvents lblIDNumber As Label
	Friend WithEvents lblName As Label
	Friend WithEvents grbStudent As GroupBox
	Friend WithEvents lblCourse As Label
	Friend WithEvents lblUsername As Label
	Friend WithEvents txtEmailAddress As TextBox
	Friend WithEvents txtSurname As TextBox
	Friend WithEvents txtName As TextBox
	Friend WithEvents txtIDNumber As TextBox
	Friend WithEvents txtAdminNumber As TextBox
	Friend WithEvents txtCourse As TextBox
	Friend WithEvents txtFirstStudyYear As TextBox
	Friend WithEvents grpDetails As GroupBox
	Friend WithEvents lblFaculty As Label
	Friend WithEvents lblStudentNumberReg As Label
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents GroupBox4 As GroupBox
	Friend WithEvents GroupBox5 As GroupBox
	Friend WithEvents GroupBox6 As GroupBox
	Friend WithEvents txtStudentNumber As TextBox
	Friend WithEvents lblMajor2 As Label
	Friend WithEvents lblMajor1 As Label
	Friend WithEvents lblSemester1Reg As Label
	Friend WithEvents rtxtYearView As RichTextBox
	Friend WithEvents lblC As Label
	Friend WithEvents cmbYearView As ComboBox
	Friend WithEvents lblYearView As Label
    Friend WithEvents lblModResult As Label
    Friend WithEvents lblStuResult As Label
    Friend WithEvents txtStuResult As TextBox
    Friend WithEvents lblResultVal As Label
    Friend WithEvents btnMainPassword As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents txtCellNumber As MaskedTextBox
    Friend WithEvents lbxSem1Avail As ListBox
    Friend WithEvents lbxSem1Chosen As ListBox
    Friend WithEvents txtMajor2 As TextBox
    Friend WithEvents txtMajor1 As TextBox
    Friend WithEvents txtFaculty As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lbxSem2Chosen As ListBox
    Friend WithEvents lbxSem2Avail As ListBox
    Friend WithEvents lblSemester2Reg As Label
    Friend WithEvents SmsDataSet1 As SMSDataSet
    Friend WithEvents AdminTableAdapter1 As SMSDataSetTableAdapters.ADMINTableAdapter
    Friend WithEvents StudentTableAdapter1 As SMSDataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents TableAdapterManager1 As SMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BSAdmin As BindingSource
    Friend WithEvents BSStudent As BindingSource
    Friend WithEvents tbpCourses As TabPage
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents btnAddFaculty As Button
    Friend WithEvents txtAddFaculty As TextBox
    Friend WithEvents cmbFaculty As ComboBox
    Friend WithEvents FacultyTableAdapter1 As SMSDataSetTableAdapters.FACULTYTableAdapter
    Friend WithEvents BSFaculty As BindingSource
    Friend WithEvents CourseTableAdapter1 As SMSDataSetTableAdapters.COURSETableAdapter
    Friend WithEvents BSCourse As BindingSource
    Friend WithEvents DisciplineTableAdapter1 As SMSDataSetTableAdapters.DISCIPLINETableAdapter
    Friend WithEvents BSDiscipline As BindingSource
    Friend WithEvents ModuleTableAdapter1 As SMSDataSetTableAdapters.MODULETableAdapter
    Friend WithEvents BSModule As BindingSource
    Friend WithEvents btnReg As Button
    Friend WithEvents ModulE_REGISTRATIONTableAdapter1 As SMSDataSetTableAdapters.MODULE_REGISTRATIONTableAdapter
    Friend WithEvents BSModuleRegistration As BindingSource
    Friend WithEvents SMSDataSet As SMSDataSet
    Friend WithEvents btnCaptureMarks As Button
    Friend WithEvents cmbModules As ComboBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtResult As MaskedTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
