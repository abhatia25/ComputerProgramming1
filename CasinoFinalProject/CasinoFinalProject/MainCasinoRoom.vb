'Aditya Bhatia
'Main Casino Room
'5/21/2018
Public Class MainCasinoRoom

    Private Sub DONEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DONEToolStripMenuItem.Click
        Me.Hide()
        frmDone.Show()
    End Sub

    Private Sub MainCasinoRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Show()
        My.Computer.Audio.Play(My.Resources.casino_background, AudioPlayMode.BackgroundLoop)
    End Sub
End Class