'Aditya Bhatia
'Guess It
'3/19/2018
Public Class frmGuessIt
    Dim userGuess As Integer = 0
    Dim secretNumber As Integer = 0
    Dim intTries As Integer = 0

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Try
            userGuess = Convert.ToInt32(txtGuess.Text)
            If userGuess > secretNumber Then
                lblAnswer.Text = "Too High"
                intTries = intTries + 1
            ElseIf userGuess < secretNumber Then
                lblAnswer.Text = "Too Low"
                intTries = intTries + 1
            Else
                MessageBox.Show("Great Job! You Guessed It!")
                lblAnswer.Text = "You took " & intTries & " tries"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmGuessIt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        secretNumber = Rnd() * 49
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmMyGrades.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub
End Class