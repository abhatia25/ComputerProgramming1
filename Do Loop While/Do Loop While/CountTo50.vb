Public Class frmCountTo50

    Private Sub frmCountTo50_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim intResult As Integer
        Do
            intResult = intResult + i
            i += 1
        Loop While (intResult <= 50)
        lblResult.Text = intResult.ToString
    End Sub
End Class
