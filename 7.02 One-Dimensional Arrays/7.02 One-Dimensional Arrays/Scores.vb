'Aditya Bhatia
'Scores
'5/8/2018
Public Class frmScores
    Dim dblScores(2) As Double
    Private Sub btnAddScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddScore.Click
        Dim dblAverage As Double = 0

        For i As Integer = 0 To dblScores.Length - 1
            dblScores(i) = InputBox("Please enter a number", "Number ")
        Next i

        For i As Integer = 0 To dblScores.Length - 1
            lstScores.Items.Add(dblScores(i))
        Next i

        findAverage(dblScores, dblAverage)
        lblAverage.Text = "The average is " & dblAverage
    End Sub

    Sub findAverage(ByVal dblScores() As Double, ByRef dblAverage As Double)
        dblAverage = (dblScores(0) + dblScores(1) + dblScores(2)) / 3
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmTrackTemperatures.Show()
    End Sub
End Class