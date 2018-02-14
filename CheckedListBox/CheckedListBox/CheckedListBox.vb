Public Class CheckedListBox
    Private Sub btnWhatIsChecked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhatIsChecked.Click
        ' Display in a message box all the items that are checked.
        Dim indexChecked As Integer
        Dim itemChecked As Object
        Const quote As String = """"
        ' First show the index and check state of all selected items.
        For Each indexChecked In clbCheckedListBox1Example.CheckedIndices
            ' The indexChecked variable contains the index of the item.
            MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" + _
                            clbCheckedListBox1Example.GetItemCheckState(indexChecked).ToString() + ".")
        Next
        ' Next show the object title and check state for each item selected.
        For Each itemChecked In clbCheckedListBox1Example.CheckedItems

            ' Use the IndexOf method to get the index of an item.
            MessageBox.Show("Item with title: " + quote + itemChecked.ToString() + quote + _
                            ", is checked. Checked state is: " + _
                            clbCheckedListBox1Example.GetItemCheckState(clbCheckedListBox1Example.Items.IndexOf(itemChecked)).ToString() + ".")
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
