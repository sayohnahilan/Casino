'simple blackjack game
'by sayohn ahilan

Public Class Home
    'game time
    Dim timeleft As Integer = 9

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tell player of starting  and time
        MsgBox("Casino closes in 10 minutes." & vbCrLf + "You have " + Convert.ToString(GlobalVariables.bucks) + " dollars.")

        'pretty
        WelcomeLabel.Parent = Background

        'start game timer
        Time.Enabled = True
        Time.Start()
    End Sub

    Private Sub Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time.Tick
        'calculate time left
        timeleft = timeleft - 1
        If timeleft <= 0 Then
            Time.Stop()
            'Final Message
            If GlobalVariables.bucks > GlobalVariables.starmoney Then
                Dim gain As Integer = (GlobalVariables.bucks - GlobalVariables.starmoney)
                MsgBox("You profitted a total of " + Convert.ToString(gain) + " dollars.")
            ElseIf GlobalVariables.bucks < GlobalVariables.starmoney Then
                Dim loss As Integer = (GlobalVariables.starmoney - GlobalVariables.bucks)
                MsgBox("You lost a total of " + Convert.ToString(loss) + " dollars.")
            Else
                MsgBox("Time up. You left with as the same amount.")
            End If
            End
        ElseIf timeleft = 1 Then
            MsgBox("You have a min left.")
        ElseIf timeleft = 5 Then
            MsgBox("You have 5 mins left.")
        End If
    End Sub

    Private Sub Blackjack_Click(sender As Object, e As EventArgs) Handles Blackjack.Click
        'open blackjack
        Me.Hide()
        BStartup.Show()
    End Sub

    Private Sub Music_Click(sender As Object, e As EventArgs) Handles Msc.Click
        'open music
        Me.Hide()
        Music.Show()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        'Final Message
        If GlobalVariables.bucks > GlobalVariables.starmoney Then
            Dim gain As Integer = (GlobalVariables.bucks - GlobalVariables.starmoney)
            MsgBox("You profitted a total of " + Convert.ToString(gain) + " dollars.")
        ElseIf GlobalVariables.bucks < GlobalVariables.starmoney Then
            Dim loss As Integer = (GlobalVariables.starmoney - GlobalVariables.bucks)
            MsgBox("You lost a total of " + Convert.ToString(loss) + " dollars.")
        Else
            MsgBox("End of Game. You left with as the same amount.")
        End If
        'Stop music
        My.Computer.Audio.Stop()
        Me.Close()
        End
    End Sub

    Private Sub Slot_Click(sender As Object, e As EventArgs) Handles Slot.Click
        'open slots
        Me.Hide()
        SlotsGame.Show()
    End Sub

    Private Sub Abt_Click(sender As Object, e As EventArgs) Handles Abt.Click
        'open info
        Me.Hide()
        About.Show()
    End Sub

    Private Sub Poker_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Texas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'open five card
        Me.Hide()
        FiveCard.Show()
    End Sub

    Private Sub Support_Click(sender As Object, e As EventArgs) Handles Support.Click
        Me.Hide()
        Supprt.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FiveCardDrawHome.Show()
    End Sub
End Class
Public Class GlobalVariables
    'player starting money
    Public Shared bucks As Integer = 1000
    Public Shared starmoney As Integer = 0
End Class
