'Aditya Bhatia
'If Then Else Excersise
'2/14/2018
Public Class frmIfThenElse

    Private Sub btnCheckIfStatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckIfStatement.Click
        If TextBox1.Text = "1" Then
            lblMessage.Text = "message 1 "
        End If
        If TextBox1.Text = "2" Then
            lblMessage.Text = "message 2"
        End If
        If TextBox1.Text = "3" Then
            lblMessage.Text = "message 3"
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckBox1.CheckedChanged
        If chkCheckBox1.Checked = True Then
            chkCheckBox1.Text = "I'm Checked!"
        Else : chkCheckBox1.Text = "I'm not checked!"
        End If
    End Sub

    Private Sub CloseProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseProgramToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        chkCheckBox1.Checked = False
        lblMessage.Text = ""
        TextBox1.Text = ""
        MessageBox.Show("Cleared")
    End Sub
End Class