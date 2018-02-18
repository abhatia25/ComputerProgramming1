'Aditya Bhatia
'Simple Dice Rolling
'2/15/2018
Public Class frmSimpleDiceRolling

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
    End Sub

    Private Sub ElseIfToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElseIfToolStripMenuItem.Click
        Me.Visible = False
        frmElseIf.Visible = True
    End Sub

    Private Sub SumOf4NumbersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumOf4NumbersToolStripMenuItem.Click
        Me.Visible = False
        frmSumof4Numbers.Visible = True
    End Sub

    Private Sub SimpleCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleCalculatorToolStripMenuItem.Click
        Me.Visible = False
        frmSimpleCalculator.Visible = True
    End Sub
    Private Sub btnRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoll.Click
        If cmbDieSize.Text = String.Empty Then
            MessageBox.Show("Please choose the size of die you wish to roll", "Error") 'Quick error handling in case the user tries to roll without selecting a die size
        Else
            Dim oDice As New Random 'Choses random number for dice value
            Dim iDieSize As Integer = CInt(cmbDieSize.Text) 'Sets Dice Size as Integer
            Dim iDiceResult As Integer = oDice.Next(1, iDieSize + 1)
            lstDiceRolls.Items.Add("D" & iDieSize.ToString & ControlChars.Tab & iDiceResult.ToString) 'Creates dice string to be added to listbox
        End If
    End Sub
    Private Sub frmD6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstDiceRolls.Items.Add("Size" & ControlChars.Tab & "Roll") 'Adds titles to listbox
    End Sub

End Class