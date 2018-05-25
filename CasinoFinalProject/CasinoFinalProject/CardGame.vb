'Aditya Bhatia
'Card Game
'5/21/2018
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
            btnNext.Visible = True
        ElseIf Winner(playerTotal, computerTotal) = "Computer" Then
            Me.lblWinner.Text = "Computer won!"
        Else
            Me.lblWinner.Text = "It's a draw!"
        End If

    End Sub

    'Displays a card corresponding to a random number in the range 1 to 10.
    '
    'post: picCard now displays a card in the range 1 to 10 and 
    'total score has been updated.
    '
    Sub DealCard(ByRef picCard As PictureBox, ByRef total As Integer)
        My.Computer.Audio.Play(My.Resources.card_shuffle, AudioPlayMode.Background)
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
        My.Computer.Audio.Play(My.Resources.card_snap, AudioPlayMode.Background)
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

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        GlobalVariables.Game6Passed = True
        GlobalVariables.Money += 500
        Me.Hide()
        frmMainCasinoRoom.Show()
    End Sub

    Private Sub picComputerCard2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picComputerCard2.Click, picComputerCard1.Click, picComputerCard3.Click
        GlobalVariables.Game6Passed = True
        GlobalVariables.Money += 500
        Me.Hide()
        frmMainCasinoRoom.Show()
    End Sub
End Class