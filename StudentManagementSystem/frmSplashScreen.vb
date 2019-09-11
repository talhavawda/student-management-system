Public Class frmSplashScreen
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    End Sub

	Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		My.Application.MinimumSplashScreenDisplayTime = 5000
		tmrSplash.Enabled = True
	End Sub

	Private Sub tmrSplash_Tick(sender As Object, e As EventArgs) Handles tmrSplash.Tick
		If prbSplash.Value < 100 Then
			prbSplash.Value += prbSplash.Step
            lblProgressPercent.Text = (prbSplash.Value).ToString + "%"
        Else
			tmrSplash.Enabled = False
		End If


	End Sub
End Class
