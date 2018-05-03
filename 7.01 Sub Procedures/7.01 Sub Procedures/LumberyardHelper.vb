'Aditya Bhatia
'Lumberyard Helper
'5/3/2018
Public Class frmLumberyardHelper
    Dim dblBoardThickness As Double
    Dim dblBoardLength As Double
    Dim dblBoardWidth As Double
    Dim dblBoardFeet As Double
    Dim strBoardType As String

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculateBoardFeet(dblBoardFeet, dblBoardThickness, dblBoardLength, dblBoardWidth)
        Select Case dblBoardFeet
            Case < 1
                strBoardType = "board"
            Case > 4
                strBoardType = "timber"
            Case 1 To 4
                strBoardType = "lumber"
        End Select
        Me.lblAnswer.Text = "Type: " & strBoardType & " board. Feet: " & dblBoardFeet
    End Sub

    Sub CalculateBoardFeet(ByRef dblBoardFeet As Double, ByVal dblBoardThickness As Double, ByVal dblBoardLength As Double, ByVal dblBoardWidth As Double)
        If Double.TryParse(txtLength.Text, dblBoardLength) Then
            If Double.TryParse(txtThickness.Text, dblBoardThickness) Then
                If Double.TryParse(txtWidth.Text, dblBoardWidth) Then
                    dblBoardFeet = ((dblBoardThickness * (dblBoardLength * dblBoardWidth) * dblBoardWidth) / (dblBoardWidth * dblBoardWidth * dblBoardThickness))
                End If
            End If
        End If
    End Sub
End Class