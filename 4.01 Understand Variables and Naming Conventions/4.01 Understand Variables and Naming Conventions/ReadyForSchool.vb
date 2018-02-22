'Aditya Bhatia
'Ready for School
'2/20/2018
Public Class frmReadyForSchool

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

    Private Sub ScopeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScopeToolStripMenuItem.Click
        Me.Visible = False
        frmScope.Visible = True
    End Sub

    Private Sub CountingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountingToolStripMenuItem.Click
        Me.Visible = False
        frmCounting.Visible = True
    End Sub

    Private Sub chkHomework_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHomework.CheckedChanged
        MessageBox.Show("Good job!")
        lblMessage.Text &= "Homework Done" & vbCrLf
    End Sub

    Private Sub chkBreakfast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBreakfast.CheckedChanged
        MessageBox.Show("Good job!")
        lblMessage.Text &= "Eaten Breakfast" & vbCrLf
    End Sub

    Private Sub chkBrush_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBrush.CheckedChanged
        MessageBox.Show("Good job!")
        lblMessage.Text &= "Teeth Brushed" & vbCrLf
    End Sub

    Private Sub btnReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReady.Click
        If chkBreakfast.Checked And chkBrush.Checked And chkHomework.Checked Then
            lblMessage.Text &= "Ready for School"
        Else
            lblMessage.Text &= "Are you forgetting something?"
        End If
    End Sub
End Class