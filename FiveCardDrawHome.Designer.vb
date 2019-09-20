<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiveCardDrawHome
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
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.Play = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Background
        '
        Me.Background.BackgroundImage = Global.Casino.My.Resources.Resources.Casino_Background
        Me.Background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(558, 405)
        Me.Background.TabIndex = 23
        Me.Background.TabStop = False
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeLabel.ForeColor = System.Drawing.Color.White
        Me.WelcomeLabel.Location = New System.Drawing.Point(106, 29)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(358, 110)
        Me.WelcomeLabel.TabIndex = 26
        Me.WelcomeLabel.Text = "Welcome to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Five Card Draw"
        Me.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.Transparent
        Me.Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play.Location = New System.Drawing.Point(217, 176)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(124, 53)
        Me.Play.TabIndex = 27
        Me.Play.Text = "Solo"
        Me.Play.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(217, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 53)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "CPU"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(217, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 53)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Home"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FiveCardDrawHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.Background)
        Me.MaximumSize = New System.Drawing.Size(574, 444)
        Me.MinimumSize = New System.Drawing.Size(574, 444)
        Me.Name = "FiveCardDrawHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Five Card Draw Home"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents Play As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
