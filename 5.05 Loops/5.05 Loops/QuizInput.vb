'Aditya Bhatia
'Quiz Input
'3/23/2018
Public Class frmQuizInput
    Dim input As String = Nothing
    Dim good As Boolean = False

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmTestScores.Visible = True
    End Sub

    Private Sub btnCheckInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckInput.Click
        input = InputBox("Please enter A, B, C, or D, or Q to quit", "User Input")
        Do
            Select Case input
                Case "A"
                    MessageBox.Show("You entered an A")
                    good = True
                    End
                Case "B"
                    MessageBox.Show("You entered an B")
                    good = True
                    End
                Case "C"
                    MessageBox.Show("You entered an C")
                    good = True
                    End
                Case "D"
                    MessageBox.Show("You entered an D")
                    good = True
                    End
                Case "Q"
                    good = True
                    End
                Case Else
                    input = InputBox("Please enter A, B, C, or D, or Q to quit", "User Input")
                    good = False
            End Select
        Loop Until good = True
    End Sub
End Class