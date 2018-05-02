Public Class frmResouceNum1

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Me.Hide()
        frmCrystalRoom.Show()
    End Sub

    Private Sub btnLeave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeave.Click
        Me.Hide()
        frmSpaceship.Show()
    End Sub
    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmSpaceship.InventoryDialogBox()
    End Sub
End Class