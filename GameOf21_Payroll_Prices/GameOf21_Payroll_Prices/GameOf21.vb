'Aditya Bhatia
'Game of 21
'2/22/2018
Public Class frmGameOf21
    Dim playerTotal As Integer
    Dim computerTotal As Integer
    Dim computerCard1 As Integer
    Dim computerCard2 As Integer
    Dim computerCard3 As Integer
    Dim playerCard1 As Integer
    Dim playerCard2 As Integer

    Private Sub PlayGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayGameToolStripMenuItem.Click
        playerTotal = 0
        computerTotal = 0
        Me.lblPlayerDrewCard.Text = Nothing
        Me.lblComputersScore.Text = Nothing

        'Deal cards to player
        Randomize()
        playerCard1 = Int(10 * Rnd() + 1)
        playerCard2 = Int(10 * Rnd() + 1)
        Me.lblPlayerCard1.Text = playerCard1
        Me.lblPlayerCard2.Text = playerCard2
        playerTotal = playerCard1 + playerCard2

        'Determine computer cards
        computerCard1 = Int(10 * Rnd() + 1)
        computerCard2 = Int(10 * Rnd() + 1)
        computerCard3 = Int(10 * Rnd() + 1)
        Me.lblComputerCard1.Text = "*"          'hide cards for now
        Me.lblComputerCard2.Text = "*"
        Me.lblComputerCard3.Text = "*"
        computerTotal = computerCard1 + computerCard2 + computerCard3
        Me.lblPlayersScore.Text = playerTotal
    End Sub

    Private Sub btnCheckScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckScores.Click
        Me.lblComputerCard1.Text = computerCard1
        Me.lblComputerCard2.Text = computerCard2
        Me.lblComputerCard3.Text = computerCard3
        Me.lblComputersScore.Text = computerTotal

        If computerTotal > 21 And playerTotal > 21 Then                     'draw, both players over 21
            MessageBox.Show("Both players went over 21. It is a draw")
        ElseIf computerTotal > playerTotal And computerTotal <= 21 Then   'computer has higher score and wins
            MessageBox.Show("Computer wins.")
        ElseIf playerTotal > computerTotal And playerTotal <= 21 Then     'player has higher score and wins
            MessageBox.Show("Player wins.")
        ElseIf playerTotal = computerTotal And playerTotal <= 21 And
        computerTotal <= 21 Then                                            'draw, scores are equal
            MessageBox.Show("Both scores are equal. It is a draw")
        ElseIf playerTotal > 21 Then                                        'player went over 21
            MessageBox.Show("Player went over 21. Computer wins.")
        Else                                                                'computer went over 21
            MessageBox.Show("Computer went over 21. Player wins.")
        End If

    End Sub

    Private Sub btnDrawCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawCard.Click
        Dim drawCard As Integer = Int(10 * Rnd()) + 1

        Me.lblPlayerDrewCard.Text = drawCard
        playerTotal = playerCard1 + playerCard2 + drawCard
        Me.lblPlayersScore.Text = playerTotal
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
        Application.Exit()
    End Sub

    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click
        Me.Visible = False
        frmPayroll.Visible = True
    End Sub

    Private Sub PricesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PricesToolStripMenuItem.Click
        Me.Visible = False
        frmPrices.Visible = True
    End Sub
End Class
