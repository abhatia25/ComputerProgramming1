'Aditya Bhatia
'2/2/2018
'Addition Properties Menu Strip
Public Class frmAdditionPropertiesMenuStrip
    Private Sub btnAssociative_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAssociative.Click
        Me.lblProperty.Text = "(a + b) + c = a + (b +  c)"
        MessageBox.Show("Good luck with your math!")
    End Sub

    Private Sub btnCommutative_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCommutative.Click
        Me.lblProperty.Text = "a + b = b + a"
        MessageBox.Show("Good luck with your math!")
    End Sub

    Private Sub AssociativeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssociativeToolStripMenuItem.Click
        Me.lblProperty.Text = "(a + b) + c = a + (b +  c)"
        MessageBox.Show("Good luck with your math!")
    End Sub

    Private Sub CommutativeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommutativeToolStripMenuItem.Click
        Me.lblProperty.Text = "a + b = b + a"
        MessageBox.Show("Good luck with your math!")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Good luck with your math!")
        Application.Exit()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Me.lblProperty.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.lblProperty.Text = ""
    End Sub
End Class
