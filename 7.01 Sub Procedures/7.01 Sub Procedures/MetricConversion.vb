'Aditya Bhatia
'Metric Conversion
'5/3/2018
Public Class frmMetricConversion
    Dim dblNumber As Double
    Dim dblAnswer As Double
    Dim strAnswerType As String
    Dim strInputType As String

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnInToCent_Click(sender As Object, e As EventArgs) Handles btnInToCent.Click
        GetNumber(dblNumber)
        dblAnswer = dblNumber * 2.54
        strInputType = "inches"
        strAnswerType = "centimeters"
        DisplayAnswer(dblAnswer)
    End Sub

    Private Sub btnCentToIn_Click(sender As Object, e As EventArgs) Handles btnCentToIn.Click
        GetNumber(dblNumber)
        dblAnswer = dblNumber / 2.54
        strInputType = "centimeters"
        strAnswerType = "inches"
        DisplayAnswer(dblAnswer)
    End Sub

    Private Sub btnFtToCent_Click(sender As Object, e As EventArgs) Handles btnFtToCent.Click
        GetNumber(dblNumber)
        dblAnswer = dblNumber * 30
        strAnswerType = "centimeters"
        strInputType = "feet"
        DisplayAnswer(dblAnswer)
    End Sub

    Private Sub btnCentToFeet_Click(sender As Object, e As EventArgs) Handles btnCentToFeet.Click
        GetNumber(dblNumber)
        dblAnswer = dblNumber / 30
        strAnswerType = "feet"
        strAnswerType = "centimeters"
        DisplayAnswer(dblAnswer)
    End Sub

    Private Sub btnMtToYd_Click(sender As Object, e As EventArgs) Handles btnMtToYd.Click
        GetNumber(dblNumber)
        dblAnswer = dblNumber * 0.91
        strInputType = "meters"
        strAnswerType = "yards"
        DisplayAnswer(dblAnswer)
    End Sub

    Private Sub btnYdToMt_Click(sender As Object, e As EventArgs) Handles btnYdToMt.Click
        GetNumber(dblNumber)
        dblAnswer = dblNumber / 0.91
        strAnswerType = "meters"
        strInputType = "yards"
        DisplayAnswer(dblAnswer)
    End Sub

    Private Sub btnKiToMi_Click(sender As Object, e As EventArgs) Handles btnKiToMi.Click
        GetNumber(dblNumber)
        dblAnswer = dblNumber * 1.6
        strInputType = "kilometers"
        strAnswerType = "miles"
        DisplayAnswer(dblAnswer)
    End Sub

    Private Sub btnMiToKi_Click(sender As Object, e As EventArgs) Handles btnMiToKi.Click
        GetNumber(dblNumber)
        dblAnswer = dblNumber / 1.6
        strInputType = "miles"
        strAnswerType = "kilometers"
        DisplayAnswer(dblAnswer)
    End Sub

    Sub GetNumber(ByRef dblNumber As Double)
        Double.TryParse(txtNumber.Text, dblNumber)
    End Sub

    Sub DisplayAnswer(ByVal dblAnswer As Double)
        Me.lblAnswer.Text = dblNumber & " " & strInputType & " equals " & dblAnswer & " " & strAnswerType
    End Sub
End Class