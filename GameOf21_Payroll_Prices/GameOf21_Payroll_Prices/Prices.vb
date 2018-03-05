'Aditya Bhatia
'Prices
'2/21/2018
Public Class frmPrices
    Private Sub btnPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrice.Click
        Dim copies As Integer
        Dim price As Decimal

        copies = Val(Me.txtNumCopies.Text)

        'Calculate price based on the number of copies
        Me.lblPerCopyLabel.Text = "Price per copy is $"
        If copies >= 1000 Then          '1000 copies or more, price is .25 per copy
            price = 0.25
            Me.lblPerCopyAnswer.Text = "0.25"
        ElseIf copies >= 750 Then       '750-999 copies, price is .27 per copy
            price = 0.27
            Me.lblPerCopyAnswer.Text = "0.27"
        ElseIf copies >= 500 Then       '500-749 copies, price is .28 per copy
            price = 0.28
            Me.lblPerCopyAnswer.Text = "0.28"
        Else                            '0-499 copies, price is .30 per copy
            price = 0.3
            Me.lblPerCopyAnswer.Text = "0.30"
        End If

        Me.lblTotalLabel.Text = "The total price is $"
        Me.lblTotalPriceAnswer.Text = price * copies
    End Sub

    Private Sub txtNumCopies_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumCopies.TextChanged
        Me.lblPerCopyLabel.Text = Nothing
        Me.lblPerCopyAnswer.Text = Nothing
        Me.lblTotalLabel.Text = Nothing
        Me.lblTotalPriceAnswer.Text = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
        Application.Exit()
    End Sub

    Private Sub GameFo21ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameFo21ToolStripMenuItem.Click
        Me.Visible = False
        frmGameOf21.Visible = True
    End Sub

    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click
        Me.Visible = False
        frmPayroll.Visible = True
    End Sub
End Class