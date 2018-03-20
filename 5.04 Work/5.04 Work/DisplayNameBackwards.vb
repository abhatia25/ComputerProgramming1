'Aditya Bhatia
'Display Name Backwards
'3/15/2018
Public Class frmDisplayNameBackwards

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmRandomNumberGenerator.Visible = True
    End Sub

    Private Sub btnDisplayBackwards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayBackwards.Click
        Dim name As String
        Dim length As Integer

        name = Me.txtName.Text
        length = name.Length

        For index As Integer = length To 1 Step -1
            Me.lblAnswer.Text &= name.Substring(index - 1, 1).ToLower
        Next index
        picCheckMark.Visible = True
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        Me.lblAnswer.Text = Nothing
        picCheckMark.Visible = False
    End Sub
End Class