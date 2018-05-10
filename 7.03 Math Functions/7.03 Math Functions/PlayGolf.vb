'Aditya Bhatia
'Play Golf
'5/10/2018
Public Class PlayGolf
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()

    End Sub

    Private Sub btnPlayGolf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayGolf.Click
        Const NUM_GOLFERS As Integer = 4
        Const NUM_HOLES As Integer = 9
        Dim scoreCard(NUM_GOLFERS - 1, NUM_HOLES - 1) As Integer

        Call Reset()

        'Load Scorecard with scores 1 - 9        
        For col As Integer = 0 To scoreCard.GetLength(1) - 1
            For row As Integer = 0 To scoreCard.GetLength(0) - 1
                scoreCard(row, col) = RndInt(1, 9)
            Next row
        Next col

        Call DisplayScorecard(scoreCard)
        Call CalculateWinners(scoreCard)
    End Sub

    'Clears the Scorecard list box and winner display label.
    '
    'post: List box and label on form have been cleared.
    '
    Sub Reset()
        Me.lstList.Items.Clear()
        Me.lblPlayer1Winnings.Text = Nothing
        Me.lblPlayer2Winnings.Text = Nothing
        Me.lblPlayer3Winnings.Text = Nothing
        Me.lblPlayer4Winnings.Text = Nothing
    End Sub

    'Displays the golf scores in the list box from the scoreCard two-dimensional
    'array.
    '
    'post: The list box now displays each player and the corresponding scores for
    'each hole of golf, stored in the scoreCard two-dimensional array.
    '
    Sub DisplayScorecard(ByRef scoreCard(,) As Integer)
        Dim rowScore As String   'each row displaying player and holes

        Me.lstList.Items.Add(vbTab & "Hole 1" & vbTab & "Hole 2" & vbTab &
        "Hole 3" & vbTab & "Hole 4" & vbTab & "Hole 5" & vbTab & "Hole 6" &
        vbTab & "Hole 7" & vbTab & "Hole 8" & vbTab & "Hole 9")

        For row As Integer = 0 To scoreCard.GetLength(0) - 1
            rowScore = Nothing
            For col As Integer = 0 To scoreCard.GetLength(1) - 1
                rowScore &= scoreCard(row, col) & vbTab
            Next col
            Me.lstList.Items.Add("Player " & row + 1 & vbTab & rowScore)
        Next row
    End Sub

    'Calculates and displays the winner of each hole by comparing the scores of 
    'all the players.
    '
    'pre: scoreCard contains scores.
    'post: The holes each player won (determined by having the lowest number of 
    'strokes on that hole) have been displayed in a label.
    '
    Sub CalculateWinners(ByRef scoreCard(,) As Integer)
        Dim winnerRow1 As String = Nothing 'the concatenation of all player 1 wins
        Dim winnerRow2 As String = Nothing 'the concatenation of all player 2 wins
        Dim winnerRow3 As String = Nothing 'the concatenation of all player 3 wins
        Dim winnerRow4 As String = Nothing 'the concatenation of all player 4 wins
        Dim lowScore As Integer
        Dim winnerRow As Integer

        For col As Integer = 0 To scoreCard.GetLength(1) - 1
            lowScore = 9    'initialize to highest stroke value
            For row As Integer = 0 To scoreCard.GetLength(0) - 1   'compare all of the scores
                If lowScore > scoreCard(row, col) Then
                    lowScore = scoreCard(row, col)      'set low score
                    winnerRow = row                     'set player # of low score
                End If
            Next row

            If winnerRow = 0 Then                       'update winner of hole
                winnerRow1 &= "  Hole " & col + 1
            ElseIf winnerRow = 1 Then
                winnerRow2 &= "  Hole " & col + 1
            ElseIf winnerRow = 2 Then
                winnerRow3 &= "  Hole " & col + 1
            Else
                winnerRow4 &= "  Hole " & col + 1
            End If
        Next col

        'Display how many holes each player won overall
        Me.lblPlayer1Winnings.Text = "Player 1 won: " & winnerRow1
        Me.lblPlayer2Winnings.Text = "Player 2 won: " & winnerRow2
        Me.lblPlayer3Winnings.Text = "Player 3 won: " & winnerRow3
        Me.lblPlayer4Winnings.Text = "Player 4 won: " & winnerRow4
    End Sub

    'Calculates a random number between lowNum and highNum.
    '
    'post: a number between lowNum and highNum has been returned.
    '
    Function RndInt(ByVal lowNum As Integer, ByVal highNum As Integer) As Integer
        Randomize()
        Return Int((highNum - lowNum + 1) * Rnd() + lowNum)
    End Function
End Class