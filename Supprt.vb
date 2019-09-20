Public Class Supprt

    Private Sub Hom_Click(sender As Object, e As EventArgs) Handles Hom.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Supprt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pretty buttons
        Info.Parent = Background
        Infotext.Parent = Background
    End Sub

End Class