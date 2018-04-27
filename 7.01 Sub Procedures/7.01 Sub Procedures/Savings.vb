'Aditya Bhatia
'Savings
'4/26/2018
Public Class frmSavings
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmBacteriaGrowth.Show()
    End Sub

    Private Sub calcDeposit(ByRef dblTotalSavings As Double, ByVal dblSavingsAmount As Double, ByVal intSavingsTime As Integer)
        dblTotalSavings = dblSavingsAmount * intSavingsTime
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim dblSavingsAmount As Double
            Dim dblTotalSavings As Double
            Dim intSavingsTime As Integer
            intSavingsTime = Convert.ToInt32(txtSavingsTime.Text)
            dblSavingsAmount = Convert.ToDouble(txtSavingsAmount.Text)
            calcDeposit(dblTotalSavings:=dblTotalSavings, dblSavingsAmount:=dblSavingsAmount, intSavingsTime:=intSavingsTime)
            lblAnswer.Text = "You deposited a total amount of " & Format(dblTotalSavings, "Currency")
        Catch ex As Exception
            MessageBox.Show("Enter numerical values")
        End Try
    End Sub
End Class