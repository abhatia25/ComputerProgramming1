'Aditya Bhatia
'Challenge Game
'5/23/2018
Public Class frmChallengeGame
    Dim collision As Boolean = False
    Dim currentLocation As Point
    Dim nextLocation As Point
    Dim exitReached As Boolean = False

    Private Sub frmChallengeGame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            currentLocation = picPlayer.Location
            nextLocation = picPlayer.Location
            nextLocation.X = currentLocation.X + 5
            picPlayer.Location = nextLocation
        End If

        If e.KeyCode = Keys.Left Then
            currentLocation = picPlayer.Location
            nextLocation = picPlayer.Location
            nextLocation.X = currentLocation.X - 5
            picPlayer.Location = nextLocation
        End If

        If e.KeyCode = Keys.Up Then
            currentLocation = picPlayer.Location
            nextLocation = picPlayer.Location
            nextLocation.Y = currentLocation.Y - 5
            picPlayer.Location = nextLocation
        End If

        If e.KeyCode = Keys.Down Then
            currentLocation = picPlayer.Location
            nextLocation = picPlayer.Location
            nextLocation.Y = currentLocation.Y + 5
            picPlayer.Location = nextLocation
        End If
        collision = False
        For Each PictureBox In Me.Controls
            If PictureBox IsNot picPlayer AndAlso picPlayer.Bounds.IntersectsWith(PictureBox.Bounds) Then
                If PictureBox IsNot picExit AndAlso picPlayer.Bounds.IntersectsWith(PictureBox.Bounds) Then
                    collision = True
                    Exit For
                End If
            ElseIf picPlayer.Bounds.IntersectsWith(picExit.Bounds) Then
                exitReached = True
            End If
        Next
        If exitReached = True Then
            MessageBox.Show("You win!")
            btnNext.Visible = True
        End If
        If collision = True Then
            MessageBox.Show("Game Over")
            End
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        GlobalVariables.ChallengeGamePassed = True
        Me.Hide()
        frmDone.Show()
    End Sub

    Private Sub picPlayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayer.Click
        GlobalVariables.ChallengeGamePassed = True
        Me.Hide()
        frmDone.Show()
    End Sub
End Class