'Aditya Bhatia
'Square Root Rounding
'5/10/2018
Public Class frmSquareRootRounding
    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmBookStoreOrder.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        Dim squareRoot, square, difference As Double
        Me.lstList.Items.Clear()

        'Repeat the loop for all numbers between 1 and 100, inclusive       
        For number As Integer = 1 To 100
            squareRoot = Math.Sqrt(number)  'square root of a number
            square = squareRoot ^ 2         'square the square root
            difference = number - square    'subtract from original number
            Me.lstList.Items.Add(number & " - (Sqrt(" &
            number & "))^2 = " & Format(difference, "Scientific"))
        Next number
    End Sub
End Class