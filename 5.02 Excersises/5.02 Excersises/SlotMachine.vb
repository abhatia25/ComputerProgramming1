'Aditya Bhatia
'Slot Machine Game
'3/6/2018
Public Class frmSlotMachine
    Private Sub btnPull_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPull.Click
        Randomize()
        Static tokens As Integer = 100
        Dim number1 As Integer
        Dim number2 As Integer
        Dim number3 As Integer

        If tokens = 0 Then   'check to see if player has tokens
            MessageBox.Show("You are out of tokens.")
        ElseIf tokens < 0 Then
            MessageBox.Show("go borrow more money from Parker")

        Else
            tokens -= 4
            Me.lblTokens.Text = tokens

            'Generate random numbers for each wheel
            number1 = Int(3 * Rnd()) + 1
            Me.lblWheel1.Text = number1
            number2 = Int(3 * Rnd()) + 1
            Me.lblWheel2.Text = number2
            number3 = Int(3 * Rnd()) + 1
            Me.lblWheel3.Text = number3

            If number1 = number2 And number2 = number3 Then
                Select Case number1
                    Case 1      '1 1 1 case (win 4 tokens)
                        tokens += 4
                        MessageBox.Show("You get 4 tokens!")
                    Case 2      '2 2 2 case (win 8 tokens)
                        tokens += 8
                        MessageBox.Show("You get 8 tokens!")
                    Case 3      '3 3 3 case (win 12 tokens)
                        tokens += 12
                        MessageBox.Show("You get 12 tokens!")
                End Select
            Else                'one of the winning combinations did not appear
                MessageBox.Show("You lost.")
            End If
        End If
        Me.lblTokens.Text = tokens
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmBirthdayProgram.Visible = True
        MessageBox.Show("Form switched")
    End Sub
End Class
