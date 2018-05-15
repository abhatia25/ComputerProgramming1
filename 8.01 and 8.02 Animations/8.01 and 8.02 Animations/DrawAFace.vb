'Aditya Bhatia
'Draw A Face
'5/14/2018
Public Class frmDrawAFace
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnHappy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHappy.Click
        Dim pictureBoxSurface As Graphics = Me.picFrame.CreateGraphics
        pictureBoxSurface.Clear(Me.BackColor)
        Dim maxX As Integer = Me.picFrame.Size.Width
        Dim maxY As Integer = Me.picFrame.Size.Height

        'Define all the brushes
        Dim tanBrush As New SolidBrush(Color.Tan)
        Dim grayBrush As New SolidBrush(Color.LightGray)
        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim redBrush As New SolidBrush(Color.Red)
        Dim pinkBrush As New SolidBrush(Color.PaleVioletRed)

        'Draw rectangle in background of picturebox
        pictureBoxSurface.FillRectangle(tanBrush, 0, 0, maxX, maxY)

        'Draw large ellipse for face
        pictureBoxSurface.FillEllipse(grayBrush, 1, 1, maxX - 3, maxY - 3)

        'Draw eyes
        pictureBoxSurface.FillEllipse(blueBrush, maxX \ 3 - 10, 30, 35, 35)
        pictureBoxSurface.FillEllipse(blueBrush, maxX \ 2 + 10, 30, 35, 35)

        'Draw nose
        pictureBoxSurface.FillEllipse(redBrush, maxX \ 2 - 10, maxY \ 2, 20, 20)

        'Draw mouth
        pictureBoxSurface.FillPie(pinkBrush, maxX \ 3 - 5, maxY \ 4 + 40, 80, 80, 0, 180)
    End Sub

    Private Sub btnSad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSad.Click
        Dim pictureBoxSurface As Graphics = Me.picFrame.CreateGraphics
        pictureBoxSurface.Clear(Me.BackColor)
        Dim maxX As Integer = Me.picFrame.Size.Width
        Dim maxY As Integer = Me.picFrame.Size.Height

        'Define all the brushes
        Dim tanBrush As New SolidBrush(Color.Tan)
        Dim grayBrush As New SolidBrush(Color.LightGray)
        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim redBrush As New SolidBrush(Color.Red)
        Dim pinkBrush As New SolidBrush(Color.PaleVioletRed)

        'Draw rectangle in background of picturebox
        pictureBoxSurface.FillRectangle(tanBrush, 0, 0, maxX, maxY)

        'Draw large ellipse for face
        pictureBoxSurface.FillEllipse(grayBrush, 1, 1, maxX - 3, maxY - 3)

        'Draw eyes
        pictureBoxSurface.FillEllipse(blueBrush, maxX \ 3 - 10, 30, 35, 35)
        pictureBoxSurface.FillEllipse(blueBrush, maxX \ 2 + 10, 30, 35, 35)

        'Draw nose
        pictureBoxSurface.FillEllipse(redBrush, maxX \ 2 - 10, maxY \ 2, 20, 20)

        'Draw mouth
        pictureBoxSurface.FillPie(pinkBrush, maxX \ 3 - 5, maxY \ 3 + 60, 80, 80, 0, -180)
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmKicks.Show()
    End Sub
End Class