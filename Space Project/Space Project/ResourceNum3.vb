Public Class frmResourceNum3

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmSpaceship.InventoryDialogBox()
    End Sub

    Private Sub picReflector_Click(sender As Object, e As EventArgs) Handles picReflector.Click
        MessageBox.Show("Great job, you found the fourth object! It has been added to your inventory, and you can use it whenever you need to. You are now heading back to the space station.")
        GlobalVariables.intInventory3 += 1
        picReflector.Visible = False
        Me.Hide()
        frmSpaceStation.Show()
    End Sub
End Class