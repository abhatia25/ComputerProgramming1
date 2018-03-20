'Aditya Bhatia
'Quick Cuts
'3/19/2018
Public Class frmQuickCuts
    Const HairCut As Decimal = 9.95
    Const Shampoo As Decimal = 3.95
    Const Style As Decimal = 5.95
    Const Massage As Decimal = 2.95
    Dim TotalCost As Decimal = 0

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmSuperSize.Visible = True
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        TotalCost = 0
        If chkStyle.Checked Then
            TotalCost += Style
        End If
        If chkHairCut.Checked Then
            TotalCost += HairCut
        End If
        If chkMassage.Checked Then
            TotalCost += Massage
        End If
        If chkShampoo.Checked Then
            TotalCost += Shampoo
        End If
        lblAnswer.Text = TotalCost
    End Sub
End Class