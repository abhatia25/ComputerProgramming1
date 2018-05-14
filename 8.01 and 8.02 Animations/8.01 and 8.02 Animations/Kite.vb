'Aditya Bhatia
'Kite
'5/14/2018
Public Class frmKite

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmMovingPie.Show()
    End Sub

    Private Sub tmrChangeImage_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrChangeImage.Tick
        Const MAX_IMAGES As Integer = 4
        Static image As Integer = 0

        'display image 
        Select Case image
            Case 0
                Me.picImage.Image = My.Resources.kite1
            Case 1
                Me.picImage.Image = My.Resources.kite2
            Case 2
                Me.picImage.Image = My.Resources.kite3
            Case 3
                Me.picImage.Image = My.Resources.kite4
        End Select

        image = (image + 1) Mod MAX_IMAGES  'determine image 
    End Sub

    Private Sub frmKite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrChangeImage.Enabled = True
    End Sub
End Class