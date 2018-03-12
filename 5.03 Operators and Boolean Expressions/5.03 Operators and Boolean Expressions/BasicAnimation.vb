Public Class frmBasicAnimation

    Private Sub frmBasicAnimation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmStudentGrouping.Visible = True
    End Sub

    Private Sub Command1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command1.Click
        Timer1.Interval = 100
        Timer1.Enabled = True
        Label1.Text = "Welcome"
    End Sub

    Private Sub Command2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label1.Visible = True Then
            Label1.Visible = False
            BackColor = Nothing
        ElseIf Label1.Visible = False Then
            Label1.Visible = True
            BackColor = Color.HotPink
        End If
    End Sub
End Class