'Aditya Bhatia
'Find and Fix Complier Errors
'2/27/2018
Public Class frmComplierErrors

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextProgramToolStripMenuItem.Click
        Me.Visible = False
        frmBowlingScores.Visible = True
    End Sub

    Private Sub frmComplierErrors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If 1 < 2 Then
            MsgBox("Hello")
        End If

    End Sub
End Class