Public Class frmLogin

    Dim studentOrAdmin As Integer '0 for student ... 1 for Admin

    Public Sub CloseProgram() 'Procedure to close the program
        Dim exitProgram As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If exitProgram = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlLogin.Enabled = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnlSelect.Paint

    End Sub

    Private Sub pbxStudent_Click(sender As Object, e As EventArgs) Handles pbxStudent.Click
        lblUsername.Text = "Student Number:"
        lblNewStudent.Show()
        'pnlLogin.Show()
        studentOrAdmin = 0
        pnlLogin.Enabled = True
    End Sub

    Private Sub pbxStaff_Click(sender As Object, e As EventArgs) Handles pbxAdmin.Click
        lblUsername.Text = "Staff Number: "
        lblNewStudent.Hide()
        'pnlLogin.Show()
        studentOrAdmin = 1
        pnlLogin.Enabled = True

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If studentOrAdmin = 0 Then
            frmStudentHome.ShowDialog()
        Else
            frmAdminHome.ShowDialog()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frmNewUser.tbpChangePassword.Enabled = True
        frmNewUser.tbpNewUser.Enabled = False 'Tab still visible, but not allowed to click on components
        frmNewUser.ShowDialog()
    End Sub

    Private Sub lblNewStudent_Click(sender As Object, e As EventArgs) Handles lblNewStudent.Click
        frmNewUser.tbpNewUser.Enabled = True
        frmNewUser.tbpChangePassword.Enabled = False 'Tab still visible, but not allowed to click on components
        frmNewUser.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        CloseProgram()
    End Sub
End Class