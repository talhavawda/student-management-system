Public Class frmAdminHome
	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

    Private Sub pbDetails_Click(sender As Object, e As EventArgs) Handles pbDetails.Click
        frmLogin.ShowPage(frmLogin.detailsTab, frmLogin.MAINFORM)
        frmMain.grbStudent.Hide()
        frmMain.lblUsername.Text = "Staff Number: "
        frmMain.ShowDialog()



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmLogin.ShowPage(frmLogin.addResults, frmLogin.MAINFORM)
        frmLogin.ShowPage(frmLogin.reports, frmLogin.MAINFORM)
        frmMain.ShowDialog()

    End Sub
End Class