'Aditya Bhatia
'Package Check
'2/27/2018
Public Class frmPackageCheck
    Private Sub btnCheckPackage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckPackage.Click
        Dim weight As Single
        Dim length As Single
        Dim width As Single
        Dim height As Single
        Dim cubicMeters As Single
        weight = Val(Me.txtWeight.Text)
        length = Val(Me.txtLength.Text)
        width = Val(Me.txtWidth.Text)
        height = Val(Me.txtHeight.Text)
        cubicMeters = length * width * height

        'Check package requirements and display appropriate message
        If weight > 27 And cubicMeters > 100000 Then    'package too large and too heavy
            Me.lblAnswer.Text = "Rejected: Too heavy and too large"
        ElseIf weight > 27 Then                         'package too heavy
            Me.lblAnswer.Text = "Rejected: Too heavy"
        ElseIf cubicMeters > 100000 Then                'package too large
            Me.lblAnswer.Text = "Rejected: Too large"
        Else
            Me.lblAnswer.Text = "Package accepted" 'package is good
        End If
    End Sub

    Private Sub txtWeight_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWeight.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub txtHeight_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHeight.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub txtWidth_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWidth.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub txtLength_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLength.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub OtherProgramsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtherProgramsToolStripMenuItem.Click
        Me.Visible = False
        frmComputerTroubleshooting.Visible = True
    End Sub
End Class
