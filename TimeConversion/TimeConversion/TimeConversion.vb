'Aditya Bhatia
'Time Conversion
'4/20/2018
Public Class frmTimeConversion
    Dim dblMinutes As Double = 0
    Dim strMinutes As String = Nothing
    Dim dblSeconds As Double = 0
    Dim strSeconds As String = Nothing
    Dim dblHoursFormat As Double = 0
    Dim dblMinutesFormat As Double = 0
    Dim strHoursFormat As String = Nothing
    Dim strMinutesFormat As String = Nothing

    Private Sub radMinToSec_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMinToSec.CheckedChanged
        strMinutes = txtTime.Text

        If Double.TryParse(strMinutes, dblMinutes) Then
            dblSeconds = dblMinutes * 60
            strSeconds = dblSeconds.ToString
            lblAnswer.Text = "The time in seconds is: " & strSeconds
        Else
            MessageBox.Show("Please enter minutes in numerical format")
        End If
    End Sub

    Private Sub radHourMinFormat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radHourMinFormat.CheckedChanged
        strMinutes = txtTime.Text

        If Double.TryParse(strMinutes, dblMinutes) Then
            dblHoursFormat = dblMinutes \ 60
            dblMinutesFormat = dblMinutes Mod 60
            strHoursFormat = dblHoursFormat.ToString
            strMinutesFormat = dblMinutesFormat.ToString
            lblAnswer.Text = "The time in hour minute format is: " & strHoursFormat & ":" & strMinutesFormat
        Else
            MessageBox.Show("Please enter minutes in numerical format")
        End If
    End Sub
End Class
