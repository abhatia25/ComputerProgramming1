'Aditya Bhatia
'Twinkle Twinkle
'4/23/2018
Public Class frmTwinkleTwinkle
    Private Sub displayTwinkle()
        Me.lblDisplayPoem.Text = "Twinkle Twinkle Little Star" & vbCrLf & "How I Wonder What You Are" & vbCrLf & "Up Above The World So Bright" & vbCrLf & "Like a Diamond In The Night"
    End Sub

    Private Sub displayFrost()
        Me.lblDisplayPoem.Text = "Some say the world will end in fire," & vbCrLf & "Some say in ice." & vbCrLf & "From what I’ve tasted of desire" & vbCrLf & "I hold with those who favor fire." & vbCrLf & "But if it had to perish twice," & vbCrLf & "I think I know enough of hate" & vbCrLf & "To say that for destruction ice" & vbCrLf & "Is also great" & vbCrLf & "And would suffice."
    End Sub

    Private Sub poemChoiceDialogBox()
        Dim poemChoiceDB As New frmPoemChoiceDialogBox()
        'Show dialog box
        poemChoiceDB.ShowDialog()
        If poemChoiceDB.DialogResult = Windows.Forms.DialogResult.OK Then
            If poemChoiceDB.radTwinkleTwinkle.Checked Then
                displayTwinkle()
            Else
                displayFrost()
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmMultiples.Show()
    End Sub

    Private Sub btnShowPoem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPoem.Click
        poemChoiceDialogBox()
    End Sub
End Class
