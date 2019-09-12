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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tbpDetails = New System.Windows.Forms.TabPage()
        Me.grbStudent = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblFirstStudyYear = New System.Windows.Forms.Label()
        Me.grbDetails = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblAdminNumber = New System.Windows.Forms.Label()
        Me.lblStudentNumber = New System.Windows.Forms.Label()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblCellNumber = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblIdNumber = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpNewRegistration = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbMajor2 = New System.Windows.Forms.ComboBox()
        Me.cmbMajor1 = New System.Windows.Forms.ComboBox()
        Me.lblMajor2 = New System.Windows.Forms.Label()
        Me.lblMajor1 = New System.Windows.Forms.Label()
        Me.txtSemesterReg = New System.Windows.Forms.TextBox()
        Me.lblSemesterReg = New System.Windows.Forms.Label()
        Me.txtStudentNumberReg = New System.Windows.Forms.TextBox()
        Me.cmbQualReg = New System.Windows.Forms.ComboBox()
        Me.lblQualReg = New System.Windows.Forms.Label()
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
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblModView = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.lstModView = New System.Windows.Forms.ListBox()
        Me.tbpResultsAdmin = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtResultVal = New System.Windows.Forms.TextBox()
        Me.txtModResult = New System.Windows.Forms.TextBox()
        Me.txtStuResult = New System.Windows.Forms.TextBox()
        Me.lblResultVal = New System.Windows.Forms.Label()
        Me.lblModResult = New System.Windows.Forms.Label()
        Me.lblStuResult = New System.Windows.Forms.Label()
        Me.tbpReports = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.tbcMain.SuspendLayout()
        Me.tbpDetails.SuspendLayout()
        Me.grbStudent.SuspendLayout()
        Me.grbDetails.SuspendLayout()
        Me.tbpNewRegistration.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tbpViewRegistration.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tbpResultsStudent.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tbpResultsAdmin.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.tbpReports.SuspendLayout()
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
        Me.tbcMain.Size = New System.Drawing.Size(810, 499)
        Me.tbcMain.TabIndex = 0
        '
        'tbpDetails
        '
        Me.tbpDetails.Controls.Add(Me.grbStudent)
        Me.tbpDetails.Controls.Add(Me.grbDetails)
        Me.tbpDetails.Controls.Add(Me.Label1)
        Me.tbpDetails.Location = New System.Drawing.Point(4, 22)
        Me.tbpDetails.Name = "tbpDetails"
        Me.tbpDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDetails.Size = New System.Drawing.Size(802, 473)
        Me.tbpDetails.TabIndex = 0
        Me.tbpDetails.Text = "Details"
        Me.tbpDetails.UseVisualStyleBackColor = True
        '
        'grbStudent
        '
        Me.grbStudent.Controls.Add(Me.TextBox9)
        Me.grbStudent.Controls.Add(Me.TextBox8)
        Me.grbStudent.Controls.Add(Me.lblCourse)
        Me.grbStudent.Controls.Add(Me.lblFirstStudyYear)
        Me.grbStudent.Location = New System.Drawing.Point(22, 301)
        Me.grbStudent.Name = "grbStudent"
        Me.grbStudent.Size = New System.Drawing.Size(410, 100)
        Me.grbStudent.TabIndex = 7
        Me.grbStudent.TabStop = False
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(147, 51)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 9
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(147, 18)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 8
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
        Me.grbDetails.Controls.Add(Me.TextBox7)
        Me.grbDetails.Controls.Add(Me.TextBox6)
        Me.grbDetails.Controls.Add(Me.TextBox5)
        Me.grbDetails.Controls.Add(Me.TextBox4)
        Me.grbDetails.Controls.Add(Me.TextBox3)
        Me.grbDetails.Controls.Add(Me.TextBox2)
        Me.grbDetails.Controls.Add(Me.TextBox1)
        Me.grbDetails.Controls.Add(Me.lblAdminNumber)
        Me.grbDetails.Controls.Add(Me.lblStudentNumber)
        Me.grbDetails.Controls.Add(Me.lblEmailAddress)
        Me.grbDetails.Controls.Add(Me.lblCellNumber)
        Me.grbDetails.Controls.Add(Me.lblSurname)
        Me.grbDetails.Controls.Add(Me.lblIdNumber)
        Me.grbDetails.Controls.Add(Me.lblName)
        Me.grbDetails.Location = New System.Drawing.Point(22, 6)
        Me.grbDetails.Name = "grbDetails"
        Me.grbDetails.Size = New System.Drawing.Size(410, 289)
        Me.grbDetails.TabIndex = 3
        Me.grbDetails.TabStop = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(147, 250)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(147, 205)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(147, 161)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(147, 122)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(147, 83)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(147, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(147, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'lblAdminNumber
        '
        Me.lblAdminNumber.AutoSize = True
        Me.lblAdminNumber.Location = New System.Drawing.Point(15, 56)
        Me.lblAdminNumber.Name = "lblAdminNumber"
        Me.lblAdminNumber.Size = New System.Drawing.Size(82, 13)
        Me.lblAdminNumber.TabIndex = 7
        Me.lblAdminNumber.Text = "Admin Number :"
        '
        'lblStudentNumber
        '
        Me.lblStudentNumber.AutoSize = True
        Me.lblStudentNumber.Location = New System.Drawing.Point(15, 16)
        Me.lblStudentNumber.Name = "lblStudentNumber"
        Me.lblStudentNumber.Size = New System.Drawing.Size(90, 13)
        Me.lblStudentNumber.TabIndex = 6
        Me.lblStudentNumber.Text = "Student Number :"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(15, 253)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(79, 13)
        Me.lblEmailAddress.TabIndex = 5
        Me.lblEmailAddress.Text = "Email Address :"
        '
        'lblCellNumber
        '
        Me.lblCellNumber.AutoSize = True
        Me.lblCellNumber.Location = New System.Drawing.Point(15, 212)
        Me.lblCellNumber.Name = "lblCellNumber"
        Me.lblCellNumber.Size = New System.Drawing.Size(70, 13)
        Me.lblCellNumber.TabIndex = 4
        Me.lblCellNumber.Text = "Cell Number :"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(15, 168)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(55, 13)
        Me.lblSurname.TabIndex = 3
        Me.lblSurname.Text = "Surname :"
        '
        'lblIdNumber
        '
        Me.lblIdNumber.AutoSize = True
        Me.lblIdNumber.Location = New System.Drawing.Point(15, 90)
        Me.lblIdNumber.Name = "lblIdNumber"
        Me.lblIdNumber.Size = New System.Drawing.Size(64, 13)
        Me.lblIdNumber.TabIndex = 1
        Me.lblIdNumber.Text = "ID Number :"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(15, 129)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "cant change password here. a separate form will deal with that which a button her" &
    "e will go to that form"
        '
        'tbpNewRegistration
        '
        Me.tbpNewRegistration.Controls.Add(Me.GroupBox2)
        Me.tbpNewRegistration.Controls.Add(Me.GroupBox1)
        Me.tbpNewRegistration.Location = New System.Drawing.Point(4, 22)
        Me.tbpNewRegistration.Name = "tbpNewRegistration"
        Me.tbpNewRegistration.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpNewRegistration.Size = New System.Drawing.Size(802, 473)
        Me.tbpNewRegistration.TabIndex = 1
        Me.tbpNewRegistration.Text = "New Registration"
        Me.tbpNewRegistration.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbMajor2)
        Me.GroupBox2.Controls.Add(Me.cmbMajor1)
        Me.GroupBox2.Controls.Add(Me.lblMajor2)
        Me.GroupBox2.Controls.Add(Me.lblMajor1)
        Me.GroupBox2.Controls.Add(Me.txtSemesterReg)
        Me.GroupBox2.Controls.Add(Me.lblSemesterReg)
        Me.GroupBox2.Controls.Add(Me.txtStudentNumberReg)
        Me.GroupBox2.Controls.Add(Me.cmbQualReg)
        Me.GroupBox2.Controls.Add(Me.lblQualReg)
        Me.GroupBox2.Controls.Add(Me.lblStudentNumberReg)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(503, 246)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cmbMajor2
        '
        Me.cmbMajor2.FormattingEnabled = True
        Me.cmbMajor2.Location = New System.Drawing.Point(285, 189)
        Me.cmbMajor2.Name = "cmbMajor2"
        Me.cmbMajor2.Size = New System.Drawing.Size(121, 21)
        Me.cmbMajor2.TabIndex = 9
        '
        'cmbMajor1
        '
        Me.cmbMajor1.FormattingEnabled = True
        Me.cmbMajor1.Location = New System.Drawing.Point(285, 151)
        Me.cmbMajor1.Name = "cmbMajor1"
        Me.cmbMajor1.Size = New System.Drawing.Size(121, 21)
        Me.cmbMajor1.TabIndex = 8
        '
        'lblMajor2
        '
        Me.lblMajor2.AutoSize = True
        Me.lblMajor2.Location = New System.Drawing.Point(15, 197)
        Me.lblMajor2.Name = "lblMajor2"
        Me.lblMajor2.Size = New System.Drawing.Size(135, 13)
        Me.lblMajor2.TabIndex = 7
        Me.lblMajor2.Text = "Select your Second Major :"
        '
        'lblMajor1
        '
        Me.lblMajor1.AutoSize = True
        Me.lblMajor1.Location = New System.Drawing.Point(15, 159)
        Me.lblMajor1.Name = "lblMajor1"
        Me.lblMajor1.Size = New System.Drawing.Size(117, 13)
        Me.lblMajor1.TabIndex = 6
        Me.lblMajor1.Text = "Select your First Major :"
        '
        'txtSemesterReg
        '
        Me.txtSemesterReg.Location = New System.Drawing.Point(285, 114)
        Me.txtSemesterReg.Name = "txtSemesterReg"
        Me.txtSemesterReg.Size = New System.Drawing.Size(100, 20)
        Me.txtSemesterReg.TabIndex = 5
        '
        'lblSemesterReg
        '
        Me.lblSemesterReg.AutoSize = True
        Me.lblSemesterReg.Location = New System.Drawing.Point(15, 121)
        Me.lblSemesterReg.Name = "lblSemesterReg"
        Me.lblSemesterReg.Size = New System.Drawing.Size(180, 13)
        Me.lblSemesterReg.TabIndex = 4
        Me.lblSemesterReg.Text = "Please Enter the Semester of Study :"
        '
        'txtStudentNumberReg
        '
        Me.txtStudentNumberReg.Location = New System.Drawing.Point(285, 34)
        Me.txtStudentNumberReg.Name = "txtStudentNumberReg"
        Me.txtStudentNumberReg.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentNumberReg.TabIndex = 3
        '
        'cmbQualReg
        '
        Me.cmbQualReg.FormattingEnabled = True
        Me.cmbQualReg.Location = New System.Drawing.Point(285, 78)
        Me.cmbQualReg.Name = "cmbQualReg"
        Me.cmbQualReg.Size = New System.Drawing.Size(121, 21)
        Me.cmbQualReg.TabIndex = 2
        '
        'lblQualReg
        '
        Me.lblQualReg.AutoSize = True
        Me.lblQualReg.Location = New System.Drawing.Point(15, 81)
        Me.lblQualReg.Name = "lblQualReg"
        Me.lblQualReg.Size = New System.Drawing.Size(182, 13)
        Me.lblQualReg.TabIndex = 1
        Me.lblQualReg.Text = "Choose your Preferred Qualification  :"
        '
        'lblStudentNumberReg
        '
        Me.lblStudentNumberReg.AutoSize = True
        Me.lblStudentNumberReg.Location = New System.Drawing.Point(15, 41)
        Me.lblStudentNumberReg.Name = "lblStudentNumberReg"
        Me.lblStudentNumberReg.Size = New System.Drawing.Size(176, 13)
        Me.lblStudentNumberReg.TabIndex = 0
        Me.lblStudentNumberReg.Text = "Please Enter your Student Number :"
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
        Me.tbpViewRegistration.Size = New System.Drawing.Size(802, 473)
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
        Me.tbpResultsStudent.Size = New System.Drawing.Size(802, 473)
        Me.tbpResultsStudent.TabIndex = 2
        Me.tbpResultsStudent.Text = "View Results"
        Me.tbpResultsStudent.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblResults)
        Me.GroupBox4.Controls.Add(Me.lblModView)
        Me.GroupBox4.Controls.Add(Me.lstResults)
        Me.GroupBox4.Controls.Add(Me.lstModView)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(391, 194)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(258, 25)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(67, 13)
        Me.lblResults.TabIndex = 4
        Me.lblResults.Text = "Your Results"
        '
        'lblModView
        '
        Me.lblModView.AutoSize = True
        Me.lblModView.Location = New System.Drawing.Point(45, 25)
        Me.lblModView.Name = "lblModView"
        Me.lblModView.Size = New System.Drawing.Size(72, 13)
        Me.lblModView.TabIndex = 3
        Me.lblModView.Text = "Your Modules"
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(240, 51)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(120, 95)
        Me.lstResults.TabIndex = 2
        '
        'lstModView
        '
        Me.lstModView.FormattingEnabled = True
        Me.lstModView.Location = New System.Drawing.Point(28, 51)
        Me.lstModView.Name = "lstModView"
        Me.lstModView.Size = New System.Drawing.Size(120, 95)
        Me.lstModView.TabIndex = 1
        '
        'tbpResultsAdmin
        '
        Me.tbpResultsAdmin.Controls.Add(Me.GroupBox5)
        Me.tbpResultsAdmin.Location = New System.Drawing.Point(4, 22)
        Me.tbpResultsAdmin.Name = "tbpResultsAdmin"
        Me.tbpResultsAdmin.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpResultsAdmin.Size = New System.Drawing.Size(802, 473)
        Me.tbpResultsAdmin.TabIndex = 3
        Me.tbpResultsAdmin.Text = "Add Results"
        Me.tbpResultsAdmin.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtResultVal)
        Me.GroupBox5.Controls.Add(Me.txtModResult)
        Me.GroupBox5.Controls.Add(Me.txtStuResult)
        Me.GroupBox5.Controls.Add(Me.lblResultVal)
        Me.GroupBox5.Controls.Add(Me.lblModResult)
        Me.GroupBox5.Controls.Add(Me.lblStuResult)
        Me.GroupBox5.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(311, 215)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'txtResultVal
        '
        Me.txtResultVal.Location = New System.Drawing.Point(202, 135)
        Me.txtResultVal.Name = "txtResultVal"
        Me.txtResultVal.Size = New System.Drawing.Size(100, 20)
        Me.txtResultVal.TabIndex = 5
        '
        'txtModResult
        '
        Me.txtModResult.Location = New System.Drawing.Point(202, 93)
        Me.txtModResult.Name = "txtModResult"
        Me.txtModResult.Size = New System.Drawing.Size(100, 20)
        Me.txtModResult.TabIndex = 4
        '
        'txtStuResult
        '
        Me.txtStuResult.Location = New System.Drawing.Point(202, 46)
        Me.txtStuResult.Name = "txtStuResult"
        Me.txtStuResult.Size = New System.Drawing.Size(100, 20)
        Me.txtStuResult.TabIndex = 3
        '
        'lblResultVal
        '
        Me.lblResultVal.AutoSize = True
        Me.lblResultVal.Location = New System.Drawing.Point(26, 135)
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
        Me.lblStuResult.Size = New System.Drawing.Size(127, 13)
        Me.lblStuResult.TabIndex = 0
        Me.lblStuResult.Text = "Enter a Student Number :"
        '
        'tbpReports
        '
        Me.tbpReports.Controls.Add(Me.GroupBox6)
        Me.tbpReports.Location = New System.Drawing.Point(4, 22)
        Me.tbpReports.Name = "tbpReports"
        Me.tbpReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpReports.Size = New System.Drawing.Size(802, 473)
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 511)
        Me.Controls.Add(Me.tbcMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.tbcMain.ResumeLayout(False)
        Me.tbpDetails.ResumeLayout(False)
        Me.tbpDetails.PerformLayout()
        Me.grbStudent.ResumeLayout(False)
        Me.grbStudent.PerformLayout()
        Me.grbDetails.ResumeLayout(False)
        Me.grbDetails.PerformLayout()
        Me.tbpNewRegistration.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tbpViewRegistration.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tbpResultsStudent.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tbpResultsAdmin.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tbpReports.ResumeLayout(False)
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
    Friend WithEvents lblFirstStudyYear As Label
    Friend WithEvents grbDetails As GroupBox
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents lblCellNumber As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblIdNumber As Label
    Friend WithEvents lblName As Label
    Friend WithEvents grbStudent As GroupBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblAdminNumber As Label
    Friend WithEvents lblStudentNumber As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblQualReg As Label
    Friend WithEvents lblStudentNumberReg As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtStudentNumberReg As TextBox
    Friend WithEvents cmbQualReg As ComboBox
    Friend WithEvents cmbMajor2 As ComboBox
    Friend WithEvents cmbMajor1 As ComboBox
    Friend WithEvents lblMajor2 As Label
    Friend WithEvents lblMajor1 As Label
    Friend WithEvents txtSemesterReg As TextBox
    Friend WithEvents lblSemesterReg As Label
    Friend WithEvents rtxtYearView As RichTextBox
    Friend WithEvents lblC As Label
    Friend WithEvents cmbYearView As ComboBox
    Friend WithEvents lblYearView As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents lblModView As Label
    Friend WithEvents lstResults As ListBox
    Friend WithEvents lstModView As ListBox
    Friend WithEvents lblModResult As Label
    Friend WithEvents lblStuResult As Label
    Friend WithEvents txtResultVal As TextBox
    Friend WithEvents txtModResult As TextBox
    Friend WithEvents txtStuResult As TextBox
    Friend WithEvents lblResultVal As Label
End Class
