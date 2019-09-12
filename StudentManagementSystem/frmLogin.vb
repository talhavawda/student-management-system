Public Class frmLogin


    Friend newUser As TabPage 'Reference to the newUser Tab Page on frmNewUser
    Friend changePassword As TabPage 'reference to the changePassword Tab Page on frmNewUser

    Public Sub HidetbpNewUser() 'Hide the newUSer Tab
        newUser = frmNewUser.tbpNewUser
        frmNewUser.tbcNewUser.TabPages.Remove(frmNewUser.tbpNewUser)
    End Sub

    Public Sub HidetbpChangePassword() 'Hide the ChangePassword Tab
        changePassword = frmNewUser.tbpChangePassword
        frmNewUser.tbcNewUser.TabPages.Remove(frmNewUser.tbpChangePassword)
    End Sub

    Private Sub ShowtbpNewUser() 'Show the newUser Tab
        frmNewUser.tbcNewUser.TabPages.Add(newUser)
    End Sub

    Private Sub ShowtbpChangePassword() 'Show the changePassword Tab
        frmNewUser.tbcNewUser.TabPages.Add(changePassword)
    End Sub

    Dim studentOrAdmin As Integer '0 for student ... 1 for Admin

    Const STUDENT As Integer = 0
	Const ADMIN As Integer = 1
	Dim userType As Integer 'gets assigned to either STUDENT (0) or ADMIN(1)

    
Public Sub CloseProgram() 'Procedure to close the program
        Dim exitProgram As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If exitProgram = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlLogin.Enabled = False
        HidetbpNewUser() 'Reference to the Tab will be stored in newUser
        HidetbpChangePassword() 'Reference to the Tab will be stored in changePassword
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlSelect.Paint

    End Sub

    Private Sub pbxStudent_Click(sender As Object, e As EventArgs) Handles pbxStudent.Click
        lblUsername.Text = "Student Number:"
        lblNewStudent.Show()
        'pnlLogin.Show()
        userType = STUDENT
        pnlLogin.Enabled = True
    End Sub

    Private Sub pbxStaff_Click(sender As Object, e As EventArgs) Handles pbxAdmin.Click
        lblUsername.Text = "Staff Number: "
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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ShowtbpChangePassword() 'Show the Change Password Tab
        HidetbpNewUser() 'Hide the New USer Tab
        frmNewUser.ShowDialog()
    End Sub

    Private Sub lblNewStudent_Click(sender As Object, e As EventArgs) Handles lblNewStudent.Click
        ShowtbpNewUser() 'Show New User tab
        HidetbpChangePassword() 'Hide the Change Password Tab
        frmNewUser.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        CloseProgram()
    End Sub
End Class