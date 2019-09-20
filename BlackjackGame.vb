Public Class BlackJack

    'dim variables needed
    Dim plcrd1, plcrd2, plcrd3, plcrd4, plcrd5 As Integer
    Dim dlcrd1, dlcrd2, dlcrd3, dlcrd4, dlcrd5 As Integer
    Dim plscore, dlscore As Integer
    Dim turncounter As Integer
    Dim betmoney As Integer
    Dim plstartmoney As Integer

    Private Sub BlackjackGame_show(sender As Object, e As EventArgs) Handles MyBase.Shown
        'get player money
        PlayerMoney.Text = GlobalVariables.bucks
        plstartmoney = GlobalVariables.bucks
    End Sub

    Private Sub deal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deal.Click
        'get bet
        If PlayerMoney.Text = 0 Then
            MsgBox("Bankruptcy")
            End
        ElseIf Bet.Value <= PlayerMoney.Text Then
            betmoney = Bet.Value
        Else
            MsgBox("Bet less money")
            Exit Sub
        End If
        PlayerMoney.Text = GlobalVariables.bucks

        'disable buttons
        hit.Enabled = True
        stick.Enabled = True
        deal.Enabled = False
        Bet.Enabled = False

        'first turn
        turncounter = 0
        plscore = 0
        dlscore = 0
        hit.Enabled = True

        'starting card
        plcrd1 = 51 * Rnd()
        plcrd2 = 51 * Rnd()
        dlcrd1 = 51 * Rnd()
        dlcrd2 = 51 * Rnd()

        'display starting cards
        PlayerCard1.Image = Card.Images(plcrd1)
        PlayerCard2.Image = Card.Images(plcrd2)
        PlayerCard3.Image = Nothing
        PlayerCard4.Image = Nothing
        PlayerCard5.Image = Nothing
        DealerCard1.Image = Card.Images(52)
        DealerCard2.Image = Card.Images(dlcrd2)
        DealerCard3.Image = Nothing
        DealerCard4.Image = Nothing
        DealerCard5.Image = Nothing

        'calculate player score
        Dim plscore1 As Integer = 0
        Dim plscore2 As Integer = 0
        If plcrd1 \ 4 > 9 Then
            plscore1 = 10
        Else
            plscore1 = (plcrd1 + 4) \ 4
        End If
        If plcrd2 \ 4 > 9 Then
            plscore2 = 10
        Else
            plscore2 = (plcrd2 + 4) \ 4
        End If
        plscore = plscore1 + plscore2

        'calculate dealer score
        Dim dlscore1 As Integer = 0
        Dim dlscore2 As Integer = 0
        If dlcrd1 \ 4 > 9 Then
            dlscore1 = 10
        Else
            dlscore1 = (dlcrd1 + 4) \ 4
        End If
        If dlcrd2 \ 4 > 9 Then
            dlscore2 = 10
        Else
            dlscore2 = (dlcrd2 + 4) \ 4
        End If
        dlscore = dlscore1 + dlscore2
    End Sub
    Private Sub BlackJack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'form load randomize
        Randomize()

        'starting money
        PlayerMoney.Text = GlobalVariables.bucks
        plstartmoney = GlobalVariables.bucks

        'hide ugly cards
        PlayerCard1.Parent = Background
        PlayerCard2.Parent = Background
        PlayerCard3.Parent = Background
        PlayerCard4.Parent = Background
        PlayerCard5.Parent = Background
        DealerCard1.Parent = Background
        DealerCard2.Parent = Background
        DealerCard3.Parent = Background
        DealerCard4.Parent = Background
        DealerCard5.Parent = Background

        'hide ugly buttons
        stick.Parent = Background
        hit.Parent = Background
        deal.Parent = Background
        quit.Parent = Background
        BetValue.Parent = Background
        PlayerMoneyLabel.Parent = Background
        PlayerMoney.Parent = Background

        'disable buttons
        hit.Enabled = False
        stick.Enabled = False
        Bet.Enabled = True
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        'exit blackjack and open home
        MsgBox("Thanks for playing Blackjack!")
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub hit_Click(sender As Object, e As EventArgs) Handles hit.Click
        'computer couter to know where to put card
        turncounter += 1

        'first turn
        If turncounter = 1 Then
            'player 3rd card
            Dim plscore3 As Integer = 0
            plcrd3 = 51 * Rnd()
            PlayerCard3.Image = Card.Images(plcrd3)
            If plcrd3 \ 4 > 9 Then
                plscore3 = 10
            Else
                plscore3 = (plcrd3 + 4) \ 4
            End If
            plscore = plscore + plscore3

            'check player bust
            If plscore > 21 Then
                DealerCard1.Image = Card.Images(dlcrd1)
                MsgBox("Player Bust")
                GlobalVariables.bucks = GlobalVariables.bucks - betmoney
                PlayerMoney.Text = GlobalVariables.bucks
                Reset.PerformClick()
                Exit Sub
            End If
            'dealer 3rd card
            Dim dlscore3 As Integer = 0
            If dlscore < 16 Then
                dlcrd3 = 51 * Rnd()
                DealerCard3.Image = Card.Images(dlcrd3)
                If dlcrd3 \ 4 > 9 Then
                    dlscore3 = 10
                Else
                    dlscore3 = (dlcrd3 + 4) \ 4
                End If
                dlscore = dlscore + dlscore3
            End If

            'check dealer bust
            If dlscore > 21 Then
                DealerCard1.Image = Card.Images(dlcrd1)
                MsgBox("Dealer Bust")
                GlobalVariables.bucks = GlobalVariables.bucks + betmoney
                PlayerMoney.Text = GlobalVariables.bucks
                Reset.PerformClick()
                Exit Sub
            End If
        End If


        'second turn
        If turncounter = 2 Then
            'player 4th card
            Dim plscore4 As Integer = 0
            plcrd4 = 51 * Rnd()
            PlayerCard4.Image = Card.Images(plcrd4)
            If plcrd4 \ 4 > 9 Then
                plscore4 = 10
            Else
                plscore4 = (plcrd4 + 4) \ 4
            End If
            plscore = plscore + plscore4

            'check player bust
            If plscore > 21 Then
                DealerCard1.Image = Card.Images(dlcrd1)
                MsgBox("Player Bust")
                GlobalVariables.bucks = GlobalVariables.bucks - betmoney
                PlayerMoney.Text = GlobalVariables.bucks
                Reset.PerformClick()
                Exit Sub
            End If

            'dealer 4th card
            Dim dlscore4 As Integer = 0
            If dlscore < 16 Then
                dlcrd4 = 51 * Rnd()
                DealerCard4.Image = Card.Images(dlcrd4)
                If dlcrd4 \ 4 > 9 Then
                    dlscore4 = 10
                Else
                    dlscore4 = (dlcrd4 + 4) \ 4
                End If
                dlscore = dlscore + dlscore4
            End If

            'check dealer bust
            If dlscore > 21 Then
                DealerCard1.Image = Card.Images(dlcrd1)
                MsgBox("Dealer Bust")
                GlobalVariables.bucks = GlobalVariables.bucks + betmoney
                PlayerMoney.Text = GlobalVariables.bucks
                Reset.PerformClick()
                Exit Sub
            End If
        End If


        'third turn
        If turncounter = 3 Then
            'player 5th card
            Dim plscore5 As Integer = 0
            plcrd5 = 51 * Rnd()
            PlayerCard5.Image = Card.Images(plcrd5)
            If plcrd5 \ 4 > 9 Then
                plscore5 = 10
            Else
                plscore5 = (plcrd5 + 4) \ 4
            End If
            plscore = plscore + plscore5

            'check player bust
            If plscore > 21 Then
                DealerCard1.Image = Card.Images(dlcrd1)
                MsgBox("Player Bust")
                GlobalVariables.bucks = GlobalVariables.bucks - betmoney
                PlayerMoney.Text = GlobalVariables.bucks
                Reset.PerformClick()
                Exit Sub
            End If

            'dealer 5th card
            Dim dlscore5 As Integer = 0
            If dlscore < 16 Then
                dlcrd5 = 51 * Rnd()
                DealerCard5.Image = Card.Images(dlcrd5)
                If dlcrd5 \ 4 > 9 Then
                    dlscore5 = 10
                Else
                    dlscore5 = (dlcrd5 + 4) \ 4
                End If
                dlscore = dlscore + dlscore5
            End If

            'check dealer bust
            If dlscore > 21 Then
                DealerCard1.Image = Card.Images(dlcrd1)
                MsgBox("Dealer Bust")
                GlobalVariables.bucks = GlobalVariables.bucks + betmoney
                PlayerMoney.Text = GlobalVariables.bucks
                Reset.PerformClick()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub stick_Click(sender As Object, e As EventArgs) Handles stick.Click
        'dealer 3rd card
        Dim dlscore3 As Integer = 0
        If dlscore < 16 Then
            dlcrd3 = 51 * Rnd()
            DealerCard3.Image = Card.Images(dlcrd3)
            If dlcrd3 \ 4 > 9 Then
                dlscore3 = 10
            Else
                dlscore3 = (dlcrd3 + 4) \ 4
            End If
            dlscore = dlscore + dlscore3

            'check dealer bust
            If dlscore > 21 Then
                DealerCard1.Image = Card.Images(dlcrd1)
                MsgBox("Dealer Bust")
                GlobalVariables.bucks = GlobalVariables.bucks + betmoney
                PlayerMoney.Text = GlobalVariables.bucks
                Reset.PerformClick()
                Exit Sub
            End If
        End If


        'dealer 4th card
        Dim dlscore4 As Integer = 0
        If dlscore < 16 Then
            dlcrd4 = 51 * Rnd()
            DealerCard4.Image = Card.Images(dlcrd4)
            If dlcrd4 \ 4 > 9 Then
                dlscore4 = 10
            Else
                dlscore4 = (dlcrd4 + 4) \ 4
            End If
            dlscore = dlscore + dlscore4

            'check dealer bust
            If dlscore > 21 Then
                DealerCard1.Image = Card.Images(dlcrd1)
                MsgBox("Dealer Bust")
                GlobalVariables.bucks = GlobalVariables.bucks + betmoney
                PlayerMoney.Text = GlobalVariables.bucks
                Reset.PerformClick()
                Exit Sub
            End If
        End If


        'dealer 5th card
        Dim dlscore5 As Integer = 0
        If dlscore < 16 Then
            dlcrd5 = 51 * Rnd()
            DealerCard5.Image = Card.Images(dlcrd5)
            If dlcrd5 \ 4 > 9 Then
                dlscore5 = 10
            Else
                dlscore5 = (dlcrd5 + 4) \ 4
            End If
            dlscore = dlscore + dlscore5

            'check dealer bust
            If dlscore > 21 Then
                DealerCard1.Image = Card.Images(dlcrd1)
                MsgBox("Dealer Bust")
                GlobalVariables.bucks = GlobalVariables.bucks + betmoney
                PlayerMoney.Text = GlobalVariables.bucks
                Reset.PerformClick()
                Exit Sub
            End If
        End If

        'check for winner
        If dlscore > plscore Then
            DealerCard1.Image = Card.Images(dlcrd1)
            MsgBox("Dealer wins")
            GlobalVariables.bucks = GlobalVariables.bucks - betmoney
            PlayerMoney.Text = GlobalVariables.bucks
            Reset.PerformClick()
        ElseIf dlscore < plscore Then
            DealerCard1.Image = Card.Images(dlcrd1)
            MsgBox("Player wins")
            GlobalVariables.bucks = GlobalVariables.bucks + betmoney
            PlayerMoney.Text = GlobalVariables.bucks
            Reset.PerformClick()
        Else
            DealerCard1.Image = Card.Images(dlcrd1)
            MsgBox("Tie")
            Reset.PerformClick()
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        'reset cards
        PlayerCard1.Image = Nothing
        PlayerCard2.Image = Nothing
        PlayerCard3.Image = Nothing
        PlayerCard4.Image = Nothing
        PlayerCard5.Image = Nothing
        DealerCard1.Image = Nothing
        DealerCard2.Image = Nothing
        DealerCard3.Image = Nothing
        DealerCard4.Image = Nothing
        DealerCard5.Image = Nothing

        'disable/enable buttons
        stick.Enabled = False
        hit.Enabled = False
        deal.Enabled = True
        Bet.Enabled = True
    End Sub
End Class