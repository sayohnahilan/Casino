<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.Bet = New System.Windows.Forms.NumericUpDown()
        Me.Done = New System.Windows.Forms.Button()
        Me.Infotext = New System.Windows.Forms.Label()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.WelcomeLabel.Location = New System.Drawing.Point(19, 55)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(520, 55)
        Me.WelcomeLabel.TabIndex = 27
        Me.WelcomeLabel.Text = "Welcome to the Casino"
        '
        'Bet
        '
        Me.Bet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bet.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.Bet.Location = New System.Drawing.Point(159, 305)
        Me.Bet.Maximum = New Decimal(New Integer() {500000, 0, 0, 0})
        Me.Bet.Minimum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.Bet.Name = "Bet"
        Me.Bet.Size = New System.Drawing.Size(108, 31)
        Me.Bet.TabIndex = 29
        Me.Bet.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Done
        '
        Me.Done.BackColor = System.Drawing.Color.Transparent
        Me.Done.Location = New System.Drawing.Point(273, 305)
        Me.Done.Name = "Done"
        Me.Done.Size = New System.Drawing.Size(135, 31)
        Me.Done.TabIndex = 33
        Me.Done.Text = "Enter Casino"
        Me.Done.UseVisualStyleBackColor = False
        '
        'Infotext
        '
        Me.Infotext.AutoSize = True
        Me.Infotext.BackColor = System.Drawing.Color.Transparent
        Me.Infotext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Infotext.ForeColor = System.Drawing.Color.White
        Me.Infotext.Location = New System.Drawing.Point(96, 218)
        Me.Infotext.Name = "Infotext"
        Me.Infotext.Size = New System.Drawing.Size(361, 50)
        Me.Infotext.TabIndex = 40
        Me.Infotext.Text = "Please select how much money you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "would like to convert to chips"
        Me.Infotext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.Infotext)
        Me.Controls.Add(Me.Done)
        Me.Controls.Add(Me.Bet)
        Me.Controls.Add(Me.WelcomeLabel)
        Me.Controls.Add(Me.Background)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(574, 444)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(574, 444)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents WelcomeLabel As System.Windows.Forms.Label
    Friend WithEvents Bet As System.Windows.Forms.NumericUpDown
    Friend WithEvents Done As System.Windows.Forms.Button
    Friend WithEvents Infotext As System.Windows.Forms.Label
End Class
