'Aditya Bhatia
'Rates
'5/7/2018
Public Class frmRates

    Private Sub btnDisplayRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayRate.Click
        Dim dblRates(4) As Double

        dblRates(0) = 2.3
        dblRates(1) = 2.2
        dblRates(2) = 2.0
        dblRates(3) = 2.1
        dblRates(4) = 2.4

        lblAnswer.Text = "The lowest rate is " & dblRates(2) & ".00%"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmBirthdays.Show()
    End Sub
End Class
