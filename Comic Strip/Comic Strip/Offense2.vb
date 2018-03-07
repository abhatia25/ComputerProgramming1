'Aditya Bhatia
'Comic Strip 3
'3/4/2018
Public Class frmOffense2

    Dim plays As Integer
    Dim driveyards As Integer
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub frmOffense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblMessage.Text = "The Ball Has Been Kicked"
        picFootball.Visible = True
        grpKickoff.Visible = True
        radFairCatch.Visible = True
        radRun.Visible = True
        radTouchback.Visible = True
    End Sub

    Private Sub radRun_CheckedChanged(sender As Object, e As EventArgs) Handles radRun.CheckedChanged
        If radFairCatch.Checked Or radTouchback.Checked Or radRun.Checked Then
            btnKickoff.Visible = True
        Else
            btnKickoff.Visible = False
        End If
    End Sub

    Private Sub radFairCatch_CheckedChanged(sender As Object, e As EventArgs) Handles radFairCatch.CheckedChanged
        If radFairCatch.Checked Or radTouchback.Checked Or radRun.Checked Then
            btnKickoff.Visible = True
        Else
            btnKickoff.Visible = False
        End If
    End Sub

    Private Sub radTouchback_CheckedChanged(sender As Object, e As EventArgs) Handles radTouchback.CheckedChanged
        If radFairCatch.Checked Or radTouchback.Checked Or radRun.Checked Then
            btnKickoff.Visible = True
        Else
            btnKickoff.Visible = False
        End If
    End Sub

    Private Sub btnKickoff_Click(sender As Object, e As EventArgs) Handles btnKickoff.Click
        Randomize()
        Dim KickoffYards As Integer = Int(20 * Rnd()) + 1
        Dim FairCatchYards As Integer = Int(35 * Rnd()) + 1
        If radRun.Checked Then
            MessageBox.Show("You gained " & KickoffYards & " yards!")
            btnKickoff.Visible = False
            grpKickoff.Visible = False
            radFairCatch.Visible = False
            radRun.Visible = False
            radTouchback.Visible = False
            plays += 1
            lblMessage.Text = "Play #" & plays & " - Offense"
            grpOffense.Visible = True
            chkPass.Visible = True
            chkRun.Visible = True
        End If
        If radTouchback.Checked Then
            MessageBox.Show("It's your ball at the 25!")
            btnKickoff.Visible = False
            grpKickoff.Visible = False
            radFairCatch.Visible = False
            radRun.Visible = False
            radTouchback.Visible = False
            plays += 1
            lblMessage.Text = "Play #" & plays & " - Offense"
            grpOffense.Visible = True
            chkPass.Visible = True
            chkRun.Visible = True
        End If
        If radFairCatch.Checked Then
            MessageBox.Show("It's your ball at the " & FairCatchYards & "!")
            btnKickoff.Visible = False
            grpKickoff.Visible = False
            radFairCatch.Visible = False
            radRun.Visible = False
            radTouchback.Visible = False
            plays += 1
            lblMessage.Text = "Play #" & plays & " - Offense"
            grpOffense.Visible = True
            chkPass.Visible = True
            chkRun.Visible = True
        End If
        picFootballField.Visible = True
    End Sub

    Private Sub chkRun_CheckedChanged(sender As Object, e As EventArgs) Handles chkRun.CheckedChanged
        If chkPass.Checked Or chkRun.Checked Then
            btnOffense.Visible = True
        Else
            btnOffense.Visible = False
        End If
    End Sub

    Private Sub chkPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkPass.CheckedChanged
        If chkPass.Checked Or chkRun.Checked Then
            btnOffense.Visible = True
        Else
            btnOffense.Visible = False
        End If
    End Sub

    Private Sub btnOffense_Click(sender As Object, e As EventArgs) Handles btnOffense.Click
        Dim offYards As Integer
        Randomize()
        Try
            Dim offYardsGained As Integer = Int(40 * Rnd()) + 1
            offYards = InputBox("How many yards would you like to gain?", "Getting user input", "10")
            MessageBox.Show("You have gained " & offYardsGained & "/" & offYards & " yards")
            driveyards += offYardsGained
            If offYardsGained >= 10 Then
                MessageBox.Show("First Down!")
                plays += 1
                lblMessage.Text = "Play #" & plays & " - Offense"
                chkPass.Checked = False
                chkRun.Checked = False
            Else
                MessageBox.Show("Second Down!")
                plays += 1
                lblMessage.Text = "Play #" & plays & " - Offense"
                chkPass.Checked = False
                chkRun.Checked = False
            End If
            If plays = 4 Then
                If driveyards < 10 Then
                    MessageBox.Show("It's the other team's ball")
                    Select Case GlobalVariables.pointsScored
                        Case > 10
                            MessageBox.Show("This was a high scoring game!")
                        Case < 10
                            MessageBox.Show("This was a low scoring game!")
                    End Select
                End If
            End If
            If driveyards >= 100 Then
                MessageBox.Show("You scored, now you will be on defense")
                Select Case GlobalVariables.pointsScored
                    Case > 10
                        MessageBox.Show("This was a high scoring game!")
                    Case < 10
                        MessageBox.Show("This was a low scoring game!")
                End Select
                GlobalVariables.offScore += 1
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter in a numerical number of yards")
        End Try
    End Sub
End Class