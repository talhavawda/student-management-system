Public Class frmLogin
	'We can Define a friend Variable to store Admin/Student Number To use across all forms
	Friend Const STUDENT As Integer = 0
	Friend Const ADMIN As Integer = 1
	Friend NEWUSERFORM As Integer = 0
    Friend MAINFORM As Integer = 1
	Friend userType As Integer 'gets assigned to either STUDENT (0) or ADMIN(1)


	Friend newUser As TabPage = frmNewUser.tbpNewUser               'Reference to the newUser Tab Page on frmNewUser
	Friend changePassword As TabPage = frmNewUser.tbpChangePassword 'Reference to the changePassword Tab Page on frmNewUser

    Friend details As TabPage = frmMain.tbpDetails              'Reference to Details Tab on frmMain
    Friend newReg As TabPage = frmMain.tbpNewRegistration       'Reference to New registration tab on frmMain
    Friend viewReg As TabPage = frmMain.tbpViewRegistration     'Reference to View Registration Tab on frmMain
    Friend viewResults As TabPage = frmMain.tbpResultsStudent   'Reference to View reults on frmMain
    Friend addResults As TabPage = frmMain.tbpResultsAdmin      'Reference to Add results on frmMain
    Friend reports As TabPage = frmMain.tbpReports              'Reference to Reports Tab on frmMain
    Friend courses As TabPage = frmMain.tbpCourses              'Reference to Courses Tab on frmMain


	Friend username As String

	'Generic hide method
	Public Sub HidePage(ByRef tabpage As TabPage, ByVal whichForm As Integer)
        If whichForm = 0 Then
            frmNewUser.tbcNewUser.TabPages.Remove(tabpage)
        Else
            frmMain.tbcMain.TabPages.Remove(tabpage)
        End If

    End Sub
    'Generic show method
    Public Sub ShowPage(ByRef tabpage As TabPage, ByVal whichForm As Integer)
        If whichForm = 0 Then
            frmNewUser.tbcNewUser.TabPages.Add(tabpage)
        Else
            frmMain.tbcMain.TabPages.Add(tabpage)
        End If
    End Sub


    Public Sub CloseProgram() 'Procedure to close the program
        Dim exitProgram As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If exitProgram = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HidePage(changePassword, NEWUSERFORM)
        HidePage(newUser, NEWUSERFORM)
        HidePage(details, MAINFORM)
        HidePage(newReg, MAINFORM)
        HidePage(viewReg, MAINFORM)
        HidePage(viewResults, MAINFORM)
        HidePage(addResults, MAINFORM)
        HidePage(reports, MAINFORM)
        HidePage(details, MAINFORM)
        HidePage(courses, MAINFORM)
        pnlLogin.Enabled = False


        'DATABASE CONNECTION: 
        Try
            StudentTableAdapter1.Fill(SmsDataSet1.STUDENT)
            AdminTableAdapter1.Fill(SmsDataSet1.ADMIN)
        Catch ex As SqlClient.SqlException
            MessageBox.Show("Database not connected." + Environment.NewLine + "Please make sure that you are connected to the database first before running the application.", "Database not connected.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlSelect.Paint

    End Sub

    Private Sub pbxStudent_Click(sender As Object, e As EventArgs) Handles pbxStudent.Click
        pbxStudent.BorderStyle = BorderStyle.Fixed3D
        pbxStudent.BackColor = Color.DarkGray
        pbxAdmin.BorderStyle = BorderStyle.None
        pbxAdmin.BackColor = Color.Transparent

        lblUsername.Text = "Student Number:"
        frmNewUser.lblUserNumber.Text = "Student Number:"
        lblNewStudent.Show()
        userType = STUDENT
        pnlLogin.Enabled = True
        txtLoginUsername.Clear()
        txtPassword.Clear()
        txtLoginUsername.Focus()
    End Sub

    Private Sub pbxStaff_Click(sender As Object, e As EventArgs) Handles pbxAdmin.Click
        pbxAdmin.BorderStyle = BorderStyle.Fixed3D
        pbxAdmin.BackColor = Color.DarkGray
        pbxStudent.BorderStyle = BorderStyle.None
        pbxStudent.BackColor = Color.Transparent

        lblUsername.Text = "Staff Number:"
        frmNewUser.lblUserNumber.Text = "Staff Number:"
        'pnlLogin.Show()
        userType = ADMIN
        pnlLogin.Enabled = True
        txtLoginUsername.Clear()
        txtPassword.Clear()
        txtLoginUsername.Focus()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        username = txtLoginUsername.Text                'Store Username
        Dim password As String = txtPassword.Text       'Store Password

        If userType = ADMIN Then                                                    'If and Admin Member is loging in
            AdminTableAdapter1.AdminLogin(SmsDataSet1.ADMIN, username, password)    'SQL Query
            If SmsDataSet1.ADMIN.Rows.Count = 1 Then                                'Correct Admin Login
                MsgBox("Welcome " + SmsDataSet1.ADMIN.Rows(0).Item(2).trim + " " + SmsDataSet1.ADMIN.Rows(0).Item(3).trim)
                AdminTableAdapter1.Fill(SmsDataSet1.ADMIN)                          'Fill it again after sql filter
                frmAdminHome.ShowDialog()                                           'Show Admin Home Screen
            Else
                MessageBox.Show("Invalid Username/Password." + Environment.NewLine + "Please Re-Enter your details", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Generally the username is more likely correct and the password is incorrect so not going to clear username field
                txtPassword.Clear()
                txtPassword.Focus()
            End If
        Else                                                                            'userType = STUDENT
            StudentTableAdapter1.StudentLogin(SmsDataSet1.STUDENT, username, password)  'SQL Query
            If (SmsDataSet1.STUDENT.Rows.Count = 1) Then                                'Correct Student Login
                MsgBox("Welcome " + SmsDataSet1.STUDENT.Rows(0).Item(2).trim + " " + SmsDataSet1.STUDENT.Rows(0).Item(3).trim)
                StudentTableAdapter1.Fill(SmsDataSet1.STUDENT)                          'Fill it again after sql filter
                frmStudentHome.ShowDialog()                                             'Show Student Home Screen
            Else
                MessageBox.Show("Invalid Username/Password." + Environment.NewLine + "Please Re-Enter your details", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
				'Generally the username is more likely correct and the password is incorrect so not going to clear username field
				txtPassword.Clear()
				txtPassword.Focus()
			End If
        End If


    End Sub

    Private Sub lblForgotPassword_Click(sender As Object, e As EventArgs) Handles lblForgotPassword.Click
        ShowPage(changePassword, NEWUSERFORM)
        HidePage(newUser, NEWUSERFORM)
        frmNewUser.ShowDialog()
	End Sub

	Private Sub lblNewStudent_Click(sender As Object, e As EventArgs) Handles lblNewStudent.Click
        ShowPage(newUser, NEWUSERFORM)
        HidePage(changePassword, NEWUSERFORM)
		frmNewUser.ShowDialog()
		userType = STUDENT
	End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        CloseProgram()
    End Sub

    Private Sub tmrDateTime_Tick(sender As Object, e As EventArgs) Handles tmrDateTime.Tick
		lblDateTime.Text = System.DateTime.Now.ToString("dd/MMM/yyyy | HH:mm:ss")
	End Sub

	Private Sub lblDateTime_Click(sender As Object, e As EventArgs) Handles lblDateTime.Click

	End Sub

	Private Sub frmLogin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
		txtLoginUsername.Clear()
		txtPassword.Clear()
        'username = ""
        pnlLogin.Enabled = False
	End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAboutUs.ShowDialog()
    End Sub
End Class