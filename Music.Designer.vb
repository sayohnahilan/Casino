<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Music
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
        Me.Rock = New System.Windows.Forms.Button()
        Me.Casino = New System.Windows.Forms.Button()
        Me.Jazz = New System.Windows.Forms.Button()
        Me.InstructionHeader = New System.Windows.Forms.Label()
        Me.Hom = New System.Windows.Forms.Button()
        Me.Pop = New System.Windows.Forms.Button()
        Me.Classical = New System.Windows.Forms.Button()
        Me.Reggae = New System.Windows.Forms.Button()
        Me.stop7 = New System.Windows.Forms.Button()
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
        Me.Background.TabIndex = 24
        Me.Background.TabStop = False
        '
        'Rock
        '
        Me.Rock.BackColor = System.Drawing.Color.Transparent
        Me.Rock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rock.Location = New System.Drawing.Point(346, 223)
        Me.Rock.Name = "Rock"
        Me.Rock.Size = New System.Drawing.Size(89, 46)
        Me.Rock.TabIndex = 34
        Me.Rock.Text = "Rock"
        Me.Rock.UseVisualStyleBackColor = False
        '
        'Casino
        '
        Me.Casino.BackColor = System.Drawing.Color.Transparent
        Me.Casino.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Casino.Location = New System.Drawing.Point(138, 171)
        Me.Casino.Name = "Casino"
        Me.Casino.Size = New System.Drawing.Size(89, 46)
        Me.Casino.TabIndex = 33
        Me.Casino.Text = "Casino"
        Me.Casino.UseVisualStyleBackColor = False
        '
        'Jazz
        '
        Me.Jazz.BackColor = System.Drawing.Color.Transparent
        Me.Jazz.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jazz.Location = New System.Drawing.Point(138, 223)
        Me.Jazz.Name = "Jazz"
        Me.Jazz.Size = New System.Drawing.Size(89, 46)
        Me.Jazz.TabIndex = 32
        Me.Jazz.Text = "Jazz"
        Me.Jazz.UseVisualStyleBackColor = False
        '
        'InstructionHeader
        '
        Me.InstructionHeader.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InstructionHeader.AutoSize = True
        Me.InstructionHeader.BackColor = System.Drawing.Color.Transparent
        Me.InstructionHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionHeader.ForeColor = System.Drawing.Color.White
        Me.InstructionHeader.Location = New System.Drawing.Point(33, 36)
        Me.InstructionHeader.Name = "InstructionHeader"
        Me.InstructionHeader.Size = New System.Drawing.Size(247, 39)
        Me.InstructionHeader.TabIndex = 35
        Me.InstructionHeader.Text = "Choose Music:"
        '
        'Hom
        '
        Me.Hom.BackColor = System.Drawing.Color.Transparent
        Me.Hom.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hom.Location = New System.Drawing.Point(398, 37)
        Me.Hom.Name = "Hom"
        Me.Hom.Size = New System.Drawing.Size(93, 44)
        Me.Hom.TabIndex = 37
        Me.Hom.Text = "Home"
        Me.Hom.UseVisualStyleBackColor = False
        '
        'Pop
        '
        Me.Pop.BackColor = System.Drawing.Color.Transparent
        Me.Pop.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pop.Location = New System.Drawing.Point(346, 171)
        Me.Pop.Name = "Pop"
        Me.Pop.Size = New System.Drawing.Size(89, 46)
        Me.Pop.TabIndex = 38
        Me.Pop.Text = "Pop"
        Me.Pop.UseVisualStyleBackColor = False
        '
        'Classical
        '
        Me.Classical.BackColor = System.Drawing.Color.Transparent
        Me.Classical.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Classical.Location = New System.Drawing.Point(233, 171)
        Me.Classical.Name = "Classical"
        Me.Classical.Size = New System.Drawing.Size(107, 46)
        Me.Classical.TabIndex = 39
        Me.Classical.Text = "Classical"
        Me.Classical.UseVisualStyleBackColor = False
        '
        'Reggae
        '
        Me.Reggae.BackColor = System.Drawing.Color.Transparent
        Me.Reggae.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reggae.Location = New System.Drawing.Point(233, 223)
        Me.Reggae.Name = "Reggae"
        Me.Reggae.Size = New System.Drawing.Size(107, 46)
        Me.Reggae.TabIndex = 40
        Me.Reggae.Text = "Reggae"
        Me.Reggae.UseVisualStyleBackColor = False
        '
        'stop7
        '
        Me.stop7.BackColor = System.Drawing.Color.Transparent
        Me.stop7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stop7.Location = New System.Drawing.Point(138, 275)
        Me.stop7.Name = "stop7"
        Me.stop7.Size = New System.Drawing.Size(297, 46)
        Me.stop7.TabIndex = 41
        Me.stop7.Text = "Stop Music"
        Me.stop7.UseVisualStyleBackColor = False
        '
        'Music
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.stop7)
        Me.Controls.Add(Me.Reggae)
        Me.Controls.Add(Me.Classical)
        Me.Controls.Add(Me.Pop)
        Me.Controls.Add(Me.Hom)
        Me.Controls.Add(Me.InstructionHeader)
        Me.Controls.Add(Me.Rock)
        Me.Controls.Add(Me.Casino)
        Me.Controls.Add(Me.Jazz)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(574, 444)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(574, 444)
        Me.Name = "Music"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Music"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents Rock As System.Windows.Forms.Button
    Friend WithEvents Casino As System.Windows.Forms.Button
    Friend WithEvents Jazz As System.Windows.Forms.Button
    Friend WithEvents InstructionHeader As System.Windows.Forms.Label
    Friend WithEvents Hom As System.Windows.Forms.Button
    Friend WithEvents Pop As System.Windows.Forms.Button
    Friend WithEvents Classical As System.Windows.Forms.Button
    Friend WithEvents Reggae As System.Windows.Forms.Button
    Friend WithEvents stop7 As System.Windows.Forms.Button
End Class
