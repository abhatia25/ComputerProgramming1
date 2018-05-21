'Aditya Bhatia
'Turtle Run
'5/17/2018
Public Class frmTurtleRun
    Dim image As Integer = 0

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnSlow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlow.Click
        tmrTurtleSpeed.Start()
        tmrTurtleSpeed.Interval = 1000
    End Sub

    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        tmrTurtleSpeed.Start()
        tmrTurtleSpeed.Interval = 400
    End Sub

    Private Sub btnFast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFast.Click
        tmrTurtleSpeed.Start()
        tmrTurtleSpeed.Interval = 50
    End Sub

    Private Sub frmTurtleRun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        picTurtle1.Visible = True
    End Sub

    Private Sub tmrTurtleSpeed_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTurtleSpeed.Tick

        Select Case Image
            Case 0
                picTurtle1.Visible = True
                picTurtle2.Visible = False
                picTurtle3.Visible = False
            Case 1
                picTurtle1.Visible = False
                picTurtle2.Visible = True
                picTurtle3.Visible = False
            Case 2
                picTurtle1.Visible = False
                picTurtle2.Visible = False
                picTurtle3.Visible = True
        End Select

        image = image + 1

        If image > 3 Then
            image = 0
        End If
    End Sub
End Class