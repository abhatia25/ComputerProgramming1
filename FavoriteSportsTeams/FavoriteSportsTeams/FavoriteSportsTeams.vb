'Aditya Bhatia
'2/5/2018
'Creative Project
Public Class frmFavoriteSportsTeams

    Private Sub frmSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to this survey!")
    End Sub

    Private Sub lblResponse_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblResponse.MouseEnter
        lblResponse.Text = "No need to hurt me!"
    End Sub
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        If Not (Me.chkPats.Checked And Me.chk76ers.Checked) Then
            lblResponse.Text = "Really? You've gotta be kiddding me!"
        Else
            lblResponse.Text = "Nice! Have a good day!"
        End If
    End Sub

    Private Sub lblResponse_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblResponse.MouseLeave
        lblResponse.Text = "Thank you for not hurting me! Have a nice day!"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Thank you! Have a nice day!")
        End
    End Sub
End Class
