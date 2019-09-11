<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.pbxStudent = New System.Windows.Forms.PictureBox()
		Me.pbxAdmin = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pnlSelect = New System.Windows.Forms.Panel()
		Me.pnlLogin = New System.Windows.Forms.Panel()
		Me.lblNewStudent = New System.Windows.Forms.Label()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblUsername = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.lblDateTime = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		CType(Me.pbxStudent, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbxAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlSelect.SuspendLayout()
		Me.pnlLogin.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.SuspendLayout()
		'
		'pbxStudent
		'
		Me.pbxStudent.Location = New System.Drawing.Point(38, 62)
		Me.pbxStudent.Name = "pbxStudent"
		Me.pbxStudent.Size = New System.Drawing.Size(138, 118)
		Me.pbxStudent.TabIndex = 0
		Me.pbxStudent.TabStop = False
		'
		'pbxAdmin
		'
		Me.pbxAdmin.Location = New System.Drawing.Point(296, 62)
		Me.pbxAdmin.Name = "pbxAdmin"
		Me.pbxAdmin.Size = New System.Drawing.Size(138, 118)
		Me.pbxAdmin.TabIndex = 1
		Me.pbxAdmin.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(232, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(48, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "I am a(n)"
		'
		'pnlSelect
		'
		Me.pnlSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnlSelect.Controls.Add(Me.pbxAdmin)
		Me.pnlSelect.Controls.Add(Me.Label1)
		Me.pnlSelect.Controls.Add(Me.pbxStudent)
		Me.pnlSelect.Location = New System.Drawing.Point(12, 12)
		Me.pnlSelect.Name = "pnlSelect"
		Me.pnlSelect.Size = New System.Drawing.Size(508, 217)
		Me.pnlSelect.TabIndex = 0
		'
		'pnlLogin
		'
		Me.pnlLogin.Controls.Add(Me.Label3)
		Me.pnlLogin.Controls.Add(Me.lblNewStudent)
		Me.pnlLogin.Controls.Add(Me.btnLogin)
		Me.pnlLogin.Controls.Add(Me.TextBox1)
		Me.pnlLogin.Controls.Add(Me.MaskedTextBox1)
		Me.pnlLogin.Controls.Add(Me.Label2)
		Me.pnlLogin.Controls.Add(Me.lblUsername)
		Me.pnlLogin.Location = New System.Drawing.Point(12, 252)
		Me.pnlLogin.Name = "pnlLogin"
		Me.pnlLogin.Size = New System.Drawing.Size(508, 138)
		Me.pnlLogin.TabIndex = 4
		'
		'lblNewStudent
		'
		Me.lblNewStudent.AutoSize = True
		Me.lblNewStudent.Cursor = System.Windows.Forms.Cursors.Hand
		Me.lblNewStudent.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.lblNewStudent.Location = New System.Drawing.Point(372, 107)
		Me.lblNewStudent.Name = "lblNewStudent"
		Me.lblNewStudent.Size = New System.Drawing.Size(97, 13)
		Me.lblNewStudent.TabIndex = 5
		Me.lblNewStudent.Text = "I am a new student"
		'
		'btnLogin
		'
		Me.btnLogin.Location = New System.Drawing.Point(331, 31)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(138, 61)
		Me.btnLogin.TabIndex = 4
		Me.btnLogin.Text = "Login"
		Me.btnLogin.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(135, 72)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 3
		Me.TextBox1.UseSystemPasswordChar = True
		'
		'MaskedTextBox1
		'
		Me.MaskedTextBox1.Location = New System.Drawing.Point(135, 33)
		Me.MaskedTextBox1.Mask = "0000000000"
		Me.MaskedTextBox1.Name = "MaskedTextBox1"
		Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
		Me.MaskedTextBox1.TabIndex = 2
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
		Me.Panel3.Controls.Add(Me.btnExit)
		Me.Panel3.Location = New System.Drawing.Point(12, 406)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(508, 42)
		Me.Panel3.TabIndex = 5
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(421, 10)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 1
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'lblDateTime
		'
		Me.lblDateTime.AutoSize = True
		Me.lblDateTime.Location = New System.Drawing.Point(73, -4)
		Me.lblDateTime.Name = "lblDateTime"
		Me.lblDateTime.Size = New System.Drawing.Size(39, 13)
		Me.lblDateTime.TabIndex = 0
		Me.lblDateTime.Text = "Label3"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
		Me.Label3.Location = New System.Drawing.Point(138, 107)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(104, 13)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "I forgot my password"
		'
		'frmLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(540, 449)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.lblDateTime)
		Me.Controls.Add(Me.pnlLogin)
		Me.Controls.Add(Me.pnlSelect)
		Me.Name = "frmLogin"
		Me.Text = "Login"
		CType(Me.pbxStudent, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbxAdmin, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlSelect.ResumeLayout(False)
		Me.pnlSelect.PerformLayout()
		Me.pnlLogin.ResumeLayout(False)
		Me.pnlLogin.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pbxStudent As PictureBox
    Friend WithEvents pbxAdmin As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlSelect As Panel
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNewStudent As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDateTime As Label
	Friend WithEvents Label3 As Label
End Class
