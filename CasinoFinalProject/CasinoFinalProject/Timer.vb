Public Class Timer
    Dim timeLeft As Integer

    Private Sub tmrTimeLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeLeft.Tick
        Do Until timeLeft = 0
            ' Display the new time left
            ' by updating the Time Left label.
            timeLeft -= 1
            lblTimer.Text = timeLeft & " seconds"
        Loop

    End Sub

    Private Sub Timer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timeLeft = 5 * 60
        lblTimer.Text = timeLeft & " seconds"
        tmrTimeLeft.Start()
    End Sub
End Class