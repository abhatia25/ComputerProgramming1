Public Class frmMultiplicationTable
    Dim NumbToMultiply As Integer = 1

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        lstResults.Items.Clear()
        lstResults.Refresh()
        txtInput.Text = ""
        NumbToMultiply = 1
    End Sub

    Private Sub btnMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiply.Click
        Do While NumbToMultiply <= 12
            lstResults.Items.Add(NumbToMultiply & " * " & Val(txtInput.Text) & " = " & NumbToMultiply * Val(txtInput.Text))
            NumbToMultiply += 1
            lstResults.Refresh()
        Loop
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
