'Aditya Bhatia
'Test Data
'5/3/2018
Public Class frmTestData
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'Create the parallel arrays and initialize them
        Dim testNameArr() As String = {"Test 1", "Test 2", "Test 3"}
        Dim testGradeArr() As Integer = {87, 91, 83}
        'Loop to add the values from the arrays to the text in the label
        For i As Integer = 0 To 2
            Me.lblAnswer.Text &= testNameArr(i) & " has a grade of " & testGradeArr(i) & vbCrLf
        Next i
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmNumArray.show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class