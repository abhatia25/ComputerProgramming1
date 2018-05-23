'Aditya Bhatia
'Mastermind
'5/21/2018
Public Class frmMastermind
    Const NUM_PEGS As Integer = 3

    Private Sub btnCheckGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckGuess.Click
        Static peg1Color As Integer, peg2Color As Integer, peg3Color As Integer

        Dim peg1Guess As Integer, peg2Guess As Integer, peg3Guess As Integer
        Dim numPegsCorrect As Integer, numColorsCorrect As Integer

        'Determine peg color assignments
        If peg1Color = 0 Then
            Call ChooseColors(peg1Color, peg2Color, peg3Color)
        End If

        Dim duplicateGuesses As Boolean = False     'assume no duplicate color entries
        Call GetGuess(peg1Guess, peg2Guess, peg3Guess, duplicateGuesses)
        If Not duplicateGuesses Then
            numPegsCorrect = CorrectPegs(peg1Guess, peg2Guess, peg3Guess, _
            peg1Color, peg2Color, peg3Color)

            numColorsCorrect = CorrectColors(peg1Guess, peg2Guess, peg3Guess, _
            peg1Color, peg2Color, peg3Color)

            Me.lblResults.Text = Me.lblResults.Text & "Pegs correct: " & _
            numPegsCorrect & Space(5) & "Colors correct: " & numColorsCorrect & vbCrLf
        End If

        If (numPegsCorrect = NUM_PEGS And numColorsCorrect = NUM_PEGS) Then
            MessageBox.Show("You Win!")
            btnNext.Visible = True
        End If
    End Sub

    'Generates unique numbers to represent the colors for the secret arrangement of
    'the colored pegs.
    '
    'post: A unique number 1 through 5 has been assigned to peg1Color,
    'peg2Color, and peg3Color to represent the colors of the pegs.
    '
    Sub ChooseColors(ByRef peg1Color As Integer, ByRef peg2Color As Integer, ByRef peg3Color As Integer)
        Do
            peg1Color = RndInt(1, 5)
            peg2Color = RndInt(1, 5)
            peg3Color = RndInt(1, 5)
        Loop While (HasDuplicates(peg1Color, peg2Color, peg3Color))
    End Sub

    'Calculates a random number between intLowNum and intHighNum.
    '
    'post: a number between intLowNum and intHighNum has been returned.
    '
    Function RndInt(ByVal intLowNum As Integer, ByVal intHighNum As Integer) As Integer
        Randomize()
        Return Int((intHighNum - intLowNum + 1) * Rnd() + intLowNum)
    End Function

    'Returns True if any of the peg colors is a duplicate with any other peg color.
    '
    'post: True has been returned if peg1Color = peg2Color Or peg1Color = peg3Color
    'Or peg2Color = peg3Color, otherwise False has been returned.
    '
    Function HasDuplicates(ByVal peg1Color As Integer, ByVal peg2Color As Integer, ByVal peg3Color As Integer) As Boolean
        If peg1Color = peg2Color Or peg1Color = peg3Color _
                Or peg2Color = peg3Color Then
            Return True
        Else
            Return False
        End If
    End Function

    'Gets the unique guesses of the three peg colors from the user.
    '
    'post: peg1Guess, peg2Guess, and peg3Guess equal the unique peg 
    'color guesses from the user.
    '
    Sub GetGuess(ByRef peg1Guess As Integer, ByRef peg2Guess As Integer, ByRef peg3Guess As Integer, ByRef duplicateGuesses As Boolean)
        'Get guess of peg 1
        If Me.radPeg1Yellow.Checked Then
            peg1Guess = 1
        ElseIf Me.radPeg1Blue.Checked Then
            peg1Guess = 2
        ElseIf Me.radPeg1Red.Checked Then
            peg1Guess = 3
        ElseIf Me.radPeg1Green.Checked Then
            peg1Guess = 4
        ElseIf Me.radPeg1White.Checked Then
            peg1Guess = 5
        End If

        'Get guess of peg 2
        If Me.radPeg2Yellow.Checked Then
            peg2Guess = 1
        ElseIf Me.radPeg2Blue.Checked Then
            peg2Guess = 2
        ElseIf Me.radPeg2Red.Checked Then
            peg2Guess = 3
        ElseIf Me.radPeg2Green.Checked Then
            peg2Guess = 4
        ElseIf Me.radPeg2White.Checked Then
            peg2Guess = 5
        End If

        'Get guess of peg 3
        If Me.radPeg3Yellow.Checked Then
            peg3Guess = 1
        ElseIf Me.radPeg3Blue.Checked Then
            peg3Guess = 2
        ElseIf Me.radPeg3Red.Checked Then
            peg3Guess = 3
        ElseIf Me.radPeg3Green.Checked Then
            peg3Guess = 4
        ElseIf Me.radPeg3White.Checked Then
            peg3Guess = 5
        End If

        If HasDuplicates(peg1Guess, peg2Guess, peg3Guess) Then
            MessageBox.Show("Each guess must be unique. Please guess 3 different peg colors.")
            duplicateGuesses = True
        End If
    End Sub

    'Calculates the number of correct pegs chosen by the user.
    '
    'post: The number of correct pegs has been returned.
    '
    Function CorrectPegs(ByVal peg1Guess As Integer, ByVal peg2Guess As Integer, ByVal peg3Guess As Integer, ByVal peg1Color As Integer, ByVal peg2Color As Integer, ByVal peg3Color As Integer) As Integer
        Dim numCorrect As Integer = 0

        If (peg1Guess = peg1Color) Then
            numCorrect += 1
        End If

        If (peg2Guess = peg2Color) Then
            numCorrect += 1
        End If

        If (peg3Guess = peg3Color) Then
            numCorrect += 1
        End If

        Return numCorrect
    End Function

    'Calculates the number of correct colors chosen by the user.
    '
    'post: The number of correct colors has been returned.
    '
    Function CorrectColors(ByVal peg1Guess As Integer, ByVal peg2Guess As Integer, ByVal peg3Guess As Integer, ByVal peg1Color As Integer, ByVal peg2Color As Integer, ByVal peg3Color As Integer) As Integer
        Dim numCorrect As Integer = 0

        If (peg1Guess = peg1Color Or peg1Guess = peg2Color Or _
                peg1Guess = peg3Color) Then
            numCorrect += 1
        End If

        If (peg2Guess = peg2Color Or peg2Guess = peg1Color Or _
                peg2Guess = peg3Color) Then
            numCorrect += 1
        End If

        If (peg3Guess = peg3Color Or peg3Guess = peg2Color Or _
                peg3Guess = peg1Color) Then
            numCorrect += 1
        End If

        Return numCorrect
    End Function

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        GlobalVariables.Game3Passed = True
        GlobalVariables.Money += 500
        Me.Hide()
        frmMainCasinoRoom.Show()
    End Sub
End Class