'Aditya Bhatia
'My User Validation
'3/14/2018
Public Class frmMyUserValidation

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmHurricaneWindSpeeds.Visible = True
    End Sub

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        If MaskedTextBox1.Text = "555-55-1212" And MaskedTextBox2.Text = "54321" Then
            MessageBox.Show("Welcome to the system!")
            MessageBox.Show("The system is offline right now.")
        Else
            MessageBox.Show("I don't recognize this number")
        End If
    End Sub
End Class
