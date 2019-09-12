Public Class frmSplashScreen
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    End Sub

	Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		My.Application.MinimumSplashScreenDisplayTime = 5000
		tmrLoadingLabel.Enabled = True
    End Sub

    Private Sub tmrSplash_Tick(sender As Object, e As EventArgs)



    End Sub

    Private Sub tmrLoadingLabel_Tick(sender As Object, e As EventArgs) Handles tmrLoadingLabel.Tick
		If lblLoadingBar.Text.Length < 200 Then
			lblLoadingBar.Text += "|"
		Else
			tmrLoadingLabel.Enabled = False
        End If

    End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs)

	End Sub
End Class
