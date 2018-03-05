'Aditya Bhatia
'Initials
'2/27/2018
Public Class frmInitials
    Private Sub btnInitials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInitials.Click
        Dim name As String
        Dim firstInitial As String
        Dim lastInitial As String
        Dim space As Integer

        name = Me.txtName.Text
        firstInitial = name.Substring(0, 1)
        space = name.IndexOf(" ")
        If space = -1 Then          'no space character found
            lastInitial = Nothing
        Else                        'get last name initial
            lastInitial = name.Substring(space + 1, 1)
        End If

        Me.lblAnswer.Text = String.Concat(firstInitial.ToUpper, lastInitial.ToUpper)
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextProgramToolStripMenuItem.Click
        Me.Visible = False
        frmMonogram.Visible = True
    End Sub
End Class