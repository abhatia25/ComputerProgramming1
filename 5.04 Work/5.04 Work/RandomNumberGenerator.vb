'Aditya Bhatia
'Random Number Generator
Public Class frmRandomNumberGenerator
    Private Sub btnGenerateNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateNumbers.Click
        Randomize()
        Dim largestNum As Integer
        Dim largestNumTemp As String
        Dim num1, num2, num3 As Integer
        Dim count As Integer = 0

        Do
            largestNumTemp = InputBox("Enter the largest number >= 3 to generate", Me.Text)
            largestNum = Val(largestNumTemp)
        Loop While largestNum < 3

        'Generate random numbers
        Do
            num1 = Int(largestNum * Rnd() + 1)
            num2 = Int(largestNum * Rnd() + 1)
            num3 = Int(largestNum * Rnd() + 1)
            count += 1
        Loop While (num1 = num2 Or num2 = num3 Or num1 = num3)

        lblNumber1.Text = num1
        lblNumber2.Text = num2
        lblNumber3.Text = num3
        lblAnswer.Text = count
        lblExplanation.Text = "loop iterations were needed to generate three unique numbers."
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmChaos.Visible = True
    End Sub
End Class