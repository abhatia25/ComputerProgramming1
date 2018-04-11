Public Class frmBasement
    Dim shakeCount As Integer = 0
    Dim message As String
    Dim intCandyCounter As Integer

    Private Sub frmBasement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCandyCounter.Text = "Candy Counter:" & vbCrLf & "7"
        MessageBox.Show("You have now entered the basement, it's very dark and you can't see run the mouse over the walls and try to find the candy, YOU HAVE A TIME LIMIT, GO")
        Timer1.Start()
    End Sub

    Private Sub btnCandy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandy.Click
        btnCandy.BackgroundImage = My.Resources.Resses
        intCandyCounter = 7
        Timer1.Stop()
        ProgressBar1.Value = 0
        MessageBox.Show("You found the candy!")
        intCandyCounter = 7 + 1
        lblCandyCounter.Text = "Candy Counter:" & vbCrLf & intCandyCounter
        Me.Visible = False
        frmEnd.Visible = True
    End Sub


    Private Sub Incorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn10.Click, btn11.Click, btn12.Click, btn13.Click, btn14.Click, btn15.Click, btn16.Click, btn17.Click, btn18.Click, btn19.Click, btn20.Click, btn21.Click, btn22.Click, btn23.Click, btn24.Click, btn25.Click, btn26.Click, btn27.Click, btn28.Click, btn29.Click, btn30.Click, btn31.Click, btn32.Click, btn33.Click, btn34.Click, btn35.Click, btn36.Click, btn37.Click, btn38.Click, btn39.Click, btn40.Click, btn41.Click, btn42.Click, btn43.Click, btn44.Click, btn45.Click, btn46.Click, btn47.Click, btn48.Click, btn49.Click, btn50.Click, btn51.Click, btn52.Click, btn53.Click, btn54.Click, btn55.Click, btn56.Click, btn57.Click, btn58.Click, btn59.Click, btn60.Click, btn61.Click, btn62.Click, btn63.Click, btn64.Click, btn65.Click, btn66.Click, btn67.Click, btn68.Click, btn69.Click, btn70.Click, btn71.Click, btn72.Click, btn73.Click, btn74.Click, btn75.Click, btn76.Click, btn77.Click, btn78.Click, btn79.Click, btn80.Click, btn81.Click, btn82.Click, btn83.Click, btn84.Click, btn85.Click, btn86.Click, btn87.Click, btn88.Click, btn89.Click, btn90.Click, btn91.Click, btn92.Click, btn93.Click, btn94.Click, btn95.Click, btn96.Click, btn97.Click, btn98.Click, btn99.Click, btn100.Click, btn101.Click, btn102.Click, btn103.Click, btn104.Click, btn105.Click, btn106.Click, btn107.Click, btn108.Click, btn109.Click, btn110.Click, Button127.Click
        ShakeMe()
        MessageBox.Show("Its Not There")
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            PictureBox1.Visible = True
            Timer1.Stop()
            ProgressBar1.Value = 0
            MessageBox.Show("You did not find the candy in time, the clown found you. GAME OVER")
            Me.Visible = False
            frmGameOver.Visible = True
        End If
    End Sub

    Private Sub shakeMe()
        Dim myLoc As Point, myLocDef As Point 'Declare variables myLoc and myLocDef as a point
        myLocDef = Me.Location 'myLocDef is assigned to current location of form
        myLoc = Me.Location 'myLoc is assigned to current location of form
        For i As Integer = 0 To 6 'Number of times to shake form
            For x As Integer = 0 To 4 'Number of directions form should shake
                Select Case x
                    Case 0
                        myLoc.X = myLocDef.X + 5 'First goes right 5
                    Case 1
                        myLoc.X = myLocDef.X - 5 'Then goes left 5
                    Case 2
                        myLoc.Y = myLocDef.Y - 5 'Then goes down 5
                    Case 3
                        myLoc.Y = myLocDef.Y + 5 'Then goes up 5
                    Case 4
                        myLoc = myLocDef 'Finishes at same place the form started
                End Select
                Me.Location = myLoc 'Reassign location of form to myLoc
                Me.Refresh() 'Refresh form
            Next 'Continue Loop
        Next 'Continue Loop
        Me.Location = myLocDef 'Reassign location of form to myLocDef
        Me.Refresh() 'Refresh form
    End Sub
End Class