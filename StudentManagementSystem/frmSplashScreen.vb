﻿Public Class frmSplashScreen

	Dim progressCounter As Integer = 0

	Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

	End Sub

	Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'My.Application.MinimumSplashScreenDisplayTime = 3000	'this must be set in ApplicationEvents.vb (accessible via Project Properties)
		frmTeamScreen.Show()
		tmrLoadingLabel.Enabled = True
	End Sub

	Private Sub tmrSplash_Tick(sender As Object, e As EventArgs)



	End Sub

	Private Sub tmrLoadingLabel_Tick(sender As Object, e As EventArgs) Handles tmrLoadingLabel.Tick
		'Since this form is set as a Splash Screen in the Project Settings the for will automatically close after 2 seconds thus no need to check for length of the LoadingBar 

		lblLoadingBar.Text += "|"
		progressCounter += 1
		If lblLoadingBar.Text = "||" Then
			Threading.Thread.Sleep(1000)
			frmTeamScreen.Close()
		End If
		'now SplashScreen will show for another 2000ms as MinDisplayTime set to 3000

		If progressCounter = 135 Then
			tmrLoadingLabel.Enabled = False 'Stop the progress bar (if not connected to server then progress bar wont continue till the end of the screen
		End If

	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs)

	End Sub

End Class
