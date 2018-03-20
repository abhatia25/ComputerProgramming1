'Aditya Bhatia
'Random
'3/19/2018
Public Class frmRandom
    Dim number1 As Double
    Dim number2 As Integer
    Dim number3 As Integer
    Dim number4 As Integer
    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Randomize()
        number1 = Rnd() * 1
        number2 = Rnd() * 2147483647 + 1
        number3 = Rnd() * 100 + 1
        number4 = Rnd() * 50 + 11
        lblAnswer.Text = number1 & vbCrLf & number2 & vbCrLf & number3 & vbCrLf & number4
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmGuessIt.Visible = True
    End Sub
End Class