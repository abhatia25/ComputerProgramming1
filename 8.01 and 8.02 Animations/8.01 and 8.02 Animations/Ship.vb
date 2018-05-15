'Aditya Bhatia
'Ship
'5/15/2018
Public Class frmShip

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()

    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Dim pictureBoxSurface As Graphics = Me.picImage.CreateGraphics
        pictureBoxSurface.Clear(Me.BackColor)
        Dim maxX As Integer = Me.picImage.Size.Width
        Dim maxY As Integer = Me.picImage.Size.Height

        'Define brushes
        Dim darkBlueBrush As New SolidBrush(Color.DarkBlue)
        Dim brownBrush As New SolidBrush(Color.Brown)
        Dim blackBrush As New SolidBrush(Color.Black)
        Dim whiteBrush As New SolidBrush(Color.White)

        'Draw mast
        Dim point1 As Single = maxX / 2
        Dim point2 As Single = maxY
        Dim point3 As Single = maxX / 2
        Dim point4 As Single = maxY / 1.25
        pictureBoxSurface.DrawLine(Pens.Black, point1, point2, point3, point4)
    End Sub

    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click

    End Sub
End Class