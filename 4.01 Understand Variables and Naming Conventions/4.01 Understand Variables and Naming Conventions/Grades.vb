'Aditya Bhatia
'Grades
'2/19/2018
Public Class frmGrades
    Dim Q1Avg As Decimal = 0
    Dim Q2Avg As Decimal = 0
    Dim FinalExamGrade As Decimal = 0
    Dim FinalGrade As Decimal = 0
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
        End
    End Sub

    Private Sub HelloAgainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelloAgainToolStripMenuItem.Click
        Me.Visible = False
        frmHelloAgain.Visible = True
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

    Private Sub CountingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountingToolStripMenuItem.Click
        Me.Visible = False
        frmCounting.Visible = True
    End Sub

    Private Sub btnShowGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowGrade.Click
        Q1Avg = txtQ1Grade.Text
        Q2Avg = txtQ2Grade.Text
        FinalExamGrade = txtFEGrade.Text
        FinalGrade = (0.4 * Q1Avg) + (0.4 * Q2Avg) + (0.2 * FinalExamGrade)
        lblGrades.Text = FinalGrade
    End Sub
End Class