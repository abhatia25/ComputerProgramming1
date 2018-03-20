'Aditya Bhatia
'Coder/Decoder
'3/15/2018
Public Class frmCoder_Decoder
    Dim message As String

    Private Sub btnEnterMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterMessage.Click
        message = InputBox("Enter a message", Me.Text)
        If message = Nothing Then       'cancel selected or text box empty
            Me.lblAnswer.Text = "You must enter a message in the text box. Try again."
        End If
    End Sub

    Private Sub radEncode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radEncode.Click
        Me.lblAnswer.Text = Nothing
        Dim length As Integer = message.Length
        Dim unicode As Integer
        Dim coded As Char

        For index As Integer = 0 To length - 1
            unicode = AscW(message.Chars(index))
            Select Case unicode
                Case 89, 90, 121, 122   'convert Y to A, Z to B, y to a, z to b
                    unicode -= 24
                Case 32                 'leave space as a space
                    unicode = unicode
                Case Else               'add 2 to every other number
                    unicode += 2
            End Select
            coded = ChrW(unicode)
            Me.lblAnswer.Text &= coded
        Next index

        message = Me.lblAnswer.Text
    End Sub

    Private Sub radDecode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radDecode.Click
        Me.lblAnswer.Text = Nothing
        Dim length As Integer = message.Length
        Dim unicode As Integer
        Dim coded As Char

        For index As Integer = 0 To length - 1
            unicode = AscW(message.Chars(index))
            Select Case unicode
                Case 65, 66, 97, 98     'convert A to Y, B to Z, a to y, b to z
                    unicode += 24
                Case 32                 'leave space as a space
                    unicode = unicode
                Case Else               'subtract 2 from every other number
                    unicode -= 2
            End Select
            coded = ChrW(unicode)
            Me.lblAnswer.Text &= coded
        Next index

        message = Me.lblAnswer.Text
    End Sub

    Private Sub radDecode_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radDecode.CheckedChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub radEncode_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radEncode.CheckedChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmPalindrome.Visible = True
    End Sub
End Class
