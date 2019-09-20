Public Class FiveCard

    'dim variables
    Dim betmoney As Integer
    Dim plstartmoney As Integer
    Dim crd(4) As Integer
    Dim fcrd(4) As Integer
    Dim slccrd1, slccrd2, slccrd3, slccrd4, slccrd5 As Integer
    Dim clickcount As Integer = 0
    Dim cardimages(4) As PictureBox
    Dim councount As Integer = 0

    Private Sub FiveCard_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        PlayerMoney.Text = GlobalVariables.bucks
        plstartmoney = GlobalVariables.bucks
    End Sub

    Private Sub FiveCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'form load randomize
        Randomize()

        'starting money
        PlayerMoney.Text = GlobalVariables.bucks
        plstartmoney = GlobalVariables.bucks

        'hide ugly cards
        Card1.Parent = Background
        Card2.Parent = Background
        Card3.Parent = Background
        Card4.Parent = Background
        Card5.Parent = Background

        'array of pictureboxes
        cardimages(0) = Card1
        cardimages(1) = Card2
        cardimages(2) = Card3
        cardimages(3) = Card4
        cardimages(4) = Card5

        'enable cards
        For i = 0 To 4
            cardimages(i).Enabled = False
            cardimages(i).AccessibleDescription = ""
        Next

        'disable buttons
        Done.Enabled = False
        Bet.Enabled = True

        'hide ugly buttons
        dl.Parent = Background
        Done.Parent = Background
        quit.Parent = Background
        BetValue.Parent = Background
        PlayerMoneyLabel.Parent = Background
        PlayerMoney.Parent = Background
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        'exit game and open home
        MsgBox("Thanks for playing Five Card Draw!")
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub deal_Click(sender As Object, e As EventArgs) Handles dl.Click
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

        'get cards
        For i = 0 To 4
            crd(i) = newcard()
            cardimages(i).Image = DeckOfCArds.Images(crd(i))
        Next

        'deak with cards
        For i = 0 To 4
            cardimages(i).Enabled = True
            cardimages(i).Tag = crd(i)
        Next

        'deal with buttons
        dl.Enabled = False
        Bet.Enabled = False
        Done.Enabled = True

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
            cardimages(i).Enabled = False
        Next

        'if they clicked then get new card
        For i = 0 To 4
            If cardimages(i).AccessibleDescription <> "*" Then
                fcrd(i) = crd(i)
            Else
                fcrd(i) = newcard()
                cardimages(i).Image = DeckOfCArds.Images(fcrd(i))
            End If
        Next

        'deal with buttons and start calculation
        Done.Enabled = False
        Bet.Enabled = True
        calculate(fcrd)

        'reset clicked value
        For i = 0 To 4
            cardimages(i).AccessibleDescription = ""
        Next

    End Sub

    Function newcard() As Integer
        'get number
        Return 52 * Rnd() + 8
    End Function

    Sub calculate(ByVal deal() As Integer)

        'Figure Out Hand

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

        'cards i will be using
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
            RoyalFlushCount = 1
            WinType = "Royal Flush!!!"
            GlobalVariables.bucks += betmoney * 5
            GoTo msged
        End If
        'Straitflush
        If StraitFlush = 1 Then
            WinType = "Strait Flush!!!"
            GlobalVariables.bucks += betmoney * 4
            GoTo msged
        End If
        'Strait
        If StraitCount = 1 Then
            WinType = "Strait!"
            GlobalVariables.bucks += betmoney * 4
            GoTo msged
        End If
        'Flush
        If FlushCount = 1 Then
            WinType = "Flush!"
            GlobalVariables.bucks += betmoney * 3
            GoTo Msged
        End If
        '4 of a kind
        If FourOfAKindCount = 1 Then
            WinType = "4 of a kind!"
            GlobalVariables.bucks += betmoney * 3
            GoTo msged
        End If
        'Full House
        If FullHouseCount = 1 Then
            WinType = "Full house!"
            GlobalVariables.bucks += betmoney * 3
            GoTo msged
        End If
        'Three of A Kind
        If ThreeOfAKindCount = 1 Then
            WinType = "3 of a kind!"
            GlobalVariables.bucks += betmoney * 2
            GoTo msged
        End If
        'Two Pair
        If AbsolutePairCount = 2 Then
            WinType = "2 Pair!"
            GlobalVariables.bucks += betmoney * 2
            GoTo msged
        End If
        'Jacks of Better
        If AbsolutePairCount = 1 Then
            WinType = "Pair!"
            GlobalVariables.bucks += betmoney
            GoTo msged
        End If

Msged:
        If WinType = "" Then
            GlobalVariables.bucks -= betmoney * 5
            WinType = "No Win."
        End If
        MsgBox(WinType)


        PlayerMoney.Text = Convert.ToString(GlobalVariables.bucks)

        If GlobalVariables.bucks <= 0 Then
            MsgBox("Bankruptcy")
            End
        End If

        dl.Enabled = True
        Done.Enabled = False

 
    End Sub

End Class