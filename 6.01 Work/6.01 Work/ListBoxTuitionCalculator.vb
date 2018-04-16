'Aditya Bhatia
'List Box Tuition Calculator
'4/16/2018
Public Class frmListBoxTuitionCalculator

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Const decUnderGraduatePerHour As Decimal = 75
        Const decGraduatePerHour As Decimal = 145
        Const decThesisPerHour As Decimal = 160
        Dim intCreditHours As Integer
        Dim decTuition As Double = 0
        If Me.cboCreditHours.SelectedIndex = 0 Then
            intCreditHours = Val(Me.cboCreditHours.SelectedItem)
        Else
            intCreditHours = Val(Me.cboCreditHours.Text)
        End If
        Select Case Me.lstCourseLevels.SelectedItem
            Case "Undergraduate"
                decTuition = decUnderGraduatePerHour * intCreditHours
            Case "Graduate"
                decTuition = decGraduatePerHour * intCreditHours
            Case "Thesis and Dissertation"
                decTuition = decThesisPerHour * intCreditHours
        End Select
        Me.lblAnswer.Text = "Tuition is " & Format(decTuition, "Currency") & " for the total credit hours requested."
    End Sub

    Private Sub lstCourseLevels_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCourseLevels.SelectedIndexChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
