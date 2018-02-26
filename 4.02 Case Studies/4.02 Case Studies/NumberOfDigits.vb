'Aditya Bhatia
'Number of Digits
'2/26/2018
Public Class frmNumberOfDigits

    Private Sub btnCheckNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckNumber.Click
        Dim number As Integer

        number = Val(Me.txtNumber.Text)

        Select Case number
            Case -9 To 9    'one digit number
                Me.lblAnswer.Text = "The number is a one digit number."
            Case -99 To 99  'two digit number
                Me.lblAnswer.Text = "The number is a two digit number."
            Case Else       'more than 2 digits
                Me.lblAnswer.Text = "Number out of range."
        End Select
    End Sub

    Private Sub txtNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumber.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub CaseStudyCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaseStudyCalculatorToolStripMenuItem.Click
        Me.Visible = False
        frmCaseStudyCalculator.Visible = True
    End Sub

    Private Sub ShellGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShellGameToolStripMenuItem.Click
        Me.Visible = False
        frmShellGame.Visible = True
    End Sub
End Class