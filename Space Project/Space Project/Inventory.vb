'Aditya Bhatia
'Inventory
'5/1/2018
Public Class frmInventory

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInventory1.Text = "Quantity: " & GlobalVariables.intInventory1 'handgun
        lblInventory2.Text = "Quantity: " & GlobalVariables.intInventory2 'orb
        lblInventory3.Text = "Quantity: " & GlobalVariables.intInventory3 'reflector
        lblInventory4.Text = "Quantity: " & GlobalVariables.intInventory4 'crystal
        lblInventory5.Text = "Quantity: " & GlobalVariables.intInventory5 'shield
    End Sub
End Class