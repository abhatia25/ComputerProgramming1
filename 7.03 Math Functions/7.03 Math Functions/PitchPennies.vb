'Aditya Bhatia
'Pitch Pennies
'5/10/2018
Public Class frmPitchPennies
    Const PUZZLE As String = "Puzzle"
    Const GAME As String = "Game"
    Const BALL As String = "Ball"
    Const POSTER As String = "Poster"
    Const DOLL As String = "Doll"
    Const NUM_SQUARES As Integer = 25 'number of squares on interface
    Dim board(NUM_SQUARES) As String
    Dim puzzleCount As Integer
    Dim gameCount As Integer
    Dim ballCount As Integer
    Dim posterCount As Integer
    Dim dollCount As Integer
    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        Me.btnTossPennies.Enabled = True
        Call Reset()
        Call LoadPrizes()
        Call LoadButtons()
    End Sub
    'Reset game for a new game.
    '
    'post: The Text property on every button on the interface has been cleared, all
    'counter variables for the prizes have been reset to 0, and each element of the
    'board array has been initialized with Nothing.
    '
    Sub Reset()
        'Reset prize counters
        puzzleCount = 0
        gameCount = 0
        ballCount = 0
        posterCount = 0
        dollCount = 0
        'Clear text on buttons on interface
        Me.btnSquare1.Text = Nothing
        Me.btnSquare2.Text = Nothing
        Me.btnSquare3.Text = Nothing
        Me.btnSquare4.Text = Nothing
        Me.btnSquare5.Text = Nothing
        Me.btnSquare6.Text = Nothing
        Me.btnSquare7.Text = Nothing
        Me.btnSquare8.Text = Nothing
        Me.btnSquare9.Text = Nothing
        Me.btnSquare10.Text = Nothing
        Me.btnSquare11.Text = Nothing
        Me.btnSquare12.Text = Nothing
        Me.btnSquare13.Text = Nothing
        Me.btnSquare14.Text = Nothing
        Me.btnSquare15.Text = Nothing
        Me.btnSquare16.Text = Nothing
        Me.btnSquare17.Text = Nothing
        Me.btnSquare18.Text = Nothing
        Me.btnSquare19.Text = Nothing
        Me.btnSquare20.Text = Nothing
        Me.btnSquare21.Text = Nothing
        Me.btnSquare22.Text = Nothing
        Me.btnSquare23.Text = Nothing
        Me.btnSquare24.Text = Nothing
        Me.btnSquare25.Text = Nothing
        Me.lblAnswer.Text = Nothing
        'Clear the array
        For index As Integer = 0 To board.Length - 1
            board(index) = Nothing
        Next index
    End Sub
    'Stores prize names in board array.
    '
    'post: Three prize names of each prize (Puzzle, Game, Ball, Poster, Doll)
    'have been randomly stored in board array.
    '
    Sub LoadPrizes()
        Call LoadPiece(PUZZLE) 'fill 3 squares with Puzzle
        Call LoadPiece(GAME) 'fill 3 squares with Game
        Call LoadPiece(BALL)
        Call LoadPiece(POSTER) 'fill 3 squares with Poster
        Call LoadPiece(DOLL)
        'fill 3 squares with Ball
        'fill 3 squares with Doll
    End Sub
    'Stores a prize name in board array.
    '
    'post: Three prizes of prize have been stored in the array
    '
    Sub LoadPiece(ByVal prize As String)
        Dim randomNum As Integer
        Dim count As Integer = 0
        Do
            randomNum = RndInt(0, 24)
            If board(randomNum) = Nothing Then
                board(randomNum) = prize
                count += 1
            End If
        Loop While count < 3
    End Sub
    'Display the prizes, stored in board array, on the buttons on the interface.
    '
    'post: Prize names or Nothing have been displayed on buttons.
    '
    Sub LoadButtons()
        Me.btnSquare1.Text = board(0)
        Me.btnSquare2.Text = board(1)
        Me.btnSquare3.Text = board(2)
        Me.btnSquare4.Text = board(3)
        Me.btnSquare5.Text = board(4)
        Me.btnSquare6.Text = board(5)
        Me.btnSquare7.Text = board(6)
        Me.btnSquare8.Text = board(7)
        Me.btnSquare9.Text = board(8)
        Me.btnSquare10.Text = board(9)
        Me.btnSquare11.Text = board(10)
        Me.btnSquare12.Text = board(11)
        Me.btnSquare13.Text = board(12)
        Me.btnSquare14.Text = board(13)
        Me.btnSquare15.Text = board(14)
        Me.btnSquare16.Text = board(15)
        Me.btnSquare17.Text = board(16)
        Me.btnSquare18.Text = board(17)
        Me.btnSquare19.Text = board(18)
        Me.btnSquare20.Text = board(19)
        Me.btnSquare21.Text = board(20)
        Me.btnSquare22.Text = board(21)
        Me.btnSquare23.Text = board(22)
        Me.btnSquare24.Text = board(23)
        Me.btnSquare25.Text = board(24)
    End Sub
    'Pitches ten pennies onto a 5 x 5 board of 25 buttons and counts which squares are
    'landed on.
    '
    'post: Ten pennies have been pitched onto the 5 x 5 board and displayed with an x on the
    'buttons and counter variables for each of the prizes have been updated if a penny is
    'pitched on that square.
    '
    Private Sub btnTossPennies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTossPennies.Click
        Dim toss As Integer
        Me.btnTossPennies.Enabled = False
        For index As Integer = 1 To 10
            toss = RndInt(0, 24)
            board(toss) &= " x "
        Next index
        'get which square penny pitched onto
        'mark interface with x for a penny
        Call DeterminePrizes()
    End Sub
    'Displays the names of the prizes won or No prizes.
    '
    'post: The names of the prizes won have been displayed on the interface or No prizes
    'has been displayed.
    '
    Sub DeterminePrizes()
        Dim marking As String
        Dim firstTwoChars As String
        Dim lastChar As String
        Call LoadButtons()
        For index As Integer = 0 To 24
            marking = board(index) 'get name of prize or Nothing on square
            If marking <> Nothing Then
                lastChar = marking.Substring(marking.Length - 2, 1)
                If lastChar = "x" Then
                    firstTwoChars = marking.Substring(0, 2) 'get first two characters of text, if any
                    Select Case firstTwoChars
                        'update counters
                        Case "Pu"
                            puzzleCount += 1
                        Case "Ga"
                            gameCount += 1
                        Case "Ba"
                            ballCount += 1
                        Case "Po"
                            posterCount += 1
                        Case "Do"
                            dollCount += 1
                    End Select
                End If
            End If
        Next index
        If puzzleCount < 3 And gameCount < 3 And ballCount < 3 And _
        posterCount < 3 And dollCount < 3 Then
            Me.lblAnswer.Text = "No prizes."
        Else
            Me.lblAnswer.Text = "Prizes won: "
            If puzzleCount >= 3 Then
                Me.lblAnswer.Text &= "puzzle "
            End If
            If gameCount >= 3 Then
                Me.lblAnswer.Text &= "game "
            End If
            If ballCount >= 3 Then
                Me.lblAnswer.Text &= "ball "
            End If
            If posterCount >= 3 Then
                Me.lblAnswer.Text &= "poster "
            End If
            If dollCount >= 3 Then
                Me.lblAnswer.Text &= "doll "
            End If
        End If
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