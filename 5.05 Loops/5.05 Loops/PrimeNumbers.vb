'Aditya Bhatia
'Prime Numbers
'3/20/2018
Public Class frmPrimeNumbers

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim intTestNum As Integer = Val(Me.txtInteger.Text)

        Dim intDivisor As Integer = 1

        If intTestNum <= 1 Then
            lblPrimeResult.Text = "The number is not prime"
        Else
            Do
                intDivisor += 1
            Loop While intTestNum Mod intDivisor <> 0
            If intDivisor = intTestNum Then
                lblPrimeResult.Text = "The number is prime"
            Else
                lblPrimeResult.Text = "The number is not prime"
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmTimerControl.Visible = True
    End Sub
End Class
