Public Class frmGuessingGame
    Const MIN As Integer = 1
    Const MAX As Integer = 50

    Private Sub btnCheckGuess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckGuess.Click
        Randomize()
        Static secretNumber As Integer = Int((MAX - MIN + 1) * Rnd() + MIN)
        Dim guess As Integer
        Try
            guess = txtPlayerGuess.Text
            If guess = secretNumber Then
                lblMessage.Text = "You Win!"
            Else
                If guess < secretNumber Then
                    lblMessage.Text = "The secret number is higher"
                Else
                    lblMessage.Text = "The secret number is lower"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter the number in digits.")
        End Try
    End Sub
    Private Sub txtPlayerGuess_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlayerGuess.TextChanged
        Me.lblMessage.Text = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextProgramToolStripMenuItem.Click
        Me.Visible = False
        frmRockPaperScissors.Visible = True
    End Sub
End Class
