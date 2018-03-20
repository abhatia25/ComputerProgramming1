'Aditya Bhatia
'Intro To Loops
'3/14/2018
Public Class frmIntroToLoops
    Private Sub btnSumOddNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumOddNumbers.Click
        Dim max As Integer = Val(Me.txtMaxValue.Text)
        Dim sum As Integer
        Dim increment As Integer = 2

        For counter As Integer = 1 To max Step increment
            sum += counter   'update sum
        Next counter

        'Display answer
        Me.lblSumMessage.Text = "The sum of the odd numbers from 1 to the maximum value is:"
        Me.lblSum.Text = sum
    End Sub

    Private Sub txtMaxValue_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaxValue.TextChanged
        Me.lblSumMessage.Text = Nothing
        Me.lblSum.Text = Nothing
    End Sub
End Class