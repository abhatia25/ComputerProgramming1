'Aditya Bhatia
'Loan Analyzer
'4/17/2018
Public Class frmLoanAnalyzer
    'Displays options for choosing loan information and adds
    'appropriate choices to list box
    'post: Options have been displayed.
    Private Sub ImageClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles picAuto.Click, picHome.Click
        Dim picImageClicked As PictureBox = sender

        'Display options for choosing loan information
        Me.grpWhatToKnow.Visible = True
        Me.radHowMuch.Visible = True
        Me.radPaymentSize.Visible = True
        Me.btnNewLoan.Visible = True
        Me.btnCalculate.Visible = True
        'Calculate button should be displayed but disabled
        Me.btnCalculate.Enabled = False

        'Clear any existing list items
        Me.lstTerm.Items.Clear()

        'Add appropriate terms to list box depending on image clicked
        Select Case picImageClicked.Tag
            Case "auto"
                Me.lstTerm.Items.Add("2 years")
                Me.lstTerm.Items.Add("3 years")
                Me.lstTerm.Items.Add("5 years")
                Me.lstTerm.Items.Add("7 years")
            Case "home"
                Me.lstTerm.Items.Add("10 years")
                Me.lstTerm.Items.Add("15 years")
                Me.lstTerm.Items.Add("30 years")
        End Select
    End Sub

    'Hides loan information options. Clears label text.
    '
    'post: Loan options have been hidden and text in label 
    'text set to an empty string.
    '
    Private Sub btnNewLoan_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles btnNewLoan.Click
        Me.grpWhatToKnow.Visible = False
        Me.radHowMuch.Checked = False
        Me.radPaymentSize.Checked = False
        Me.lblTermPrompt.Visible = False
        Me.lstTerm.Visible = False
        Me.lblPrincipalOrPaymentPrompt.Visible = False
        Me.txtPrincipalOrPayment.Visible = False
        Me.lblRatePrompt.Visible = False
        Me.cboInterestRate.Visible = False
        Me.btnNewLoan.Visible = False
        Me.btnCalculate.Visible = False
        Me.lblResult.Text = Nothing
        Me.lblResult.Visible = True
    End Sub

    'Displays options for entering loan information
    '
    'post: Options have been displayed.
    '
    Private Sub WhatDoYouWantToKnow_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles radHowMuch.Click, radPaymentSize.Click
        Dim radOptionClicked As RadioButton = sender

        'Display term options
        Me.lblTermPrompt.Visible = True
        Me.lstTerm.Visible = True

        'Display either principal or payment options
        Select Case radOptionClicked.Tag
            Case "how much"
                Me.lblPrincipalOrPaymentPrompt.Text = "Desired Payment:"
            Case "payment size"
                Me.lblPrincipalOrPaymentPrompt.Text = "Loan Amount:"
        End Select
        Me.lblPrincipalOrPaymentPrompt.Visible = True
        Me.txtPrincipalOrPayment.Visible = True
        Me.txtPrincipalOrPayment.Text = Nothing

        'Display interest rate options
        Me.lblRatePrompt.Visible = True
        Me.cboInterestRate.Visible = True
        Me.cboInterestRate.Text = Nothing
    End Sub

    'Clears the last loan results. Checks for numeric loan information and
    'enables the Calcualte button if required data has been entered or
    'selected.
    '
    'post: The Results label has been cleared. The Calculate button has been
    'enabled if data has been entered or selected.
    '
    Private Sub InfoEntered(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles lstTerm.SelectedIndexChanged, _
    txtPrincipalOrPayment.TextChanged, cboInterestRate.SelectedIndexChanged, _
    cboInterestRate.TextChanged
        Me.lblResult.Text = Nothing
        Me.btnCalculate.Enabled = False

        If Me.txtPrincipalOrPayment.Text <> Nothing And _
        Me.cboInterestRate.Text <> Nothing Then
            Me.btnCalculate.Enabled = True
        End If
    End Sub

    'Displays either the monthly payment for a loan or a loan amount that can 
    'be borrowed.
    '
    'post: The calculation result for the selected term, principal or
    'payment, and interest rate have been displayed.
    '
    Private Sub btnCalculate_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim term As Integer
        Dim principalOrPayment As Decimal
        Dim rate As Double
        Dim result As Decimal
        Dim validData As Boolean
        Me.lblResult.Visible = True

        'Get term
        term = Val(Me.lstTerm.SelectedItem)

        'Get principal or payment
        GetDollarAmount(Me.txtPrincipalOrPayment, principalOrPayment, validData)

        'Get interest rate if principal or payment is valid
        If validData Then
            GetPercentAmount(Me.cboInterestRate, rate, validData)
        End If

        'Calculate result if principal or payment and interest are valid
        If validData Then
            If Me.radHowMuch.Checked Then
                result = PV(rate / 12, term * 12, -principalOrPayment)
                Me.lblResult.Text = "Loan amount: " & Format(result, "Currency")
            Else
                result = Pmt(rate / 12, term * 12, -principalOrPayment)
                Me.lblResult.Text = "Payment amount: " & Format(result, "Currency")
            End If
        Else
            Me.lblResult.Text = "Data not valid."
        End If
    End Sub

    'Processes data in a text box to read a dollar amount,
    'if any
    '
    'post: dollars has been assigned a number if numeric data 
    'with or without a $ and commas is stored in the text box. 
    'isValid has been set to True if a numeric value is stored 
    'in the text box.
    '
    Sub GetDollarAmount(ByVal txtUserData As TextBox, ByRef dollars As Decimal, _
    ByRef isValid As Boolean)
        Dim testAmount As String

        isValid = False         'assume nonnumeric data
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


    'Processes data in a combo box to read a percentage amount,
    'if any
    '
    'post: percent has been assigned a decimal number if numeric data 
    'with or without a % is stored in the combo box. isValid has been 
    'set to True if a numeric value is stored in the combo box.
    '
    Sub GetPercentAmount(ByVal cboUserData As ComboBox, ByRef percent As Double, _
    ByRef isValid As Boolean)
        Dim testAmount As String

        isValid = False             'assume nonnumeric data
        If cboUserData.Text <> Nothing Then
            testAmount = cboUserData.Text
            testAmount = testAmount.TrimEnd("%")        'delete %
            If IsNumeric(testAmount) Then               'numeric data
                If Val(testAmount) >= 1 Then            'convert data
                    percent = Val(testAmount) / 100
                Else
                    percent = Val(testAmount)
                End If
                isValid = True
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmCardGame.Show()
    End Sub
End Class