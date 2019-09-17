Public Class frmNewUser

    Dim SelectedCollege As Integer
    Dim yr As String = System.DateTime.Now.Year.ToString
    Dim newStudNum As String


    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SmsDataSet1.ADMIN' table. You can move, or remove it, as needed.
        Me.ADMINTableAdapter.Fill(Me.SmsDataSet1.ADMIN)
        FacultyTableAdapter1.Fill(SmsDataSet1.FACULTY)

        For Each Row As DataRow In SmsDataSet1.FACULTY.Rows
            cmbCollege.Items.Add(Row.Item(0))

        Next


        Dim ran As String = Int((999999 - 100000 + 1) * Rnd() + 100000).ToString
        newStudNum = yr + ran
        txtNewStudAdminNumber.Text = newStudNum
        'Above 2 lines creates new Student/staff number
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

    Private Sub txtNewStudAdminNumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtNewStudAdminNumber.MaskInputRejected

    End Sub

    Private Sub tbpNewUser_Click(sender As Object, e As EventArgs) Handles tbpNewUser.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub cmbCollege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCollege.SelectedIndexChanged
        cmbMajor1.Items.Clear()
        cmbMajor2.Items.Clear()


        SelectedCollege = cmbCollege.SelectedIndex + 1

        DisciplineTableAdapter1.FillMajors(SmsDataSet1.DISCIPLINE, SelectedCollege)

        For Each Row As DataRow In SmsDataSet1.DISCIPLINE.Rows
            cmbMajor1.Items.Add(Row.Item(1))
            cmbMajor2.Items.Add(Row.Item(1))
        Next
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click

        If (frmMain.ValidateCell(txtNewCell.Text) = False) Then  'validate cell
            MessageBox.Show("Invalid Data Entered", "Invalid Cell number", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf frmMain.ValidateEmail(txtNewEmail.Text) = False Then 'validate email
            MessageBox.Show("Invalid Data Entered", "Invalid email address", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then 'check passwords match
            MessageBox.Show("Invalid Data Entered", "Passwords dont match", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (frmLogin.userType = frmLogin.ADMIN) Then    'If Admin is using this form
                ADMINTableAdapter.InsertAdmin(txtNewStudAdminNumber.Text, txtNewID.Text, txtNewFirstname.Text, txtNewSurname.Text, txtNewCell.Text, txtNewEmail.Text, txtPassword.Text)
            Else    'If Student is using this form
                StudentTableAdapter1.InsertStudent(txtNewStudAdminNumber.Text, txtNewID.Text, txtNewFirstname.Text, txtNewSurname.Text, txtNewCell.Text, txtNewEmail.Text, txtPassword.Text, Integer.Parse(yr), 0)
            End If
            MessageBox.Show("Data Captured", "User created", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
End Class