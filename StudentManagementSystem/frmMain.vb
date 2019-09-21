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
		frmLogin.HidePage(frmLogin.details, frmLogin.MAINFORM)
		frmLogin.HidePage(frmLogin.newReg, frmLogin.MAINFORM)
		frmLogin.HidePage(frmLogin.viewReg, frmLogin.MAINFORM)
		frmLogin.HidePage(frmLogin.viewResults, frmLogin.MAINFORM)
		frmLogin.HidePage(frmLogin.reports, frmLogin.MAINFORM)
		frmLogin.HidePage(frmLogin.details, frmLogin.MAINFORM)
		frmLogin.HidePage(frmLogin.addResults, frmLogin.MAINFORM)
		frmLogin.HidePage(frmLogin.courses, frmLogin.MAINFORM)
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
		'POPULATE DETAILS TAB WITH USER'S DETAILS
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

	Private Sub tbpCourses_Enter(sender As Object, e As EventArgs) Handles tbpCourses.Enter
		FacultyTableAdapter1.Fill(SmsDataSet1.FACULTY)

		cmbFaculty.Items.Clear()

		For Each Row As DataRow In SmsDataSet1.FACULTY.Rows
			cmbFaculty.Items.Add(Row.Item(0)) 'List Faculty Names in ComboBox
		Next
	End Sub

	Private Sub btnAddFaculty_Click(sender As Object, e As EventArgs) Handles btnAddFaculty.Click
		Dim newFacultyID As Integer = FacultyTableAdapter1.HighestFacultyID() + 1
		FacultyTableAdapter1.InsertFaculty(txtAddFaculty.Text, newFacultyID) 'first parameter is Name of Faculty; second paramter is FacultyID
		tbpCourses_Enter(sender, e) 'call to populate the Faculty comboBox with updated values
	End Sub

	Private Sub tbpNewRegistration_Enter(sender As Object, e As EventArgs) Handles tbpNewRegistration.Enter

		'POPULATE STUDENT DETAILS ON NEW REGISTRATION TAB


		StudentTableAdapter1.FillDetails(SmsDataSet1.STUDENT, frmLogin.username) 'contains row (index = 0) with the specific student's detials
		txtStudentNumber.Text = SmsDataSet1.STUDENT.Rows(0).Item(0).trim 'frmLogin.username
        Dim CourseID As String
        Dim FacultyID As String
        Dim FacultyName As String
        Try
            StudentTableAdapter1.GetCourseID(SmsDataSet1.STUDENT, frmLogin.username)
            CourseID = SmsDataSet1.STUDENT.Rows(0).Item(0)
            CourseTableAdapter1.GetFacultyID(SmsDataSet1.COURSE, CourseID)
            FacultyID = SmsDataSet1.COURSE.Rows(0).Item(0)
            FacultyTableAdapter1.GetFacultyName(SmsDataSet1.FACULTY, FacultyID)
            FacultyName = SmsDataSet1.FACULTY.Rows(0).Item(0)
        Catch ex As Exception
            CourseID = "NULL"
            FacultyName = "NULL"
            FacultyID = "NULL"
        End Try




        txtFaculty.Text = FacultyName

		'txtMajor1.Text =
		'txtMajor2.Text = 

	End Sub
End Class