'Aditya bhatia
'List Box Tuition Calculator
Public Class frmListBoxTuitionCalculator

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Const decUnderGraduatePerHour As Decimal = 75
        Const decGraduatePerHour As Decimal = 145
        Const decThesisPerHour As Decimal = 160
        Dim decTuition As Decimal

        Select Case Me.lstCourseLevels.SelectedItem
            Case "Undergraduate"
                decTuition = decUnderGraduatePerHour
            Case "Graduate"
                decTuition = decGraduatePerHour
            Case "Thesis and Dissertation"
                decTuition = decThesisPerHour
        End Select

        Me.lblTuition.Text = "Tuition is " & Format(decTuition, "Currency") & "per credit hour"

    End Sub

    Private Sub lstCourseLevels_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCourseLevels.SelectedIndexChanged
        Me.lblTuition = Nothing
    End Sub
End Class
