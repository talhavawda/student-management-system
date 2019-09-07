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
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.Button3)
		Me.Panel1.Controls.Add(Me.Button2)
		Me.Panel1.Controls.Add(Me.Button1)
		Me.Panel1.Location = New System.Drawing.Point(12, 12)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(620, 346)
		Me.Panel1.TabIndex = 0
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(32, 104)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(150, 120)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Details (change own. add new admin)"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(226, 104)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(150, 120)
		Me.Button2.TabIndex = 1
		Me.Button2.Text = "Marks (Capture, view reports)"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(419, 104)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(150, 120)
		Me.Button3.TabIndex = 2
		Me.Button3.Text = "Change a students reg"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'frmAdminHome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(644, 401)
		Me.Controls.Add(Me.Panel1)
		Me.Name = "frmAdminHome"
		Me.Text = "Home | Admin"
		Me.Panel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Panel1 As Panel
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
End Class
