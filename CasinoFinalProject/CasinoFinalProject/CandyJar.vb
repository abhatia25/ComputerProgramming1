'Aditya Bhatia
'Candy Jar
'5/21/2018
Public Class frmCandyJar
    Dim intCorrectAnswer As Integer
    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click

        Dim strUserGuess As String
        Dim dblUserGuess As Double

        strUserGuess = txtJellyBeansGuess.Text

        If Double.TryParse(strUserGuess, dblUserGuess) Then
            If intCorrectAnswer = dblUserGuess Then
                lblResult.Text = "You guessed " & dblUserGuess & vbCrLf & "You guessed it!"
                btnNext.Visible = True
            ElseIf intCorrectAnswer > dblUserGuess Then
                lblResult.Text = "You guessed " & dblUserGuess & vbCrLf & "Too low"
            Else
                lblResult.Text = "You guessed " & dblUserGuess & vbCrLf & "Too high"
            End If
        Else
            MessageBox.Show("Please enter a number")
        End If
    End Sub

    Private Sub frmCandyJar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        intCorrectAnswer = Rnd() * 300
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        GlobalVariables.Game1Passed = True
        GlobalVariables.Money += 500
        Me.Hide()
        frmMainCasinoRoom.Show()
    End Sub

    Private Sub lblResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResult.Click
        GlobalVariables.Game1Passed = True
        GlobalVariables.Money += 500
        Me.Hide()
        frmMainCasinoRoom.Show()
    End Sub
End Class