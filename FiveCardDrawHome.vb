Public Class FiveCardDrawHome

    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click
        Me.Hide()
        FiveCard.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Texas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub FiveCardDrawHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WelcomeLabel.Parent = Background
    End Sub
End Class