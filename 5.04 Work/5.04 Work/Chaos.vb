'Aditya Bhatia
'Chaos
'3/15/2018
Public Class frmChaos

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Timer1.Enabled = True
        While Timer1.Enabled
            BackColor = Color.Cyan
            wait(0.1)
            BackColor = Color.Crimson
            wait(0.1)
            BackColor = Color.DarkOliveGreen
            wait(0.1)
        End While
    End Sub

    Private Sub frmChaos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub wait(ByVal seconds As Decimal)
        For i As Decimal = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
End Class