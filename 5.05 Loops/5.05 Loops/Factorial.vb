'Aditya Bhatia
'Factorial
'3/20/2018
Public Class frmFactorial

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmUnlock.Visible = True
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim NumberToCalc As Integer
        Dim factorial As Double = 1
        NumberToCalc = InputBox("Please enter a number", "Factorial Number")

        For variable As Integer = 1 To NumberToCalc
            factorial *= variable
        Next variable
        lblAnswer.Text = "Factorial is " & factorial
    End Sub
End Class