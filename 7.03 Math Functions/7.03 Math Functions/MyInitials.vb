'Aditya Bhatia
'My Initials
'5/9/2018
Public Class frmMyInitials
    Dim firstInitial As Char
    Dim spaceLocation As Integer
    Dim secondInitial As Char
    Dim strFirstInitial As String
    Dim strSecondInitial As String

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        firstInitial = txtName.Text.Chars(0)
        spaceLocation = txtName.Text.IndexOf(" ")
        secondInitial = txtName.Text.Chars(spaceLocation + 1)
        strFirstInitial = firstInitial.ToString
        strSecondInitial = secondInitial.ToString
        lblAnswer.Text = strFirstInitial.ToUpper & " " & strSecondInitial.ToUpper
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmWhichIsFirst.Show()
    End Sub
End Class