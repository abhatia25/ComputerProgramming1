Public Class frmPictureBox

    Private Sub frmPictureBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If Me.BackgroundImageLayout = ImageLayout.Stretch Then
            Me.BackgroundImageLayout = ImageLayout.Center
        Else
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub btnComboBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComboBox.Click
        Me.Visible = False
        frmComboBox.Visible = True
    End Sub
End Class