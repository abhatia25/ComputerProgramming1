'Aditya Bhatia
'Payroll
'2/21/2018
Public Class frmPayroll
    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Dim hoursWorked As Integer
        Dim hourlyRate As Decimal
        Dim grossWage As Decimal
        Dim overtime As Integer

        hoursWorked = Val(Me.txtHours.Text)
        hourlyRate = Val(Me.txtRate.Text)

        'Calculate gross wages
        If hoursWorked > 40 Then        'calculate overtime pay
            overtime = hoursWorked - 40
            grossWage = (40 * hourlyRate) + (overtime * (hourlyRate * 1.5))
        Else                            'no overtime pay
            grossWage = hoursWorked * hourlyRate
        End If

        Me.lblAnswerLabel.Text = "Gross wages = $"
        Me.lblAnswer.Text = grossWage
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
        Application.Exit()
    End Sub

    Private Sub GameOf21ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameOf21ToolStripMenuItem.Click
        Me.Visible = False
        frmGameOf21.Visible = True
    End Sub

    Private Sub PricesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PricesToolStripMenuItem.Click
        Me.Visible = False
        frmPrices.Visible = True
    End Sub
End Class