<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.Blackjack = New System.Windows.Forms.Button()
        Me.Msc = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.Slot = New System.Windows.Forms.Button()
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.Abt = New System.Windows.Forms.Button()
        Me.Support = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.WelcomeLabel.Location = New System.Drawing.Point(21, 13)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(520, 55)
        Me.WelcomeLabel.TabIndex = 26
        Me.WelcomeLabel.Text = "Welcome to the Casino"
        '
        'Blackjack
        '
        Me.Blackjack.BackColor = System.Drawing.Color.Transparent
        Me.Blackjack.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blackjack.Location = New System.Drawing.Point(58, 122)
        Me.Blackjack.Name = "Blackjack"
        Me.Blackjack.Size = New System.Drawing.Size(229, 53)
        Me.Blackjack.TabIndex = 2735
        Me.Blackjack.Text = "Blackjack"
        Me.Blackjack.UseVisualStyleBackColor = False
        '
        'Msc
        '
        Me.Msc.BackColor = System.Drawing.Color.Transparent
        Me.Msc.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Msc.Location = New System.Drawing.Point(211, 270)
        Me.Msc.Name = "Msc"
        Me.Msc.Size = New System.Drawing.Size(149, 53)
        Me.Msc.TabIndex = 35
        Me.Msc.Text = "Music"
        Me.Msc.UseVisualStyleBackColor = False
        '
        'Quit
        '
        Me.Quit.BackColor = System.Drawing.Color.Transparent
        Me.Quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit.Location = New System.Drawing.Point(58, 329)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(454, 53)
        Me.Quit.TabIndex = 35
        Me.Quit.Text = "Leave Casino"
        Me.Quit.UseVisualStyleBackColor = False
        '
        'Slot
        '
        Me.Slot.BackColor = System.Drawing.Color.Transparent
        Me.Slot.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Slot.Location = New System.Drawing.Point(293, 122)
        Me.Slot.Name = "Slot"
        Me.Slot.Size = New System.Drawing.Size(219, 53)
        Me.Slot.TabIndex = 35
        Me.Slot.Text = "Slots"
        Me.Slot.UseVisualStyleBackColor = False
        '
        'Time
        '
        Me.Time.Enabled = True
        Me.Time.Interval = 60000
        '
        'Abt
        '
        Me.Abt.BackColor = System.Drawing.Color.Transparent
        Me.Abt.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abt.Location = New System.Drawing.Point(363, 270)
        Me.Abt.Name = "Abt"
        Me.Abt.Size = New System.Drawing.Size(149, 53)
        Me.Abt.TabIndex = 35
        Me.Abt.Text = "About"
        Me.Abt.UseVisualStyleBackColor = False
        '
        'Support
        '
        Me.Support.BackColor = System.Drawing.Color.Transparent
        Me.Support.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Support.Location = New System.Drawing.Point(58, 270)
        Me.Support.Name = "Support"
        Me.Support.Size = New System.Drawing.Size(149, 53)
        Me.Support.TabIndex = 2736
        Me.Support.Text = "Support"
        Me.Support.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(58, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(454, 53)
        Me.Button1.TabIndex = 2737
        Me.Button1.Text = "Five Card Draw"
        Me.Button1.UseVisualStyleBackColor = False
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
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Support)
        Me.Controls.Add(Me.Abt)
        Me.Controls.Add(Me.Slot)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.Msc)
        Me.Controls.Add(Me.Blackjack)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.MaximumSize = New System.Drawing.Size(574, 444)
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(574, 444)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.Background,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents Blackjack As System.Windows.Forms.Button
    Friend WithEvents Msc As System.Windows.Forms.Button
    Friend WithEvents Quit As System.Windows.Forms.Button
    Friend WithEvents Slot As System.Windows.Forms.Button
    Friend WithEvents Time As System.Windows.Forms.Timer
    Friend WithEvents Abt As System.Windows.Forms.Button
    Friend WithEvents Support As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
