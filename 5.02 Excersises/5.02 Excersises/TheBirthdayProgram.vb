'Aditya Bhatia
'Birthday Program
'3/6/2018
Public Class frmBirthdayProgram

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmUniqueNumbers.Visible = True
        MessageBox.Show("Form switched")
    End Sub

    Private Sub btnBirthday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBirthday.Click
        MsgBox("Your birth date was " & DateTimePicker1.Text)
        MsgBox("Day of the year: " & _
          DateTimePicker1.Value.DayOfYear.ToString())
    End Sub
End Class