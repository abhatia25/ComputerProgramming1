'Aditya Bhatia
'Store
'5/22/2018
Public Class frmStore
    Dim items() As String
    Dim quantities() As Integer

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoney.Click
        frmMainCasinoRoom.InventoryDB()
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        For Each itemChecked In cstItems.CheckedItems
            Dim i As Integer
            items(i) = itemChecked.ToString
            i += 1
        Next
    End Sub
End Class