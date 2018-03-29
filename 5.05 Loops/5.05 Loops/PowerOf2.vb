'Aditya Bhatia
'Power of 2
'3/20/2018
Public Class frmPowerOf2
    Dim intExpon As Integer = 1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmFactorial.Visible = True
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Do While Me.intExpon <= 10
            lblResult.Text &= "2 to the " & intExpon & " equals " & (2 ^ intExpon) & vbCrLf
            intExpon = intExpon + 1
        Loop
    End Sub
End Class