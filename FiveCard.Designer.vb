<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiveCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FiveCard))
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.Card5 = New System.Windows.Forms.PictureBox()
        Me.Card4 = New System.Windows.Forms.PictureBox()
        Me.Card3 = New System.Windows.Forms.PictureBox()
        Me.Card2 = New System.Windows.Forms.PictureBox()
        Me.Card1 = New System.Windows.Forms.PictureBox()
        Me.quit = New System.Windows.Forms.Button()
        Me.dl = New System.Windows.Forms.Button()
        Me.PlayerMoneyLabel = New System.Windows.Forms.Label()
        Me.Bet = New System.Windows.Forms.NumericUpDown()
        Me.BetValue = New System.Windows.Forms.Label()
        Me.PlayerMoney = New System.Windows.Forms.Label()
        Me.Done = New System.Windows.Forms.Button()
        Me.DeckOfCArds = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Background
        '
        Me.Background.BackgroundImage = Global.Casino.My.Resources.Resources.Casino_Background
        Me.Background.Location = New System.Drawing.Point(-7, -7)
        Me.Background.MaximumSize = New System.Drawing.Size(635, 322)
        Me.Background.MinimumSize = New System.Drawing.Size(635, 322)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(635, 322)
        Me.Background.TabIndex = 0
        Me.Background.TabStop = False
        '
        'Card5
        '
        Me.Card5.BackColor = System.Drawing.Color.Transparent
        Me.Card5.Location = New System.Drawing.Point(492, 100)
        Me.Card5.Name = "Card5"
        Me.Card5.Size = New System.Drawing.Size(117, 165)
        Me.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card5.TabIndex = 25
        Me.Card5.TabStop = False
        '
        'Card4
        '
        Me.Card4.BackColor = System.Drawing.Color.Transparent
        Me.Card4.Location = New System.Drawing.Point(372, 100)
        Me.Card4.Name = "Card4"
        Me.Card4.Size = New System.Drawing.Size(117, 165)
        Me.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card4.TabIndex = 24
        Me.Card4.TabStop = False
        '
        'Card3
        '
        Me.Card3.BackColor = System.Drawing.Color.Transparent
        Me.Card3.Location = New System.Drawing.Point(252, 100)
        Me.Card3.Name = "Card3"
        Me.Card3.Size = New System.Drawing.Size(117, 165)
        Me.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card3.TabIndex = 23
        Me.Card3.TabStop = False
        '
        'Card2
        '
        Me.Card2.BackColor = System.Drawing.Color.Transparent
        Me.Card2.Location = New System.Drawing.Point(132, 100)
        Me.Card2.Name = "Card2"
        Me.Card2.Size = New System.Drawing.Size(117, 165)
        Me.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card2.TabIndex = 22
        Me.Card2.TabStop = False
        '
        'Card1
        '
        Me.Card1.BackColor = System.Drawing.Color.Transparent
        Me.Card1.Location = New System.Drawing.Point(12, 100)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(117, 165)
        Me.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card1.TabIndex = 21
        Me.Card1.TabStop = False
        '
        'quit
        '
        Me.quit.BackColor = System.Drawing.Color.Transparent
        Me.quit.Location = New System.Drawing.Point(540, 10)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(68, 34)
        Me.quit.TabIndex = 27
        Me.quit.Text = "Quit"
        Me.quit.UseVisualStyleBackColor = False
        '
        'dl
        '
        Me.dl.BackColor = System.Drawing.Color.Transparent
        Me.dl.Location = New System.Drawing.Point(465, 50)
        Me.dl.Name = "dl"
        Me.dl.Size = New System.Drawing.Size(68, 34)
        Me.dl.TabIndex = 26
        Me.dl.Text = "Deal"
        Me.dl.UseVisualStyleBackColor = False
        '
        'PlayerMoneyLabel
        '
        Me.PlayerMoneyLabel.AutoSize = True
        Me.PlayerMoneyLabel.BackColor = System.Drawing.Color.Transparent
        Me.PlayerMoneyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerMoneyLabel.ForeColor = System.Drawing.Color.White
        Me.PlayerMoneyLabel.Location = New System.Drawing.Point(12, 9)
        Me.PlayerMoneyLabel.Name = "PlayerMoneyLabel"
        Me.PlayerMoneyLabel.Size = New System.Drawing.Size(165, 29)
        Me.PlayerMoneyLabel.TabIndex = 30
        Me.PlayerMoneyLabel.Text = "Player Money:"
        '
        'Bet
        '
        Me.Bet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bet.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.Bet.Location = New System.Drawing.Point(129, 44)
        Me.Bet.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.Bet.Minimum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.Bet.Name = "Bet"
        Me.Bet.Size = New System.Drawing.Size(66, 31)
        Me.Bet.TabIndex = 28
        Me.Bet.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'BetValue
        '
        Me.BetValue.AutoSize = True
        Me.BetValue.BackColor = System.Drawing.Color.Transparent
        Me.BetValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BetValue.ForeColor = System.Drawing.Color.White
        Me.BetValue.Location = New System.Drawing.Point(12, 49)
        Me.BetValue.Name = "BetValue"
        Me.BetValue.Size = New System.Drawing.Size(122, 29)
        Me.BetValue.TabIndex = 29
        Me.BetValue.Text = "Bet Value:"
        '
        'PlayerMoney
        '
        Me.PlayerMoney.AutoSize = True
        Me.PlayerMoney.BackColor = System.Drawing.Color.Transparent
        Me.PlayerMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerMoney.ForeColor = System.Drawing.Color.White
        Me.PlayerMoney.Location = New System.Drawing.Point(174, 12)
        Me.PlayerMoney.Name = "PlayerMoney"
        Me.PlayerMoney.Size = New System.Drawing.Size(0, 29)
        Me.PlayerMoney.TabIndex = 31
        '
        'Done
        '
        Me.Done.BackColor = System.Drawing.Color.Transparent
        Me.Done.Location = New System.Drawing.Point(539, 50)
        Me.Done.Name = "Done"
        Me.Done.Size = New System.Drawing.Size(68, 34)
        Me.Done.TabIndex = 32
        Me.Done.Text = "Done"
        Me.Done.UseVisualStyleBackColor = False
        '
        'DeckOfCArds
        '
        Me.DeckOfCArds.ImageStream = CType(resources.GetObject("DeckOfCArds.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.DeckOfCArds.TransparentColor = System.Drawing.Color.Transparent
        Me.DeckOfCArds.Images.SetKeyName(0, "0.png")
        Me.DeckOfCArds.Images.SetKeyName(1, "1.png")
        Me.DeckOfCArds.Images.SetKeyName(2, "2.png")
        Me.DeckOfCArds.Images.SetKeyName(3, "3.png")
        Me.DeckOfCArds.Images.SetKeyName(4, "4.png")
        Me.DeckOfCArds.Images.SetKeyName(5, "5.png")
        Me.DeckOfCArds.Images.SetKeyName(6, "6.png")
        Me.DeckOfCArds.Images.SetKeyName(7, "7.png")
        Me.DeckOfCArds.Images.SetKeyName(8, "8.png")
        Me.DeckOfCArds.Images.SetKeyName(9, "9.png")
        Me.DeckOfCArds.Images.SetKeyName(10, "10.png")
        Me.DeckOfCArds.Images.SetKeyName(11, "11.png")
        Me.DeckOfCArds.Images.SetKeyName(12, "12.png")
        Me.DeckOfCArds.Images.SetKeyName(13, "13.png")
        Me.DeckOfCArds.Images.SetKeyName(14, "14.png")
        Me.DeckOfCArds.Images.SetKeyName(15, "15.png")
        Me.DeckOfCArds.Images.SetKeyName(16, "16.png")
        Me.DeckOfCArds.Images.SetKeyName(17, "17.png")
        Me.DeckOfCArds.Images.SetKeyName(18, "18.png")
        Me.DeckOfCArds.Images.SetKeyName(19, "19.png")
        Me.DeckOfCArds.Images.SetKeyName(20, "20.png")
        Me.DeckOfCArds.Images.SetKeyName(21, "21.png")
        Me.DeckOfCArds.Images.SetKeyName(22, "22.png")
        Me.DeckOfCArds.Images.SetKeyName(23, "23.png")
        Me.DeckOfCArds.Images.SetKeyName(24, "24.png")
        Me.DeckOfCArds.Images.SetKeyName(25, "25.png")
        Me.DeckOfCArds.Images.SetKeyName(26, "26.png")
        Me.DeckOfCArds.Images.SetKeyName(27, "27.png")
        Me.DeckOfCArds.Images.SetKeyName(28, "28.png")
        Me.DeckOfCArds.Images.SetKeyName(29, "29.png")
        Me.DeckOfCArds.Images.SetKeyName(30, "30.png")
        Me.DeckOfCArds.Images.SetKeyName(31, "31.png")
        Me.DeckOfCArds.Images.SetKeyName(32, "32.png")
        Me.DeckOfCArds.Images.SetKeyName(33, "33.png")
        Me.DeckOfCArds.Images.SetKeyName(34, "34.png")
        Me.DeckOfCArds.Images.SetKeyName(35, "35.png")
        Me.DeckOfCArds.Images.SetKeyName(36, "36.png")
        Me.DeckOfCArds.Images.SetKeyName(37, "37.png")
        Me.DeckOfCArds.Images.SetKeyName(38, "38.png")
        Me.DeckOfCArds.Images.SetKeyName(39, "39.png")
        Me.DeckOfCArds.Images.SetKeyName(40, "40.png")
        Me.DeckOfCArds.Images.SetKeyName(41, "41.png")
        Me.DeckOfCArds.Images.SetKeyName(42, "42.png")
        Me.DeckOfCArds.Images.SetKeyName(43, "43.png")
        Me.DeckOfCArds.Images.SetKeyName(44, "44.png")
        Me.DeckOfCArds.Images.SetKeyName(45, "45.png")
        Me.DeckOfCArds.Images.SetKeyName(46, "46.png")
        Me.DeckOfCArds.Images.SetKeyName(47, "47.png")
        Me.DeckOfCArds.Images.SetKeyName(48, "48.png")
        Me.DeckOfCArds.Images.SetKeyName(49, "49.png")
        Me.DeckOfCArds.Images.SetKeyName(50, "50.png")
        Me.DeckOfCArds.Images.SetKeyName(51, "51.png")
        Me.DeckOfCArds.Images.SetKeyName(52, "52.png")
        Me.DeckOfCArds.Images.SetKeyName(53, "53.png")
        Me.DeckOfCArds.Images.SetKeyName(54, "54.png")
        Me.DeckOfCArds.Images.SetKeyName(55, "55.png")
        Me.DeckOfCArds.Images.SetKeyName(56, "56.png")
        Me.DeckOfCArds.Images.SetKeyName(57, "57.png")
        Me.DeckOfCArds.Images.SetKeyName(58, "58.png")
        Me.DeckOfCArds.Images.SetKeyName(59, "59.png")
        Me.DeckOfCArds.Images.SetKeyName(60, "60.png")
        Me.DeckOfCArds.Images.SetKeyName(61, "61.png")
        '
        'FiveCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 283)
        Me.Controls.Add(Me.Done)
        Me.Controls.Add(Me.PlayerMoney)
        Me.Controls.Add(Me.PlayerMoneyLabel)
        Me.Controls.Add(Me.Bet)
        Me.Controls.Add(Me.BetValue)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.dl)
        Me.Controls.Add(Me.Card5)
        Me.Controls.Add(Me.Card4)
        Me.Controls.Add(Me.Card3)
        Me.Controls.Add(Me.Card2)
        Me.Controls.Add(Me.Card1)
        Me.Controls.Add(Me.Background)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(635, 322)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(635, 322)
        Me.Name = "FiveCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FiveCard"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Background As System.Windows.Forms.PictureBox
    Friend WithEvents Card5 As System.Windows.Forms.PictureBox
    Friend WithEvents Card4 As System.Windows.Forms.PictureBox
    Friend WithEvents Card3 As System.Windows.Forms.PictureBox
    Friend WithEvents Card2 As System.Windows.Forms.PictureBox
    Friend WithEvents Card1 As System.Windows.Forms.PictureBox
    Friend WithEvents quit As System.Windows.Forms.Button
    Friend WithEvents dl As System.Windows.Forms.Button
    Friend WithEvents PlayerMoneyLabel As System.Windows.Forms.Label
    Friend WithEvents Bet As System.Windows.Forms.NumericUpDown
    Friend WithEvents BetValue As System.Windows.Forms.Label
    Friend WithEvents PlayerMoney As System.Windows.Forms.Label
    Friend WithEvents Done As System.Windows.Forms.Button
    Friend WithEvents DeckOfCArds As System.Windows.Forms.ImageList
End Class
