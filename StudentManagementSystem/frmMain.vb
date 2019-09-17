﻿Public Class frmMain
    Public Function ValidateCell(ByVal cell As String) As Boolean
        If cell(0) <> "0" Or cell.Length <> 10 Then
            Return False
        End If
        Return True
    End Function

    Public Function ValidateEmail(ByVal email As String) As Boolean
        If email.IndexOf("@") > 0 And email.LastIndexOf(".") > email.IndexOf("@") Then
            Return True
        End If
        Return False
    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grbDetails.Enter

    End Sub

    Private Sub lblStudentNumber_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblEmailAddress_Click(sender As Object, e As EventArgs) Handles lblEmailAddress.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblMajor2.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles lblModResult.Click

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.HidePage(frmLogin.detailsTab, frmLogin.MAINFORM)
        frmLogin.HidePage(frmLogin.newReg, frmLogin.MAINFORM)
        frmLogin.HidePage(frmLogin.viewReg, frmLogin.MAINFORM)
        frmLogin.HidePage(frmLogin.viewResults, frmLogin.MAINFORM)
        frmLogin.HidePage(frmLogin.reports, frmLogin.MAINFORM)
        frmLogin.HidePage(frmLogin.detailsTab, frmLogin.MAINFORM)
        frmLogin.HidePage(frmLogin.addResults, frmLogin.MAINFORM)
    End Sub

    Private Sub btnMainPassword_Click(sender As Object, e As EventArgs) Handles btnMainPassword.Click
        frmLogin.ShowPage(frmLogin.changePassword, frmLogin.NEWUSERFORM)
        frmNewUser.ShowDialog()
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        'If ValidateCell(txtCellNumber.Text) And ValidateEmail(txtEmailAddress.text) Then'
        If (ValidateEmail(txtEmailAddress.Text) = False) Then
            MsgBox("Invalid Email Address")
        ElseIf (ValidateCell(txtCellNumber.Text) = False) Then
            MsgBox("Invalid Cell Number")
        Else
            If frmLogin.userType = frmLogin.ADMIN Then
                AdminTableAdapter1.UpdateDetails(txtName.Text, txtSurname.Text, txtCellNumber.Text, txtEmailAddress.Text, txtAdminNumber.Text)
                MsgBox("Details Captured")
            Else
                StudentTableAdapter1.UpdateDetails(txtName.Text, txtSurname.Text, txtCellNumber.Text, txtEmailAddress.Text, txtAdminNumber.Text)
                MsgBox("Details Captured")
            End If
        End If


    End Sub

    Private Sub txtCellNumber_TextChanged(sender As Object, e As EventArgs)

    End Sub

	Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If frmLogin.userType = frmLogin.ADMIN Then
            AdminTableAdapter1.FillDetails(SmsDataSet1.ADMIN, frmLogin.username)
            txtAdminNumber.Text = frmLogin.username
            txtIDNumber.Text = SmsDataSet1.ADMIN.Rows(0).Item(1).trim
            txtName.Text = SmsDataSet1.ADMIN.Rows(0).Item(2).trim
            txtSurname.Text = SmsDataSet1.ADMIN.Rows(0).Item(3).trim
            txtCellNumber.Text = SmsDataSet1.ADMIN.Rows(0).Item(4).trim
            txtEmailAddress.Text = SmsDataSet1.ADMIN.Rows(0).Item(5).trim
        Else
            StudentTableAdapter1.FillDetails(SmsDataSet1.STUDENT, frmLogin.username)
            txtAdminNumber.Text = frmLogin.username
            txtIDNumber.Text = SmsDataSet1.STUDENT.Rows(0).Item(1).trim
            txtName.Text = SmsDataSet1.STUDENT.Rows(0).Item(2).trim
            txtSurname.Text = SmsDataSet1.STUDENT.Rows(0).Item(3).trim
            txtCellNumber.Text = SmsDataSet1.STUDENT.Rows(0).Item(4).trim
            txtEmailAddress.Text = SmsDataSet1.STUDENT.Rows(0).Item(5).trim
            txtFirstStudyYear.Text = SmsDataSet1.STUDENT.Rows(0).Item(7)
            'txtCourse.Text = SmsDataSet1.STUDENT.Rows(0).Item(8)   'Need to get course as string

        End If
	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs)

	End Sub

    Private Sub txtText_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbpDetails_Click(sender As Object, e As EventArgs) Handles tbpDetails.Click

    End Sub
End Class