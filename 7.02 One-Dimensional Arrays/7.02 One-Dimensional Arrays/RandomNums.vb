'Aditya Bhatia
'Random Nums
'5/7/2018
Public Class frmRandomNums
    Dim intNumbers(9) As Integer
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GenerateNumbers()
        DisplayNumbers()
    End Sub

    Private Sub GenerateNumbers()
        Randomize()
        For i As Integer = 0 To intNumbers.Length - 1
            intNumbers(i) = (Rnd() * 100) + 1
        Next i
    End Sub

    Private Sub DisplayNumbers()
        For i As Integer = 0 To intNumbers.Length - 1
            lstDisplay.Items.Add(intNumbers(i))
        Next i
    End Sub

    Private Sub FindLowNumber(ByRef intLowNumber As Integer)
        Array.Sort(intNumbers)
        intLowNumber = intNumbers(0)
    End Sub

    Private Sub FindHighNumber(ByRef intHighNumber As Integer)
        Array.Sort(intNumbers)
        intHighNumber = intNumbers(9)
    End Sub

    Private Sub btnHigh_Click(sender As Object, e As EventArgs) Handles btnHigh.Click
        Dim intHighNumber As Integer
        FindHighNumber(intHighNumber)
        lblAnswer.Text = "High Number: " & intHighNumber
    End Sub

    Private Sub btnLow_Click(sender As Object, e As EventArgs) Handles btnLow.Click
        Dim intLowNumber As Integer
        FindLowNumber(intLowNumber)
        lblAnswer.Text = "Low Number: " & intLowNumber
    End Sub
End Class