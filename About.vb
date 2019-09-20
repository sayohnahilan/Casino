Public Class About

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pretty buttons
        Info.Parent = Background
        Infotext.Parent = Background
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Hom.Click
        'back to home
        Me.Hide()
        Home.Show()
    End Sub
End Class