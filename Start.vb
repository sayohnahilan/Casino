Public Class Start

    Private Sub FiveCard_Show(sender As Object, e As EventArgs) Handles MyBase.Shown
        WelcomeLabel.Parent = Background
        Infotext.Parent = Background
    End Sub

    Private Sub Done_Click(sender As Object, e As EventArgs) Handles Done.Click
        GlobalVariables.bucks = Bet.Value - (Bet.Value Mod 25)
        GlobalVariables.starmoney = Bet.Value - (Bet.Value Mod 25)
        Me.Hide()
        Home.Show()
    End Sub
End Class