'Aditya Bhatia
'Numbers Array
'5/3/2018
Public Class frmNumArray
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intNumArr(2) As Integer
        Dim average As Double
        addToArray(intNumArr)
        average = getAverage(intNumArr)
        Me.lblDisplayAvg.Text = "The average of the numbers is " &
    average.ToString("##.0")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    'Function to determine and return the average given the array.
    Function getAverage(ByVal intNumArr() As Integer) As Double
        Dim sum, avg As Double
        For Each num As Integer In intNumArr
            sum += num
        Next
        avg = sum / intNumArr.Length
        Return avg
    End Function

    'Sub to add values to the array
    Private Sub addToArray(ByRef intNumArr() As Integer)
        For i As Integer = 0 To intNumArr.Length - 1
            intNumArr(i) = InputBox("Enter a Number")
        Next i
    End Sub
End Class