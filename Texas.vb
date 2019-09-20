Public Class Texas

    'dim variables
    Dim cpubet As Integer
    Dim playerbet As Integer
    Dim plcrd(4) As Integer
    Dim plfcrd(4) As Integer
    Dim cpucrd(4) As Integer
    Dim clickcount As Integer = 0

    Dim plcardimages(4) As PictureBox
    Dim cpucardimages(4) As PictureBox
    Dim playerscore As Integer = 0
    Dim cpuscore As Integer = 0
    Dim firstdone As Boolean = True

    Private Sub FiveCard_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        PlayerMoney.Text = GlobalVariables.bucks
    End Sub

    Private Sub FiveCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'form load randomize
        Randomize()

        'starting money
        PlayerMoney.Text = GlobalVariables.bucks

        'array of pictureboxes
        plcardimages(0) = Card1
        plcardimages(1) = Card2
        plcardimages(2) = Card3
        plcardimages(3) = Card4
        plcardimages(4) = Card5

        cpucardimages(0) = PictureBox1
        cpucardimages(1) = PictureBox2
        cpucardimages(2) = PictureBox3
        cpucardimages(3) = PictureBox4
        cpucardimages(4) = PictureBox5

        'enable cards
        For i = 0 To 4
            plcardimages(i).Enabled = False
            plcardimages(i).AccessibleDescription = ""
            plcardimages(i).Parent = Background
            cpucardimages(i).Enabled = False
            cpucardimages(i).AccessibleDescription = ""
            cpucardimages(i).Parent = Background
        Next

        'disable buttons
        Done.Enabled = False
        Cll.Enabled = False
        Rs.Enabled = False
        Fld.Enabled = False
        Raisevalue.Enabled = False
        Alin.Enabled = False

        'hide ugly buttons
        dl.Parent = Background
        Done.Parent = Background
        quit.Parent = Background
        betlbl.Parent = Background
        bet.Parent = Background
        PlayerMoneyLabel.Parent = Background
        PlayerMoney.Parent = Background
        Cll.Parent = Background
        Rs.Parent = Background
        Fld.Parent = Background
        Alin.Parent = Background
        Raisevalue.Parent = Background
        PlayerMoney.Text = GlobalVariables.bucks

    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        'exit game and open home
        MsgBox("Thanks for playing Five Card Draw!")
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub deal_Click(sender As Object, e As EventArgs) Handles dl.Click
        If GlobalVariables.bucks <= 0 Then
            MsgBox("You played yourself")
            End
        End If

        'get cards
        For i = 0 To 4
            plcrd(i) = newcard()
            cpucrd(i) = newcard()
            plcardimages(i).Image = DeckOfCArds.Images(plcrd(i))
            cpucardimages(i).Image = DeckOfCArds.Images(0)
        Next

        'deak with cards
        For i = 0 To 4
            plcardimages(i).Enabled = False
            plcardimages(i).Tag = plcrd(i)
        Next

        'get computer bet
        cpubet = 25 * calculate(cpucrd) + 25 * Int(5 * Rnd() + 1)
        While cpubet >= GlobalVariables.bucks
            cpubet = 25 * calculate(cpucrd) + 25 * Int(5 * Rnd() + 1)
        End While
        bet.Text = cpubet
        PlayerMoney.Text = GlobalVariables.bucks


        'deal with buttons
        Cll.Enabled = True
        Rs.Enabled = True
        Fld.Enabled = True
        Raisevalue.Enabled = True
        Alin.Enabled = True
        dl.Enabled = False
        bet.Enabled = False
        Done.Enabled = False
        firstdone = True

    End Sub

    Private Sub Card_Click(sender As Object, e As EventArgs) Handles Card1.Click, Card2.Click, Card3.Click, Card4.Click, Card5.Click
        'click cards
        If sender.accessibledescription = "" Then
            sender.image = DeckOfCArds.Images(0)
            sender.accessibledescription = "*"
        Else
            sender.image = DeckOfCArds.Images(sender.tag)
            sender.accessibledescription = ""
        End If

    End Sub

    Private Sub Done_Click(sender As Object, e As EventArgs) Handles Done.Click

        'deal with cards
        For i = 0 To 4
            plcardimages(i).Enabled = False
            If plcardimages(i).AccessibleDescription <> "*" Then
                plfcrd(i) = plcrd(i)
            Else
                plfcrd(i) = newcard()
                plcardimages(i).Image = DeckOfCArds.Images(plfcrd(i))
            End If
        Next

        'computer bet again
        cpubet = 25 * calculate(cpucrd) + 25 * Int(5 * Rnd() + 1)
        While cpubet >= GlobalVariables.bucks
            cpubet = 25 * calculate(cpucrd) + 25 * Int(5 * Rnd() + 1)
        End While
        bet.Text = cpubet
        PlayerMoney.Text = GlobalVariables.bucks

        'deal with buttons
        Cll.Enabled = True
        Rs.Enabled = True
        Fld.Enabled = True
        Raisevalue.Enabled = True
        Alin.Enabled = True
        Done.Enabled = False
        firstdone = False

    End Sub

    Function newcard() As Integer
        'get number
        Return 52 * Rnd() + 8
    End Function

    Private Sub Cll_Click(sender As Object, e As EventArgs) Handles Cll.Click
        playerbet = cpubet
        GlobalVariables.bucks -= playerbet
        PlayerMoney.Text = GlobalVariables.bucks

        If firstdone = True Then
            'disable buttons
            Done.Enabled = True
            Cll.Enabled = False
            Rs.Enabled = False
            Fld.Enabled = False
            Raisevalue.Enabled = False
            Alin.Enabled = False
            For i = 0 To 4
                plcardimages(i).Enabled = True
            Next
        Else
            For i = 0 To 4
                cpucardimages(i).Image = DeckOfCArds.Images(cpucrd(i))
            Next
            Cll.Enabled = False
            Rs.Enabled = False
            Fld.Enabled = False
            Raisevalue.Enabled = False
            Alin.Enabled = False

            'deal with buttons and start calculation
            Done.Enabled = False
            playerscore = calculate(plfcrd)
            cpuscore = calculate(cpucrd)

            'give money
            If playerscore > cpuscore Then
                GlobalVariables.bucks += playerbet * 2
                PlayerMoney.Text = GlobalVariables.bucks
            ElseIf playerscore < cpuscore Then
                PlayerMoney.Text = GlobalVariables.bucks
            Else
                Dim pl As Integer = 0
                Dim cpu As Integer = 0
                For i = 0 To 4

                    If plcrd(i) >= 1 And plcrd(i) <= 4 Then
                        plcrd(i) += 52
                    End If
                    If cpucrd(i) >= 1 And cpucrd(i) <= 4 Then
                        cpucrd(i) += 52
                    End If

                    If plcrd(i) < pl Then
                        pl = plcrd(i)
                    End If
                    If cpucrd(i) < cpu Then
                        cpu = cpucrd(i)
                    End If
                Next
                If pl > cpu Then
                    GlobalVariables.bucks += playerbet * 2
                    PlayerMoney.Text = GlobalVariables.bucks
                Else
                    PlayerMoney.Text = GlobalVariables.bucks
                End If
            End If

            dl.Enabled = True
            Done.Enabled = False

            'reset clicked value
            For i = 0 To 4
                plcardimages(i).AccessibleDescription = ""
            Next

        End If

        bet.Text = Nothing

    End Sub

    Private Sub Rs_Click(sender As Object, e As EventArgs) Handles Rs.Click
        'if bet is more than money earned
        If Raisevalue.Value > GlobalVariables.bucks Then
            MsgBox("Bet less you math fool")
            Exit Sub
        End If

        'tell computer player bet
        playerbet = cpubet + Raisevalue.Value
        bet.Text = playerbet
        GlobalVariables.bucks -= (cpubet + Raisevalue.Value)
        PlayerMoney.Text = GlobalVariables.bucks
        cpubet += Raisevalue.Value

        If firstdone = True Then
            'disable buttons
            Done.Enabled = True
            Cll.Enabled = False
            Rs.Enabled = False
            Fld.Enabled = False
            Raisevalue.Enabled = False
            Alin.Enabled = False
            For i = 0 To 4
                plcardimages(i).Enabled = True
            Next
        Else
            For i = 0 To 4
                cpucardimages(i).Image = DeckOfCArds.Images(cpucrd(i))
            Next
            Cll.Enabled = False
            Rs.Enabled = False
            Fld.Enabled = False
            Raisevalue.Enabled = False
            Alin.Enabled = False

            'deal with buttons and start calculation
            Done.Enabled = False
            playerscore = calculate(plfcrd)
            cpuscore = calculate(cpucrd)

            If playerscore > cpuscore Then
                GlobalVariables.bucks += playerbet * 2
                PlayerMoney.Text = GlobalVariables.bucks
            ElseIf playerscore < cpuscore Then
                PlayerMoney.Text = GlobalVariables.bucks
            Else
                Dim pl As Integer = 0
                Dim cpu As Integer = 0
                For i = 0 To 4

                    If plcrd(i) >= 1 And plcrd(i) <= 4 Then
                        plcrd(i) += 52
                    End If
                    If cpucrd(i) >= 1 And cpucrd(i) <= 4 Then
                        cpucrd(i) += 52
                    End If

                    If plcrd(i) < pl Then
                        pl = plcrd(i)
                    End If
                    If cpucrd(i) < cpu Then
                        cpu = cpucrd(i)
                    End If
                Next
                If pl > cpu Then
                    GlobalVariables.bucks += playerbet * 2
                    PlayerMoney.Text = GlobalVariables.bucks
                Else
                    PlayerMoney.Text = GlobalVariables.bucks
                End If
            End If

            dl.Enabled = True
            Done.Enabled = False

            'reset clicked value
            For i = 0 To 4
                plcardimages(i).AccessibleDescription = ""
            Next

        End If

        bet.Text = Nothing

    End Sub

    Private Sub Fld_Click(sender As Object, e As EventArgs) Handles Fld.Click
        'show cards and deal with buttons
        For i = 0 To 4
            cpucardimages(i).Image = DeckOfCArds.Images(cpucrd(i))
        Next
        Cll.Enabled = False
        Rs.Enabled = False
        Fld.Enabled = False
        Raisevalue.Enabled = False
        Alin.Enabled = False
        dl.Enabled = True
        bet.Text = Nothing
    End Sub

    Private Sub Alin_Click(sender As Object, e As EventArgs) Handles Alin.Click
        'player goes all in
        playerbet += GlobalVariables.bucks
        cpubet += GlobalVariables.bucks
        bet.Text = playerbet
        GlobalVariables.bucks = 0
        PlayerMoney.Text = 0

        For i = 0 To 4
            cpucardimages(i).Image = DeckOfCArds.Images(cpucrd(i))
        Next
        Cll.Enabled = False
        Rs.Enabled = False
        Fld.Enabled = False
        Raisevalue.Enabled = False
        Alin.Enabled = False
        dl.Enabled = True
        Done.Enabled = False


        'deal with buttons and start calculation
        If firstdone = True Then
            playerscore = calculate(plcrd)
            cpuscore = calculate(cpucrd)
        
        'give money to winner
            If playerscore > cpuscore Then
                GlobalVariables.bucks += playerbet * 2
                PlayerMoney.Text = GlobalVariables.bucks
            ElseIf playerscore < cpuscore Then
                PlayerMoney.Text = GlobalVariables.bucks
            Else
                Dim pl As Integer = 0
                Dim cpu As Integer = 0
                For i = 0 To 4

                    If plcrd(i) >= 1 And plcrd(i) <= 4 Then
                        plcrd(i) += 52
                    End If
                    If cpucrd(i) >= 1 And cpucrd(i) <= 4 Then
                        cpucrd(i) += 52
                    End If

                    If plcrd(i) < pl Then
                        pl = plcrd(i)
                    End If
                    If cpucrd(i) < cpu Then
                        cpu = cpucrd(i)
                    End If
                Next
                If pl > cpu Then
                    GlobalVariables.bucks += playerbet * 2
                    PlayerMoney.Text = GlobalVariables.bucks
                Else
                    PlayerMoney.Text = GlobalVariables.bucks
                End If
            End If

        Else
            playerscore = calculate(plfcrd)
            cpuscore = calculate(cpucrd)

            'give money to winner
            If playerscore > cpuscore Then
                GlobalVariables.bucks += playerbet * 2
                PlayerMoney.Text = GlobalVariables.bucks
            ElseIf playerscore < cpuscore Then
                PlayerMoney.Text = GlobalVariables.bucks
            Else
                Dim pl As Integer = 0
                Dim cpu As Integer = 0
                For i = 0 To 4

                    If plcrd(i) >= 1 And plcrd(i) <= 4 Then
                        plcrd(i) += 52
                    End If
                    If cpucrd(i) >= 1 And cpucrd(i) <= 4 Then
                        cpucrd(i) += 52
                    End If

                    If plcrd(i) < pl Then
                        pl = plcrd(i)
                    End If
                    If cpucrd(i) < cpu Then
                        cpu = cpucrd(i)
                    End If
                Next
                If pl > cpu Then
                    GlobalVariables.bucks += playerbet * 2
                    PlayerMoney.Text = GlobalVariables.bucks
                Else
                    PlayerMoney.Text = GlobalVariables.bucks
                End If
            End If
        End If
        dl.Enabled = True
        Done.Enabled = False

        'reset clicked value
        For i = 0 To 4
            plcardimages(i).AccessibleDescription = ""
        Next

        bet.Text = Nothing

    End Sub


    Function calculate(ByVal deal() As Integer) As Integer

        'figure Out Hand

        'dim needed variables
        Dim AceOfSpadesForRoyal As Integer = 0
        Dim ThreeOfAKindCount As Integer = 0
        Dim FourOfAKindCount As Integer = 0
        Dim FullHouseCount As Integer = 0
        Dim StraitCount As Integer = 0
        Dim FlushCount As Integer = 0
        Dim StraitFlush As Integer = 0
        Dim RoyalFlushCount As Integer = 0
        Dim TwoPairCount As Integer = 0
        Dim AbsolutePairCount As Integer = 0

        'cards used will be using
        Dim FinalCards(0 To 4) As String
        FinalCards(0) = CStr(deal(0))
        FinalCards(1) = CStr(deal(1))
        FinalCards(2) = CStr(deal(2))
        FinalCards(3) = CStr(deal(3))
        FinalCards(4) = CStr(deal(4))

        'get card suit
        Dim FinalCardsSuit(0 To 4) As String
        For I = 0 To 4
            If (CInt(FinalCards(I))) > 7 Then FinalCardsSuit(I) = "C"
            If (CInt(FinalCards(I))) > 20 Then FinalCardsSuit(I) = "D"
            If (CInt(FinalCards(I))) > 33 Then FinalCardsSuit(I) = "H"
            If (CInt(FinalCards(I))) > 46 Then FinalCardsSuit(I) = "S"
        Next

        'count card suit values
        Dim ccount As Integer = 0
        Dim dcount As Integer = 0
        Dim hcount As Integer = 0
        Dim scount As Integer = 0
        For I = 0 To 4
            If FinalCardsSuit(I) = "C" Then ccount = ccount + 1
            If FinalCardsSuit(I) = "D" Then dcount = dcount + 1
            If FinalCardsSuit(I) = "H" Then hcount = hcount + 1
            If FinalCardsSuit(I) = "S" Then scount = scount + 1
        Next

        'flush count checker
        If ccount = 5 Or dcount = 5 Or hcount = 5 Or scount = 5 Then
            FlushCount = 1
        End If

        'variables for information
        Dim String2 As String = " 8 21 34 47 "
        Dim String3 As String = " 9 22 35 48 "
        Dim String4 As String = " 10 23 36 49 "
        Dim String5 As String = " 11 24 37 50 "
        Dim String6 As String = " 12 25 38 51 "
        Dim String7 As String = " 13 26 39 52 "
        Dim String8 As String = " 14 27 40 53 "
        Dim String9 As String = " 15 28 41 54 "
        Dim String10 As String = " 16 29 42 55 "
        Dim StringJ As String = " 17 30 43 56 "
        Dim StringQ As String = " 18 31 44 57 "
        Dim StringK As String = " 19 32 45 58 "
        Dim StringA As String = " 20 33 46 59 "
        Dim count2 As Integer = 0
        Dim count3 As Integer = 0
        Dim count4 As Integer = 0
        Dim count5 As Integer = 0
        Dim count6 As Integer = 0
        Dim count7 As Integer = 0
        Dim count8 As Integer = 0
        Dim count9 As Integer = 0
        Dim count10 As Integer = 0
        Dim countJ As Integer = 0
        Dim countQ As Integer = 0
        Dim countK As Integer = 0
        Dim countA As Integer = 0
        Dim CardRank(0 To 4) As Integer
        Dim CardRank2(0 To 4) As Integer

        'check for how many of each card
        For I = 0 To UBound(FinalCards)
            If CBool(InStr(String2, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                count2 = count2 + 1
                CardRank(I) = 13
                CardRank2(I) = 13
            End If
            If CBool(InStr(String3, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                count3 = count3 + 1
                CardRank(I) = 12
                CardRank2(I) = 12
            End If
            If CBool(InStr(String4, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                count4 = count4 + 1
                CardRank(I) = 11
                CardRank2(I) = 11
            End If
            If CBool(InStr(String5, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                count5 = count5 + 1
                CardRank(I) = 10
                CardRank2(I) = 10
            End If
            If CBool(InStr(String6, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                count6 = count6 + 1
                CardRank(I) = 9
                CardRank2(I) = 9
            End If
            If CBool(InStr(String7, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                count7 = count7 + 1
                CardRank(I) = 8
                CardRank2(I) = 8
            End If
            If CBool(InStr(String8, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                count8 = count8 + 1
                CardRank(I) = 7
                CardRank2(I) = 7
            End If
            If CBool(InStr(String9, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                count9 = count9 + 1
                CardRank(I) = 6
                CardRank2(I) = 6
            End If
            If CBool(InStr(String10, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                count10 = count10 + 1
                CardRank(I) = 5
                CardRank2(I) = 5
            End If
            If CBool(InStr(StringJ, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                countJ = countJ + 1
                CardRank(I) = 4
                CardRank2(I) = 4
            End If
            If CBool(InStr(StringQ, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                countQ = countQ + 1
                CardRank(I) = 3
                CardRank2(I) = 3
            End If
            If CBool(InStr(StringK, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                countK = countK + 1
                CardRank(I) = 2
                CardRank2(I) = 2
            End If
            If CBool(InStr(StringA, (" " & FinalCards(I) & " "), CompareMethod.Binary)) = True Then
                countA = countA + 1
                CardRank(I) = 1
                CardRank2(I) = 14
            End If
        Next

        'check value of cards
        Array.Sort(CardRank)
        Array.Sort(CardRank2)
        If CardRank(0) = 1 Then AceOfSpadesForRoyal = 1
        If CardRank(1) = CardRank(0) + 1 _
            And CardRank(2) = CardRank(1) + 1 _
            And CardRank(3) = CardRank(2) + 1 _
            And CardRank(4) = CardRank(3) + 1 Then
            StraitCount = 1
        End If
        If CardRank2(1) = CardRank2(0) + 1 _
           And CardRank2(2) = CardRank2(1) + 1 _
           And CardRank2(3) = CardRank2(2) + 1 _
           And CardRank2(4) = CardRank2(3) + 1 Then
            StraitCount = 1
        End If

        'check for 2,3,4 multiples
        If count2 = 2 Then AbsolutePairCount += 1
        If count2 = 3 Then ThreeOfAKindCount = 1
        If count2 = 4 Then FourOfAKindCount = 1
        If count3 = 2 Then AbsolutePairCount += 1
        If count3 = 3 Then ThreeOfAKindCount = 1
        If count3 = 4 Then FourOfAKindCount = 1
        If count4 = 2 Then AbsolutePairCount += 1
        If count4 = 3 Then ThreeOfAKindCount = 1
        If count4 = 4 Then FourOfAKindCount = 1
        If count5 = 2 Then AbsolutePairCount += 1
        If count5 = 3 Then ThreeOfAKindCount = 1
        If count5 = 4 Then FourOfAKindCount = 1
        If count6 = 2 Then AbsolutePairCount += 1
        If count6 = 3 Then ThreeOfAKindCount = 1
        If count6 = 4 Then FourOfAKindCount = 1
        If count7 = 2 Then AbsolutePairCount += 1
        If count7 = 3 Then ThreeOfAKindCount = 1
        If count7 = 4 Then FourOfAKindCount = 1
        If count8 = 2 Then AbsolutePairCount += 1
        If count8 = 3 Then ThreeOfAKindCount = 1
        If count8 = 4 Then FourOfAKindCount = 1
        If count9 = 2 Then AbsolutePairCount += 1
        If count9 = 3 Then ThreeOfAKindCount = 1
        If count9 = 4 Then FourOfAKindCount = 1
        If count10 = 2 Then AbsolutePairCount += 1
        If count10 = 3 Then ThreeOfAKindCount = 1
        If count10 = 4 Then FourOfAKindCount = 1
        If countJ = 2 Then AbsolutePairCount += 1
        If countJ = 3 Then ThreeOfAKindCount = 1
        If countJ = 4 Then FourOfAKindCount = 1
        If countQ = 2 Then AbsolutePairCount += 1
        If countQ = 3 Then ThreeOfAKindCount = 1
        If countQ = 4 Then FourOfAKindCount = 1
        If countK = 2 Then AbsolutePairCount += 1
        If countK = 3 Then ThreeOfAKindCount = 1
        If countK = 4 Then FourOfAKindCount = 1
        If countA = 2 Then AbsolutePairCount += 1
        If countA = 3 Then ThreeOfAKindCount = 1
        If countA = 4 Then FourOfAKindCount = 1

        'full house check
        Dim WinType As String = ""
        If AbsolutePairCount = 1 And ThreeOfAKindCount = 1 Then
            FullHouseCount = 1
        End If

        'royal flush check
        If AceOfSpadesForRoyal = 1 And StraitCount = 1 And FlushCount = 1 Then
            RoyalFlushCount = 1
        End If

        'straight flush check
        If StraitCount = 1 And FlushCount = 1 Then
            StraitFlush = 1
        End If


        'Winnings'
        'Royal Flush
        If RoyalFlushCount = 1 Then
            Return 9
            GoTo msged
        End If
        'Straitflush
        If StraitFlush = 1 Then
            Return 8
            GoTo msged
        End If
        'Strait
        If StraitCount = 1 Then
            Return 7
            GoTo msged
        End If
        'Flush
        If FlushCount = 1 Then
            Return 6
            GoTo Msged
        End If
        '4 of a kind
        If FourOfAKindCount = 1 Then
            Return 5
            GoTo msged
        End If
        'Full House
        If FullHouseCount = 1 Then
            Return 4
            GoTo msged
        End If
        'Three of A Kind
        If ThreeOfAKindCount = 1 Then
            Return 3
            GoTo msged
        End If
        'Two Pair
        If AbsolutePairCount = 2 Then
            Return 2
            GoTo msged
        End If
        'Jacks of Better
        If AbsolutePairCount = 1 Then
            Return 1
            GoTo msged
        End If
        Return 0
Msged:
    End Function

End Class