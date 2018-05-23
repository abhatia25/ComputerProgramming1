'Aditya Bhatia
'Store
'5/22/2018
Option Strict On
Option Explicit On
Public Class frmStore
    Dim items(7) As String
    Dim intQuantity As Integer
    Dim countNumber As Integer

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoney.Click
        frmMainCasinoRoom.InventoryDB()
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Hide()
        frmDone.Show()
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Dim i As Integer = 0
        countNumber = cstItems.CheckedItems.Count
        For Each itemChecked1 As Object In cstItems.CheckedItems
            items(i) = itemChecked1.ToString()
            i += 1
        Next
        CollectQuantities()
        For i1 As Integer = 0 To countNumber - 1
            lstItems.Items.Add(items(i1) & vbTab & intQuantity)
        Next
    End Sub

    Sub CollectQuantities()
        intQuantity = Convert.ToInt32(Me.cboQuantity.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstItems.Items.Clear()
        Array.Clear(items, 0, items.Length)
    End Sub
End Class