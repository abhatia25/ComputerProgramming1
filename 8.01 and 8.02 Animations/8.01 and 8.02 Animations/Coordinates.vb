'Aditya Bhatia
'Coordinates
'5/16/2018
Public Class frmCoordinates
    Private Sub btnShowGrid_Click(sender As Object, e As EventArgs) Handles btnShowGrid.Click
        Dim formSurface As Graphics = Me.CreateGraphics
        Dim maxX As Integer = Me.Size.Width
        Dim maxY As Integer = Me.Size.Height
        Dim magentaPen As New Pen(Color.Magenta, 1)
        Dim greenPen As New Pen(Color.Green, 1)

        'Draw a grid that is 10 pixels by 10 pixels
        For xCoord As Integer = 0 To maxX Step 10
            For yCoord As Integer = 0 To maxY Step 10
                If xCoord Mod 50 = 0 Or yCoord Mod 50 = 0 Then
                    'makes every 50th pixel a green square
                    formSurface.DrawRectangle(greenPen, xCoord, yCoord, 10, 10)
                Else
                    formSurface.DrawRectangle(magentaPen, xCoord, yCoord, 10, 10)
                End If
            Next yCoord
        Next xCoord

        Me.lblAnswer.Text = "Max x is " & maxX & ", " & "Max y is " & maxY
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmTestGraphics.Show()
    End Sub
End Class