'Aditya Bhatia
'Hurricane Wind Speeds
'3/15/2018
Public Class frmHurricaneWindSpeeds
    Private Sub btnCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategory.Click
        Dim speed As Integer
        Try
            speed = Me.txtMPH.Text

            Select Case speed
                Case 0 To 73
                    Me.lblCategory.Text = "Not strong enough to be a hurricane."
                Case 74 To 95
                    Me.lblCategory.Text = "Category 1: 74-95 mph or 64-82 kt or 119-153 km/hour"
                Case 96 To 110
                    Me.lblCategory.Text = "Category 2: 96-110 mph or 64-82 kt or 119-153 km/hour"
                Case 111 To 130
                    Me.lblCategory.Text = "Category 3: 111-130 mph or 64-82 kt or 119-153 km/hour"
                Case 131 To 155
                    Me.lblCategory.Text = "Category 4: 131-155 mph or 64-82 kt or 119-153 km/hour"
                Case Else
                    Me.lblCategory.Text = "Category 5: 156+ mph or 135+ kt or 249+ km/hour"
            End Select
        Catch ex As Exception
            MessageBox.Show("Please enter a numerical value")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmVowels.Visible = True
    End Sub
End Class