'Aditya Bhatia'
'Practice with Buttons'
Public Class frmButtonpractice

    Private Sub btnStep1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep1.Click
        lblStep1.Text = " Design the interface "
    End Sub

    Private Sub btnStep2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep2.Click
        lblStep2.Text = " Plan the code "
    End Sub

    Private Sub btnStep3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStep3.Click
        lblStep3.Text = " Write the code "
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblStep1.Text = " "
        lblStep2.Text = " "
        lblStep3.Text = " "
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
