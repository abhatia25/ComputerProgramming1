Public Class frmResourceNum2

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmSpaceship.InventoryDialogBox()
    End Sub

    Private Sub picOrb_Click(sender As Object, e As EventArgs) Handles picOrb.Click
        MessageBox.Show("Great job, you found the third object! It has been added to your inventory, and you can use it whenever you need to. You are now heading back to the space station.")
        GlobalVariables.intInventory2 += 1
        picOrb.Visible = False
        Me.Hide()
        frmSpaceStation.Show()
    End Sub
End Class