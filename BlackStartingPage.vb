Public Class BStartup
    Private Sub Starting_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hide game form
        BlackJack.Hide()

        'nice visual label
        WelcomeLabel.Parent = Background
        Play.Parent = Background
    End Sub

    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click
        'start game
        Me.Hide()
        BlackJack.Show()
    End Sub

    Private Sub Instructions_Click(sender As Object, e As EventArgs) Handles Instruc.Click
        'Instructions
        Me.Hide()
        BlackJackInstructions.Show()
    End Sub

    Private Sub MSC_Click(sender As Object, e As EventArgs)
        'Music Options
        Me.Hide()
        Music.Show()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        'End Blackjack Game
        Me.Hide()
        Home.Show()
    End Sub
End Class