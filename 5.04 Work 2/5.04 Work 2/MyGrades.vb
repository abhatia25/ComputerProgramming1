'Aditya Bhatia
'My Grades
'3/19/2018
Public Class frmMyGrades
    Dim userGrade As Double = 0

    Private Sub btnYourGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYourGrade.Click
        Try
            userGrade = txtGrade.Text
            Select Case userGrade
                Case 93 To 100
                    Me.lblAnswer.Text = "You made an A"
                Case 85 To 92
                    Me.lblAnswer.Text = "You made a B"
                Case 77 To 84
                    Me.lblAnswer.Text = "You made a C"
                Case 70 To 76
                    Me.lblAnswer.Text = "You made a D"
                Case 0 To 69
                    Me.lblAnswer.Text = "Study more"
            End Select
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmCellPhone.Visible = True
    End Sub
End Class