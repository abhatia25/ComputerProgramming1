Public Class frmComboBox
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim MyVariable As String
        MyVariable = cmbComboBox1.Text
        MessageBox.Show(MyVariable)
    End Sub

    Private Sub btnPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPictureBox.Click
        Me.Visible = False
        frmPictureBox.Visible = True
    End Sub
End Class
