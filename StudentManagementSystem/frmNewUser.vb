Public Class frmNewUser
	Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Before Closing remove both tabs.Their references will be stored on frmLogin in their respective variables
        frmLogin.HidetbpNewUser()
        frmLogin.HidetbpChangePassword()
        Me.Close()
    End Sub

    Private Sub frmNewUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.HidetbpNewUser()
        frmLogin.HidetbpChangePassword()
    End Sub
End Class