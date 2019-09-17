Public Class frmNewUser

    Dim SelectedCollege As Integer

    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FacultyTableAdapter1.Fill(SmsDataSet1.FACULTY)

        For Each Row As DataRow In SmsDataSet1.FACULTY.Rows
            cmbCollege.Items.Add(Row.Item(1))

        Next
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

    End Sub
End Class