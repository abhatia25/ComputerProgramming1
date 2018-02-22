'Aditya Bhatia
'Scope
'2/20/2018
Public Class frmScope
    Dim intX As Integer = 10
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

    Private Sub CountingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountingToolStripMenuItem.Click
        Me.Visible = False
        frmCounting.Visible = True
    End Sub

    Private Sub btnLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocal.Click
        Dim intX As Integer = 5
        lblScopeAnswer.Text = intX
    End Sub

    Private Sub btnGlobal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGlobal.Click
        lblScopeAnswer.Text = intX
    End Sub
End Class