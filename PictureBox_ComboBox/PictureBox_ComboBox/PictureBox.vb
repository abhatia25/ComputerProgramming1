Public Class frmPictureBox

    Private Sub frmPictureBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If Me.BackgroundImageLayout = ImageLayout.Stretch Then
            Me.BackgroundImageLayout = ImageLayout.Center
        Else
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub
End Class