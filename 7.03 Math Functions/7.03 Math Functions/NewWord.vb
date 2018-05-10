'Aditya Bhatia
'New Word
'5/10/2018
Public Class frmNewWord

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmRemoveWord.Show()
    End Sub

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        Dim originalWord As String
        Dim newWord As String
        Dim replacementLetter As Char
        Dim newLetter As Char

        Try
            originalWord = txtWord.Text
            replacementLetter = txtReplace.Text
            newLetter = txtNew.Text
            newWord = originalWord.Replace(replacementLetter, newLetter)
            lblAnswer.Text = "The new word is " & newWord
        Catch ex As Exception
            MessageBox.Show("Please only enter 1 letter to replace")
        End Try
    End Sub
End Class