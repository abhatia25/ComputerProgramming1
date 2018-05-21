'Aditya Bhatia
'Timer
'5/21/2018
Public Class Timer

    Private Sub tmrTimeLeft_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimeLeft.Tick
        If prgTimeLeft.Value > 0 Then
            ' Display the new time left
            ' by updating the Time Left label.
            prgTimeLeft.Value -= 1
        End If

    End Sub

    Private Sub Timer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prgTimeLeft.Value = 100
        tmrTimeLeft.Start()
    End Sub
End Class