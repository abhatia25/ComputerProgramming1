'Aditya Bhatia
'Inventory
'5/1/2018
Public Class frmInventory

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblInventory1.Text = "Quantity: " & GlobalVariables.intInventory1
        lblInventory2.Text = "Quantity: " & GlobalVariables.intInventory2
        lblInventory3.Text = "Quantity: " & GlobalVariables.intInventory3
        lblInventory4.Text = "Quantity: " & GlobalVariables.intInventory4
    End Sub
End Class