Public Class frmMain
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
End Class