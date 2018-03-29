'Aditya Bhatia
'ListBox
'3/20/2018
Public Class frmListBox

    Private Sub frmListBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim counter As Integer
        For counter = 1 To 10
            ListBox1.Items.Add(counter)
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmSumNumbers.Visible = True
    End Sub
End Class