'Aditya Bhatia
'3.01 Programming Excersises
'2/12/2018
Public Class frmSandwich

    Private Sub radHam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radHam.CheckedChanged
        lblMainChoice.Text = "You chose the ham sandwich."
    End Sub

    Private Sub radTurkey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radTurkey.CheckedChanged
        lblMainChoice.Text = "You chose the turkey sandwich."
    End Sub

    Private Sub chkMayo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMayo.CheckedChanged
        lblChoice1.Text = "You would like mayonnaise."
    End Sub

    Private Sub chkMustard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMustard.CheckedChanged
        lblChoice2.Text = "You would like mustard."
    End Sub

    Private Sub chkCheese_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheese.CheckedChanged
        lblChoice3.Text = "You would like cheese."
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Thank you for shopping!")
        End
    End Sub

    Private Sub frmSandwich_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to the Sandwich Shop!")
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        chkCheese.Checked = False
        chkMayo.Checked = False
        chkMustard.Checked = False
        lblMainChoice.Text = ""
        lblChoice1.Text = ""
        lblChoice2.Text = ""
        lblChoice3.Text = ""
        MessageBox.Show("Cleared")
    End Sub
End Class
