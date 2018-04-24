'Aditya Bhatia
'Reasons
'4/24/2028
Public Class frmReasons
    Private Sub showReasons()
        lblAnswer.Text = "CS teaches critical thinking." & vbCrLf & "CS touches everyone, everyday." & vbCrLf & "Computing jobs are in high demand."
    End Sub

    Private Sub btnCompSci_Click(sender As Object, e As EventArgs) Handles btnCompSci.Click
        showReasons()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmGuessIt.Show()
    End Sub
End Class