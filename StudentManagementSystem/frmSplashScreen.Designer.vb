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
        Me.lblProgressPercent = New System.Windows.Forms.Label()
        Me.prbSplash = New System.Windows.Forms.ProgressBar()
        Me.tmrSplash = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblProgressPercent
        '
        Me.lblProgressPercent.AutoSize = True
        Me.lblProgressPercent.Location = New System.Drawing.Point(247, 260)
        Me.lblProgressPercent.Name = "lblProgressPercent"
        Me.lblProgressPercent.Size = New System.Drawing.Size(0, 13)
        Me.lblProgressPercent.TabIndex = 3
        '
        'prbSplash
        '
        Me.prbSplash.BackColor = System.Drawing.SystemColors.Control
        Me.prbSplash.Location = New System.Drawing.Point(144, 260)
        Me.prbSplash.Name = "prbSplash"
        Me.prbSplash.Size = New System.Drawing.Size(259, 23)
        Me.prbSplash.Step = 1
        Me.prbSplash.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prbSplash.TabIndex = 4
        '
        'tmrSplash
        '
        Me.tmrSplash.Interval = 1
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(541, 323)
        Me.Controls.Add(Me.prbSplash)
        Me.Controls.Add(Me.lblProgressPercent)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProgressPercent As Label
	Friend WithEvents prbSplash As ProgressBar
	Friend WithEvents tmrSplash As Timer
End Class
