<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSplashScreen
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
		Me.lblLoadingBar = New System.Windows.Forms.Label()
		Me.tmrLoadingLabel = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'lblLoadingBar
		'
		Me.lblLoadingBar.AutoSize = True
		Me.lblLoadingBar.BackColor = System.Drawing.Color.Transparent
		Me.lblLoadingBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLoadingBar.ForeColor = System.Drawing.Color.Aqua
		Me.lblLoadingBar.Location = New System.Drawing.Point(152, 337)
		Me.lblLoadingBar.Name = "lblLoadingBar"
		Me.lblLoadingBar.Size = New System.Drawing.Size(9, 13)
		Me.lblLoadingBar.TabIndex = 5
		Me.lblLoadingBar.Text = "|"
		'
		'tmrLoadingLabel
		'
		Me.tmrLoadingLabel.Interval = 10
		'
		'frmSplashScreen
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDark
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(578, 412)
		Me.Controls.Add(Me.lblLoadingBar)
		Me.Cursor = System.Windows.Forms.Cursors.AppStarting
		Me.DoubleBuffered = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmSplashScreen"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "StudentManagementSystem"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblLoadingBar As Label
	Friend WithEvents tmrLoadingLabel As Timer
End Class
