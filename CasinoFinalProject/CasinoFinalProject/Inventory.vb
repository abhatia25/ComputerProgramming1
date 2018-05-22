'Aditya Bhatia
'Inventory
'5/22/2018
Public Class frmInventory

    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblMoney.Text = "Money: " & Format(GlobalVariables.Money, "Currency")
    End Sub
End Class