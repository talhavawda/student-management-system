Public Class frmNewUser
	Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Before Closing remove both tabs.Their references will be stored on frmLogin in their respective variables

        frmLogin.HidePage(frmLogin.newUser)
        frmLogin.HidePage(frmLogin.changePassword)
        Me.Close()
    End Sub

    Private Sub frmNewUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        frmLogin.HidePage(frmLogin.newUser)
        frmLogin.HidePage(frmLogin.changePassword)
        txtStudAdminNumber.Clear()
        txtID.Clear()
        txtCell.Clear()
        txtNewPassword.Clear()
        txtRePassword.Clear()
    End Sub

    Private Sub txtNewStudAdminNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtNewStudAdminNumber.MaskInputRejected

    End Sub

    Private Sub tbpNewUser_Click(sender As Object, e As EventArgs) Handles tbpNewUser.Click

    End Sub
End Class