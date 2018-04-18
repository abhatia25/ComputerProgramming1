'Aditya Bhatia
'Card Game
'4/17/2018
Public Class frmCardGame
    Private Sub btnPlayGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayGame.Click
        Static playerScore As Integer = 0
        Static computerScore As Integer = 0
        Static drawsScore As Integer = 0
        Dim playerTotal As Integer, computerTotal As Integer

        Call DealCard(Me.picPlayerCard1, playerTotal)
        Call DealCard(Me.picPlayerCard2, playerTotal)
        Call DealCard(Me.picPlayerCard3, playerTotal)
        Me.lblPlayerPoints.Text = playerTotal

        Call DealCard(Me.picComputerCard1, computerTotal)
        Call DealCard(Me.picComputerCard2, computerTotal)
        Call DealCard(Me.picComputerCard3, computerTotal)
        Me.lblComputerPoints.Text = computerTotal

        If Winner(playerTotal, computerTotal) = "Player" Then
            Me.lblWinner.Text = "You won!"
            Call UpdateScore(playerScore)
        ElseIf Winner(playerTotal, computerTotal) = "Computer" Then
            Me.lblWinner.Text = "Computer won!"
            Call UpdateScore(computerScore)
        Else
            Me.lblWinner.Text = "It's a draw!"
            Call UpdateScore(drawsScore)
        End If

        Call ShowScore(Me.lblScore, playerScore, computerScore, drawsScore)
    End Sub

    'Displays a card corresponding to a random number in the range 1 to 10.
    '
    'post: picCard now displays a card in the range 1 to 10 and 
    'total score has been updated.
    '
    Sub DealCard(ByRef picCard As PictureBox, ByRef total As Integer)
        Dim cardNum As Integer = RndInt(1, 10)
        Select Case cardNum
            Case 1
                picCard.BackgroundImage = My.Resources.card1
            Case 2
                picCard.BackgroundImage = My.Resources.card2
            Case 3
                picCard.BackgroundImage = My.Resources.card3
            Case 4
                picCard.BackgroundImage = My.Resources.card4
            Case 5
                picCard.BackgroundImage = My.Resources.card5
            Case 6
                picCard.BackgroundImage = My.Resources.card6
            Case 7
                picCard.BackgroundImage = My.Resources.card7
            Case 8
                picCard.BackgroundImage = My.Resources.card8
            Case 9
                picCard.BackgroundImage = My.Resources.card9
            Case 10
                picCard.BackgroundImage = My.Resources.card10
        End Select

        total += cardNum
    End Sub

    'Calculates a random number between lowNum and highNum.
    '
    'post: a number between lowNum and highNum has been returned.
    '
    Function RndInt(ByVal lowNum As Integer, ByVal highNum As Integer) As Integer
        Randomize()
        Return Int((highNum - lowNum + 1) * Rnd() + lowNum)
    End Function

    'Returns a string indicating the winner.
    '
    'post: The winner has been returned.
    '
    Function Winner(ByVal playerTotal As Integer, ByVal compTotal As Integer) As String
        If playerTotal = compTotal Then
            Return "Draw"
        ElseIf compTotal > playerTotal Then
            Return "Computer"
        Else
            Return "Player"
        End If
    End Function

    'Updates the score of winner.
    '
    'post: winner score has been increased by WIN_POINTS.
    '
    Sub UpdateScore(ByRef winner As Integer)
        Const WIN_POINTS As Integer = 1
        winner += WIN_POINTS
    End Sub

    'Displays the current score of Player, Computer, and draws.
    '
    'post: scores have been displayed in a label.
    '
    Sub ShowScore(ByRef lblLabel As Label, ByVal playerScore As Integer, ByVal compScore As Integer, ByVal drawsScore As Integer)
        lblScore.Text = "You: " & playerScore & vbCrLf _
            & "Computer: " & compScore & vbCrLf _
            & "Draws: " & drawsScore
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmDiceGame.Show()
    End Sub
End Class