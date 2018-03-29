'Aditya Bhatia
'Subtraction
'3/20/2018
Public Class frmSubtraction

    Private Sub Subtraction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim counter, sum As Integer
        For counter = 100 To 5 Step -5
            sum -= counter
            ListBox1.Items.Add(sum)
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmWordGuessGame.Visible = True
    End Sub
End Class