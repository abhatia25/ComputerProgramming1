'Aditya Bhatia
'5.03 Practice
'3/7/2018
Public Class frmPractice
    Dim intNum1 As Integer = 0
    Dim intNum2 As Integer = 0
    Dim div As Double = 0
    Dim intdiv As Double = 0
    Dim moddiv As Double = 0
    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        Try
            intNum1 = Convert.ToInt32(txtNum1.Text)
            intNum2 = Convert.ToInt32(txtNum2.Text)
            div = intNum1 / intNum2
            intdiv = intNum1 \ intNum2
            moddiv = intNum1 Mod intNum2
            lblAnswer.Text = "Division: " & div & vbCrLf & "Integer Division: " & intdiv & vbCrLf & "Modular Division: " & moddiv
        Catch ex As Exception
            MessageBox.Show("Please enter numerical values")
        End Try
    End Sub
End Class
