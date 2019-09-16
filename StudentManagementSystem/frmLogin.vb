﻿Public Class frmLogin
    'We can Define a friend Variable to store Admin/Student Number To use across all forms
    Friend Const STUDENT As Integer = 0
    Friend Const ADMIN As Integer = 1
    Friend NEWUSERFORM As Integer = 0
    Friend MAINFORM As Integer = 1
    Friend userType As Integer 'gets assigned to either STUDENT (0) or ADMIN(1)


    Friend newUser As TabPage = frmNewUser.tbpNewUser               'Reference to the newUser Tab Page on frmNewUser
    Friend changePassword As TabPage = frmNewUser.tbpChangePassword 'Reference to the changePassword Tab Page on frmNewUser

    Friend detailsTab As TabPage = frmMain.tbpDetails           'Reference to details Tab on frmMain
    Friend newReg As TabPage = frmMain.tbpNewRegistration       'Reference to New registration tab on frmMain
    Friend viewReg As TabPage = frmMain.tbpViewRegistration     'Reference to View Registration Tab on frmMain
    Friend viewResults As TabPage = frmMain.tbpResultsStudent   'Reference to View reults on frmMain
    Friend addResults As TabPage = frmMain.tbpResultsAdmin      'Reference to Add results on frmMain
    Friend reports As TabPage = frmMain.tbpReports              'Reference to Reports Tab on frmMain

    Friend username As String                                   'Friend so we can use it across Multiple Forms


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
        HidePage(detailsTab, MAINFORM)
        HidePage(newReg, MAINFORM)
        HidePage(viewReg, MAINFORM)
        HidePage(viewResults, MAINFORM)
        HidePage(addResults, MAINFORM)
        HidePage(reports, MAINFORM)
        HidePage(detailsTab, MAINFORM)
        pnlLogin.Enabled = False


        'DATABASE CONNECTION: 
        StudentTableAdapter1.Fill(SmsDataSet1.STUDENT)
        AdminTableAdapter1.Fill(SmsDataSet1.ADMIN)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlSelect.Paint

    End Sub

    Private Sub pbxStudent_Click(sender As Object, e As EventArgs) Handles pbxStudent.Click
        lblUsername.Text = "Student Number:"
        frmNewUser.lblStudAdminNumber.Text = "Student Number:"
        lblNewStudent.Show()
        userType = STUDENT
        txtLoginUsername.Clear()
        txtPassword.Clear()
        txtLoginUsername.Focus()
        pnlLogin.Enabled = True
    End Sub

    Private Sub pbxStaff_Click(sender As Object, e As EventArgs) Handles pbxAdmin.Click
        lblUsername.Text = "Staff Number:"
        frmNewUser.lblStudAdminNumber.Text = "Staff Number:"
        'pnlLogin.Show()
        userType = ADMIN
        txtLoginUsername.Clear()
        txtPassword.Clear()
        txtLoginUsername.Focus()
        pnlLogin.Enabled = True

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        username = txtLoginUsername.Text                'Store Username
        Dim password As String = txtPassword.Text       'Store Password

        If userType = ADMIN Then                                                    'If and Admin Member is loging in
            AdminTableAdapter1.AdminLogin(SmsDataSet1.ADMIN, username, password)    'SQL Query
            If SmsDataSet1.ADMIN.Rows.Count = 1 Then                                'Correct Admin Login
                MsgBox("Welcome " + SmsDataSet1.STUDENT.Rows(0).Item(2).trim + " " + SmsDataSet1.STUDENT.Rows(0).Item(3).trim)
                AdminTableAdapter1.Fill(SmsDataSet1.ADMIN)                          'Fill it again after sql filter
                frmAdminHome.ShowDialog()                                           'Show Admin Home Screen
            Else
                MessageBox.Show("Invalid Username/Password." + Environment.NewLine + "Please Re-Enter your deatils", "Invalid Lodin Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else                                                                            'userType = STUDENT
            StudentTableAdapter1.StudentLogin(SmsDataSet1.STUDENT, username, password)  'SQL Query
            If (SmsDataSet1.STUDENT.Rows.Count = 1) Then                                'Correct Student Login
                MsgBox("Welcome " + SmsDataSet1.STUDENT.Rows(0).Item(2).trim + " " + SmsDataSet1.STUDENT.Rows(0).Item(3).trim)
                StudentTableAdapter1.Fill(SmsDataSet1.STUDENT)                          'Fill it again after sql filter
                frmStudentHome.ShowDialog()                                             'Show Student Home Screen
            Else
                MessageBox.Show("Invalid Username/Password." + Environment.NewLine + "Please Re-Enter your deatils", "Invalid Lodin Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        'userType = STUDENT		'will already be set as STUDENT
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        CloseProgram()
    End Sub

    Private Sub tmrDateTime_Tick(sender As Object, e As EventArgs) Handles tmrDateTime.Tick
        lblDateTime.Text = System.DateTime.Now.ToString("dd/MMM/yyyy | HH:mm:ss")
    End Sub

    Private Sub lblDateTime_Click(sender As Object, e As EventArgs) Handles lblDateTime.Click

    End Sub
End Class