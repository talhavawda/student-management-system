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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim exitProgram As DialogResult = MessageBox.Show("Are you sure you want to Logout?" + vbNewLine + "Your session will be terminated and the program will close", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If exitProgram = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub tmrAdminTime_Tick(sender As Object, e As EventArgs) Handles tmrAdminTime.Tick
        lblDateTime.Text = System.DateTime.Now.ToString("dd/MMM/yyyy | HH:mm:ss")
    End Sub

    Private Sub frmAdminHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.Close()
    End Sub
End Class