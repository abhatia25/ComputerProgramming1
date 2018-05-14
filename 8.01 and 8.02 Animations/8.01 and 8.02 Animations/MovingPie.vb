'Aditya Bhatia
'Moving Pie
'5/14/2018
Public Class frmMovingPie

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmMovingRectangle.Show()
    End Sub

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
        Dim magentaBrush As New SolidBrush(Color.Magenta)
        Dim aquaBrush As New SolidBrush(Color.Aqua)
        Dim navyBrush As New SolidBrush(Color.Navy)
        Dim randomColor As Integer = Int(3 * Rnd())
        Select Case randomColor
            Case 0
                formSurface.FillPie(magentaBrush, x1, y1, x2, y2, 0, 180)
            Case 1
                formSurface.FillPie(aquaBrush, x1, y1, x2, y2, 0, 180)
            Case 2
                formSurface.FillPie(navyBrush, x1, y1, x2, y2, 0, 180)
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
End Class