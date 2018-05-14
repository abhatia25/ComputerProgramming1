'Aditya Bhatia
'Bouncing Ball
'5/14/2018
Public Class frmBouncingBall
    Private Sub tmrAnimatedBall_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrAnimatedBall.Tick
        Const MAX_IMAGES As Integer = 4
        Static newPosition As Integer = 0
        Static direction As Integer
        'Display an image from array
        Me.picBall.Image = My.Resources.ball0
        'Determine next image
        If newPosition = 0 Then
            direction = 1
        ElseIf newPosition = MAX_IMAGES - 1 Then 'change to downward direction
            direction = -1
        End If
        newPosition += direction
        'Display next image
        Select Case newPosition
            Case 0
                Me.picBall.Image = My.Resources.ball0
            Case 1
                Me.picBall.Image = My.Resources.ball1
            Case 2
                Me.picBall.Image = My.Resources.ball2
            Case 3
                Me.picBall.Image = My.Resources.ball3
        End Select
    End Sub

    Private Sub frmBouncingBall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrAnimatedBall.Enabled = True
    End Sub
End Class