'Aditya Bhatia
'Progress Bar Practice
'2/21/2018
Public Class frmProgressBarPractice

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            lblMessage.Text = "Hello"
        End If
        lblProgress.Text = ProgressBar1.Value & ("%")
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Timer1.Stop()
        ProgressBar1.Value = 0
        lblMessage.Text = "Visual Basic"
        lblProgress.Text = "0%"
    End Sub
End Class
