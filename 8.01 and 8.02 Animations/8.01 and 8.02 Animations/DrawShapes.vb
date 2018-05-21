'Aditya Bhatia
'Draw Shapes
'5/17/2018
Public Class frmDrawShapes

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmTestCurves.Show()
    End Sub

    Private Sub btnDrawShapes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawShapes.Click
        'Create drawing surface
        Dim formSurface As Graphics = Me.CreateGraphics
        formSurface.Clear(Me.BackColor)

        'Determine max X and maxY values
        Dim maxX As Integer = Me.Size.Width
        Dim maxY As Integer = Me.Size.Height

        'Define all the pens
        Dim lightSeaGreenPen As New Pen(Color.LightSeaGreen, 2)
        Dim thickerDeepPinkPen As New Pen(Color.DeepPink, 10)
        Dim thickDodgerBluePen As New Pen(Color.DodgerBlue, 5)
        Dim thinRedPen As New Pen(Color.Red, 3)

        'Draw thin LightSeaGreen horizontal line
        formSurface.DrawLine(lightSeaGreenPen, 30, maxY \ 3, maxX - 30, maxY \ 3)

        'Draw thicker DeepPink circle
        formSurface.DrawEllipse(thickerDeepPinkPen, maxX \ 2, maxY \ 2, 40, 40)

        'Draw thick DashDotDot Dodgerblue rectangle
        thickDodgerBluePen.DashStyle = Drawing2D.DashStyle.DashDotDot
        formSurface.DrawRectangle(thickDodgerBluePen, 80, maxY \ 4, maxX \ 3, 70)

        'Draw thin Red arc
        formSurface.DrawArc(thinRedPen, 30, 0, maxX - 60, maxY - 60, 0, 180)
    End Sub
End Class