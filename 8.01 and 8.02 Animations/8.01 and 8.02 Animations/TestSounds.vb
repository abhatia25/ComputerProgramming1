'Aditya Bhatia
'Test Sounds
'5/16/2018
Public Class frmTestSounds
    Private Sub btnApplause_Click(sender As Object, e As EventArgs) Handles btnApplause.Click
        My.Computer.Audio.Play(My.Resources.Applause, AudioPlayMode.Background)
    End Sub

    Private Sub btnAhem_Click(sender As Object, e As EventArgs) Handles btnAhem.Click
        My.Computer.Audio.Play(My.Resources.ahem, AudioPlayMode.Background)
    End Sub

    Private Sub btnAirRaid_Click(sender As Object, e As EventArgs) Handles btnAirRaid.Click
        My.Computer.Audio.Play(My.Resources.air_raid, AudioPlayMode.Background)
    End Sub

    Private Sub btnArrow_Click(sender As Object, e As EventArgs) Handles btnArrow.Click
        My.Computer.Audio.Play(My.Resources.arrow, AudioPlayMode.Background)
    End Sub

    Private Sub btnBabyCrying_Click(sender As Object, e As EventArgs) Handles btnBabyCrying.Click
        My.Computer.Audio.Play(My.Resources.baby_cry, AudioPlayMode.Background)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmCoordinates.Show()
    End Sub
End Class