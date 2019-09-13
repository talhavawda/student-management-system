Public Class frmLogin
    'We can Define a friend Variable to store Admin/Student Number To use across all forms
    Const STUDENT As Integer = 0
    Const ADMIN As Integer = 1
    Friend NEWUSERFORM As Integer = 0
    Friend MAINFORM As Integer = 1
    Dim userType As Integer 'gets assigned to either STUDENT (0) or ADMIN(1)

    Friend newUser As TabPage = frmNewUser.tbpNewUser               'Reference to the newUser Tab Page on frmNewUser
    Friend changePassword As TabPage = frmNewUser.tbpChangePassword 'Reference to the changePassword Tab Page on frmNewUser

    Friend detailsTab As TabPage = frmMain.tbpDetails           'Reference to details Tab on frmMain
    Friend newReg As TabPage = frmMain.tbpNewRegistration       'Reference to New registration tab on frmMain
    Friend viewReg As TabPage = frmMain.tbpViewRegistration     'Reference to View Registration Tab on frmMain
    Friend viewResults As TabPage = frmMain.tbpResultsStudent   'Reference to View reults on frmMain
    Friend addresults As TabPage = frmMain.tbpResultsAdmin      'Reference to Add results on frmMain
    Friend reports As TabPage = frmMain.tbpReports              'Reference to Reports Tab on frmMain


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
        HidePage(addresults, MAINFORM)
        HidePage(reports, MAINFORM)
        HidePage(detailsTab, MAINFORM)
        pnlLogin.Enabled = False
    End Sub

	Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlSelect.Paint

	End Sub

	Private Sub pbxStudent_Click(sender As Object, e As EventArgs) Handles pbxStudent.Click
        lblUsername.Text = "Student Number:"
        frmNewUser.lblStudAdminNumber.Text = "Student Number:"
        lblNewStudent.Show()
		'pnlLogin.Show()
		userType = STUDENT
		txtLoginUsername.Focus()
		pnlLogin.Enabled = True
	End Sub

	Private Sub pbxStaff_Click(sender As Object, e As EventArgs) Handles pbxAdmin.Click
		lblUsername.Text = "Staff Number:"
		frmNewUser.lblStudAdminNumber.Text = "Staff Number:"
		lblNewStudent.Hide()
		'pnlLogin.Show()
		userType = ADMIN
		txtLoginUsername.Focus()
		pnlLogin.Enabled = True

	End Sub

	Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		If userType = STUDENT Then
			frmStudentHome.ShowDialog()
		Else
			frmAdminHome.ShowDialog()
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
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        CloseProgram()
    End Sub
End Class