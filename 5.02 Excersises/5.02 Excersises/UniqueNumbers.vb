'Aditya Bhatia
'Unique Numbers
'3/6/2018
Public Class frmUniqueNumbers

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmPerimeter.Visible = True
        MessageBox.Show("Form switched")
    End Sub

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

        Me.lblNumber1.Text = num1
        Me.lblNumber2.Text = num2
        Me.lblNumber3.Text = num3
        Me.lblAnswer.Text = "Count: " & count
        Me.lblExplanation.Text = "Explanation: " & "loop iterations were needed to generate three unique numbers."
    End Sub
End Class