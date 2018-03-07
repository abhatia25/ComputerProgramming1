'Aditya Bhatia
'Perimeter
'3/6/2018
Public Class frmPerimeter
    Dim side1 As Integer = 0
    Dim side2 As Integer = 0
    Dim side3 As Integer = 0
    Dim side4 As Integer = 0
    Dim perimeter As Integer = 0
    Dim answer As String = Nothing
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            side1 = txtSide1.Text
            side2 = txtSide2.Text
            side3 = txtSide3.Text
            side4 = txtSide4.Text
            perimeter = (side1 + side2 + side3 + side4)
            answer = perimeter.ToString
            lblAnswer.Text = "Perimeter: " & answer
        Catch ex As Exception
            MessageBox.Show("Please enter numerical values.")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        txtSide1.Text = ""
        txtSide2.Text = ""
        txtSide3.Text = ""
        txtSide4.Text = ""
        lblAnswer.Text = ""
    End Sub
End Class