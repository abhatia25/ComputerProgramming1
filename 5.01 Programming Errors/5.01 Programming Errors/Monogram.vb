'Aditya Bhatia
'Monogram
'2/27/2018
Public Class frmMonogram

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub btnMonogram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonogram.Click
        Dim fullName As String
        Dim firstInitial As String
        Dim lastInitial As String
        Dim middleInitial As String
        Dim temp As String              'substring of just the middle and last names
        Dim firstName As String         'substring of just the first name
        Dim space As Integer

        fullName = Me.txtNames.Text
        firstInitial = fullName.Substring(0, 1)
        space = fullName.IndexOf(" ")
        If space = -1 Then              'no space character found
            middleInitial = Nothing
            lastInitial = Nothing
        Else                            'at least one space found
            firstName = fullName.Substring(0, space)
            middleInitial = fullName.Substring(space + 1, 1)
            'Create without first name
            temp = fullName.Substring(space + 1, fullName.Length - firstName.Length - 1)
            'Get location of second space character
            space = temp.IndexOf(" ")
            If space = -1 Then          'no second space character found
                lastInitial = Nothing
            Else                        'get last name initial
                lastInitial = temp.Substring(space + 1, 1)
            End If
        End If

        If lastInitial = Nothing Then   'user entered two names
            Me.lblAnswer.Text = firstInitial.ToLower & middleInitial.ToUpper
        Else                            'user entered three names
            Me.lblAnswer.Text = firstInitial.ToLower & lastInitial.ToUpper & _
            middleInitial.ToLower
        End If
    End Sub

    Private Sub txtNames_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNames.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub

End Class