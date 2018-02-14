'Aditya Bhatia
'2/6/2018
'Calculations
Public Class frmCalculations
    Private Sub btnExpression1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpression1.Click
        Me.lblExpression1.Text = 5 + 2 ^ 3 'Performs Calculation for expression
    End Sub

    Private Sub btnExpression2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpression2.Click
        Me.lblExpression2.Text = 4 / 2 + 5
    End Sub

    Private Sub btnExpression3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpression3.Click
        Me.lblExpression3.Text = 3 + 4 * 2
    End Sub

    Private Sub btnExpression4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpression4.Click
        Me.lblExpression4.Text = 7 - 3 + 2
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MsgBox("Have a good day!") '
        End
    End Sub
End Class
