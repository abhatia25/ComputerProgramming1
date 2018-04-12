'Aditya Bhatia
'Haunted House Project - Living Room
'3/28/2018
Public Class frmLivingRoom
    Dim hintAnswer As String = Nothing 'Declare hintAnswer as string and initialize to nothing

    Private Sub btnHint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHint.Click 'When hint button is clicked
        hintAnswer = Nothing 'Re-initialize hintAnswer to nothing
        hintAnswer = InputBox("During what month do people sleep the least?", "Hint #3").ToLower 'Ask riddle in input box
        If hintAnswer = "february" Then 'Verify if answer is correct
            MessageBox.Show("The candy is in the dark space") 'Give hint
        Else
            MessageBox.Show("Incorrect") 'Tell user that their answer was wrong
            shakeMe() 'Shake form
        End If
    End Sub

    Private Sub Correct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrect.Click 'when the correct button is clicked
        GlobalVariables.CandyCounter += 1
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & GlobalVariables.CandyCounter
        Timer1.Stop()
        ProgressBar1.Value = 0
        picCandy.Visible = True
        MessageBox.Show("You found the candy!")
        My.Computer.Audio.Play(My.Resources.Applause, AudioPlayMode.WaitToComplete)
        Me.Visible = False
        frmMasterBedroom.Visible = True 'to add once forms are merged
    End Sub

    Private Sub Incorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncorrect1.Click, btnIncorrect2.Click, btnIncorrect3.Click, btnIncorrect4.Click
        MessageBox.Show("Incorrect")
        shakeMe()
    End Sub

    Private Sub frmLivingRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & GlobalVariables.CandyCounter
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1) 'When timer ticks, progress bar increments by 1
        If ProgressBar1.Value = 100 Then 'When progress bar gets full
            Timer1.Stop()
            ProgressBar1.Value = 0
            Me.Visible = False 'Hide this form
            'frmGameOver.Visible = True 'Open Game Over form
        End If
    End Sub

    Private Sub Timer_Start(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrect.Click, btnHint.Click, btnIncorrect1.Click, btnIncorrect2.Click, btnIncorrect3.Click, btnIncorrect4.Click
        Timer1.Start()
    End Sub
End Class