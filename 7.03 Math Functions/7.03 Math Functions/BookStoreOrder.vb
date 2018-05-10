'Aditya Bhatia
'Book Store Order
'5/10/2018
Public Class frmBookStoreOrder
    Private Sub btnAddToCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToCart.Click
        Dim item As String = Me.lstItem.SelectedItem
        Dim quantity As Integer
        'Validate the quantity, since a combo box allows user entry and list selection
        If IsNumeric(Me.cboQuantity.Text) Then
            quantity = Val(Me.cboQuantity.Text)
            'convert to numeric
            Me.lstCart.Items.Add(item & vbTab & quantity) 'add to list box
        Else
            MessageBox.Show("Must enter a valid numeric quantity.") 'display error
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmPitchPennies.Show()
    End Sub
End Class