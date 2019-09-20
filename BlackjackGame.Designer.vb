<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackJack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlackJack))
        Me.deal = New System.Windows.Forms.Button()
        Me.hit = New System.Windows.Forms.Button()
        Me.stick = New System.Windows.Forms.Button()
        Me.PlayerCard1 = New System.Windows.Forms.PictureBox()
        Me.PlayerCard2 = New System.Windows.Forms.PictureBox()
        Me.DealerCard1 = New System.Windows.Forms.PictureBox()
        Me.DealerCard2 = New System.Windows.Forms.PictureBox()
        Me.Card = New System.Windows.Forms.ImageList(Me.components)
        Me.quit = New System.Windows.Forms.Button()
        Me.PlayerCard3 = New System.Windows.Forms.PictureBox()
        Me.PlayerCard4 = New System.Windows.Forms.PictureBox()
        Me.PlayerCard5 = New System.Windows.Forms.PictureBox()
        Me.DealerCard3 = New System.Windows.Forms.PictureBox()
        Me.DealerCard4 = New System.Windows.Forms.PictureBox()
        Me.DealerCard5 = New System.Windows.Forms.PictureBox()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.Bet = New System.Windows.Forms.NumericUpDown()
        Me.BetValue = New System.Windows.Forms.Label()
        Me.PlayerMoneyLabel = New System.Windows.Forms.Label()
        Me.PlayerMoney = New System.Windows.Forms.Label()
        Me.Reset = New System.Windows.Forms.Button()
        CType(Me.PlayerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deal
        '
        Me.deal.BackColor = System.Drawing.Color.Transparent
        Me.deal.Location = New System.Drawing.Point(370, 204)
        Me.deal.Name = "deal"
        Me.deal.Size = New System.Drawing.Size(68, 34)
        Me.deal.TabIndex = 4
        Me.deal.Text = "Deal"
        Me.deal.UseVisualStyleBackColor = False
        '
        'hit
        '
        Me.hit.BackColor = System.Drawing.Color.Transparent
        Me.hit.Location = New System.Drawing.Point(444, 164)
        Me.hit.Name = "hit"
        Me.hit.Size = New System.Drawing.Size(68, 34)
        Me.hit.TabIndex = 5
        Me.hit.Text = "Hit"
        Me.hit.UseVisualStyleBackColor = False
        '
        'stick
        '
        Me.stick.BackColor = System.Drawing.Color.Transparent
        Me.stick.Location = New System.Drawing.Point(370, 164)
        Me.stick.Name = "stick"
        Me.stick.Size = New System.Drawing.Size(68, 34)
        Me.stick.TabIndex = 6
        Me.stick.Text = "Stick"
        Me.stick.UseVisualStyleBackColor = False
        '
        'PlayerCard1
        '
        Me.PlayerCard1.BackColor = System.Drawing.Color.Transparent
        Me.PlayerCard1.Location = New System.Drawing.Point(12, 263)
        Me.PlayerCard1.Name = "PlayerCard1"
        Me.PlayerCard1.Size = New System.Drawing.Size(102, 127)
        Me.PlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard1.TabIndex = 10
        Me.PlayerCard1.TabStop = False
        '
        'PlayerCard2
        '
        Me.PlayerCard2.BackColor = System.Drawing.Color.Transparent
        Me.PlayerCard2.Location = New System.Drawing.Point(120, 263)
        Me.PlayerCard2.Name = "PlayerCard2"
        Me.PlayerCard2.Size = New System.Drawing.Size(102, 127)
        Me.PlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard2.TabIndex = 11
        Me.PlayerCard2.TabStop = False
        '
        'DealerCard1
        '
        Me.DealerCard1.BackColor = System.Drawing.Color.Transparent
        Me.DealerCard1.Location = New System.Drawing.Point(12, 12)
        Me.DealerCard1.Name = "DealerCard1"
        Me.DealerCard1.Size = New System.Drawing.Size(102, 127)
        Me.DealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard1.TabIndex = 12
        Me.DealerCard1.TabStop = False
        '
        'DealerCard2
        '
        Me.DealerCard2.BackColor = System.Drawing.Color.Transparent
        Me.DealerCard2.Location = New System.Drawing.Point(120, 12)
        Me.DealerCard2.Name = "DealerCard2"
        Me.DealerCard2.Size = New System.Drawing.Size(102, 127)
        Me.DealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard2.TabIndex = 13
        Me.DealerCard2.TabStop = False
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
        'quit
        '
        Me.quit.BackColor = System.Drawing.Color.Transparent
        Me.quit.Location = New System.Drawing.Point(444, 204)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(68, 34)
        Me.quit.TabIndex = 14
        Me.quit.Text = "Quit"
        Me.quit.UseVisualStyleBackColor = False
        '
        'PlayerCard3
        '
        Me.PlayerCard3.BackColor = System.Drawing.Color.Transparent
        Me.PlayerCard3.Location = New System.Drawing.Point(228, 263)
        Me.PlayerCard3.Name = "PlayerCard3"
        Me.PlayerCard3.Size = New System.Drawing.Size(102, 127)
        Me.PlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard3.TabIndex = 15
        Me.PlayerCard3.TabStop = False
        '
        'PlayerCard4
        '
        Me.PlayerCard4.BackColor = System.Drawing.Color.Transparent
        Me.PlayerCard4.Location = New System.Drawing.Point(336, 263)
        Me.PlayerCard4.Name = "PlayerCard4"
        Me.PlayerCard4.Size = New System.Drawing.Size(102, 127)
        Me.PlayerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard4.TabIndex = 16
        Me.PlayerCard4.TabStop = False
        '
        'PlayerCard5
        '
        Me.PlayerCard5.BackColor = System.Drawing.Color.Transparent
        Me.PlayerCard5.Location = New System.Drawing.Point(444, 263)
        Me.PlayerCard5.Name = "PlayerCard5"
        Me.PlayerCard5.Size = New System.Drawing.Size(102, 127)
        Me.PlayerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard5.TabIndex = 17
        Me.PlayerCard5.TabStop = False
        '
        'DealerCard3
        '
        Me.DealerCard3.BackColor = System.Drawing.Color.Transparent
        Me.DealerCard3.Location = New System.Drawing.Point(228, 12)
        Me.DealerCard3.Name = "DealerCard3"
        Me.DealerCard3.Size = New System.Drawing.Size(102, 127)
        Me.DealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard3.TabIndex = 18
        Me.DealerCard3.TabStop = False
        '
        'DealerCard4
        '
        Me.DealerCard4.BackColor = System.Drawing.Color.Transparent
        Me.DealerCard4.Location = New System.Drawing.Point(336, 12)
        Me.DealerCard4.Name = "DealerCard4"
        Me.DealerCard4.Size = New System.Drawing.Size(102, 127)
        Me.DealerCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard4.TabIndex = 19
        Me.DealerCard4.TabStop = False
        '
        'DealerCard5
        '
        Me.DealerCard5.BackColor = System.Drawing.Color.Transparent
        Me.DealerCard5.Location = New System.Drawing.Point(444, 12)
        Me.DealerCard5.Name = "DealerCard5"
        Me.DealerCard5.Size = New System.Drawing.Size(102, 127)
        Me.DealerCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard5.TabIndex = 20
        Me.DealerCard5.TabStop = False
        '
        'Background
        '
        Me.Background.BackgroundImage = Global.Casino.My.Resources.Resources.Casino_Background
        Me.Background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(558, 405)
        Me.Background.TabIndex = 21
        Me.Background.TabStop = False
        '
        'Bet
        '
        Me.Bet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bet.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.Bet.Location = New System.Drawing.Point(164, 206)
        Me.Bet.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Bet.Minimum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.Bet.Name = "Bet"
        Me.Bet.Size = New System.Drawing.Size(66, 31)
        Me.Bet.TabIndex = 22
        Me.Bet.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'BetValue
        '
        Me.BetValue.AutoSize = True
        Me.BetValue.BackColor = System.Drawing.Color.Transparent
        Me.BetValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BetValue.ForeColor = System.Drawing.Color.White
        Me.BetValue.Location = New System.Drawing.Point(47, 207)
        Me.BetValue.Name = "BetValue"
        Me.BetValue.Size = New System.Drawing.Size(122, 29)
        Me.BetValue.TabIndex = 23
        Me.BetValue.Text = "Bet Value:"
        '
        'PlayerMoneyLabel
        '
        Me.PlayerMoneyLabel.AutoSize = True
        Me.PlayerMoneyLabel.BackColor = System.Drawing.Color.Transparent
        Me.PlayerMoneyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerMoneyLabel.ForeColor = System.Drawing.Color.White
        Me.PlayerMoneyLabel.Location = New System.Drawing.Point(47, 167)
        Me.PlayerMoneyLabel.Name = "PlayerMoneyLabel"
        Me.PlayerMoneyLabel.Size = New System.Drawing.Size(165, 29)
        Me.PlayerMoneyLabel.TabIndex = 24
        Me.PlayerMoneyLabel.Text = "Player Money:"
        '
        'PlayerMoney
        '
        Me.PlayerMoney.AutoSize = True
        Me.PlayerMoney.BackColor = System.Drawing.Color.Transparent
        Me.PlayerMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerMoney.ForeColor = System.Drawing.Color.White
        Me.PlayerMoney.Location = New System.Drawing.Point(212, 169)
        Me.PlayerMoney.Name = "PlayerMoney"
        Me.PlayerMoney.Size = New System.Drawing.Size(0, 29)
        Me.PlayerMoney.TabIndex = 25
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(507, 27)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(38, 54)
        Me.Reset.TabIndex = 26
        Me.Reset.UseVisualStyleBackColor = True
        '
        'BlackJack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.PlayerMoney)
        Me.Controls.Add(Me.PlayerMoneyLabel)
        Me.Controls.Add(Me.Bet)
        Me.Controls.Add(Me.BetValue)
        Me.Controls.Add(Me.DealerCard5)
        Me.Controls.Add(Me.DealerCard4)
        Me.Controls.Add(Me.DealerCard3)
        Me.Controls.Add(Me.PlayerCard5)
        Me.Controls.Add(Me.PlayerCard4)
        Me.Controls.Add(Me.PlayerCard3)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.DealerCard2)
        Me.Controls.Add(Me.DealerCard1)
        Me.Controls.Add(Me.PlayerCard2)
        Me.Controls.Add(Me.PlayerCard1)
        Me.Controls.Add(Me.stick)
        Me.Controls.Add(Me.hit)
        Me.Controls.Add(Me.deal)
        Me.Controls.Add(Me.Background)
        Me.Controls.Add(Me.Reset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(574, 444)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(574, 444)
        Me.Name = "BlackJack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BlackJack Game"
        CType(Me.PlayerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deal As System.Windows.Forms.Button
    Friend WithEvents hit As System.Windows.Forms.Button
    Friend WithEvents stick As System.Windows.Forms.Button
    Friend WithEvents PlayerCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents DealerCard1 As System.Windows.Forms.PictureBox
    Friend WithEvents DealerCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents Card As System.Windows.Forms.ImageList
    Friend WithEvents quit As System.Windows.Forms.Button
    Friend WithEvents PlayerCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerCard4 As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerCard5 As System.Windows.Forms.PictureBox
    Friend WithEvents DealerCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents DealerCard4 As System.Windows.Forms.PictureBox
    Friend WithEvents DealerCard5 As System.Windows.Forms.PictureBox
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents Bet As System.Windows.Forms.NumericUpDown
    Friend WithEvents BetValue As System.Windows.Forms.Label
    Friend WithEvents PlayerMoneyLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerMoney As System.Windows.Forms.Label
    Friend WithEvents Reset As System.Windows.Forms.Button

End Class
