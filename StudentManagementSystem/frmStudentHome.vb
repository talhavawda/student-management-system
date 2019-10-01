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

	Private Sub pbxResults_Click(sender As Object, e As EventArgs) Handles pbxResults.Click
        frmLogin.ShowPage(frmLogin.viewResults, frmLogin.MAINFORM)
        frmMain.grpStud.Hide()
        frmMain.ShowDialog()
	End Sub

	Private Sub pbxRegistration_Click(sender As Object, e As EventArgs) Handles pbxRegestration.Click
		frmLogin.ShowPage(frmLogin.newReg, frmLogin.MAINFORM)
        frmLogin.ShowPage(frmLogin.viewReg, frmLogin.MAINFORM)
        frmMain.ClearRegBoxes() 'first clear Modules from listboxes to repopulate
        frmMain.tbpNewRegistration_Enter(sender, e)
        frmMain.ShowDialog()


	End Sub

	Private Sub pbDetails_Click(sender As Object, e As EventArgs) Handles pbxDetails.Click
        frmLogin.ShowPage(frmLogin.details, frmLogin.MAINFORM)
        frmMain.grbStudent.Show()
        frmMain.lblUsername.Text = "Student Number: "
        frmMain.tbpNewRegistration_Enter(sender, e)
        frmMain.ShowDialog()
    End Sub

    Private Sub frmStudentHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim exitProgram As DialogResult = MessageBox.Show("Are you sure you want to Logout?" + vbNewLine + "Your session will be terminated and the program will close", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If exitProgram = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub tmrTimeStudent_Tick(sender As Object, e As EventArgs) Handles tmrTimeStudent.Tick
        lblDateTime.Text = System.DateTime.Now.ToString("dd/MMM/yyyy | HH:mm:ss")
    End Sub
End Class