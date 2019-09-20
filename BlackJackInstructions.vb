Public Class BlackJackInstructions

    Private Sub Instructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pretty background
        InstructionHeader.Parent = Background
        Play.Parent = Background
        Home.Parent = Background
        Instruc.Parent = Background
    End Sub
    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click
        'start game
        Me.Hide()
        BlackJack.Show()
    End Sub
    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        'back to home
        Me.Hide()
        BStartup.Show()
    End Sub
End Class