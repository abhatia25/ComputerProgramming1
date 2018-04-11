'Aditya Bhatia
'Haunted House Project - Kitchen
'3/28/2018
Public Class frmKitchen
    Dim hintAnswer As String = Nothing 'Declare hintAnswer as string and initialize to nothing

    Private Sub btnHint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHint.Click 'When btnHint is clicked
        hintAnswer = Nothing 'Reassign hintAnswer to nothing
        hintAnswer = InputBox("It wraps you in it's ghostly arms, a gray and clammy thing. Yet if you move, it lets go and never says a thing!", "Hint #2").ToLower 'value of input box to lowercase is assigned to hintAnswer
        If hintAnswer = "fog" Then 'If hintAnswer is correct
            MessageBox.Show("The candy is in the fridge") 'Show hint
        Else 'If not correct
            MessageBox.Show("Incorrect") 'Show incorrect message
            shakeMe() 'Shake form
        End If
    End Sub

    Private Sub Correct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrect.Click 'When btnCorrect is clicked
        picCandy.Visible = True 'Show picCandy
        MessageBox.Show("You found the candy!") 'Show "You found the candy" in a message box
        GlobalVariables.CandyCounter += 1 'Increment candyCounter by 1
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & GlobalVariables.CandyCounter 'Display value of candyCounter in lblCandyCounter
        My.Computer.Audio.Play(My.Resources.Applause, AudioPlayMode.WaitToComplete) 'Play applause audio
        Me.Visible = False 'Hide this form
        frmLivingRoom.Visible = True 'Show living room form
        MessageBox.Show("Welcome to the living room") 'Display living room enterance message
    End Sub

    Private Sub Incorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncorrect1.Click, btnIncorrect2.Click, btnIncorrect3.Click, btnIncorrect4.Click, btnIncorrect5.Click, btnIncorrect6.Click 'When any incorrect button is clicked
        MessageBox.Show("Incorrect") 'Show incorrect message
        shakeMe() 'Shake form
    End Sub

    Private Sub frmKitchen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'When form opens
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & GlobalVariables.CandyCounter 'Display candy counter in lblCandyCounter
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

    Private Sub Start_Timer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrect.Click, btnHint.Click, btnIncorrect1.Click, btnIncorrect2.Click, btnIncorrect3.Click, btnIncorrect4.Click, btnIncorrect5.Click, btnIncorrect6.Click 'When any button is clicked
        KitchenTimer.Start() 'Start KitchenTimer
    End Sub

    Private Sub KitchenTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KitchenTimer.Tick 'When KitchenTimer ticks
        KitchenProgressBar.Increment(1) 'Progress bar increment by 1
        If KitchenProgressBar.Value = 100 Then 'When progress bar gets full
            Me.Visible = False 'Hide this form
            frmGameOver.Visible = True 'Open Game Over form
            KitchenProgressBar.Value = 0 'Reset progress bar
        End If
    End Sub
End Class