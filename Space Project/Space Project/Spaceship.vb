'Aditya Bhatia
'Spaceship
'5/1/2018
Public Class frmSpaceship

    Private Sub picHandgun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picHandgun.Click
        MessageBox.Show("Great job, you found the first object! It has been added to your inventory, and you can use it whenever you need to.")
        GlobalVariables.intInventory1 += 1
        picHandgun.Visible = False
    End Sub

    Private Sub btnSpaceStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpaceStation.Click
        Me.Hide()
        frmSpaceStation.Show()
    End Sub

    Sub InventoryDialogBox()
        Dim InventoryDB As New frmInventory()
        'Show dialog box
        InventoryDB.ShowDialog()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        InventoryDialogBox()
    End Sub

    Private Sub btnAliens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAliens.Click
        MessageBox.Show("Aliens have entered your spaceship. GAME OVER")
        Me.Hide()
        frmGameOver.Show()
    End Sub

    Private Sub frmSpaceship_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        picHandgun.Visible = True
    End Sub
End Class