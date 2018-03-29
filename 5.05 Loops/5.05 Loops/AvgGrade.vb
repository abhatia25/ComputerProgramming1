'Aditya Bhatia
'Average Grade
'3/23/2018
Public Class frmAvgGrade
    Dim gradesEntered As Integer = 1
    Dim gradesSum As Double = 0
    Dim gradeEntered As Double = 0
    Dim gradeAverage As Double = 0

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmMotivation.Visible = True
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Do While gradesEntered <= 5
            gradeEntered += InputBox("Please enter a grade", "Grades")
            gradesSum += gradeEntered
            lblAnswer.Text &= "Grade Entered: " & gradeEntered & vbCrLf
            gradesEntered += 1
            gradeEntered = 0
        Loop
        gradeAverage = gradesSum / 5
        lblAnswer.Text &= "Grade Average: " & gradeAverage.ToString
    End Sub
End Class