'Aditya Bhatia
'Bank Protection
Public Class frmThanksFeedback

    Private Sub btnEndSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndSubmit.Click
        If chkAverage.Checked Or chkBad.Checked Or chkGood.Checked Then
            MessageBox.Show("Thanks for the feedback!" & vbCrLf & "Have a nice day!")
            End
        Else
            MessageBox.Show("Have a nice day!")
            End
        End If
    End Sub
End Class