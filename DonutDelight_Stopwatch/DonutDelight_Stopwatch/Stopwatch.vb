'Aditya Bhatia
'Stopwatch
'2/21/2018
Public Class frmStopwatch
    Private stopwatch As New Stopwatch
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        lblStopwatch.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", _
        Math.Floor(elapsed.TotalHours), _
        elapsed.Minutes, elapsed.Seconds, _
        elapsed.Milliseconds)
    End Sub
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Timer1.Start()
        Me.stopwatch.Start()
        btnReset.Enabled = False
    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Me.stopwatch.Reset()
        lblStopwatch.Text = "00:00:00:00"
        lbxStopwatchTimes.Items.Clear()
    End Sub
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Timer1.Stop()
        Me.stopwatch.Stop()
        btnReset.Enabled = True
    End Sub
    Private Sub btnMark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMark.Click
        lbxStopwatchTimes.Items.Add(lbxStopwatchTimes.Items.Count + 1 & " " & lblStopwatch.Text)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a great day!")
        End
    End Sub

    Private Sub DonutDelightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonutDelightToolStripMenuItem.Click
        Me.Visible = False
        frmDonutDelight.Visible = True
    End Sub
End Class