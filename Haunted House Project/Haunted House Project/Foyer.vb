'Aditya Bhatia
'Haunted House Project - Foyer
'3/26/2018
Public Class frmFoyer
    Dim hintAnswer As String = Nothing 'Declare hintAnswer as string with an inital value of nothing

    Private Sub Incorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandles.Click, btnKitchen.Click, btnStatue2.Click, btnWindow.Click
        MessageBox.Show("Incorrect") 'If any of the incorrect locations are clicked, then a messagebox will show "Incorrect"
        shakeMe() 'If incorrect, then form will shake
    End Sub

    Private Sub btnStatue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatue.Click
        GlobalVariables.CandyCounter += 1 'Increment Candy Counter by 1
        FoyerTimer8.Stop()
        FoyerProgressBar.Value = 0
        lblCandyCounter.Text = "Candy Counter:" & vbCrLf & GlobalVariables.CandyCounter
        picCandy.Visible = True
        MessageBox.Show("You found the candy!")
        My.Computer.Audio.Play(My.Resources.Applause, AudioPlayMode.WaitToComplete) 'Play applause audio
        Me.Visible = False
        frmKitchen.Visible = True 'Move to kitchen
        MessageBox.Show("Welcome to the kitchen")
    End Sub

    Private Sub frmFoyer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & GlobalVariables.CandyCounter ' Display Candy Counter in label
        MessageBox.Show("Click on objects to find the candy")
    End Sub

    Private Sub btnHint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHint.Click
        hintAnswer = Nothing
        hintAnswer = InputBox("What is the scariest side of a haunted house?", "Hint #1") 'Display input box for 1st hint
        If hintAnswer.ToLower = "inside" Then 'Convert hintAnswer to all lowercase letters and check if value is correct
            MessageBox.Show("The candy is above the hallway entrance") 'If correct then give hint
        Else
            MessageBox.Show("Incorrect") 'If incorrect then show "incorrect"
            shakeMe() 'If incorrect then shake form
        End If
    End Sub

    Private Sub FoyerTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoyerTimer8.Tick
        FoyerProgressBar.Increment(1) 'When timer ticks, progress bar increments by 1
        If FoyerProgressBar.Value = 100 Then 'When progress bar gets full
            FoyerTimer8.Stop()
            FoyerProgressBar.Value = 0
            Me.Visible = False 'Hide this form
            'frmGameOver.Visible = True 'Open Game Over form
        End If
    End Sub

    Private Sub Start_Timer(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandles.Click, btnHint.Click, btnKitchen.Click, btnStatue.Click, btnStatue2.Click, btnWindow.Click
        FoyerTimer8.Start() 'Start timer once user clicks on any button
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