'Aditya Bhatia
'Computer Troubleshooting
'2/27/2018
Public Class frmComputerTroubleshooting
    Private Sub btnWhatToDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhatToDo.Click
        Dim beep As Char
        Dim spin As Char
        beep = Me.txtBeep.Text
        spin = Me.txtSpin.Text

        'Determine repair message
        If (spin = "Y" Or spin = "y") And (beep = "Y" Or beep = "y") Then       'hard drive spins and computer beeps
            Me.lblAnswer.Text = "Contact tech support."
        ElseIf (spin = "N" Or spin = "n") And (beep = "Y" Or beep = "y") Then   'hard drive doesn't spin and computer beeps
            Me.lblAnswer.Text = "Check drive contacts."
        ElseIf (spin = "Y" Or spin = "y") And (beep = "N" Or beep = "n") Then   'hard drive spins and computer doesn't beep
            Me.lblAnswer.Text = "Check the speaker connections."
        Else                                                                    'hard drive doesn't spin and computer doesn't beep
            Me.lblAnswer.Text = "Bring computer to repair center."
        End If
    End Sub

    Private Sub txtSpin_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSpin.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub txtBeep_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBeep.TextChanged
        Me.lblAnswer.Text = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextProgramToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NextProgramToolStripMenuItem.Click
        Me.Visible = False
        frmComplierErrors.Visible = True
    End Sub
End Class