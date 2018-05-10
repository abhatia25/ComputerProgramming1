'Aditya Bhatia
'Remove Word
'5/10/2018
Public Class frmRemoveWord

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim strString As String
        Dim strWord As String
        Dim intLetter1 As Integer
        Dim intLetter2 As Integer
        Dim strNewString As String

        strString = txtString.Text
        strWord = txtWord.Text

        intLetter1 = strString.IndexOf(strWord.Chars(0))
        intLetter2 = strWord.Length + 1


        strNewString = strString.Remove(intLetter1, intLetter2)

        lblAnswer.Text = strNewString
    End Sub

    Private Sub ExityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExityToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmBookStoreOrder.Show()
    End Sub
End Class