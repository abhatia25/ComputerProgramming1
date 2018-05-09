'Aditya Bhatia
'Birthdays
'5/7/2018
Public Class frmBirthdays

    Private Sub btnBirthdates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBirthdates.Click
        Dim names(2) As String
        Dim birthdates(2) As String

        For i As Integer = 0 To names.Length - 1
            names(i) = InputBox("Please enter a name", "Names")
        Next i

        For i As Integer = 0 To birthdates.Length - 1
            birthdates(i) = InputBox("Please enter a birthdate", "Birthdates")
        Next i
        lstDisplay.Items.Add(names(0) & " " & birthdates(0))
        lstDisplay.Items.Add(names(1) & " " & birthdates(1))
        lstDisplay.Items.Add(names(2) & " " & birthdates(2))
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmGPAArray.Show()
    End Sub
End Class