'Aditya Bhatia
'Times Ten
'4/23/2018
Public Class frmTimesTen
    Dim intNumEntered As Integer
    Dim intAnswer As Integer

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmSignature.Show()
    End Sub

    Private Sub MultiplyByTen(ByVal intNum As Integer, ByRef intAnswer As Integer)
        'sets the answer in intAnswer's location
        intAnswer = intNum * 10
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Try
            intNumEntered = Convert.ToInt16(Me.txtNumEntered.Text)

            'sends inNumEntered value and intAnswer location
            MultiplyByTen(intNumEntered, intAnswer)

            'displays answer
            Me.lblAnswer.Text = intNumEntered & " x 10 = " & intAnswer

        Catch ex As Exception
            MessageBox.Show("Enter a numeric value")
        End Try
    End Sub
End Class