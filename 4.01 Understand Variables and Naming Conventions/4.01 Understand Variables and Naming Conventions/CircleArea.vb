'Aditya Bhatia
'Circle Area
'2/20/2018
Public Class frmCircleArea
    Const dblPI As Double = 3.1457
    Dim dblRadius As Double = 0
    Dim dblArea As Double = 0
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

    Private Sub ReadyForSchoolToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReadyForSchoolToolStripMenuItem.Click
        Me.Visible = False
        frmReadyForSchool.Visible = True
    End Sub

    Private Sub CountingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountingToolStripMenuItem.Click
        Me.Visible = False
        frmCounting.Visible = True
    End Sub

    Private Sub ScopeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScopeToolStripMenuItem.Click
        Me.Visible = False
        frmScope.Visible = True
    End Sub

    Private Sub btnAreaShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAreaShow.Click
        dblRadius = Me.txtRadius.Text
        dblArea = dblPI * (dblRadius * dblRadius)
        lblCircleArea.Text = dblArea
    End Sub

    Private Sub txtRadius_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRadius.TextChanged
        lblCircleArea.Text = ""
    End Sub
End Class