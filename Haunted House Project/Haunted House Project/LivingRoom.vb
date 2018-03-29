'Aditya Bhatia
'Haunted House Project - Living Room
'3/28/2018
Public Class frmLivingRoom
    Dim hintAnswer As String = Nothing
    Dim candyCounter As Integer = 3

    Private Sub btnHint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHint.Click
        hintAnswer = Nothing
        hintAnswer = InputBox("During what month do people sleep the least?", "Hint #3").ToLower
        If hintAnswer = "february" Then
            MessageBox.Show("The candy is in the dark space")
        Else
            MessageBox.Show("Incorrect")
            shakeMe()
        End If
    End Sub

    Private Sub Correct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrect.Click
        picCandy.Visible = True
        MessageBox.Show("You found the candy!")
        candyCounter += 1
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & candyCounter
        My.Computer.Audio.Play(My.Resources.Applause, AudioPlayMode.WaitToComplete)
        Me.Visible = False
        'frmMasterBedroom.Visible = True
        MessageBox.Show("Welcome to the master bedroom")
    End Sub

    Private Sub Incorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncorrect1.Click, btnIncorrect2.Click, btnIncorrect3.Click, btnIncorrect4.Click
        MessageBox.Show("Incorrect")
        shakeMe()
    End Sub

    Private Sub frmLivingRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & candyCounter
    End Sub

    Public Sub shakeMe()
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