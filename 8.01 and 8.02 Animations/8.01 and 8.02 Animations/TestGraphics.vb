'Aditya Bhatia
'Test Graphics
'5/16/2018
Public Class frmTestGraphics
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmDrawShapes.Show()
    End Sub

    Private Sub btnDrawNow_Click(sender As Object, e As EventArgs) Handles btnDrawNow.Click
        'Create Drawing Surface
        Dim formSurface As Graphics = Me.CreateGraphics
        'Define Pen
        Dim indigoPen As New Pen(Color.Indigo, 5)
        Dim salmonPen As New Pen(Color.Salmon, 5)
        Dim tealPen As New Pen(Color.Teal, 2)

        'Draw on form
        indigoPen.DashStyle = Drawing2D.DashStyle.DashDot
        formSurface.DrawRectangle(indigoPen, 0, 0, 200, 200)
        formSurface.DrawEllipse(salmonPen, 0, 0, 200, 200)
        formSurface.DrawArc(tealPen, 0, 0, 100, 100, 0, 120)
    End Sub
End Class