'Aditya Bhatia
'Game Over
'5/1/2018
Public Class frmGameOver

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub btnPlayAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayAgain.Click
        GlobalVariables.intInventory1 = 0
        GlobalVariables.intInventory2 = 0
        GlobalVariables.intInventory3 = 0
        GlobalVariables.intInventory4 = 0
        frmIntroduction.Show()
        Me.Hide()
    End Sub
End Class