'Aditya Bhatia
'Student Grouping
'3/12/2018
Public Class frmStudentGrouping
    Private Sub btnDetermineGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetermineGroup.Click
        Dim name As String = Me.txtStudentName.Text
        Dim space As Integer = name.IndexOf(" ")
        Dim lastInitial As Char

        If space = -1 Then
            Me.lblAnswer.Text = "Student's first and last name must be separated by a space."
        Else
            lastInitial = name.Chars(space + 1)
            lastInitial = Char.ToUpper(lastInitial)   'convert to uppercase

            Select Case lastInitial
                Case Is <= "I"
                    Me.lblAnswer.Text = name & " is in Group 1"
                Case Is <= "S"
                    Me.lblAnswer.Text = name & " is in Group 2"
                Case Is <= "Z"
                    Me.lblAnswer.Text = name & " is in Group 3"
            End Select
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
    End Sub
End Class