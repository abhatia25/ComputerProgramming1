'Aditya Bhatia
'Test Curves
'5/17/2018
Public Class frmTestCurves

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmClickIt.Show()
    End Sub

    Private Sub btnDraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraw.Click
        'Create Drawing Surfaces
        Dim labelDrawCurve As Graphics = Me.lblDrawCurve.CreateGraphics
        Dim labelDrawClosedCurve As Graphics = Me.lblDrawClosedCurve.CreateGraphics
        Dim labelFillClosedCurve As Graphics = Me.lblFillCurve.CreateGraphics
        Dim labelDrawPolygon As Graphics = Me.lblDrawPolygon.CreateGraphics
        Dim labelFillPolygon As Graphics = Me.lblFillPolygon.CreateGraphics

        'Define pen and brush
        Dim tomatoPen As New Pen(Color.Tomato, 1)
        Dim tomatoBrush As New SolidBrush(Color.Tomato)

        'Define points
        Dim curvePoints() As Point = {New Point(10, 30), New Point(35, 35), New Point(75, 80), New Point(120, 201)}

        'Draw shapes
        labelDrawCurve.DrawCurve(tomatoPen, curvePoints)
        labelDrawClosedCurve.DrawClosedCurve(tomatoPen, curvePoints)
        labelFillClosedCurve.FillClosedCurve(tomatoBrush, curvePoints)
        labelDrawPolygon.DrawPolygon(tomatoPen, curvePoints)
        labelFillPolygon.FillPolygon(tomatoBrush, curvePoints)
    End Sub
End Class