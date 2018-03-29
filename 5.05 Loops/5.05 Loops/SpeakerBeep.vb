'Aditya Bhatia
'Speaker Beep
'3/20/2018
Public Class frmSpeakerBeep
    Private Sub frmSpeakerBeep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 4
            Beep()
        Next i
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmListBox.Visible = True
    End Sub
End Class