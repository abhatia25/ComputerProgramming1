'Aditya Bhatia
'Counting
'2/20/2018
Public Class frmCounting

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
        End
    End Sub

    Private Sub HelloAgainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelloAgainToolStripMenuItem.Click
        Me.Visible = False
        frmHelloAgain.Visible = True
    End Sub

    Private Sub GradesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradesToolStripMenuItem.Click
        Me.Visible = False
        frmGrades.Visible = True
    End Sub

    Private Sub Pizza2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pizza2ToolStripMenuItem.Click
        Me.Visible = False
        frmPizza2.Visible = True
    End Sub

    Private Sub CircleAreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CircleAreaToolStripMenuItem.Click
        Me.Visible = False
        frmCircleArea.Visible = True
    End Sub

    Private Sub ReadyForSchoolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReadyForSchoolToolStripMenuItem.Click
        Me.Visible = False
        frmReadyForSchool.Visible = True
    End Sub

    Private Sub ScopeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScopeToolStripMenuItem.Click
        Me.Visible = False
        frmScope.Visible = True
    End Sub

    Private Sub btnDim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDim.Click
        Dim intCounter As Integer = 1
        intCounter = intCounter + 1
        lblAnswer.Text = intCounter
    End Sub

    Private Sub btnStatic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatic.Click
        Static intCounter As Integer = 1
        intCounter = intCounter + 1
        lblAnswer.Text = intCounter
    End Sub
End Class