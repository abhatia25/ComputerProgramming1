'Aditya Bhatia
'Guess It
'4/24/2018
Public Class frmGuessIt
    Dim intCorrectAnswer As Integer
    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        Hint()
    End Sub
    Private Sub Hint()
        Dim strUserGuess As String
        Dim dblUserGuess As Double

        strUserGuess = txtJellyBeansGuess.Text

        If Double.TryParse(strUserGuess, dblUserGuess) Then
            If intCorrectAnswer = dblUserGuess Then
                lblResult.Text = "You guessed it!"
            ElseIf intCorrectAnswer > dblUserGuess Then
                lblResult.Text = "Too low"
            Else
                lblResult.Text = "Too high"
            End If
        Else
            MessageBox.Show("Please enter a number")
        End If
    End Sub

    Private Sub frmCandyJar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        intCorrectAnswer = Rnd() * 300
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmCandy.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class