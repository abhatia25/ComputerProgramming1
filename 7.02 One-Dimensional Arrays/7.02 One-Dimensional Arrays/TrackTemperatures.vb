'Aditya Bhatia
'Track Temperatures
'5/8/2018
Public Class frmTrackTemperatures
    Dim Temperatures(0 To 6) As Single

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        Dim Prompt, Title As String
        Dim i As Short

        Prompt = "Enter the day's high temperature."

        For i = 0 To UBound(Temperatures)
            Title = "Day" & (i + 1)
            Temperatures(i) = InputBox(Prompt, Title)
        Next
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim Result As String
        Dim i As Short
        Dim total As Single = 0
        Result = "High temperatures for the week: " & vbCrLf & vbCrLf
        For i = 0 To UBound(Temperatures)
            Result = Result & "Day " & (i + 1) & vbTab & Temperatures(i) & vbCrLf
            total = total + Temperatures(i)
        Next
        Result = Result & vbCrLf & "Average temperature : " & Format(total / 7, "0.0")
        txtTemps.Text = Result
    End Sub
End Class