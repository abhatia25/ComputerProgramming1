'Aditya Bhatia
'Stop Light
'5/14/2018
Public Class frmStopLight
    Private Sub btnRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRed.Click
        picLight.Image = My.Resources.stopLightRed
    End Sub
    Private Sub btnYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYellow.Click
        picLight.Image = My.Resources.stopLightYellow
    End Sub
    Private Sub btnGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGreen.Click
        picLight.Image = My.Resources.stopLightGreen
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frm100DiceRolls.Show()
    End Sub
End Class