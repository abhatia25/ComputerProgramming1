'Aditya Bhatia
'Test Sounds
'5/16/2018
Public Class frmTestSounds
    Private Sub btnApplause_Click(sender As Object, e As EventArgs) Handles btnApplause.Click
        My.Computer.Audio.Play(My.Resources.Applause, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub btnAhem_Click(sender As Object, e As EventArgs) Handles btnAhem.Click
        My.Computer.Audio.Play(My.Resources.ahem, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub btnAirRaid_Click(sender As Object, e As EventArgs) Handles btnAirRaid.Click
        My.Computer.Audio.Play(My.Resources.air_raid, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub btnArrow_Click(sender As Object, e As EventArgs) Handles btnArrow.Click
        My.Computer.Audio.Play(My.Resources.air_raid, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub btnBabyCrying_Click(sender As Object, e As EventArgs) Handles btnBabyCrying.Click
        My.Computer.Audio.Play(My.Resources.baby_cry, AudioPlayMode.WaitToComplete)
    End Sub
End Class