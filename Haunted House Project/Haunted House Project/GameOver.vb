'Aditya Bhatia
'Haunted House Project - Game Over
'3/29/2018
Public Class frmGameOver

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        Me.Visible = False
        frmInstructions.Visible = True
    End Sub
End Class