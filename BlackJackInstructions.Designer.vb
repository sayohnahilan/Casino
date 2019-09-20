<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackJackInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlackJackInstructions))
        Me.InstructionHeader = New System.Windows.Forms.Label()
        Me.Home = New System.Windows.Forms.Button()
        Me.Play = New System.Windows.Forms.Button()
        Me.Instruc = New System.Windows.Forms.Label()
        Me.Background = New System.Windows.Forms.PictureBox()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.InstructionHeader.Size = New System.Drawing.Size(206, 39)
        Me.InstructionHeader.TabIndex = 26
        Me.InstructionHeader.Text = "Instructions:"
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.Transparent
        Me.Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.Location = New System.Drawing.Point(400, 71)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(87, 44)
        Me.Home.TabIndex = 34
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = False
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.Transparent
        Me.Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play.Location = New System.Drawing.Point(407, 22)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(74, 44)
        Me.Play.TabIndex = 33
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = False
        '
        'Instruc
        '
        Me.Instruc.AutoSize = True
        Me.Instruc.BackColor = System.Drawing.Color.Transparent
        Me.Instruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instruc.ForeColor = System.Drawing.Color.White
        Me.Instruc.Location = New System.Drawing.Point(21, 162)
        Me.Instruc.Name = "Instruc"
        Me.Instruc.Size = New System.Drawing.Size(517, 150)
        Me.Instruc.TabIndex = 35
        Me.Instruc.Text = resources.GetString("Instruc.Text")
        Me.Instruc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'BlackJackInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.Instruc)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.InstructionHeader)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(574, 444)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(574, 444)
        Me.Name = "BlackJackInstructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructions"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents InstructionHeader As System.Windows.Forms.Label
    Friend WithEvents Home As System.Windows.Forms.Button
    Friend WithEvents Play As System.Windows.Forms.Button
    Friend WithEvents Instruc As System.Windows.Forms.Label
End Class
