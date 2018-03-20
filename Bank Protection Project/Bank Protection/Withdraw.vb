'Aditya Bhatia
'Bank Protection
Public Class frmWithdraw
    Dim accountBalance As Double = 0
    Dim withdrawAmount As Double = 0
    Dim predictedBalance As Double = 0
    Dim confirmation As String = Nothing
    Private Sub btnWithdrawSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWithdrawSubmit.Click
        Try
            Randomize()
            accountBalance = Rnd() * 9000
            withdrawAmount = txtWithdraw.Text
            predictedBalance = accountBalance - withdrawAmount
            Select Case predictedBalance
                Case Is < 0
                    MessageBox.Show("Account balance is less than withdraw amount")
                Case Is >= 0
                    MessageBox.Show("Money withdrawn")
                    confirmation = InputBox("Are you sure you want to withdraw this money?", "Confirmation").ToLower
            End Select
            If confirmation = "yes" Then
                accountBalance = predictedBalance
                MessageBox.Show("Money withdrawn")
                Me.Visible = False
                frmThanksFeedback.Visible = True
            ElseIf confirmation = "no" Then
                txtWithdraw.Text = ""
            Else
                MessageBox.Show("Enter your answer as yes or no")
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter numerical values")
        End Try
    End Sub
End Class