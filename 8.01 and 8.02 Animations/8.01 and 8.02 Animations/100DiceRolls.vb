'Aditya Bhatia
'100 Dice Rolls
'5/14/2018
Public Class frm100DiceRolls
    Private Sub btn100DiceRolls_Click(ByVal sender As System.Object,ByVal e As System.EventArgs) Handles btn100DiceRolls.Click
        Const NUM_ROLLS As Integer = 100
        Dim btnItems() As Button = {Me.btn0, Me.btn1, Me.btn2, Me.btn3, Me.btn4, Me.btn5, Me.btn6, Me.btn7, Me.btn8, Me.btn9, Me.btn10, Me.btn11, Me.btn12, Me.btn13, Me.btn14, Me.btn15}
        Dim boardSquares(btnItems.Length) As Integer
        'the board spots
        CountTrials(NUM_ROLLS, boardSquares, btnItems)
        DisplayCounts(boardSquares, btnItems)
    End Sub
    'Counts the total number of times each spot (button) on a game board was landed on
    'beginning from the Start location and moving around the board clockwise. Each move 
    'is determined by rolling a pair of dice and the count is maintained in the array
    'boardSquares(). The application simulates 100 dice rolls.
    '
    'post: boardSquares() stores the total number of times each corresponding spot
    'on a game board was landed on based on dice rolls simulated 100 times moving around
    'the board clockwise from the Start location.
    '
    Sub CountTrials(ByVal numRolls As Integer, ByRef boardSquares() As Integer, ByRef btnItems() As Button)
        Dim rollOne, rollTwo, rollOutcome As Integer
        Dim offset, currentLocation As Integer
        currentLocation = 0
        For roll As Integer = 0 To (numRolls - 1)
            rollOne = RndInt(1, 6)
            rollTwo = RndInt(1, 6)
            rollOutcome = rollOne + rollTwo
            'Account for the last spot before landing on Start again
            If ((rollOutcome + currentLocation) > (btnItems.Length - 1)) Then
                offset = rollOutcome + currentLocation - btnItems.Length
            Else
                offset = rollOutcome + currentLocation
            End If
            'Count the number of times this spot has been landed on
            boardSquares(offset) += 1
            currentLocation = offset
        Next roll
    End Sub
    'Displays the total number of times each spot (button) on the Game Board was landed
    'on based on 100 dice rolls.
    '
    'post: The element values in the boardSquares array, which stores the total
    'number of times each spot was landed on, has been displayed on the corresponding button
    'on the form.
    '
    Sub DisplayCounts(ByRef boardSquares() As Integer, ByRef btnItems() As Button)
        For item As Integer = 0 To boardSquares.Length - 2
            btnItems(item).Text = boardSquares(item)
        Next item
    End Sub
    'Calculates a random number between lowNum and highNum.
    '
    'post: a number between lowNum and highNum has been returned.
    '
    Function RndInt(ByVal lowNum As Integer, ByVal highNum As Integer)
        Randomize()
        Return Int((highNum - lowNum + 1) * Rnd() + lowNum)
    End Function

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmHotAirBalloon.Show()
    End Sub
End Class