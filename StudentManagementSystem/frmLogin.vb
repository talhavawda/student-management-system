﻿Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub pbxStudent_Click(sender As Object, e As EventArgs) Handles pbxStudent.Click
        lblUsername.Text = "Student Number: "
    End Sub

    Private Sub pbxStaff_Click(sender As Object, e As EventArgs) Handles pbxStaff.Click
		lblUsername.Text = "Staff Number: "
		'Test | Commit Change
	End Sub

	Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

	End Sub
End Class