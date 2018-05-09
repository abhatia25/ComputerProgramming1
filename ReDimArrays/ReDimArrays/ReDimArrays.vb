Public Class frmReDimArrays

    Private strSports() As String = {"baseball", "basketball", "football"}


    Private Sub btnReDim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReDim.Click
        For Each item As String In strSports
            lstArray.Items.Add("[" & item & "]")
        Next
        ReDim strSports(4)
        strSports(3) = "wakeboarding"
        strSports(4) = "soccer"
        For Each item As String In strSports
            lstNewArray.Items.Add("[" & item & "]")
        Next
    End Sub
End Class
