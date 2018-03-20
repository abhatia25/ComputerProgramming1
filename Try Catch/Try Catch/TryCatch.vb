'Aditya Bhatia
'Try Catch II
'3/14/2018
Public Class frmTryCatch
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim number As Integer
        Try
            number = Convert.ToInt32(txtNumber.Text)

            If number = 15 Then
                MessageBox.Show("The number is 15")
            ElseIf number < 15 Then
                MessageBox.Show("The number is less than 15")
            ElseIf number > 15 Then
                MessageBox.Show("The number is greater than 15")
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a numeric value")
        End Try
    End Sub
End Class
