Public Class frmLogin
    'We can Define a friend Variable to store Admin/Student Number To use across all forms
    Const STUDENT As Integer = 0
	Const ADMIN As Integer = 1
	Dim userType As Integer 'gets assigned to either STUDENT (0) or ADMIN(1)

    Friend newUser As TabPage = frmNewUser.tbpNewUser 'Reference to the newUser Tab Page on frmNewUser
    Friend changePassword As TabPage = frmNewUser.tbpChangePassword 'Reference to the changePassword Tab Page on frmNewUser

    Friend detailsTab As TabPage 'Reference to details Tab on frmMain
    Friend newReg As TabPage 'Reference to New registration tab on frmMain
    Friend viewReg As TabPage 'Reference to View Registration Tab on frmMain
    Friend viewResults As TabPage 'Reference to View reults on frmMain
    Friend addresults As TabPage 'Reference to Add results on frmMain
    Friend reports As TabPage 'Reference to Reports Tab on frmMain


    'Generic hide method
    Public Sub HidePage(ByRef tabpage As TabPage)
        frmNewUser.tbcNewUser.TabPages.Remove(tabpage)
    End Sub
    'Generic show method
    Public Sub ShowPage(ByRef tabpage As TabPage)
        frmNewUser.tbcNewUser.TabPages.Add(tabpage)
    End Sub


    Public Sub CloseProgram() 'Procedure to close the program
		Dim exitProgram As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If exitProgram = DialogResult.Yes Then
			Me.Close()
		End If
	End Sub

	Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrDateTime.Enabled = True
        HidePage(changePassword)
        HidePage(newUser)
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
		pnlLogin.Enabled = True
	End Sub

	Private Sub pbxStaff_Click(sender As Object, e As EventArgs) Handles pbxAdmin.Click
        lblUsername.Text = "Staff Number:"
        frmNewUser.lblStudAdminNumber.Text = "Staff Number:"
        lblNewStudent.Hide()
		'pnlLogin.Show()
		userType = ADMIN
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
        ShowPage(changePassword)
        HidePage(newUser)
        frmNewUser.ShowDialog()
	End Sub

	Private Sub lblNewStudent_Click(sender As Object, e As EventArgs) Handles lblNewStudent.Click
        ShowPage(newUser)
        HidePage(changePassword)
        frmNewUser.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        CloseProgram()
    End Sub

    Private Sub tmrDateTime_Tick(sender As Object, e As EventArgs) Handles tmrDateTime.Tick
        lblDateTime.Text = System.DateTime.Now.ToString("yyyy/MM/dd      HH:mm:ss")
    End Sub
End Class