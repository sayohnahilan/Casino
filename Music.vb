Public Class Music
    Dim ResourceFilePathPrefix As String
    Dim mysong As String
    Private Sub Jazz_Click(sender As Object, e As EventArgs) Handles Jazz.Click
        'Play song
        mysong = ResourceFilePathPrefix & "Jazz.wav"
        My.Computer.Audio.Play(mysong, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Casino_Click(sender As Object, e As EventArgs) Handles Casino.Click
        'Play song
        mysong = ResourceFilePathPrefix & "SlowJazz.wav"
        My.Computer.Audio.Play(mysong, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Rock_Click(sender As Object, e As EventArgs) Handles Rock.Click
        'Play song
        mysong = ResourceFilePathPrefix & "Rock.wav"
        My.Computer.Audio.Play(mysong, AudioPlayMode.BackgroundLoop)

        'let them know
        MsgBox("Wait 30 secs for the beat drop.")
    End Sub

    Private Sub Play_Click(sender As Object, e As EventArgs)
        'start game
        Me.Hide()
        BlackJack.Show()
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Hom.Click
        'back to home
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Music_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pretty
        InstructionHeader.Parent = Background

        'load sound
        If System.Diagnostics.Debugger.IsAttached() Then
            'In Debugging mode         
            ResourceFilePathPrefix = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\Music\")
        Else
            'In Published mode        
            ResourceFilePathPrefix = Application.StartupPath & "\Resources\Music\"
        End If

        'Play song

        mysong = ResourceFilePathPrefix & "SlowJazz.wav"
        My.Computer.Audio.Play(mysong, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Pop_Click(sender As Object, e As EventArgs) Handles Pop.Click
        'Play song
        mysong = ResourceFilePathPrefix & "Pop.wav"
        My.Computer.Audio.Play(mysong, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Classical_Click(sender As Object, e As EventArgs) Handles Classical.Click
        'Play song
        mysong = ResourceFilePathPrefix & "Classical.wav"
        My.Computer.Audio.Play(mysong, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Reggae_Click(sender As Object, e As EventArgs) Handles Reggae.Click
        'Play song
        mysong = ResourceFilePathPrefix & "Reggae.wav"
        My.Computer.Audio.Play(mysong, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub stop7_Click(sender As Object, e As EventArgs) Handles stop7.Click
        'Stop playing music
        My.Computer.Audio.Stop()
    End Sub
End Class