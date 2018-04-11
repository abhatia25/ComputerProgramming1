'Aditya Bhatia
'Haunted House Project - Living Room
'3/28/2018
Public Class frmLivingRoom 'STILL NEED TO COMMENT
    Dim hintAnswer As String = Nothing 'Declare hintAnswer as string and initialize to nothing

    Private Sub btnHint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHint.Click 'When hint button is clicked
        hintAnswer = Nothing 'Re-initialize hintAnswer to nothing
        hintAnswer = InputBox("During what month do people sleep the least?", "Hint #3").ToLower 'Ask riddle in input box
        If hintAnswer = "february" Then 'Verify if answer is correct
            MessageBox.Show("The candy is in the dark space") 'Give hint
            MessageBox.Show("People sleep the least in february becuase it has the lowest number of days") 'State fun fact from riddle
        Else
            MessageBox.Show("Incorrect") 'Tell user that their answer was wrong
            shakeMe() 'Shake form
        End If
    End Sub

    Private Sub Correct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrect.Click 'when the correct button is clicked
        picCandy.Visible = True
        MessageBox.Show("You found the candy!")
        GlobalVariables.CandyCounter += 1
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & GlobalVariables.CandyCounter
        My.Computer.Audio.Play(My.Resources.Applause, AudioPlayMode.WaitToComplete)
        Me.Visible = False
        frmMasterBedroom.Visible = True 'to add once forms are merged
        MessageBox.Show("Welcome to the master bedroom")
    End Sub

    Private Sub Incorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncorrect1.Click, btnIncorrect2.Click, btnIncorrect3.Click, btnIncorrect4.Click
        MessageBox.Show("Incorrect")
        shakeMe()
    End Sub

    Private Sub frmLivingRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & GlobalVariables.CandyCounter
    End Sub

    Private Sub shakeMe()
        Dim myLoc As Point, myLocDef As Point
        myLocDef = Me.Location
        myLoc = Me.Location
        For i As Integer = 0 To 100
            For x As Integer = 0 To 4
                Select Case x
                    Case 0
                        myLoc.X = myLocDef.X + 10
                    Case 1
                        myLoc.X = myLocDef.X - 10
                    Case 2
                        myLoc.Y = myLocDef.Y - 10
                    Case 3
                        myLoc.Y = myLocDef.Y + 10
                    Case 4
                        myLoc = myLocDef
                End Select
                Me.Location = myLoc
                Me.Refresh()
            Next
        Next
        Me.Location = myLocDef
        Me.Refresh()
    End Sub
End Class