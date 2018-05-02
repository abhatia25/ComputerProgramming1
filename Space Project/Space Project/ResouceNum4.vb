Public Class frmResouceNum4

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Me.Hide()
        frmManufacturePlanet.Show()
    End Sub

    Private Sub btnLeave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeave.Click
        Me.Hide()
        frmSpaceStation.Show()
    End Sub
    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmSpaceship.InventoryDialogBox()
    End Sub
End Class