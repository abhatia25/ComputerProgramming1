'Aditya Bhatia
Public Class frmForLoop
    Private Sub ClearList()
        lstData.Items.Clear()
    End Sub

    Private Sub btnForLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForLoop.Click
        Dim intCount As Integer

        ClearList()

        For intCount = 1 To 8
            lstData.Items.Add(intCount.ToString)
        Next
    End Sub
End Class
