Public Class frmSimpleCalculator

    Private Sub ElseIfToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElseIfToolStripMenuItem.Click
        Me.Visible = False
        frmElseIf.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
        End
    End Sub

    Private Sub SumOf4NumbersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumOf4NumbersToolStripMenuItem.Click
        Me.Visible = False
        frmSumof4Numbers.Visible = True
    End Sub

    Private Sub SimpleDiceRollingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleDiceRollingToolStripMenuItem.Click
        Me.Visible = False
        frmSimpleDiceRolling.Visible = True
    End Sub
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim num1, num2, difference, product, quotient As Single
        Dim sum As Single

        num1 = txtNum1.Text
        num2 = txtNum2.Text
        sum = num1 + num2
        difference = num1 - num2
        product = num1 * num2
        quotient = num1 / num2
        lblAdd.Text = sum
        lblSub.Text = difference
        lblMult.Text = product
        lblDiv.Text = quotient

    End Sub
End Class