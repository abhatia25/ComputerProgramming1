Public Class CrystalRoom

    Private Sub frmCrystalRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MessageBox.Show("No body has been here since the first World War was occuring.")

    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Me.Hide()
        CrystalBasement.Show()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmSpaceship.InventoryDialogBox()
    End Sub

End Class