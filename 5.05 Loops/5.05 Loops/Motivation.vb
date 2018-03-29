'Aditya Bhatia
'Motivation
'3/23/2018
Public Class frmMotivation
    Dim messageTimes As Integer = 0
    Dim MessageTimesDisplayed As Integer = 0

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmQuizInput.Visible = True
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        lblAnswer.Text = ""
        messageTimes = InputBox("Please enter the number of times you would like the message displayed (Must be between 1 and 10)", "User Input")
        Do Until MessageTimesDisplayed = messageTimes
            lblAnswer.Text &= "Study More!" & vbCrLf
            MessageTimesDisplayed += 1
        Loop
    End Sub
End Class