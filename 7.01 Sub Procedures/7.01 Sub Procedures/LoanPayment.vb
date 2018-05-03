'Aditya Bhatia
'Loan Payment
'4/29/2018
Public Class frmLoanPayment
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmLumberyardHelper.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim sngRate, sngPrincipal As Single
        Dim intTerm As Integer
        Dim sngPayment As Single
        Dim blnValidData As Boolean

        GetPercentAmount(Me.txtRate.Text, sngRate, blnValidData)

        If blnValidData Then
            intTerm = Val(Me.txtTerm.Text)
            If intTerm <= 0 Then
                blnValidData = False
            End If
        End If

        If blnValidData Then
            GetDollarAmount(Me.txtPrincipal.Text, sngPrincipal, blnValidData)
        End If

        If blnValidData Then
            sngPayment = Pmt(sngRate / 12, intTerm * 12, -sngPrincipal)
            Me.lblMonthlyPayment.Text = "The monthly payment for a loan of " & Format(sngPrincipal, "Currency") & " at " & sngRate & "% for " & intTerm & " years is " & Format(sngPayment, "Currency")
        Else
            Me.lblMonthlyPayment.Text = "Enter valid data."
        End If
    End Sub

    Sub GetPercentAmount(ByVal strRate As String, ByRef sngRate As Single, ByRef blnValidData As Boolean)
        If Convert.ToDouble(strRate) < 1 Then
            sngRate = strRate * 100
            blnValidData = True
        ElseIf Convert.ToDouble(strRate) > 100 Then
            MessageBox.Show("Rate cannot be over 100%")
            blnValidData = False
        Else
            sngRate = strRate
            blnValidData = True
        End If
    End Sub

    Sub GetDollarAmount(ByVal strPrincipal As String, ByRef sngPrincipal As Single, ByRef blnValidData As Boolean)
        If Convert.ToDouble(strPrincipal) < 0 Then
            MessageBox.Show("Principal cannot be less than 0")
            blnValidData = False
        Else
            sngPrincipal = strPrincipal
            blnValidData = True
        End If
    End Sub

    Private Sub NewDataEntered(sender As Object, e As EventArgs) Handles txtRate.TextChanged, txtPrincipal.TextChanged, txtTerm.TextChanged
        Me.lblMonthlyPayment.Text = Nothing
    End Sub
End Class