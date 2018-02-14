'Aditya Bhatia
'2/7/2018
'Text Box Example 1
Public Class frmTextBoxes
    Private Sub btnMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMessage.Click
        MessageBox.Show("Thank you " + txtName.Text + " from " + txtOrg.Text + "!" + " Your comment was: " + txtComment.Text + "!")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Thank you for your time!")
    End Sub
End Class
