Public Class frmNewUser
	Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Before Closing remove both tabs.Their references will be stored on frmLogin in their respective variables
        frmLogin.HidetbpNewUser()
        frmLogin.HidetbpChangePassword()
        Me.Close()
    End Sub
End Class