Public Class frmAdminHome
	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

	Private Sub pbDetails_Click(sender As Object, e As EventArgs) Handles pbxDetails.Click
        frmLogin.ShowPage(frmLogin.details, frmLogin.MAINFORM)
        frmMain.grbStudent.Hide()
		frmMain.lblUsername.Text = "Staff Number: "
		frmMain.ShowDialog()

	End Sub

	Private Sub pbxMarks_Click(sender As Object, e As EventArgs) Handles pbxMarks.Click
		frmLogin.ShowPage(frmLogin.addResults, frmLogin.MAINFORM)
        frmLogin.ShowPage(frmLogin.reports, frmLogin.MAINFORM)
        frmLogin.ShowPage(frmLogin.viewResults, frmLogin.MAINFORM)
        frmMain.grpStud.Show()
        frmMain.ShowDialog()

	End Sub

	Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

	End Sub

	Private Sub pbxCourses_Click(sender As Object, e As EventArgs) Handles pbxCourses.Click
        frmLogin.ShowPage(frmLogin.courses, frmLogin.MAINFORM)
        frmMain.ShowDialog()
    End Sub

    Private Sub pbxRegistration_Click(sender As Object, e As EventArgs) Handles pbxRegistration.Click
        frmLogin.ShowPage(frmLogin.viewReg, frmLogin.MAINFORM)
        frmMain.ShowDialog()

    End Sub
End Class