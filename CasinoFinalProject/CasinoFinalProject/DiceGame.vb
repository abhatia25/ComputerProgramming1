'Aditya Bhatia
'Dice Game
'5/21/2018
Public Class frmDiceGame
    Dim totalPoints As Integer = 1000

    Private Sub btnRollDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollDice.Click
        Dim risk As Integer = Val(Me.txtRisk.Text)
        Dim total As Integer

        If ValidEntry(risk) Then
            Call RollDice(Me.picDie1, Me.picDie2, total)
            If total Mod 2 = 0 Then     'player loses
                totalPoints -= risk
            Else                        'player wins
                totalPoints += (2 * risk)
            End If

            Me.lblPoints.Text = "Total points = " & totalPoints

            If totalPoints = 0 Then
                MessageBox.Show("Game Over.")
            End If
        End If
    End Sub

    'Gets two random numbers to represent each die and displays the corresponding die
    'image in the picture box objects and calculates the total of the dice.
    '
    'post: the total of roll of dice has been calculated and the picture box objects have been
    'assigned the corresponding dice images.
    '
    Sub RollDice(ByRef picDie1 As PictureBox, ByRef picDie2 As PictureBox, ByRef total As Integer)
        Dim die1 As Integer = RndInt(1, 6)
        Select Case die1
            Case 1
                picDie1.BackgroundImage = My.Resources.die1
            Case 2
                picDie1.BackgroundImage = My.Resources.die2
            Case 3
                picDie1.BackgroundImage = My.Resources.die3
            Case 4
                picDie1.BackgroundImage = My.Resources.die4
            Case 5
                picDie1.BackgroundImage = My.Resources.die5
            Case 6
                picDie1.BackgroundImage = My.Resources.die6
        End Select

        Dim die2 As Integer = RndInt(1, 6)
        Select Case die2
            Case 1
                picDie2.BackgroundImage = My.Resources.die1
            Case 2
                picDie2.BackgroundImage = My.Resources.die2
            Case 3
                picDie2.BackgroundImage = My.Resources.die3
            Case 4
                picDie2.BackgroundImage = My.Resources.die4
            Case 5
                picDie2.BackgroundImage = My.Resources.die5
            Case 6
                picDie2.BackgroundImage = My.Resources.die6
        End Select

        total = die1 + die2
    End Sub

    'Calculates a random number between lowNum and highNum.
    '
    'post: a number between lowNum and highNum has been returned.
    '
    Function RndInt(ByVal lowNum As Integer, ByVal highNum As Integer) As Integer
        Randomize()
        Return Int((highNum - lowNum + 1) * Rnd() + lowNum)
    End Function

    'Determine if player can bet risk points out of the totalPoints that the player owns
    '
    'post: true has been returned if risk had been less than or equal to totalPoints
    'false has been returned if risk had been greater than totalPoints
    '
    Function ValidEntry(ByVal risk As Integer) As Boolean
        If risk > totalPoints Then
            Me.lblPoints.Text = "You may not risk more than " & totalPoints & "."
            Return False
        ElseIf risk <= 0 Then
            Me.lblPoints.Text = "You may not risk less than 1 point."
            Return False
        Else
            Return True
        End If
    End Function
End Class