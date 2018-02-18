'Aditya Bhatia
'Sum of 4 Numbers
'2/15/2018
Public Class frmSumof4Numbers

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intNum3 As Integer
        Dim intNum4 As Integer
        Dim intAns As Integer

        intNum1 = Val(txtNum1.Text) 'By adding Val to this statement the text becomes a value
        intNum2 = Val(txtNum2.Text)
        intNum3 = Val(txtNum3.Text)
        intNum4 = Val(txtNum4.Text)

        intAns = intNum1 + intNum2 + intNum3 + intNum4 'always write the answer first

        lblAns.Text = intAns

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNum1.Clear() 'Clear textboxes
        txtNum2.Clear()
        txtNum3.Clear()
        txtNum4.Clear()

        lblAns.Text = "?" 'Text in lblAns changes to ?

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
        End
    End Sub

    Private Sub SimpleDiceRollingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleDiceRollingToolStripMenuItem.Click
        Me.Visible = False 'Hide current form
        frmSimpleDiceRolling.Visible = True 'Show frmSimpleDiceRolling
    End Sub

    Private Sub ElseIfToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElseIfToolStripMenuItem.Click
        Me.Visible = False
        frmElseIf.Visible = True
    End Sub

    Private Sub SimpleCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleCalculatorToolStripMenuItem.Click
        Me.Visible = False
        frmSimpleCalculator.Visible = True
    End Sub
End Class