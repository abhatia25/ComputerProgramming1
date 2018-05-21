'Aditya Bhatia
'Rock Paper Scissors
'5/21/2018
Public Class frmRockPaperScissors
    Private Sub btnGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Const ROCK As Integer = 1
        Const PAPER As Integer = 2
        Const SCISSORS As Integer = 3
        Dim computerThrow As Integer

        'Generate computer throw
        Randomize()
        computerThrow = Int(3 * Rnd()) + 1

        If Me.radRock.Checked And computerThrow = ROCK Then
            Me.lblWinner.Text = "Computer throws Rock. It's a Draw!"
        ElseIf Me.radRock.Checked And computerThrow = PAPER Then
            Me.lblWinner.Text = "Computer throws Paper. Computer wins!"
        ElseIf Me.radRock.Checked And computerThrow = SCISSORS Then
            Me.lblWinner.Text = "Computer throws Scissors. You win!"
        End If

        If Me.radPaper.Checked And computerThrow = ROCK Then
            Me.lblWinner.Text = "Computer throws Rock. You win!"
        ElseIf Me.radPaper.Checked And computerThrow = PAPER Then
            Me.lblWinner.Text = "Computer throws Paper. It's a draw!"
        ElseIf Me.radPaper.Checked And computerThrow = SCISSORS Then
            Me.lblWinner.Text = "Computer throws Scissors. Computer wins!"
        End If

        If Me.radScissors.Checked And computerThrow = ROCK Then
            Me.lblWinner.Text = "Computer throws Rock. Computer wins!"
        ElseIf Me.radScissors.Checked And computerThrow = PAPER Then
            Me.lblWinner.Text = "Computer throws Paper. You win!"
        ElseIf Me.radScissors.Checked And computerThrow = SCISSORS Then
            Me.lblWinner.Text = "Computer throws Scissors. It's a draw!"
        End If

    End Sub
End Class