'Aditya Bhatia
'Star Wars Project
'5/4/2018
Public Class frmEnemy1
    Dim currentLocation As Point
    Dim nextLocation As Point

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.Hide()
        frmEnemy2.Show()
    End Sub

    Private Sub frmEnemy1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            currentLocation = picPlayer.Location
            nextLocation = picPlayer.Location
            nextLocation.X = currentLocation.X + 10
            picPlayer.Location = nextLocation
        End If

        If e.KeyCode = Keys.Left Then
            currentLocation = picPlayer.Location
            nextLocation = picPlayer.Location
            nextLocation.X = currentLocation.X - 10
            picPlayer.Location = nextLocation
        End If

        If e.KeyCode = Keys.Up Then
            currentLocation = picPlayer.Location
            nextLocation = picPlayer.Location
            nextLocation.X = currentLocation.Y + 10
            picPlayer.Location = nextLocation
        End If

        If e.KeyCode = Keys.Down Then
            currentLocation = picPlayer.Location
            nextLocation = picPlayer.Location
            nextLocation.X = currentLocation.Y - 10
            picPlayer.Location = nextLocation
        End If
        If e.KeyCode = Keys.F Then
            If prgPlayerHealth.Value > 0 Then
                If prgEnemyHealth.Value > 0 Then
                    prgEnemyHealth.Value -= 10
                Else
                    MessageBox.Show("You win!")
                    btnNext.Visible = True
                End If
            Else
                MessageBox.Show("Computer Wins!")
                End
            End If
        End If
    End Sub

    Private Sub frmEnemy1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        prgEnemyHealth.Value = 100
        prgPlayerHealth.Value = 100
    End Sub

    Private Sub picEnemy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPlayer.Click
        prgEnemyHealth.Value -= 10
    End Sub
End Class
