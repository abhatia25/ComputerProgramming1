Public Class frmAttic
    Dim message As String
    Dim tries As Integer = 0

    Private Sub frmAttic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCandyCounter.Text = "Candy Counter:" & vbCrLf & GlobalVariables.CandyCounter
        MessageBox.Show("You have now entered the Attic, find the candy by clicking diffrent objects. YOU HAVE A TIME LIMIT, GO")
        Timer1.Start()
    End Sub

    Private Sub btnCandy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandy.Click
        btnCandy.BackgroundImage = My.Resources.CandyCorn
        Timer1.Stop()
        ProgressBar1.Value = 0
        lblProgress.Text = 0
        MessageBox.Show("You found the candy! Click Next to enter into the next room IF YOU DARE")
        btnNext.Visible = True
        GlobalVariables.CandyCounter += 1
        lblCandyCounter.Text = "Candy Counter:" & vbCrLf & GlobalVariables.CandyCounter
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            ProgressBar1.Value = 0
            PictureBox1.Visible = True
            MessageBox.Show("You did not find the candy in time, The Boy found you. GAME OVER")
            Me.Visible = False
            frmGameOver.Visible = True
        End If
        lblProgress.Text = ProgressBar1.Value & ("%")
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        MessageBox.Show("The Basement is locked you must answer a riddle to get the key")
        message = InputBox("Who Am I?: This body has no ears or tongue So he's not able to use phones Tickling doesn't work on him Because he's only made of bones")
        Select Case message
            Case "skeleton"
                MessageBox.Show("CORRECT")
                frmBasement.Show()
                Me.Hide()
            Case Else
                If tries = 0 Then
                    MessageBox.Show("WRONG, last try or you die")
                    tries += 1
                    message = InputBox("Who Am I?: This body has no ears or tongue So he's not able to use phones Tickling doesn't work on him Because he's only made of bones")
                ElseIf tries = 1 Then
                    PictureBox1.Visible = True
                    Me.Close()
                    frmGameOver.Visible = True
                End If
        End Select
    End Sub

    Private Sub Incorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click, Button19.Click
        shakeMe()
        MessageBox.Show("Its Not There")
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

