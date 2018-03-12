'Aditya Bhatia
'Mints
'3/12/2018
Public Class frmMints
    Dim intTotalMints As Integer = 0
    Dim intServings As Integer = 0
    Dim intMintsLeft As Integer = 0
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            intTotalMints = Convert.ToInt32(txtMints.Text)
            intServings = intTotalMints \ 3
            Me.lblServings.Text = intServings.ToString
            intMintsLeft = intTotalMints Mod 3
            Me.lblMintsLeft.Text = intMintsLeft.ToString
        Catch ex As Exception
            MessageBox.Show("Please enter in an integer for total mints")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmBasicAnimation.Visible = True
    End Sub
End Class