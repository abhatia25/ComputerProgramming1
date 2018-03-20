'Aditya Bhatia
'Bank Protection
'3/16/2018
Public Class frmDeposit
    Dim depositAmount As Double = 0
    Dim accountBalance As Double = 0
    Dim confirmation As String = Nothing
    Private Sub btnDepositSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositSubmit.Click
        Try
            Randomize()
            accountBalance = Rnd() * 9000
            depositAmount = Me.txtDeposit.Text
            confirmation = InputBox("Are you sure you want to deposit this money?", "Confirmation").ToLower
            If confirmation = "yes" Then
                accountBalance = accountBalance + depositAmount
                MessageBox.Show("Money Deposited")
                Me.Visible = False
                frmThanksFeedback.Visible = True
            ElseIf confirmation = "no" Then
                txtDeposit.Text = ""
            Else
                MessageBox.Show("Enter your answer as yes or no")
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter in a numerical value")
        End Try
    End Sub
End Class