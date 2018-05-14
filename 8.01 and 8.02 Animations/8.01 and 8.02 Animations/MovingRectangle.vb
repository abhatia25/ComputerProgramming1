'Aditya Bhatia
'Moving Rectangle
'5/14/2018
Public Class frmMovingRectangle
    Private Sub tmrStart_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrStart.Tick
        Dim formSurface As Graphics = Me.CreateGraphics
        formSurface.Clear(Me.BackColor)
        Dim maxX As Integer = Me.Size.Width
        Dim maxY As Integer = Me.Size.Height
        Randomize()
        Dim x1 As Integer = Int(maxX * Rnd() + 1)
        Dim y1 As Integer = Int(maxY * Rnd() + 1)
        Dim x2 As Integer = Int(maxX * Rnd() + 1)
        Dim y2 As Integer = Int(maxY * Rnd() + 1)
        Dim pinkBrush As New SolidBrush(Color.Pink)
        Dim yellowBrush As New SolidBrush(Color.Yellow)
        Dim orangeBrush As New SolidBrush(Color.Orange)
        Dim randomColor As Integer = Int(3 * Rnd())
        Select Case randomColor
            Case 0
                formSurface.FillRectangle(pinkBrush, x1, y1, x2, y2)
            Case 1
                formSurface.FillRectangle(yellowBrush, x1, y1, x2, y2)
            Case 2
                formSurface.FillRectangle(orangeBrush, x1, y1, x2, y2)
        End Select
    End Sub
    Private Sub StartToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        Me.tmrStart.Start()
    End Sub
    Private Sub StopToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        Me.tmrStart.Stop()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmBouncingBall.Show()
    End Sub
End Class