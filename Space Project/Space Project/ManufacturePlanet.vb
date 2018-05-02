Public Class frmManufacturePlanet

    Private Sub btnSupermarket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupermarket.Click
        Me.Hide()
        frmSuperMarket.Show()
    End Sub

    Private Sub btnManufacturingPlant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManufacturingPlant.Click
        Me.Hide()
        frmManufacureGuy.Show()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmSpaceship.InventoryDialogBox()
    End Sub

End Class