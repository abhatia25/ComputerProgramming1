'Aditya Bhatia
'Which Is First?
'5/9/2018
Public Class frmWhichIsFirst
    Dim word1 As String
    Dim word2 As String
    Dim strFirstWord As String
    Dim strSecondWord As String
    Dim testInt As Double

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        word1 = txtWord1.Text
        word2 = txtWord2.Text
        If String.Compare(word1, word2) = -1 Then
            strFirstWord = word1
            strSecondWord = word2
        Else
            strFirstWord = word2
            strSecondWord = word1
        End If
        lblAnswer.Text = strFirstWord & " comes before " & strSecondWord
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmNewWord.Show()
    End Sub
End Class