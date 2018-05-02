Public Class CrystalBasement

    Private Sub picCrystal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picCrystal.Click
        MessageBox.Show("Great job, you found the second objects! It has been added to your inventory, and you can use it whenever you need to. You are now going back to the Space Station.")
        GlobalVariables.intInventory2 += 1
        picCrystal.Visible = False
        Me.Hide()
        frmSpaceStation.Show()
    End Sub

    Private Sub picHello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHello.Click
        MessageBox.Show("Hello creature, I am suprised to see a survivor like you down here, Well just for you efforts to get here take this power crystal for appreciation.")
        picCrystal.Visible = True
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmSpaceship.InventoryDialogBox()
    End Sub
End Class