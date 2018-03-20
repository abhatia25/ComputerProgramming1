'Aditya Bhatia
'Ready for School v2
'3/19/2018
Public Class frmReadyForSchool

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
        End
    End Sub

    Private Sub chkHomework_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHomework.CheckedChanged
        If Me.chkHomework.Checked Then
            MessageBox.Show("Great Job")
        End If
        lblMessage.Text &= "Homework Done" & vbCrLf
    End Sub

    Private Sub chkBreakfast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBreakfast.CheckedChanged
        MessageBox.Show("Good job!")
        lblMessage.Text &= "Eaten Breakfast" & vbCrLf
    End Sub

    Private Sub chkBrush_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBrush.CheckedChanged
        MessageBox.Show("Good job!")
        lblMessage.Text &= "Teeth Brushed" & vbCrLf
    End Sub

    Private Sub btnReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReady.Click
        If chkBreakfast.Checked And chkBrush.Checked And chkHomework.Checked Then
            lblMessage.Text &= "Ready for School"
        Else
            If Not (Me.chkHomework.Checked And Me.chkBreakfast.Checked And Me.chkBrush.Checked) Then
                MessageBox.Show("Are you sure you are ready for school")
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmRandom.Visible = True
    End Sub
End Class