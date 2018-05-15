'Aditya Bhatia
'Kicks
'5/15/2018
Public Class frmKicks

    Private Sub tmrChangeImage_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrChangeImage.Tick
        Const MAX_IMAGES As Integer = 2
        Static image As Integer = 0

        'display image 
        Select Case image
            Case 0
                Me.picImage.BackgroundImageLayout = ImageLayout.Stretch
                Me.picImage.BackgroundImage = My.Resources.kicks
            Case 1
                Me.picImage.BackgroundImageLayout = ImageLayout.Stretch
                Me.picImage.BackgroundImage = Nothing
        End Select

        image = (image + 1) Mod MAX_IMAGES  'determine image
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmTalk.Show()
    End Sub
End Class