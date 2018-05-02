Public Class frmLaserRoom

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnRetry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetry.Click
        Me.Hide()
        frmGameOver.Show()
    End Sub
End Class