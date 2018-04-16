Public Class frmMasterBedroom
    Dim message As String

    Private Sub frmMasterBedroom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCandyCounter.Text = "Candy Counter:" & vbCrLf & GlobalVariables.CandyCounter
        MessageBox.Show("You have now entered the Master bedroom, find the candy by clicking different objects. YOU HAVE A TIME LIMIT, GO")
        Timer1.Start()
    End Sub

    Private Sub Incorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton1.Click, btnButton2.Click, btnButton3.Click, btnButton4.Click, btnButton5.Click, btnButton6.Click, btnButton7.Click, btnButton8.Click, btnButton9.Click, btnButton10.Click, btnButton11.Click, btnButton13.Click, btnButton14.Click
        ShakeMe()
        MessageBox.Show("Its Not There")
    End Sub

    Private Sub Correct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandy.Click
        GlobalVariables.CandyCounter += 1
        btnCandy.BackgroundImage = My.Resources.CandyCorn
        Timer1.Stop()
        ProgressBar1.Value = 0
        lblProgress.Text = 0
        MessageBox.Show("You found the candy! Click Next to enter into the next room IF YOU DARE")
        btnNext.Visible = True
        lblCandyCounter.Text = "Candy Counter:" & vbCrLf & GlobalVariables.CandyCounter
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            ProgressBar1.Value = 0
            PictureBox1.Visible = True
            MessageBox.Show("You did not find the candy in time, dead Grandma found you. GAME OVER")
            Me.Visible = False
            frmGameOver.Visible = True
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        MessageBox.Show("The room is locked you must answer a riddle to get the key")
        message = InputBox("Riddle me this:  If you see one flying around you'd better be careful at night as some turn into vampires and will give your neck a big bite", )
        If message = "bats" Then
            MessageBox.Show("CORRECT")

            frmChildBedroom.Show()
            Me.Hide()
        Else
            MessageBox.Show("WRONG, last try or you die")

            message = InputBox("Riddle me this:  If you see one flying around you'd better be careful at night as some turn into vampires and will give your neck a big bite", )
        End If
        If message = "bats" Then
            frmChildBedroom.Show()
            Me.Hide()
        Else
            PictureBox1.Visible = True
            MessageBox.Show("Sorry, dead Grandma found you")
            Me.Close()
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

