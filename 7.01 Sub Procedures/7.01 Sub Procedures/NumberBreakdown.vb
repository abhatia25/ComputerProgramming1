'Aditya Bhatia
'Number Breakdown
'4/27/2018
Public Class frmNumberBreakdown

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()

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

        End If
    End Sub
End Class