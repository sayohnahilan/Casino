<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BStartup
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
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.Play = New System.Windows.Forms.Button()
        Me.Instruc = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.Background = New System.Windows.Forms.PictureBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.WelcomeLabel.Location = New System.Drawing.Point(33, 73)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(492, 55)
        Me.WelcomeLabel.TabIndex = 25
        Me.WelcomeLabel.Text = "Welcome to Blackjack"
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.Transparent
        Me.Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play.Location = New System.Drawing.Point(217, 180)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(124, 53)
        Me.Play.TabIndex = 26
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = False
        '
        'Instruc
        '
        Me.Instruc.BackColor = System.Drawing.Color.Transparent
        Me.Instruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instruc.Location = New System.Drawing.Point(176, 239)
        Me.Instruc.Name = "Instruc"
        Me.Instruc.Size = New System.Drawing.Size(207, 53)
        Me.Instruc.TabIndex = 32
        Me.Instruc.Text = "Instructions"
        Me.Instruc.UseVisualStyleBackColor = False
        '
        'Quit
        '
        Me.Quit.BackColor = System.Drawing.Color.Transparent
        Me.Quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit.Location = New System.Drawing.Point(217, 298)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(124, 53)
        Me.Quit.TabIndex = 34
        Me.Quit.Text = "Home"
        Me.Quit.UseVisualStyleBackColor = False
        '
        'Background
        '
        Me.Background.BackgroundImage = Global.Casino.My.Resources.Resources.Casino_Background
        Me.Background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(558, 405)
        Me.Background.TabIndex = 22
        Me.Background.TabStop = False
        '
        'BStartup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.Instruc)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(574, 444)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(574, 444)
        Me.Name = "BStartup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BlackJack"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents Play As System.Windows.Forms.Button
    Friend WithEvents Instruc As System.Windows.Forms.Button
    Friend WithEvents Quit As System.Windows.Forms.Button
End Class
