'Aditya Bhatia
'Multiples
'4/23/2018
Public Class frmMultiples
    Private Sub showMultiples(ByVal intNum As Integer)
        'loops through 1 to 10 to create multiple
        For intTime As Integer = 1 To 10
            Me.lblShowMultiples.Text &= intNum & " x " & intTime & " = " & intNum * intTime & vbCrLf
            'adds text to label with return
        Next intTime
    End Sub

    Private Sub btnShowMultiples_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowMultiples.Click
        Me.lblShowMultiples.Text = ""
        Dim intNumEntered As Integer   'input from user
        Try
            intNumEntered = Convert.ToInt32(Me.txtNum.Text)
            showMultiples(intNumEntered) 'calls method & send input
        Catch ex As Exception
            MessageBox.Show("Enter a numeric value")
            'error message
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmTimesTen.Show()
    End Sub
End Class