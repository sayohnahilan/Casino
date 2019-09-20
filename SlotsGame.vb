Public Class SlotsGame
    'card numbers
    Dim c1 As Integer
    Dim c2 As Integer

    Private Sub SlotsGame_show(sender As Object, e As EventArgs) Handles MyBase.Shown
        'player money
        PlayerMoney.Text = GlobalVariables.bucks
    End Sub

    Private Sub SlotsGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'randomize
        Randomize()

        'pretty
        Card1.Parent = Background
        Card2.Parent = Background
        PlayerMoneyLabel.Parent = Background
        PlayerMoney.Parent = Background
        Winnings.Parent = Background
        WinInfo.Parent = Background

        'player money
        PlayerMoney.Text = GlobalVariables.bucks
    End Sub

    Private Sub Spin_Click(sender As Object, e As EventArgs) Handles Spin.Click
        'check bankruptcy
        If PlayerMoney.Text < 100 Then
            MsgBox("Bankruptcy")
            End
        End If

        'tell money
        GlobalVariables.bucks -= 100
        PlayerMoney.Text = GlobalVariables.bucks

        'get cards
        CardSpin.Interval = 300
        CardSpin.Start()

        'disable spin button
        Spin.Enabled = False
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        MsgBox("Thanks for playing Slots!")
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub CardSpin_Tick(sender As Object, e As EventArgs) Handles CardSpin.Tick
        'spin cards fast
        If CardSpin.Interval > 20 Then
            c1 = Int(52 * Rnd())
            Card1.Image = Card.Images(c1)
            c2 = Int(52 * Rnd())
            Card2.Image = Card.Images(c2)
            CardSpin.Interval = CardSpin.Interval - 20
        Else
            'stop spinning
            CardSpin.Enabled = False

            'calculate
            If (c1 Mod 4) = (c2 Mod 4) And ((c1 + 4) \ 4) = ((c2 + 4) \ 4) Then
                GlobalVariables.bucks += 100
                GlobalVariables.bucks *= 2
                PlayerMoney.Text = GlobalVariables.bucks
            ElseIf ((c1 + 4) \ 4) = ((c2 + 4) \ 4) Then
                GlobalVariables.bucks += 50
                PlayerMoney.Text = GlobalVariables.bucks
            ElseIf (c1 Mod 4) = (c2 Mod 4) Then
                GlobalVariables.bucks += 25
                PlayerMoney.Text = GlobalVariables.bucks
            End If

            'enable spin button
            Spin.Enabled = True
        End If
    End Sub
End Class