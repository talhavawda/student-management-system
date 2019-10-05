Public Class frmNewUser

    Dim SelectedCollege As Integer
    Dim yr As String = System.DateTime.Now.Year.ToString
    Dim newStudNum As String

    Dim major1Code As String
    Dim major2Code As String

    'Clear all the components when the tab page loads
    Private Sub ClearNewUserTab()
        txtNewUserNumber.Clear()
        txtNewID.Clear()
        txtNewFirstname.Clear()
        txtNewSurname.Clear()
        txtNewCell.Clear()
        txtNewEmail.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()

        'Clear the combo boxes
        cmbCollege.SelectedIndex = -1
        cmbMajor1.SelectedIndex = -1
        cmbMajor2.SelectedIndex = -1


    End Sub

    Private Function createNewStudentNumber() As String
        Dim ran As String = Int((999999 - 100000 + 1) * Rnd() + 100000).ToString
        newStudNum = yr + ran
        Return newStudNum
    End Function

	Private Sub frmNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load, tbpNewUser.Enter

		'TODO: This line of code loads data into the 'SmsDataSet1.ADMIN' table. You can move, or remove it, as needed.
		Me.ADMINTableAdapter.Fill(Me.SmsDataSet1.ADMIN)
		FacultyTableAdapter1.Fill(SmsDataSet1.FACULTY)

		cmbCollege.Items.Clear()

		For Each Row As DataRow In SmsDataSet1.FACULTY.Rows
			cmbCollege.Items.Add(Row.Item(0))
		Next

		Dim studNumUnique As Boolean = False

		If (frmLogin.userType = frmLogin.STUDENT) Then
			Do While studNumUnique = False
				newStudNum = createNewStudentNumber()

				StudentTableAdapter1.Fill(SmsDataSet1.STUDENT)
				StudentTableAdapter1.FillDetails(SmsDataSet1.STUDENT, newStudNum)

				If (SmsDataSet1.STUDENT.Rows.Count = 0) Then
					studNumUnique = True
				End If
			Loop        'This loop continuously creates new STUDENT numbers until it is unique
		Else
			Do While studNumUnique = False
				newStudNum = createNewStudentNumber()

				ADMINTableAdapter.Fill(SmsDataSet1.ADMIN)
				ADMINTableAdapter.FillDetails(SmsDataSet1.ADMIN, newStudNum)

				If (SmsDataSet1.ADMIN.Rows.Count = 0) Then
					studNumUnique = True
				End If
			Loop        'This loop continuously creates new AMDIN numbers until it is unique
		End If

		txtNewUserNumber.Text = newStudNum

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Before Closing remove both tabs.Their references will be stored on frmLogin in their respective variables
        frmLogin.HidePage(frmLogin.newUser, frmLogin.NEWUSERFORM)
        frmLogin.HidePage(frmLogin.changePassword, frmLogin.NEWUSERFORM)
        Me.Close()
    End Sub

    Private Sub frmNewUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        frmLogin.HidePage(frmLogin.newUser, frmLogin.NEWUSERFORM)
        frmLogin.HidePage(frmLogin.changePassword, frmLogin.NEWUSERFORM)
        txtStudAdminNumber.Clear()
        txtID.Clear()
        txtCell.Clear()
        txtNewPassword.Clear()
        txtRePassword.Clear()
    End Sub

    Private Sub txtNewStudAdminNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtNewUserNumber.MaskInputRejected

    End Sub

    Private Sub tbpNewUser_Click(sender As Object, e As EventArgs) Handles tbpNewUser.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub cmbCollege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCollege.SelectedIndexChanged
        cmbMajor1.Items.Clear()
        cmbMajor1.Text = ""
        cmbMajor2.Items.Clear()
        cmbMajor2.Text = ""
        cmbMajor2.Enabled = False

        SelectedCollege = cmbCollege.SelectedIndex + 1

        DisciplineTableAdapter1.FillMajors(SmsDataSet1.DISCIPLINE, SelectedCollege)

        For Each Row As DataRow In SmsDataSet1.DISCIPLINE.Rows
            cmbMajor1.Items.Add(Row.Item(1))
        Next

        'Allow student to select their first major
        cmbMajor1.Enabled = True
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click

        DisciplineTableAdapter1.FillCodeByName(SmsDataSet1.DISCIPLINE, cmbMajor2.SelectedItem.Trim)
        major2Code = SmsDataSet1.DISCIPLINE.Rows(0).Item(0)

        CourseTableAdapter1.Fill(SmsDataSet1.COURSE)
        CourseTableAdapter1.FillCourseID(SmsDataSet1.COURSE, major1Code, major2Code)
        Dim selectedCourseID As Integer = SmsDataSet1.COURSE.Rows(0).Item(0)

        If (frmMain.ValidateCell(txtNewCell.Text) = False) Then  'validate cell
            MessageBox.Show("Invalid Data Entered", "Invalid Cell number", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf frmMain.ValidateEmail(txtNewEmail.Text) = False Then 'validate email
            MessageBox.Show("Invalid Data Entered", "Invalid email address", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then 'check passwords match
            MessageBox.Show("Invalid Data Entered", "Passwords dont match", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (frmLogin.userType = frmLogin.ADMIN) Then    'If Admin is using this form
                ADMINTableAdapter.InsertAdmin(txtNewUserNumber.Text, txtNewID.Text, txtNewFirstname.Text, txtNewSurname.Text, txtNewCell.Text, txtNewEmail.Text, txtPassword.Text)
            Else    'If Student is using this form
                StudentTableAdapter1.InsertStudent(txtNewUserNumber.Text, txtNewID.Text, txtNewFirstname.Text, txtNewSurname.Text, txtNewCell.Text, txtNewEmail.Text, txtPassword.Text, Integer.Parse(yr), selectedCourseID)
				'txtNewUserNumber.Text gets populated on form load
			End If

			Dim welcomeString As String = "Welcome " + txtNewFirstname.Text + " " + txtNewSurname.Text + Environment.NewLine + "Your Student Number is: " + txtNewUserNumber.Text
			MessageBox.Show(welcomeString, "User created", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim number As String = txtStudAdminNumber.Text
        Dim IDNumber As String = txtID.Text
        Dim cellNumber As String = txtCell.Text
        Dim password As String = txtNewPassword.Text

        If frmLogin.userType = frmLogin.ADMIN Then
            ADMINTableAdapter.CheckChangePasswordDetails(SmsDataSet1.ADMIN, number, IDNumber, cellNumber)
            If password <> txtRePassword.Text Or SmsDataSet1.ADMIN.Rows.Count <> 1 Then
                MessageBox.Show("Invalid Data Entered", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ADMINTableAdapter.Fill(SmsDataSet1.ADMIN)
                ADMINTableAdapter.UpdatePassword(password, number, IDNumber, cellNumber)
                MessageBox.Show("Password Successfully Updated", "Password Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else 'Student Changing Password
            StudentTableAdapter1.CheckChangePasswordDetails(SmsDataSet1.STUDENT, number, IDNumber, cellNumber)
            If password <> txtRePassword.Text Or SmsDataSet1.STUDENT.Rows.Count <> 1 Then
                MessageBox.Show("Invalid Data Entered", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                StudentTableAdapter1.Fill(SmsDataSet1.STUDENT)
                StudentTableAdapter1.UpdatePassword(password, number, IDNumber, cellNumber)
                MessageBox.Show("Password Successfully Updated", "Password Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub cmbMajor1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMajor1.SelectedIndexChanged
        cmbMajor2.Items.Clear()
        cmbMajor2.Text = ""
        cmbMajor2.Enabled = False


        DisciplineTableAdapter1.FillCodeByName(SmsDataSet1.DISCIPLINE, cmbMajor1.SelectedItem)
        major1Code = SmsDataSet1.DISCIPLINE.Rows(0).Item(0)
        '^^^ get DisciplineCode of major 1 ^^^


        CourseTableAdapter1.FillSecondMajor(SmsDataSet1.COURSE, major1Code, SelectedCollege)
        '^^^ Fill course table with all courses where major 1 = major1 OR major 2 = major1 ^^^

        DisciplineTableAdapter1.Fill(SmsDataSet1.DISCIPLINE)
        For Each Row As DataRow In SmsDataSet1.COURSE.Rows
            If major1Code = Row.Item(3) Then
                major2Code = Row.Item(2)
            Else
                major2Code = Row.Item(3)
            End If
            '^^^ to check for all combinations (major1 and major2)

            DisciplineTableAdapter1.FillMajor2(SmsDataSet1.DISCIPLINE, major2Code)
            cmbMajor2.Items.Add(SmsDataSet1.DISCIPLINE.Rows(0).Item(1))
        Next
        '^^^ populate combobox

        'Allow student to select their second major
        cmbMajor2.Enabled = True

    End Sub

    Private Sub tbcNewUser_Enter(sender As Object, e As EventArgs) Handles tbcNewUser.Enter
        'Clear all the components when the tab page loads
        ClearNewUserTab()


        'Disable Majors Combo Boxes when form loads
        'will be enabled when student selects a faculty
        cmbMajor1.Enabled = False
        cmbMajor2.Enabled = False
    End Sub

    Private Sub cmbMajor2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMajor2.SelectedIndexChanged

    End Sub
End Class