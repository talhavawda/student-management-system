<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentHome))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbxResults = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbxReg = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbxDetails = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxReg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.pbxResults)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.pbxReg)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbxDetails)
        Me.Panel1.Location = New System.Drawing.Point(22, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 340)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(450, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 37)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Results"
        '
        'pbxResults
        '
        Me.pbxResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxResults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxResults.Image = Global.StudentManagementSystem.My.Resources.Resources.RESULTS
        Me.pbxResults.Location = New System.Drawing.Point(425, 91)
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
        Me.Label2.Location = New System.Drawing.Point(222, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Registration"
        '
        'pbxReg
        '
        Me.pbxReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxReg.Image = Global.StudentManagementSystem.My.Resources.Resources.Reports
        Me.pbxReg.Location = New System.Drawing.Point(229, 91)
        Me.pbxReg.Name = "pbxReg"
        Me.pbxReg.Size = New System.Drawing.Size(150, 120)
        Me.pbxReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxReg.TabIndex = 5
        Me.pbxReg.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Edit Details"
        '
        'pbxDetails
        '
        Me.pbxDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbxDetails.Image = Global.StudentManagementSystem.My.Resources.Resources.EDIT
        Me.pbxDetails.Location = New System.Drawing.Point(30, 91)
        Me.pbxDetails.Name = "pbxDetails"
        Me.pbxDetails.Size = New System.Drawing.Size(150, 120)
        Me.pbxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxDetails.TabIndex = 3
        Me.pbxDetails.TabStop = False
        '
        'frmStudentHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 401)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStudentHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home | Student"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxReg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbxDetails As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pbxResults As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pbxReg As PictureBox
End Class
