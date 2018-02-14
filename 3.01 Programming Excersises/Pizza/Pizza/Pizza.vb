'Aditya Bhatia
'3.01 Programming Excersises
'2/12/2018
Public Class frmPizza

    Private Sub chkPepperoni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPepperoni.CheckedChanged
        lblChoice1.Text = "You chose to add pepperoni."
    End Sub

    Private Sub chkCheese_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheese.CheckedChanged
        lblChoice2.Text = "You chose to add cheese."
    End Sub

    Private Sub chkMushrooms_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMushrooms.CheckedChanged
        lblChoice3.Text = "You chose to add mushrooms."
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        chkCheese.Checked = False
        chkMushrooms.Checked = False
        chkPepperoni.Checked = False
        lblChoice1.Text = ""
        lblChoice2.Text = ""
        lblChoice3.Text = ""
        MessageBox.Show("Cleared")
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        MessageBox.Show("Have a good day!")
        End
    End Sub
End Class
