'Aditya Bhatia
'Shell Game
'2/26/2018
Public Class frmShellGame

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub CaseStudyCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaseStudyCalculatorToolStripMenuItem.Click
        Me.Visible = False
        frmCaseStudyCalculator.Visible = True
    End Sub

    Private Sub NumberOfDigitsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberOfDigitsToolStripMenuItem.Click
        Me.Visible = False
        frmNumberOfDigits.Visible = True
    End Sub

    'Determines which shell was clicked and displays a message if shell clicked is the same as a randomly chosen shell.
    'pre: Shell picture objects have valid Tag properties
    'post: The hidden pearl has been shown and a message box has been displayed.

    Private Sub picShell1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim picShellClicked As PictureBox = sender
        Dim shellClicked As Integer = Val(picShellClicked.Tag)

        Randomize()
        Dim shellWithPearl As Integer = Int(3 * Rnd()) + 1

        Select Case shellWithPearl
            Case 1
                Me.picPearl1.Visible = True
            Case 2
                Me.picPearl2.Visible = True
            Case 3
                Me.picPearl3.Visible = True

        End Select

        If shellClicked = shellWithPearl Then
            MessageBox.Show("You Win!")
        Else
            MessageBox.Show("You Lose!")
        End If
        Select Case shellWithPearl
            Case 1
                Me.picPearl1.Visible = False
            Case 2
                Me.picPearl2.Visible = False
            Case 3
                Me.picPearl3.Visible = False

        End Select
    End Sub

End Class