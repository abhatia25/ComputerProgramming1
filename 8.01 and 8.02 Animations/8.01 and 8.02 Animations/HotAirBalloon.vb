'Aditya Bhatia
'Hot Air Balloon
'5/14/2018
Public Class frmHotAirBalloon
    Private Sub tmrChangeImage_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrChangeImage.Tick
        Const MAX_IMAGES As Integer = 3
        Static image As Integer = 0
        'display image
        Select Case image
            Case 0
                Me.picImage.Image = My.Resources.hotairballoon1
            Case 1
                Me.picImage.Image = My.Resources.hotairballoon2
            Case 2
                Me.picImage.Image = My.Resources.hotairballoon3
        End Select
        image = (image + 1) Mod MAX_IMAGES 'determine image
    End Sub

    Private Sub frmHotAirBalloon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrChangeImage.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmKite.Show()
    End Sub
End Class