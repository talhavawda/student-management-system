﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentHome
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentHome))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.pbxResults = New System.Windows.Forms.PictureBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.pbxRegestration = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.pbxDetails = New System.Windows.Forms.PictureBox()
		Me.SmsDataSet1 = New StudentManagementSystem.SMSDataSet()
		Me.StudentTableAdapter1 = New StudentManagementSystem.SMSDataSetTableAdapters.STUDENTTableAdapter()
		Me.BSStudent = New System.Windows.Forms.BindingSource(Me.components)
		Me.pnlInfo = New System.Windows.Forms.Panel()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.lblDateTime = New System.Windows.Forms.Label()
		Me.tmrTimeStudent = New System.Windows.Forms.Timer(Me.components)
		Me.lblStudentName = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		CType(Me.pbxResults, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbxRegestration, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbxDetails, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SmsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BSStudent, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.pnlInfo.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.pbxResults)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.pbxRegestration)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.pbxDetails)
		Me.Panel1.Location = New System.Drawing.Point(7, 3)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(633, 349)
		Me.Panel1.TabIndex = 0
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(473, 221)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(99, 37)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Results"
		'
		'pbxResults
		'
		Me.pbxResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pbxResults.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pbxResults.Image = CType(resources.GetObject("pbxResults.Image"), System.Drawing.Image)
		Me.pbxResults.Location = New System.Drawing.Point(446, 91)
		Me.pbxResults.Name = "pbxResults"
		Me.pbxResults.Size = New System.Drawing.Size(150, 120)
		Me.pbxResults.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbxResults.TabIndex = 7
		Me.pbxResults.TabStop = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(237, 221)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(159, 37)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Registration"
		'
		'pbxRegestration
		'
		Me.pbxRegestration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pbxRegestration.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pbxRegestration.Image = CType(resources.GetObject("pbxRegestration.Image"), System.Drawing.Image)
		Me.pbxRegestration.Location = New System.Drawing.Point(241, 91)
		Me.pbxRegestration.Name = "pbxRegestration"
		Me.pbxRegestration.Size = New System.Drawing.Size(150, 120)
		Me.pbxRegestration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbxRegestration.TabIndex = 5
		Me.pbxRegestration.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(60, 221)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(98, 37)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Details"
		'
		'pbxDetails
		'
		Me.pbxDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pbxDetails.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pbxDetails.Image = CType(resources.GetObject("pbxDetails.Image"), System.Drawing.Image)
		Me.pbxDetails.Location = New System.Drawing.Point(33, 91)
		Me.pbxDetails.Name = "pbxDetails"
		Me.pbxDetails.Size = New System.Drawing.Size(150, 120)
		Me.pbxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pbxDetails.TabIndex = 3
		Me.pbxDetails.TabStop = False
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
		'BSStudent
		'
		Me.BSStudent.DataMember = "STUDENT"
		Me.BSStudent.DataSource = Me.SmsDataSet1
		'
		'pnlInfo
		'
		Me.pnlInfo.Controls.Add(Me.lblStudentName)
		Me.pnlInfo.Controls.Add(Me.btnExit)
		Me.pnlInfo.Controls.Add(Me.lblDateTime)
		Me.pnlInfo.Location = New System.Drawing.Point(7, 358)
		Me.pnlInfo.Name = "pnlInfo"
		Me.pnlInfo.Size = New System.Drawing.Size(633, 42)
		Me.pnlInfo.TabIndex = 6
		'
		'btnExit
		'
		Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnExit.Location = New System.Drawing.Point(550, 8)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 1
		Me.btnExit.Text = "End Session"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'lblDateTime
		'
		Me.lblDateTime.AutoSize = True
		Me.lblDateTime.Location = New System.Drawing.Point(14, 13)
		Me.lblDateTime.Name = "lblDateTime"
		Me.lblDateTime.Size = New System.Drawing.Size(89, 13)
		Me.lblDateTime.TabIndex = 0
		Me.lblDateTime.Text = "<Date and Time>"
		'
		'tmrTimeStudent
		'
		Me.tmrTimeStudent.Enabled = True
		'
		'lblStudentName
		'
		Me.lblStudentName.AutoSize = True
		Me.lblStudentName.Location = New System.Drawing.Point(268, 13)
		Me.lblStudentName.Name = "lblStudentName"
		Me.lblStudentName.Size = New System.Drawing.Size(84, 13)
		Me.lblStudentName.TabIndex = 2
		Me.lblStudentName.Text = "<StudentName>"
		'
		'frmStudentHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(644, 401)
		Me.Controls.Add(Me.pnlInfo)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmStudentHome"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Home | Student"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.pbxResults, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbxRegestration, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbxDetails, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SmsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BSStudent, System.ComponentModel.ISupportInitialize).EndInit()
		Me.pnlInfo.ResumeLayout(False)
		Me.pnlInfo.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
    Friend WithEvents pbxDetails As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pbxResults As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pbxRegestration As PictureBox
	Friend WithEvents SmsDataSet1 As SMSDataSet
	Friend WithEvents StudentTableAdapter1 As SMSDataSetTableAdapters.STUDENTTableAdapter
	Friend WithEvents BSStudent As BindingSource
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDateTime As Label
    Friend WithEvents tmrTimeStudent As Timer
	Friend WithEvents lblStudentName As Label
End Class
