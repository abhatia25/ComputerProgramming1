'Aditya Bhatia
'Bookstore
'4/27/2018
Public Class frmBookstore

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmNumberBreakdown.Show()
    End Sub

    Private Sub AddToCart(ByVal intQuantity As Integer, ByVal strItem As String)
        lstShoppingCart.Items.Add(strItem & "  " & intQuantity)
    End Sub

    Private Sub btnAddToCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToCart.Click
        Dim intQuantity As Integer
        Dim strItem As String
        intQuantity = cboQuantity.Text
        strItem = lstItems.SelectedItem
        AddToCart(intQuantity:=intQuantity, strItem:=strItem)
    End Sub
End Class