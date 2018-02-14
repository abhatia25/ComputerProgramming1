Public Class frmMovieSelector

    Private Sub radMovieType1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMovieType1.CheckedChanged
        Me.lblMovieTitle.Text = "Daddy's Home"
    End Sub

    Private Sub radMovieType2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMovieType2.CheckedChanged
        Me.lblMovieTitle.Text = "The Fate of the Furious"
    End Sub

    Private Sub radMovieType3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMovieType3.CheckedChanged
        Me.lblMovieTitle.Text = "Inside Job"
    End Sub

    Private Sub radMovieType4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMovieType4.CheckedChanged
        Me.lblMovieTitle.Text = "Titanic"
    End Sub

    Private Sub radMovieType5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMovieType5.CheckedChanged
        Me.lblMovieTitle.Text = "Home Alone"
    End Sub

    Private Sub radMovieType6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMovieType6.CheckedChanged
        Me.lblMovieTitle.Text = "Jurassic Park"
    End Sub

    Private Sub btnQuantity1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuantity1.Click
        Me.lblTotalCost.Text = 1 * 5.0
        Me.lblDone.Text = "Enjoy your movie!"
    End Sub

    Private Sub btnQuantity2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuantity2.Click
        Me.lblTotalCost.Text = 2 * 5.0
        Me.lblDone.Text = "Enjoy your movie!"
    End Sub

    Private Sub btnQuantity3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuantity3.Click
        Me.lblTotalCost.Text = 3 * 5.0
        Me.lblDone.Text = "Enjoy your movie!"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Me.lblTotalCost.Text = ""
        Me.lblDone.Text = ""
        Me.lblMovieTitle.Text = ""
        Me.radMovieType1.Checked = False
        Me.radMovieType2.Checked = False
        Me.radMovieType3.Checked = False
        Me.radMovieType4.Checked = False
        Me.radMovieType5.Checked = False
        Me.radMovieType6.Checked = False
    End Sub
End Class
