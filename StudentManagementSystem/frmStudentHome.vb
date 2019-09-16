Public Class frmStudentHome
	'Students Can:
	'1. Access Details Tab
	'2. Access New Registration Tab ??? YES
	'3. Access View Registration Tab
	'4. Access View Results Tab

	Private Sub Button1_Click(sender As Object, e As EventArgs)
        'change text of Main
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbxResults.Click
        frmLogin.ShowPage(frmLogin.viewResults, frmLogin.MAINFORM)
        frmMain.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxReg.Click
        frmLogin.ShowPage(frmLogin.newReg, frmLogin.MAINFORM)
        frmLogin.ShowPage(frmLogin.viewReg, frmLogin.MAINFORM)
        frmMain.ShowDialog()
    End Sub

    Private Sub pbDetails_Click(sender As Object, e As EventArgs) Handles pbxDetails.Click
        frmLogin.ShowPage(frmLogin.detailsTab, frmLogin.MAINFORM)
        frmMain.grbStudent.Show()
        frmMain.lblUsername.Text = "Student Number: "
        frmMain.ShowDialog()
    End Sub
End Class