'Aditya Bhatia
Public Class frmTestScores
    Dim scoreEntered As Double = 0
    Dim highestScore As Double
    Dim lowestScore As Double
    Dim sumScores As Double = 0
    Dim avgScore As Double = 0
    Dim numScoresEntered As Integer = 0

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub btnEnterScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterScores.Click
        Do Until scoreEntered = -1
            scoreEntered = 0
            scoreEntered = InputBox("Please enter a score", "Scores")
            If highestScore < scoreEntered Then
                highestScore = scoreEntered
            ElseIf lowestScore > scoreEntered And scoreEntered > -1 Then
                lowestScore = scoreEntered
            End If
            sumScores += scoreEntered
            numScoresEntered += 1
        Loop
    End Sub

    Private Sub btnShowStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowStats.Click
        avgScore = sumScores / numScoresEntered
        lblAnswer.Text = "Highest Score: " & highestScore & vbCrLf & "Lowest Score: " & lowestScore & vbCrLf & "Average Score: " & avgScore
    End Sub
End Class