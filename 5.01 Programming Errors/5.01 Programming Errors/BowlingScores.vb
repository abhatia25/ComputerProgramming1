'Aditya Bhatia
'Bowling Scores
'2/27/2018
Public Class frmBowlingScores

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextProgramToolStripMenuItem.Click
        Me.Visible = False
        frmInitials.Visible = True
    End Sub

    Dim high As Integer = 0
    Dim low As Integer = 300
    Dim counter As Integer = 0

    Private Sub btnEnterScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterScores.Click
        Const FLAG As Integer = -1
        Dim score As Integer
        Dim tempScore As String
        Do
            tempScore = InputBox("Enter a bowling score (-1 to finish)", "Bowling Scores")
            If tempScore = Nothing Then 'cancel selected or text box empty
                score = FLAG
            Else
                score = Val(tempScore)
                Select Case score
                    Case 0 To 300       'in the valid range of scores
                        counter += 1
                        If score > high And score <> FLAG Then  'new high score
                            high = score
                        End If

                        If score < low And score <> FLAG Then   'new low score
                            low = score
                        End If
                    Case FLAG           'do nothing, but not an invalid score
                    Case Else           'invalid score
                        MessageBox.Show("Invalid score.")
                End Select
            End If
        Loop While score <> FLAG
    End Sub

    Private Sub btnStatistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatistics.Click
        If counter = 0 Then             'no scores were entered
            MessageBox.Show("Enter scores first.")
        Else                            'display the high and low scores
            Me.lblAnswer.Text = "The high score is " & high & " and the low score is " & low
        End If

    End Sub

End Class