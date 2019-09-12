Public Class frmSplashScreen
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    End Sub

	Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'My.Application.MinimumSplashScreenDisplayTime = 5000	'not applicable if a splash screen is set in Settings 
		frmTeamScreen.Show()

		tmrLoadingLabel.Enabled = True
	End Sub

    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs)



    End Sub

    Private Sub tmrLoadingLabel_Tick(sender As Object, e As EventArgs) Handles tmrLoadingLabel.Tick
		'Since this form is set as a Splash Screen in the Project Settings the for will automatically close after 2 seconds thus no need to check for length of the LoadingBar 
		lblLoadingBar.Text += "|"
		If lblLoadingBar.Text = "||" Then
			Threading.Thread.Sleep(1000)
			frmTeamScreen.Close()
		End If

	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs)

	End Sub

End Class
