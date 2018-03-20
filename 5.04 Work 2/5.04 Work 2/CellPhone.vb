'Aditya Bhatia
'Cell Phone
'3/19/2018
Public Class frmCellPhone
    Const monthlyFee As Double = 9.95
    Dim minutesCostPerMinute As Double = 0
    Dim taxes As Decimal = 0
    Dim totalCharge As Decimal = 0
    Dim minutesUsed As Double = 0
    Dim minutesCost As Double = 0

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            minutesUsed = txtMinutes.Text
            Select Case minutesUsed
                Case 0 To 200
                    minutesCostPerMinute = 0
                Case 201 To 300
                    minutesCostPerMinute = 0.17
                Case 300 To 500
                    minutesCostPerMinute = 0.15
                Case > 500
                    minutesCostPerMinute = 0.12
            End Select
            minutesCost = minutesCostPerMinute * minutesUsed
            taxes = 0.07 * (minutesCost + monthlyFee)
            totalCharge = minutesCost + taxes + monthlyFee
            lblAnswer.Text = "Regular Fee : $" & monthlyFee & vbCrLf & "Minutes Cost: $" & minutesCost & vbCrLf & "Taxes: $" & taxes & vbCrLf & "Total Charge: $" & totalCharge
        Catch ex As Exception
            MessageBox.Show("Enter in numerical format")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmQuickCuts.Visible = True
    End Sub
End Class