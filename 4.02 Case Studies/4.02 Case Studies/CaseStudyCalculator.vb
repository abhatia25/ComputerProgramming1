'Aditya Bhatia
'Case Study Calculator
'2/26/2018
Public Class frmCaseStudyCalculator

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NumberOfDigitsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberOfDigitsToolStripMenuItem.Click
        Me.Visible = False
        frmNumberOfDigits.Visible = True
    End Sub

    Private Sub ShellGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShellGameToolStripMenuItem.Click
        Me.Visible = False
        frmShellGame.Visible = True
    End Sub

    Private Sub txtOperand1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperand1.TextChanged
        Me.radAddition.Checked = False 'all radiobuttons unchecked when user begins to type
        Me.radDivision.Checked = False
        Me.radExponentiation.Checked = False
        Me.radMultiplication.Checked = False
        Me.radIntDivision.Checked = False
        Me.radModDivision.Checked = False
        Me.radSubtraction.Checked = False
        Me.lblExpressionValue.Text = Nothing 'clear label when user begins to type

    End Sub

    Private Sub txtOperand2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOperand2.TextChanged
        Me.radAddition.Checked = False
        Me.radDivision.Checked = False
        Me.radExponentiation.Checked = False
        Me.radIntDivision.Checked = False
        Me.radModDivision.Checked = False
        Me.radMultiplication.Checked = False
        Me.radSubtraction.Checked = False
        Me.lblExpressionValue.Text = Nothing

    End Sub

    Private Sub radExponentiation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radExponentiation.CheckedChanged
        Dim sngAnswer As Single 'sngAnswer is declared as single
        sngAnswer = Val(Me.txtOperand1.Text) ^ Val(Me.txtOperand2.Text) 'sngAnswer is assigned to the value of txtOperand1 ^ the value of txtOperand2
        Me.lblExpressionValue.Text = sngAnswer 'display value of sngAnswer in lblExpressionValue

    End Sub

    Private Sub radMultiplication_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMultiplication.CheckedChanged
        Dim sngAnswer As Single
        sngAnswer = Val(Me.txtOperand1.Text) * Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngAnswer
    End Sub

    Private Sub radDivision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDivision.CheckedChanged
        Dim sngAnswer As Single
        sngAnswer = Val(Me.txtOperand1.Text) / Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngAnswer
    End Sub

    Private Sub radIntDivision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radIntDivision.CheckedChanged
        Dim sngAnswer As Single
        sngAnswer = Val(Me.txtOperand1.Text) \ Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngAnswer
    End Sub

    Private Sub radModDivision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radModDivision.CheckedChanged
        Dim sngAnswer As Single
        sngAnswer = Val(Me.txtOperand1.Text) Mod Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngAnswer
    End Sub

    Private Sub radAddition_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddition.CheckedChanged
        Dim sngAnswer As Single
        sngAnswer = Val(Me.txtOperand1.Text) + Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngAnswer
    End Sub

    Private Sub radSubtraction_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSubtraction.CheckedChanged
        Dim sngAnswer As Single
        sngAnswer = Val(Me.txtOperand1.Text) - Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngAnswer
    End Sub

End Class
