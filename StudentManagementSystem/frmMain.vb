Public Class frmMain
    Public Function ValidateCell(ByVal cell As String) As Boolean
        If cell(0) <> "0" Or cell.Length <> 10 Then
            Return False
        End If
        Return True
    End Function
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grbDetails.Enter

    End Sub

    Private Sub lblStudentNumber_Click(sender As Object, e As EventArgs) Handles lblStudentNumber.Click

    End Sub

    Private Sub lblEmailAddress_Click(sender As Object, e As EventArgs) Handles lblEmailAddress.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblMajor2.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lblModResult.Click

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.HidePage(frmLogin.detailsTab, frmLogin.MAINFORM)
        frmLogin.HidePage(frmLogin.newReg, frmLogin.MAINFORM)
        frmLogin.HidePage(frmLogin.viewReg, frmLogin.MAINFORM)
        frmLogin.HidePage(frmLogin.viewResults, frmLogin.MAINFORM)
        frmLogin.HidePage(frmLogin.reports, frmLogin.MAINFORM)
        frmLogin.HidePage(frmLogin.detailsTab, frmLogin.MAINFORM)
    End Sub

    Private Sub btnMainPassword_Click(sender As Object, e As EventArgs) Handles btnMainPassword.Click
        frmLogin.ShowPage(frmLogin.changePassword, frmLogin.NEWUSERFORM)
        frmNewUser.ShowDialog()
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        'If ValidateCell(txtCellNumber.Text) And ValidateEmail(txtEmailAddress.text) Then'
    End Sub

    Private Sub txtCellNumber_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class