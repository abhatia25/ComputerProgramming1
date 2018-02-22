'Aditya Bhatia
'Pizza2
'2/19/2018
Public Class frmPizza2
    Dim strCrust As String = ""
    Dim strTopping1 As String = ""
    Dim strTopping2 As String = ""
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

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        strCrust = Me.txtCrust.Text
        strTopping1 = Me.txtTopping1.Text
        strTopping2 = Me.txtTopping2.Text
        lblOrder.Text = ("You would like: " + strCrust + ", " + strTopping1 + ", " + strTopping2)
    End Sub

    Private Sub txtCrust_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCrust.TextChanged
        lblOrder.Text = ""
    End Sub

    Private Sub txtTopping1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTopping1.TextChanged
        lblOrder.Text = ""
    End Sub

    Private Sub txtTopping2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTopping2.TextChanged
        lblOrder.Text = ""
    End Sub
End Class