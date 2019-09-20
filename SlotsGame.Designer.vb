<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlotsGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SlotsGame))
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.Card1 = New System.Windows.Forms.PictureBox()
        Me.Card2 = New System.Windows.Forms.PictureBox()
        Me.Spin = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.PlayerMoneyLabel = New System.Windows.Forms.Label()
        Me.PlayerMoney = New System.Windows.Forms.Label()
        Me.Card = New System.Windows.Forms.ImageList(Me.components)
        Me.Winnings = New System.Windows.Forms.Label()
        Me.WinInfo = New System.Windows.Forms.Label()
        Me.CardSpin = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Card1
        '
        Me.Card1.BackColor = System.Drawing.Color.Transparent
        Me.Card1.Location = New System.Drawing.Point(174, 128)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(102, 127)
        Me.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card1.TabIndex = 25
        Me.Card1.TabStop = False
        '
        'Card2
        '
        Me.Card2.BackColor = System.Drawing.Color.Transparent
        Me.Card2.Location = New System.Drawing.Point(282, 128)
        Me.Card2.Name = "Card2"
        Me.Card2.Size = New System.Drawing.Size(102, 127)
        Me.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card2.TabIndex = 26
        Me.Card2.TabStop = False
        '
        'Spin
        '
        Me.Spin.BackColor = System.Drawing.Color.Transparent
        Me.Spin.Location = New System.Drawing.Point(424, 151)
        Me.Spin.Name = "Spin"
        Me.Spin.Size = New System.Drawing.Size(68, 34)
        Me.Spin.TabIndex = 27
        Me.Spin.Text = "Spin"
        Me.Spin.UseVisualStyleBackColor = False
        '
        'Quit
        '
        Me.Quit.BackColor = System.Drawing.Color.Transparent
        Me.Quit.Location = New System.Drawing.Point(424, 191)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(68, 34)
        Me.Quit.TabIndex = 28
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = False
        '
        'PlayerMoneyLabel
        '
        Me.PlayerMoneyLabel.AutoSize = True
        Me.PlayerMoneyLabel.BackColor = System.Drawing.Color.Transparent
        Me.PlayerMoneyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerMoneyLabel.ForeColor = System.Drawing.Color.White
        Me.PlayerMoneyLabel.Location = New System.Drawing.Point(13, 22)
        Me.PlayerMoneyLabel.Name = "PlayerMoneyLabel"
        Me.PlayerMoneyLabel.Size = New System.Drawing.Size(165, 29)
        Me.PlayerMoneyLabel.TabIndex = 29
        Me.PlayerMoneyLabel.Text = "Player Money:"
        '
        'PlayerMoney
        '
        Me.PlayerMoney.AutoSize = True
        Me.PlayerMoney.BackColor = System.Drawing.Color.Transparent
        Me.PlayerMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerMoney.ForeColor = System.Drawing.Color.White
        Me.PlayerMoney.Location = New System.Drawing.Point(177, 22)
        Me.PlayerMoney.Name = "PlayerMoney"
        Me.PlayerMoney.Size = New System.Drawing.Size(0, 29)
        Me.PlayerMoney.TabIndex = 30
        '
        'Card
        '
        Me.Card.ImageStream = CType(resources.GetObject("Card.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Card.TransparentColor = System.Drawing.Color.Transparent
        Me.Card.Images.SetKeyName(0, "01.png")
        Me.Card.Images.SetKeyName(1, "02.png")
        Me.Card.Images.SetKeyName(2, "03.png")
        Me.Card.Images.SetKeyName(3, "04.png")
        Me.Card.Images.SetKeyName(4, "05.png")
        Me.Card.Images.SetKeyName(5, "06.png")
        Me.Card.Images.SetKeyName(6, "07.png")
        Me.Card.Images.SetKeyName(7, "08.png")
        Me.Card.Images.SetKeyName(8, "09.png")
        Me.Card.Images.SetKeyName(9, "10.png")
        Me.Card.Images.SetKeyName(10, "11.png")
        Me.Card.Images.SetKeyName(11, "12.png")
        Me.Card.Images.SetKeyName(12, "13.png")
        Me.Card.Images.SetKeyName(13, "14.png")
        Me.Card.Images.SetKeyName(14, "15.png")
        Me.Card.Images.SetKeyName(15, "16.png")
        Me.Card.Images.SetKeyName(16, "17.png")
        Me.Card.Images.SetKeyName(17, "18.png")
        Me.Card.Images.SetKeyName(18, "19.png")
        Me.Card.Images.SetKeyName(19, "20.png")
        Me.Card.Images.SetKeyName(20, "21.png")
        Me.Card.Images.SetKeyName(21, "22.png")
        Me.Card.Images.SetKeyName(22, "23.png")
        Me.Card.Images.SetKeyName(23, "24.png")
        Me.Card.Images.SetKeyName(24, "25.png")
        Me.Card.Images.SetKeyName(25, "26.png")
        Me.Card.Images.SetKeyName(26, "27.png")
        Me.Card.Images.SetKeyName(27, "28.png")
        Me.Card.Images.SetKeyName(28, "29.png")
        Me.Card.Images.SetKeyName(29, "30.png")
        Me.Card.Images.SetKeyName(30, "31.png")
        Me.Card.Images.SetKeyName(31, "32.png")
        Me.Card.Images.SetKeyName(32, "33.png")
        Me.Card.Images.SetKeyName(33, "34.png")
        Me.Card.Images.SetKeyName(34, "35.png")
        Me.Card.Images.SetKeyName(35, "36.png")
        Me.Card.Images.SetKeyName(36, "37.png")
        Me.Card.Images.SetKeyName(37, "38.png")
        Me.Card.Images.SetKeyName(38, "39.png")
        Me.Card.Images.SetKeyName(39, "40.png")
        Me.Card.Images.SetKeyName(40, "41.png")
        Me.Card.Images.SetKeyName(41, "42.png")
        Me.Card.Images.SetKeyName(42, "43.png")
        Me.Card.Images.SetKeyName(43, "44.png")
        Me.Card.Images.SetKeyName(44, "45.png")
        Me.Card.Images.SetKeyName(45, "46.png")
        Me.Card.Images.SetKeyName(46, "47.png")
        Me.Card.Images.SetKeyName(47, "48.png")
        Me.Card.Images.SetKeyName(48, "49.png")
        Me.Card.Images.SetKeyName(49, "50.png")
        Me.Card.Images.SetKeyName(50, "51.png")
        Me.Card.Images.SetKeyName(51, "52.png")
        Me.Card.Images.SetKeyName(52, "55.jpg")
        '
        'Winnings
        '
        Me.Winnings.AutoSize = True
        Me.Winnings.BackColor = System.Drawing.Color.Transparent
        Me.Winnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Winnings.ForeColor = System.Drawing.Color.White
        Me.Winnings.Location = New System.Drawing.Point(13, 279)
        Me.Winnings.Name = "Winnings"
        Me.Winnings.Size = New System.Drawing.Size(118, 29)
        Me.Winnings.TabIndex = 31
        Me.Winnings.Text = "Winnings:"
        '
        'WinInfo
        '
        Me.WinInfo.AutoSize = True
        Me.WinInfo.BackColor = System.Drawing.Color.Transparent
        Me.WinInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinInfo.ForeColor = System.Drawing.Color.White
        Me.WinInfo.Location = New System.Drawing.Point(137, 279)
        Me.WinInfo.Name = "WinInfo"
        Me.WinInfo.Size = New System.Drawing.Size(360, 116)
        Me.WinInfo.TabIndex = 32
        Me.WinInfo.Text = "Same Card: Double your money!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Same Value: 50" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Same Suit: 25" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "One Spin costs 100"
        '
        'CardSpin
        '
        Me.CardSpin.Interval = 500
        '
        'SlotsGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.WinInfo)
        Me.Controls.Add(Me.Winnings)
        Me.Controls.Add(Me.PlayerMoney)
        Me.Controls.Add(Me.PlayerMoneyLabel)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.Spin)
        Me.Controls.Add(Me.Card2)
        Me.Controls.Add(Me.Card1)
        Me.Controls.Add(Me.Background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(574, 444)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(574, 444)
        Me.Name = "SlotsGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SlotsGame"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents Card1 As System.Windows.Forms.PictureBox
    Friend WithEvents Card2 As System.Windows.Forms.PictureBox
    Friend WithEvents Spin As System.Windows.Forms.Button
    Friend WithEvents Quit As System.Windows.Forms.Button
    Friend WithEvents PlayerMoneyLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerMoney As System.Windows.Forms.Label
    Friend WithEvents Card As System.Windows.Forms.ImageList
    Friend WithEvents Winnings As System.Windows.Forms.Label
    Friend WithEvents WinInfo As System.Windows.Forms.Label
    Friend WithEvents CardSpin As System.Windows.Forms.Timer
End Class
