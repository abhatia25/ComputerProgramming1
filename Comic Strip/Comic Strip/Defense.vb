'Aditya Bhatia
'Comic Strip 2
'3/4/2018
Public Class frmDefense
    Dim plays As Integer
    Dim driveyards As Integer
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmOffense2.Visible = True
    End Sub

    Private Sub frmDefense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblMessage.Text = "The Ball Has Been Kicked"
        picFootball.Visible = True
        grpKickoff.Visible = True
        radCenter.Visible = True
        radLeft.Visible = True
        radRight.Visible = True
    End Sub

    Private Sub radLeft_CheckedChanged(sender As Object, e As EventArgs) Handles radLeft.CheckedChanged
        If radCenter.Checked Or radRight.Checked Or radLeft.Checked Then
            btnKickoff.Visible = True
        Else
            btnKickoff.Visible = False
        End If
    End Sub

    Private Sub radCenter_CheckedChanged(sender As Object, e As EventArgs) Handles radCenter.CheckedChanged
        If radCenter.Checked Or radRight.Checked Or radLeft.Checked Then
            btnKickoff.Visible = True
        Else
            btnKickoff.Visible = False
        End If
    End Sub

    Private Sub radRight_CheckedChanged(sender As Object, e As EventArgs) Handles radRight.CheckedChanged
        If radCenter.Checked Or radRight.Checked Or radLeft.Checked Then
            btnKickoff.Visible = True
        Else
            btnKickoff.Visible = False
        End If
    End Sub

    Private Sub btnKickoff_Click(sender As Object, e As EventArgs) Handles btnKickoff.Click
        Randomize()
        Dim KickoffYards As Integer = Int(40 * Rnd()) + 1
        If radLeft.Checked Then
            MessageBox.Show("It's the other team's ball at the " & KickoffYards & "!")
            btnKickoff.Visible = False
            grpKickoff.Visible = False
            radCenter.Visible = False
            radLeft.Visible = False
            radRight.Visible = False
            plays += 1
            lblMessage.Text = "Play #" & plays & " - Defense"
            grpDefense.Visible = True
            chkPass.Visible = True
            chkRun.Visible = True
        End If
        If radRight.Checked Then
            MessageBox.Show("It's the other team's ball at the " & KickoffYards & "!")
            btnKickoff.Visible = False
            grpKickoff.Visible = False
            radCenter.Visible = False
            radLeft.Visible = False
            radRight.Visible = False
            plays += 1
            lblMessage.Text = "Play #" & plays & " - Defense"
            grpDefense.Visible = True
            chkPass.Visible = True
            chkRun.Visible = True
        End If
        If radCenter.Checked Then
            MessageBox.Show("It's the other team's ball at the " & KickoffYards & "!")
            btnKickoff.Visible = False
            grpKickoff.Visible = False
            radCenter.Visible = False
            radLeft.Visible = False
            radRight.Visible = False
            plays += 1
            lblMessage.Text = "Play #" & plays & " - Defense"
            grpDefense.Visible = True
            chkPass.Visible = True
            chkRun.Visible = True
        End If
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
        Dim defYards As Integer
        Randomize()
        Try
            Dim defYardsGained As Integer = Int(40 * Rnd()) + 1
            defYards = InputBox("How many yards would you like to limit the other team to?", "Getting user input", "5")
            MessageBox.Show("The other team has gained " & defYardsGained & "/" & defYards & " yards")
            driveyards += defYardsGained
            If defYardsGained >= 10 Then
                MessageBox.Show("First Down!")
                plays += 1
                lblMessage.Text = "Play #" & plays & " - Defense"
                chkPass.Checked = False
                chkRun.Checked = False
            Else
                MessageBox.Show("Second Down!")
                plays += 1
                lblMessage.Text = "Play #" & plays & " - Defense"
                chkPass.Checked = False
                chkRun.Checked = False
            End If
            If plays = 4 Then
                If driveyards < 10 Then
                    MessageBox.Show("It's time for offense!")
                    Select Case GlobalVariables.pointsScored
                        Case > 10
                            MessageBox.Show("This was a high scoring game!")
                        Case < 10
                            MessageBox.Show("This was a low scoring game!")
                    End Select
                    Me.Visible = False
                    frmOffense2.Visible = True
                End If
            End If
            If driveyards >= 100 Then
                MessageBox.Show("The other team scored, now it's time for offense")
                GlobalVariables.defScore += 1
                Select Case GlobalVariables.pointsScored
                    Case > 10
                        MessageBox.Show("This was a high scoring game!")
                    Case < 10
                        MessageBox.Show("This was a low scoring game!")
                End Select
                Me.Visible = False
                frmOffense2.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter in a numerical number of yards")
        End Try

    End Sub
End Class