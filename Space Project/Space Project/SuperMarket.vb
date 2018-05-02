Public Class frmSuperMarket

    Private Sub btnNothing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNothing.Click

        Me.Hide()
        frmManufacureGuy.Show()

    End Sub

    Private Sub btnTalk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalk.Click

        MessageBox.Show("Oh, hey Homie. You're looking for Mr.Harold? He's in the Manufacturing Plant. See you later.")

        btnNothing.Text = "Go to the Manufacturing Plant."
    End Sub

End Class