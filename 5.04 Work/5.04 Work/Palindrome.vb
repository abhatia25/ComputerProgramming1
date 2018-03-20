'Aditya Bhatia
'Palindrome
'3/15/2018
Public Class frmPalindrome
    Private Sub btnCheckIfPalindrome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckIfPalindrome.Click
        Dim text As String
        Dim noSpaces As String
        Dim reversedText As String = Nothing

        text = Me.txtText.Text
        noSpaces = text.Replace(" ", "")    'remove spaces

        'Reverse string
        For index As Integer = noSpaces.Length - 1 To 0 Step -1
            reversedText &= noSpaces.Chars(index)
        Next index

        'Determine if palidrome
        Select Case String.Compare(noSpaces, reversedText, True)
            Case 0
                Me.lblAnswer.Text = text & " is a palindrome."
            Case Else
                Me.lblAnswer.Text = text & " is not a palindrome."
                shakeMe()
        End Select
    End Sub

    Private Sub txtText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtText.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmDisplayNameBackwards.Visible = True
    End Sub

    Private Sub shakeMe()
        Dim myLoc As Point, myLocDef As Point
        myLocDef = Me.Location
        myLoc = Me.Location
        For i As Integer = 0 To 100
            For x As Integer = 0 To 4
                Select Case x
                    Case 0
                        myLoc.X = myLocDef.X + 10
                    Case 1
                        myLoc.X = myLocDef.X - 10
                    Case 2
                        myLoc.Y = myLocDef.Y - 10
                    Case 3
                        myLoc.Y = myLocDef.Y + 10
                    Case 4
                        myLoc = myLocDef
                End Select
                Me.Location = myLoc
                Me.Refresh()
            Next
        Next
        Me.Location = myLocDef
        Me.Refresh()
    End Sub
End Class