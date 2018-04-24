'Aditya Bhatia
'Loan Calculator
'4/23/2018
Public Class frmLoanCalculator
    Private Sub btnLoanAmount_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoanAmount.Click
        Dim rate As Double            'interest rate
        Dim lengthOfLoan As Integer 'length of loan in years
        Dim monthlyPayment As Decimal 'monthly payment
        Dim isValid As Boolean        'determine validity of amount and rate
        Dim loanAmount As Double 'loan amount calculated using PV
        Dim totalPaid As Decimal      'total amount spent
        Dim decAmtPaidInterest As Decimal 'total interest paid
        Dim monthlyRate As Double 'monthly interest rate
        Dim term As Integer           'term of loan in number of years

        'Get montly payment
        GetDollarAmount(Me.txtMonthlyPay, monthlyPayment, isValid)

        If isValid Then
            'Get interest rate
            GetPercentAmount(Me.txtRate, rate, isValid)
        End If

        If isValid Then
            'Get length of loan
            If Me.cboLengthYears.SelectedIndex >= 0 Then
                lengthOfLoan = Val(Me.cboLengthYears.SelectedItem) 'user selected item 
            Else
                If IsNumeric(Me.cboLengthYears.Text) Then
                    lengthOfLoan = Val(Me.cboLengthYears.Text)   'user typed value
                Else
                    isValid = False
                End If
            End If
        End If

        If isValid Then
            'Proceed with the Present Value calculation if all input values are valid
            monthlyRate = rate / 12
            term = lengthOfLoan * 12
            loanAmount = PV(monthlyRate, term, -monthlyPayment)

            totalPaid = monthlyPayment * term
            decAmtPaidInterest = totalPaid - loanAmount

            'Display information
            Me.lblAnswer.Text = "For monthly payments of " &
            Format(monthlyPayment, "Currency") &
            " for " & lengthOfLoan & " years at " & Format(rate, "percent") &
            " interest:" & vbCrLf & "The loan amount is " &
            Format(loanAmount, "Currency") & vbCrLf &
            "The total amount paid is " & Format(totalPaid, "Currency") &
            vbCrLf & "The total interest paid is " & Format(decAmtPaidInterest, "Currency")
        Else
            'Display an error message if any of the input values are not valid
            Me.lblAnswer.Text = "Data is Invalid"
        End If
    End Sub

    'Processes data in a text box to read a dollar amount, if any.
    '
    'post: dollars has been assigned a number if numeric data 
    'with or without a $ and commas is stored in the text box.
    'isValid has been set to True if a numeric value is stored
    'in the text box.
    '
    Sub GetDollarAmount(ByVal txtUserData As TextBox, ByRef dollars As Decimal, ByRef isValid As Boolean)
        Dim testAmount As String

        isValid = False                                 'assume nonnumeric data
        If txtUserData.Text <> Nothing Then
            testAmount = txtUserData.Text               'data typed
            testAmount = testAmount.Replace("$", "")    'delete $
            testAmount = testAmount.Replace(",", "")    'delete commas
            If IsNumeric(testAmount) Then               'numeric data
                dollars = Val(testAmount)
                isValid = True
            End If
        End If
    End Sub

    'Processes data in a text box to read a percentage amount, if any.
    '
    'post: percent has been assigned a decimal number if numeric 
    'data with or without a % is stored in the text box. 
    'isValid has been set to True if a numeric value is stored 
    'in the text box.
    '
    Sub GetPercentAmount(ByVal txtUserData As TextBox, ByRef percent As Double, ByRef isValid As Boolean)
        Dim testAmount As String

        isValid = False                              'assume nonnumeric data
        If txtUserData.Text <> Nothing Then
            testAmount = txtUserData.Text
            testAmount = testAmount.TrimEnd("%")  'delete %
            If IsNumeric(testAmount) Then                'numeric data
                If Val(testAmount) > 1 Then              'convert data
                    percent = Val(testAmount) / 100
                Else
                    percent = Val(testAmount)
                End If
                isValid = True
            End If
        End If
    End Sub

    Private Sub InputValues_Changed(ByVal SENDER As System.Object, ByVal e As System.EventArgs) Handles txtMonthlyPay.TextChanged, cboLengthYears.TextChanged, cboLengthYears.SelectedIndexChanged, txtRate.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmDiceRolls.Show()
    End Sub
End Class