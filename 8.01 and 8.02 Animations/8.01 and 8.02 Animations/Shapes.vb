'Aditya Bhatia
'Shapes
'5/14/2018
Public Class frmShapes
    Private Sub CircleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CircleToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.blueCircle
    End Sub
    Private Sub SquareToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SquareToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.redSq
    End Sub
    Private Sub StarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StarToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.purpleStar
    End Sub
    Private Sub TriangleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TriangleToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources.greenTriangle
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmStopLight.Show()
    End Sub
End Class
