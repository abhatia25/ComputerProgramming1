'Aditya Bhatia
'2/7/2018
'Square Area
Public Class frmSquareArea
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Thank you!")
        End 'End program
    End Sub
    Private Sub btnAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnswer.Click
        Dim side As Integer
        Dim area As Integer
        side = Val(Me.txtSide.Text) 'Side=Value in textbox
        area = side * side 'Formula for area
        Me.lblAnswer.Text = area 'Display area
    End Sub
    Private Sub txtSide_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSide.TextChanged
        Me.lblAnswer.Text = "" 'Clear the current answer when user begins to type new value
    End Sub
End Class
