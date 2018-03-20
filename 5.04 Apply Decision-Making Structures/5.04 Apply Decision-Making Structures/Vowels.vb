'Aditya Bhatia
'Vowels
'3/15/2018
Public Class frmVowels
    Private Sub btnCountVowels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCountVowels.Click
        Dim text As String
        Dim count As Integer = 0

        text = (Me.txtText.Text).ToLower

        For index As Integer = 0 To text.Length - 1
            Select Case text.Chars(index)
                Case "a", "e", "i", "o", "u"
                    count += 1
            End Select
        Next index

        Me.lblAnswer.Text = "The number of vowels in " & vbCrLf & text & " is: " & vbCrLf & count
    End Sub

    Private Sub txtText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub
End Class