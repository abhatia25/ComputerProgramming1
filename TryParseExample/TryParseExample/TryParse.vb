'Aditya Bhatia
'Try Parse Example
'4/18/2018
Public Class frmTryParse

    Private Sub btnTry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTry.Click
        Dim strNum As String = Nothing
        Dim dblNum As Double = 0

        strNum = txtInput.Text

        If Double.TryParse(strNum, dblNum) Then
            lblAnswer.Text = dblNum.ToString & " is a number"
        Else
            lblAnswer.Text = strNum & " is not a number"
        End If
    End Sub
End Class
