<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pnlSelect = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblNewStudent = New System.Windows.Forms.Label()
		Me.pbxAdmin = New System.Windows.Forms.PictureBox()
		Me.pbxStudent = New System.Windows.Forms.PictureBox()
		Me.pnlLogin = New System.Windows.Forms.Panel()
		Me.lblForgotPassword = New System.Windows.Forms.Label()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.txtLoginUsername = New System.Windows.Forms.MaskedTextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblUsername = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.btnAbout = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.lblDateTime = New System.Windows.Forms.Label()
		Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
		Me.SmsDataSet1 = New StudentManagementSystem.SMSDataSet()
		Me.StudentTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.STUDENTTableAdapter()
		Me.AdminTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.ADMINTableAdapter()
		Me.FacultyTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.FACULTYTableAdapter()
		Me.StudentToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.AdminToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.TableAdapterManager1 = New StudentManagementSystem.SMSDataSetTableAdapters.TableAdapterManager()
		Me.BSStudent = New System.Windows.Forms.BindingSource(Me.components)
		Me.BSAdmin = New System.Windows.Forms.BindingSource(Me.components)
		Me.pnlSelect.SuspendLayout()
		CType(Me.pbxAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbxStudent, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlLogin.SuspendLayout()
		Me.Panel3.SuspendLayout()
		CType(Me.SmsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BSStudent, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BSAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(200, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(107, 37)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "I am a..."
		'
		'pnlSelect
		'
		Me.pnlSelect.Controls.Add(Me.Label3)
		Me.pnlSelect.Controls.Add(Me.lblNewStudent)
		Me.pnlSelect.Controls.Add(Me.pbxAdmin)
		Me.pnlSelect.Controls.Add(Me.Label1)
		Me.pnlSelect.Controls.Add(Me.pbxStudent)
		Me.pnlSelect.Location = New System.Drawing.Point(0, 0)
		Me.pnlSelect.Name = "pnlSelect"
		Me.pnlSelect.Size = New System.Drawing.Size(538, 202)
		Me.pnlSelect.TabIndex = 0
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(156, 80)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(212, 65)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "VALID LOGINS: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                     USERNAME      PASSWORD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ADMIN:        1234" &
	"567890      jkane123" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "STUDENT:    0123456789     Test" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'lblNewStudent
		'
		Me.lblNewStudent.AutoSize = True
		Me.lblNewStudent.Cursor = System.Windows.Forms.Cursors.Hand
		Me.lblNewStudent.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.lblNewStudent.Location = New System.Drawing.Point(61, 173)
		Me.lblNewStudent.Name = "lblNewStudent"
		Me.lblNewStudent.Size = New System.Drawing.Size(97, 13)
		Me.lblNewStudent.TabIndex = 5
		Me.lblNewStudent.Text = "I am a new student"
		'
		'pbxAdmin
		'
		Me.pbxAdmin.AccessibleDescription = "Admin"
		Me.pbxAdmin.BackColor = System.Drawing.Color.Transparent
		Me.pbxAdmin.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pbxAdmin.Image = CType(resources.GetObject("pbxAdmin.Image"), System.Drawing.Image)
		Me.pbxAdmin.Location = New System.Drawing.Point(346, 47)
		Me.pbxAdmin.Name = "pbxAdmin"
		Me.pbxAdmin.Size = New System.Drawing.Size(154, 132)
		Me.pbxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbxAdmin.TabIndex = 1
		Me.pbxAdmin.TabStop = False
		'
		'pbxStudent
		'
		Me.pbxStudent.AccessibleDescription = "Student"
		Me.pbxStudent.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pbxStudent.Image = CType(resources.GetObject("pbxStudent.Image"), System.Drawing.Image)
		Me.pbxStudent.Location = New System.Drawing.Point(38, 50)
		Me.pbxStudent.Name = "pbxStudent"
		Me.pbxStudent.Size = New System.Drawing.Size(140, 120)
		Me.pbxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbxStudent.TabIndex = 0
		Me.pbxStudent.TabStop = False
		Me.pbxStudent.Tag = "Student"
		'
		'pnlLogin
		'
		Me.pnlLogin.Controls.Add(Me.lblForgotPassword)
		Me.pnlLogin.Controls.Add(Me.btnLogin)
		Me.pnlLogin.Controls.Add(Me.txtPassword)
		Me.pnlLogin.Controls.Add(Me.txtLoginUsername)
		Me.pnlLogin.Controls.Add(Me.Label2)
		Me.pnlLogin.Controls.Add(Me.lblUsername)
		Me.pnlLogin.Location = New System.Drawing.Point(0, 208)
		Me.pnlLogin.Name = "pnlLogin"
		Me.pnlLogin.Size = New System.Drawing.Size(538, 138)
		Me.pnlLogin.TabIndex = 4
		'
		'lblForgotPassword
		'
		Me.lblForgotPassword.AutoSize = True
		Me.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
		Me.lblForgotPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.lblForgotPassword.Location = New System.Drawing.Point(138, 107)
		Me.lblForgotPassword.Name = "lblForgotPassword"
		Me.lblForgotPassword.Size = New System.Drawing.Size(104, 13)
		Me.lblForgotPassword.TabIndex = 6
		Me.lblForgotPassword.Text = "I forgot my password"
		'
		'btnLogin
		'
		Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnLogin.Location = New System.Drawing.Point(331, 31)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(138, 61)
		Me.btnLogin.TabIndex = 4
		Me.btnLogin.Text = "&Login"
		Me.btnLogin.UseVisualStyleBackColor = True
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(135, 72)
		Me.txtPassword.MaxLength = 15
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(100, 20)
		Me.txtPassword.TabIndex = 3
		Me.txtPassword.UseSystemPasswordChar = True
		'
		'txtLoginUsername
		'
		Me.txtLoginUsername.Location = New System.Drawing.Point(135, 33)
		Me.txtLoginUsername.Mask = "0000000000"
		Me.txtLoginUsername.Name = "txtLoginUsername"
		Me.txtLoginUsername.Size = New System.Drawing.Size(100, 20)
		Me.txtLoginUsername.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(39, 75)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(59, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Password: "
		'
		'lblUsername
		'
		Me.lblUsername.AutoSize = True
		Me.lblUsername.Location = New System.Drawing.Point(39, 36)
		Me.lblUsername.Name = "lblUsername"
		Me.lblUsername.Size = New System.Drawing.Size(61, 13)
		Me.lblUsername.TabIndex = 0
		Me.lblUsername.Text = "Username: "
		'
		'Panel3
		'
		Me.Panel3.Controls.Add(Me.btnAbout)
		Me.Panel3.Controls.Add(Me.btnExit)
		Me.Panel3.Controls.Add(Me.lblDateTime)
		Me.Panel3.Location = New System.Drawing.Point(0, 361)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(538, 42)
		Me.Panel3.TabIndex = 5
		'
		'btnAbout
		'
		Me.btnAbout.Location = New System.Drawing.Point(370, 11)
		Me.btnAbout.Name = "btnAbout"
		Me.btnAbout.Size = New System.Drawing.Size(75, 23)
		Me.btnAbout.TabIndex = 2
		Me.btnAbout.Text = "&About"
		Me.btnAbout.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnExit.Location = New System.Drawing.Point(460, 11)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 1
		Me.btnExit.Text = "&Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'lblDateTime
		'
		Me.lblDateTime.AutoSize = True
		Me.lblDateTime.Location = New System.Drawing.Point(8, 14)
		Me.lblDateTime.Name = "lblDateTime"
		Me.lblDateTime.Size = New System.Drawing.Size(89, 13)
		Me.lblDateTime.TabIndex = 0
		Me.lblDateTime.Text = "<Date and Time>"
		'
		'tmrDateTime
		'
		Me.tmrDateTime.Enabled = True
		'
		'SmsDataSet1
		'
		Me.SmsDataSet1.DataSetName = "SMSDataSet"
		Me.SmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'StudentTableAdapter1
		'
		Me.StudentTableAdapter1.ClearBeforeFill = True
		'
		'AdminTableAdapter1
		'
		Me.AdminTableAdapter1.ClearBeforeFill = True
		'
		'FacultyTableAdapter1
		'
		Me.FacultyTableAdapter1.ClearBeforeFill = True
		'
		'StudentToolTip
		'
		Me.StudentToolTip.AutomaticDelay = 100
		'
		'AdminToolTip
		'
		Me.AdminToolTip.AutomaticDelay = 100
		'
		'TableAdapterManager1
		'
		Me.TableAdapterManager1.ADMINTableAdapter = Nothing
		Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
		Me.TableAdapterManager1.Connection = Nothing
		Me.TableAdapterManager1.COURSETableAdapter = Nothing
		Me.TableAdapterManager1.DISCIPLINETableAdapter = Nothing
		Me.TableAdapterManager1.FACULTYTableAdapter = Nothing
		Me.TableAdapterManager1.MODULE_REGISTRATIONTableAdapter = Nothing
		Me.TableAdapterManager1.MODULETableAdapter = Nothing
		Me.TableAdapterManager1.STUDENTTableAdapter = Nothing
		Me.TableAdapterManager1.UpdateOrder = StudentManagementSystem.SMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
		'
		'BSStudent
		'
		Me.BSStudent.DataMember = "STUDENT"
		Me.BSStudent.DataSource = Me.SmsDataSet1
		'
		'BSAdmin
		'
		Me.BSAdmin.DataMember = "ADMIN"
		Me.BSAdmin.DataSource = Me.SmsDataSet1
		'
		'frmLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(540, 405)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.pnlLogin)
		Me.Controls.Add(Me.pnlSelect)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmLogin"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		Me.pnlSelect.ResumeLayout(False)
		Me.pnlSelect.PerformLayout()
		CType(Me.pbxAdmin, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbxStudent, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlLogin.ResumeLayout(False)
		Me.pnlLogin.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		CType(Me.SmsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BSStudent, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BSAdmin, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents pbxStudent As PictureBox
    Friend WithEvents pbxAdmin As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlSelect As Panel
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtLoginUsername As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNewStudent As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblForgotPassword As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents tmrDateTime As Timer
    Friend WithEvents SmsDataSet1 As SMSDataSet
    Friend WithEvents StudentTableAdapter1 As SMSDataSetTableAdapters.STUDENTTableAdapter
    Friend WithEvents TableAdapterManager1 As SMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdminTableAdapter1 As SMSDataSetTableAdapters.ADMINTableAdapter
    Friend WithEvents BSStudent As BindingSource
    Friend WithEvents BSAdmin As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents FacultyTableAdapter1 As SMSDataSetTableAdapters.FACULTYTableAdapter
	Friend WithEvents btnAbout As Button
	Friend WithEvents StudentToolTip As ToolTip
	Friend WithEvents AdminToolTip As ToolTip
End Class
