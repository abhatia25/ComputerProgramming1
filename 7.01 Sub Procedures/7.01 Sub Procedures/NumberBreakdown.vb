'Aditya Bhatia
'Number Breakdown
'4/27/2018
Public Class frmNumberBreakdown

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmHotDog.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnBreakDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBreakDown.Click
        Dim intNumEntered As Integer
        Dim intOnesDigit As Integer
        Dim intTensDigit As Integer
        Dim intHundredsDigit As Integer
        intNumEntered = Val(Me.txtNumber.Text)
        If intNumEntered < 10 Then
            Me.lblDigits.Text = "The first number is: " & intNumEntered
        ElseIf intNumEntered < 100 Then
            TwoDigits(intNumEntered, intTensDigit, intOnesDigit)
            Me.lblDigits.Text = "The first digit is " & intTensDigit & vbCrLf & "The second digit is " & intOnesDigit
        ElseIf intNumEntered < 1000 Then
            ThreeDigits(intNumEntered, intHundredsDigit, intTensDigit, intOnesDigit)
            Me.lblDigits.Text = "The first digit is " & intHundredsDigit & vbCrLf & "The second digit is " & intTensDigit & vbCrLf & "The third digit is " & intOnesDigit
        Else
            Me.lblDigits.Text = "Invalid Entry"
        End If
    End Sub

    Sub TwoDigits(ByVal intNum As Integer, ByRef intFirstDigit As Integer, ByRef intSecondDigit As Integer)
        intFirstDigit = intNum \ 10
        intSecondDigit = intNum Mod 10
    End Sub

    Sub ThreeDigits(ByVal intNum As Integer, ByRef intFirstDigit As Integer, ByRef intSecondDigit As Integer, ByRef intThirdDigit As Integer)
        intFirstDigit = intNum \ 100
        intNum = intNum Mod 100
        TwoDigits(intNum, intSecondDigit, intThirdDigit)
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        Me.lblDigits.Text = ""
    End Sub
End Class