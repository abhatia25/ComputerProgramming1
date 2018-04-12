Public Class frmChildBedroom
    Dim message As String
    Dim tries As Integer = 0

    Private Sub frmChildBedroom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCandyCounter.Text = "Candy Counter:" & vbCrLf & GlobalVariables.CandyCounter
        MessageBox.Show("You have now entered the child's bedroom, find the candy by clicking diffrent objects. YOU HAVE A TIME LIMIT, GO")
        Timer1.Start()
    End Sub

    Private Sub btnCandy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandy.Click
        btnCandy.BackgroundImage = My.Resources.Butterfinger
        Timer1.Stop()
        ProgressBar1.Value = 0
        MessageBox.Show("You found the candy! Click Next to enter into the next room IF YOU DARE")
        btnNext.Visible = True
        GlobalVariables.CandyCounter += 1
        lblCandyCounter.Text = "Candy Counter:" & vbCrLf & GlobalVariables.CandyCounter
    End Sub

    Private Sub Incorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton1.Click, btnButton11.Click, btnButton12.Click, btnButton2.Click, btnButton3.Click, btnButton4.Click, btnButton5.Click, btnButton7.Click, btnButton8.Click, btnButton9.Click
        shakeMe()
        MessageBox.Show("Its Not There")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            ProgressBar1.Value = 0
            PictureBox1.Visible = True
            MessageBox.Show("You did not find the candy in time, the Ghost found you. GAME OVER")
            Me.Visible = False
            'frmGameOver.Visible = True
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        MessageBox.Show("The Attic is locked you must answer a riddle to get the key")
        message = InputBox("Riddle me this: What has one eye but can't see?", )
        Select Case message
            Case "needle"
                MessageBox.Show("CORRECT")
                frmAttic.Show()
                Me.Hide()
            Case Else
                If tries = 0 Then
                    MessageBox.Show("WRONG, last try or you die")
                    tries += 1
                    message = InputBox("Riddle me this: What has one eye but cant see?")
                ElseIf tries = 1 Then
                    PictureBox1.Visible = True
                    Me.Close()
                    frmGameOver.Visible = True
                End If
        End Select
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