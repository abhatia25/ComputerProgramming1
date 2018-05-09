'Aditya Bhatia
'My Name
'5/9/2018
Public Class frmMyName
    Dim firstName As String
    Dim lastName As String

    Private Sub btnGetName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetName.Click
        firstName = InputBox("Please enter your first name", "First Name")
        lastName = InputBox("Please enter your last name", "Last Name")
        firstName = Trim(firstName)
        lastName = Trim(lastName)
        lblAnswer.Text = String.Concat(firstName, " ", lastName)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmMyInitials.Show()
    End Sub
End Class