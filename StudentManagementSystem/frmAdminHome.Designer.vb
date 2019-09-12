<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminHome
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminHome))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.pbDetails = New System.Windows.Forms.PictureBox()
		Me.Panel1.SuspendLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbDetails, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Controls.Add(Me.PictureBox2)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.PictureBox1)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.pbDetails)
		Me.Panel1.Location = New System.Drawing.Point(12, 12)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(620, 346)
		Me.Panel1.TabIndex = 0
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(442, 226)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(114, 13)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "Change a students reg"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(231, 226)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(145, 13)
		Me.Label2.TabIndex = 8
		Me.Label2.Text = "Marks (Capture, view reports)"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(29, 226)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(185, 13)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Details (change own. add new admin)"
		'
		'PictureBox2
		'
		Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox2.Location = New System.Drawing.Point(429, 99)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(150, 120)
		Me.PictureBox2.TabIndex = 9
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox1.Location = New System.Drawing.Point(234, 99)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(150, 120)
		Me.PictureBox1.TabIndex = 7
		Me.PictureBox1.TabStop = False
		'
		'pbDetails
		'
		Me.pbDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pbDetails.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pbDetails.Location = New System.Drawing.Point(37, 99)
		Me.pbDetails.Name = "pbDetails"
		Me.pbDetails.Size = New System.Drawing.Size(150, 120)
		Me.pbDetails.TabIndex = 5
		Me.pbDetails.TabStop = False
		'
		'frmAdminHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(644, 401)
		Me.Controls.Add(Me.Panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmAdminHome"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Home | Admin"
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbDetails, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents Label1 As Label
	Friend WithEvents pbDetails As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents PictureBox1 As PictureBox
End Class
