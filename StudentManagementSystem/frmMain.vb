Public Class frmMain

    Dim currentStudyYear As Integer
    Dim studNumberForMarkCapture As String
    Dim year As String = System.DateTime.Now.Year.ToString

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


    'first clear Modules from listboxes to repopulate
    Friend Sub ClearRegBoxes()
        lbxSem1Avail.Items.Clear()
        lbxSem2Avail.Items.Clear()
        lbxSem1Chosen.Items.Clear()
        lbxSem2Chosen.Items.Clear()
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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxSem1Avail.SelectedIndexChanged
        Dim chosenAlready As Boolean = False

        For Each str As String In lbxSem1Chosen.Items
            If (lbxSem1Avail.SelectedItem = str) Then
                chosenAlready = True
            End If
        Next

        If (chosenAlready = False) Then
            lbxSem1Chosen.Items.Add(lbxSem1Avail.SelectedItem)
        Else
            MsgBox("Module chosen already")
        End If


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SmsDataSet1.DISCIPLINE' table. You can move, or remove it, as needed.
        Me.DisciplineTableAdapter1.Fill(Me.SmsDataSet1.DISCIPLINE)
        'TODO: This line of code loads data into the 'SMSDataSet.DISCIPLINE' table. You can move, or remove it, as needed.
        Me.DisciplineTableAdapter1.Fill(Me.SMSDataSet.DISCIPLINE)


        'POPULATE DETAILS TAB WITH USER'S DETAILS
        If frmLogin.userType = frmLogin.ADMIN Then
            AdminTableAdapter1.Fill(SmsDataSet1.ADMIN)
            AdminTableAdapter1.FillDetails(SmsDataSet1.ADMIN, frmLogin.username)
            txtAdminNumber.Text = frmLogin.username
            txtIDNumber.Text = SmsDataSet1.ADMIN.Rows(0).Item(1).trim
            txtName.Text = SmsDataSet1.ADMIN.Rows(0).Item(2).trim
            txtSurname.Text = SmsDataSet1.ADMIN.Rows(0).Item(3).trim
            txtCellNumber.Text = SmsDataSet1.ADMIN.Rows(0).Item(4).trim
            txtEmailAddress.Text = SmsDataSet1.ADMIN.Rows(0).Item(5).trim
        Else
            'StudentTableAdapter1.Fill(SmsDataSet1.STUDENT)
            StudentTableAdapter1.FillDetails(SmsDataSet1.STUDENT, frmLogin.username)
            txtAdminNumber.Text = frmLogin.username
            txtIDNumber.Text = SmsDataSet1.STUDENT.Rows(0).Item(1).trim
            txtName.Text = SmsDataSet1.STUDENT.Rows(0).Item(2).trim
            txtSurname.Text = SmsDataSet1.STUDENT.Rows(0).Item(3).trim
            txtCellNumber.Text = SmsDataSet1.STUDENT.Rows(0).Item(4).trim
            txtEmailAddress.Text = SmsDataSet1.STUDENT.Rows(0).Item(5).trim
            txtFirstStudyYear.Text = SmsDataSet1.STUDENT.Rows(0).Item(7)
            'txtCourse.Text = SmsDataSet1.STUDENT.Rows(0).Item(8)   'Need to get course as string -> Course = QualCode + Major1 + Major2

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

    Friend Sub tbpNewRegistration_Enter(sender As Object, e As EventArgs) Handles tbpNewRegistration.Enter

        'POPULATE STUDENT DETAILS ON NEW REGISTRATION TAB
        StudentTableAdapter1.Fill(SmsDataSet1.STUDENT)
        CourseTableAdapter1.Fill(SmsDataSet1.COURSE)
        FacultyTableAdapter1.Fill(SmsDataSet1.FACULTY)
        StudentTableAdapter1.FillDetails(SmsDataSet1.STUDENT, frmLogin.username) 'contains row (index = 0) with the specific student's detials
        txtStudentNumber.Text = SmsDataSet1.STUDENT.Rows(0).Item(0).trim 'frmLogin.username
        Dim CourseID As Integer
        Dim FacultyID As Integer
        Dim FacultyName As String

        Dim majorCode1 As String = ""
        Dim majorCode2 As String = ""

        Try
            StudentTableAdapter1.FillDetails(SmsDataSet1.STUDENT, frmLogin.username)
            CourseID = Integer.Parse(SmsDataSet1.STUDENT.Rows(0).Item(8).ToString.Trim)

            Dim yr As Integer = Integer.Parse(System.DateTime.Now.Year)
            currentStudyYear = yr - Integer.Parse(SmsDataSet1.STUDENT.Rows(0).Item(7).ToString.Trim) + 1


            CourseTableAdapter1.GetDetails(SmsDataSet1.COURSE, CourseID)
            FacultyID = Integer.Parse(SmsDataSet1.COURSE.Rows(0).Item(4).ToString.Trim)

            FacultyTableAdapter1.GetDetails(SmsDataSet1.FACULTY, FacultyID)
            FacultyName = SmsDataSet1.FACULTY.Rows(0).Item(0).ToString.Trim

            CourseTableAdapter1.Fill(SmsDataSet1.COURSE)

            CourseTableAdapter1.GetDetails(SmsDataSet1.COURSE, CourseID)

            'txtMajor1.Text = SmsDataSet1.COURSE.Rows(0).Item(2)
            'txtMajor2.Text = SmsDataSet1.COURSE.Rows(0).Item(3)


            'Display Discipline NAME in Majors fields

            'first clear Modules to repopulate
            ClearRegBoxes()


            majorCode1 = SmsDataSet1.COURSE.Rows(0).Item(2).ToString.Trim

            DisciplineTableAdapter1.GetDisciplineName(SmsDataSet1.DISCIPLINE, majorCode1)
            txtMajor1.Text = SmsDataSet1.DISCIPLINE.Rows(0).Item(1)

            DisciplineTableAdapter1.Fill(SmsDataSet1.DISCIPLINE)

            majorCode2 = SmsDataSet1.COURSE.Rows(0).Item(3).ToString.Trim

            DisciplineTableAdapter1.GetDisciplineName(SmsDataSet1.DISCIPLINE, majorCode2)
            txtMajor2.Text = SmsDataSet1.DISCIPLINE.Rows(0).Item(1)


        Catch ex As Exception
            CourseID = 0
            FacultyName = "NULL"
            FacultyID = 0
        End Try




        txtFaculty.Text = FacultyName

        'txtMajor1.Text =
        'txtMajor2.Text = 

        '===========================================================================================

        'REGISTRATION
        Dim modCode As String
        Dim modName As String

        If (currentStudyYear = 1) Then 'First Year
            ModuleTableAdapter1.GetFirstYearModules(SmsDataSet1._MODULE, majorCode1, majorCode2)
            For Each Row As DataRow In SmsDataSet1._MODULE
                modCode = Row.Item(0)
                modName = Row.Item(1)
                If Row.Item(5) = 1 Then
                    lbxSem1Avail.Items.Add(modCode & vbTab + modName)
                Else
                    lbxSem2Avail.Items.Add(modCode & vbTab + modName)
                End If
            Next
        End If

        If (currentStudyYear > 1) Then 'Second Year ANd Third Year
            ModulE_REGISTRATIONTableAdapter1.GetFailedModules(SmsDataSet1.MODULE_REGISTRATION, frmLogin.username, Integer.Parse(year) - 1)
            If SmsDataSet1.MODULE_REGISTRATION.Rows.Count <> 0 Then 'You Failed in first Year
                For Each Row As DataRow In SmsDataSet1.MODULE_REGISTRATION
                    modCode = Row.Item(1)
                    ModuleTableAdapter1.GetDetails(SmsDataSet1._MODULE, modCode)
                    modName = SmsDataSet1._MODULE.Rows(0).Item(1)
                    If Row.Item(3) = 1 Then
                        lbxSem1Avail.Items.Add(modCode & vbTab + modName)
                        lbxSem1Chosen.Items.Add(modCode & vbTab + modName)
                    Else
                        lbxSem2Avail.Items.Add(modCode & vbTab + modName)
                        lbxSem2Chosen.Items.Add(modCode & vbTab + modName)
                    End If
                Next
            End If
            ModuleTableAdapter1.Fill(SmsDataSet1._MODULE)
            ModuleTableAdapter1.GetAvailableSem1Modules(SmsDataSet1._MODULE, majorCode1, majorCode2, frmLogin.username, Integer.Parse(year) - 1)
            For Each Row As DataRow In SmsDataSet1._MODULE
                modCode = Row.Item(0)
                modName = Row.Item(1)
                lbxSem1Avail.Items.Add(modCode & vbTab + modName)
                If Integer.Parse(modCode(4)) < currentStudyYear Then
                    lbxSem1Chosen.Items.Add(modCode & vbTab + modName)
                End If
            Next
            ModuleTableAdapter1.GetAvailableSem2Modules(SmsDataSet1._MODULE, majorCode1, majorCode2, frmLogin.username, Integer.Parse(year) - 1)
            For Each Row As DataRow In SmsDataSet1._MODULE
                modCode = Row.Item(0)
                modName = Row.Item(1)
                lbxSem2Avail.Items.Add(modCode & vbTab + modName)
                If Integer.Parse(modCode(4)) < currentStudyYear Then
                    lbxSem2Chosen.Items.Add(modCode & vbTab + modName)
                End If
            Next
        End If





    End Sub

    Private Sub tbcMain_DragEnter(sender As Object, e As DragEventArgs) Handles tbcMain.DragEnter

    End Sub

    Private Sub BSModule_CurrentChanged(sender As Object, e As EventArgs) Handles BSModule.CurrentChanged

    End Sub

    Private Sub lbxSem2Avail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxSem2Avail.SelectedIndexChanged
        Dim chosenAlready As Boolean = False

        For Each str As String In lbxSem2Chosen.Items
            If (lbxSem2Avail.SelectedItem = str) Then
                chosenAlready = True
            End If
        Next

        If (chosenAlready = False) Then
            lbxSem2Chosen.Items.Add(lbxSem2Avail.SelectedItem)
        Else
            MsgBox("Module chosen already")
        End If
    End Sub

    Private Sub lbxSem1Chosen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxSem1Chosen.SelectedIndexChanged


    End Sub

    Private Sub lbxSem2Chosen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxSem2Chosen.SelectedIndexChanged

    End Sub

    Private Sub grpDetails_Enter(sender As Object, e As EventArgs) Handles grpDetails.Enter

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        ModulE_REGISTRATIONTableAdapter1.CheckAlreadyRegistered(SmsDataSet1.MODULE_REGISTRATION, frmLogin.username, year)
        If SmsDataSet1.MODULE_REGISTRATION.Rows.Count = 0 Then
            If (lbxSem1Chosen.Items.Count = 4 And lbxSem2Chosen.Items.Count = 4) Then
                For Each str As String In lbxSem1Chosen.Items
                    Dim modCode As String = str.Substring(0, 8)
                    Dim regID As Integer = ModulE_REGISTRATIONTableAdapter1.GetMaxRegID + 1
                    Dim yr As String = System.DateTime.Now.Year.ToString
                    ModulE_REGISTRATIONTableAdapter1.NewRegistration(frmLogin.username, modCode, yr, 1, -1, regID)  'mark is entered as -1 (module not complete)
                Next

                For Each str As String In lbxSem2Chosen.Items
                    Dim modCode As String = str.Substring(0, 8)
                    Dim regID As Integer = ModulE_REGISTRATIONTableAdapter1.GetMaxRegID + 1
                    Dim yr As String = System.DateTime.Now.Year.ToString
                    ModulE_REGISTRATIONTableAdapter1.NewRegistration(frmLogin.username, modCode, yr, 2, -1, regID)  'mark is entered as -1 (module not complete)
                Next

                MsgBox("Registration Complete!")
            Else
                MsgBox("Please choose four modules per semester")
            End If
        Else
            MsgBox("You Are Already Registered For The Current Academic Year")
        End If





    End Sub

    Private Sub btnCaptureMarks_Click(sender As Object, e As EventArgs) Handles btnCaptureMarks.Click
        Dim mark As Integer = Integer.Parse(txtResult.Text)
        Dim modCode As String = cmbModules.SelectedItem
        If (mark < 0 Or mark > 100) Then
            MsgBox("Invalid Mark !!!")
        Else
            'Add mark to module reg table -> studNo,ModuleCode,Mark
            ModulE_REGISTRATIONTableAdapter1.AddMark(mark, studNumberForMarkCapture, year, modCode)
            MsgBox("Mark Successfully added to the Database.")
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        cmbModules.Items.Clear()
        studNumberForMarkCapture = txtStuResult.Text
        cmbModules.Enabled = True
        ModulE_REGISTRATIONTableAdapter1.GetModuleCodes(SmsDataSet1.MODULE_REGISTRATION, studNumberForMarkCapture, year)
        If SmsDataSet1.MODULE_REGISTRATION.Rows.Count = 0 Then
            MsgBox("Invalid Student Number Entered")
        Else
            For Each Row As DataRow In SmsDataSet1.MODULE_REGISTRATION
                cmbModules.Items.Add(Row.Item(1))
            Next
        End If

    End Sub

    Private Sub txtStuResult_TextChanged(sender As Object, e As EventArgs) Handles txtStuResult.TextChanged
        cmbModules.Items.Clear()
        cmbModules.Enabled = False
    End Sub

    Private Sub lbxSem1Chosen_Click(sender As Object, e As EventArgs) Handles lbxSem1Chosen.Click
        Dim selected As String = lbxSem1Chosen.SelectedItem
        Try
            If Integer.Parse(selected(4)) < currentStudyYear Then
                MsgBox("Cannot remove Selected Module " + Environment.NewLine + "You must complete " + selected.Substring(0, 8) + " to continue with your degree")
            Else
                lbxSem1Chosen.Items.Remove(lbxSem1Chosen.SelectedItem)
            End If
        Catch ex As Exception
            MsgBox("Please select a module to remove")
        End Try




    End Sub

    Private Sub lbxSem2Chosen_Click(sender As Object, e As EventArgs) Handles lbxSem2Chosen.Click
        Dim selected As String = lbxSem2Chosen.SelectedItem
        Try
            If Integer.Parse(selected(4)) < currentStudyYear Then
                MsgBox("Cannot remove Selected Module " + Environment.NewLine + "You must complete " + selected.Substring(0, 8) + " to continue with your degree")
            Else
                lbxSem2Chosen.Items.Remove(lbxSem2Chosen.SelectedItem)
            End If
        Catch ex As Exception
            MsgBox("Please select a module to remove")
        End Try


    End Sub
End Class