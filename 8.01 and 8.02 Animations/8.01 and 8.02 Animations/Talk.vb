'Aditya Bhatia
'Talk
'5/15/2018
Public Class frmTalk

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        tmrTalk.Enabled = True
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        tmrTalk.Enabled = False
    End Sub

    Private Sub tmrTalk_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTalk.Tick
        Const MAX_IMAGES As Integer = 2
        Static image As Integer = 0

        'display image 
        Select Case image
            Case 0
                Me.picImage.BackgroundImageLayout = ImageLayout.Stretch
                Me.picImage.BackgroundImage = My.Resources.talk1
            Case 1
                Me.picImage.BackgroundImageLayout = ImageLayout.Stretch
                Me.picImage.BackgroundImage = My.Resources.talk2
        End Select

        image = (image + 1) Mod MAX_IMAGES  'determine image
        lblAnswer.Text &= "Study "
    End Sub

    Private Sub Talk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.picImage.BackgroundImageLayout = ImageLayout.Stretch
        picImage.BackgroundImage = My.Resources.talk1
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmMe.Show()
    End Sub
End Class