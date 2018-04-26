'Aditya Bhatia
'Dice Rolls
'4/24/2018
'Rolls three dice (total of 18 possible numbers)
'counts the times a number came up, puts it in a list box.
'in the listbox the numbers on the right add up to the number entered in the textbox
'the number 10 comes up most often
Public Class frmDiceRolls
    Private Sub btnRollDice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRollDice.Click
        Dim counts(18) As Integer
        Dim numRolls As Integer = Val(Me.txtRolls.Text)
        Call CountTrials(numRolls, counts)
        Call DisplayRollsCounts(counts, Me.lstRollsOutcomes)
    End Sub
    'Simulates numRolls rolls of three dice and keeps a count of the
    'outcomes.
    'pre: counts has elements with at least index values 2 through 18.
    'post: numRolls dice rolls have been simulated. Counts of numRolls
    'simulated dice rolls has been stored in counts.
    Sub CountTrials(ByVal numRolls As Integer, ByRef counts() As Integer)
        Dim rollOutcome As Integer
        Randomize()
        For roll As Integer = 1 To numRolls
            rollOutcome = (Int(6 * Rnd() + 1)) + (Int(6 * Rnd() + 1)) +
            (Int(6 * Rnd() + 1))
            counts(rollOutcome) += 1
        Next roll
    End Sub
    'Displays the contents of counts() in a list box.
    '
    'pre: counts has elements with at least index values 2 through 18.
    'post: Elements of counts() have been displayed in a list box.
    '
    Sub DisplayRollsCounts(ByRef counts() As Integer, ByRef lstList As ListBox)
        For rollOutcome As Integer = 2 To 18
            lstList.Items.Add(rollOutcome & vbTab & counts(rollOutcome))
        Next rollOutcome
    End Sub
    Private Sub txtRolls_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRolls.TextChanged
        Me.lstRollsOutcomes.Items.Clear()
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmReasons.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class