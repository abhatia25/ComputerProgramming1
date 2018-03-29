'Aditya Bhatia
'Haunted House Project - Foyer
'3/26/2018
Public Class frmFoyer
    Dim hintAnswer As String = Nothing
    Dim candyCounter As Integer = 1

    Private Sub Incorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandles.Click, btnKitchen.Click, btnStatue2.Click, btnWindow.Click
        MessageBox.Show("Incorrect") 'If any of the incorrect locations are clicked, then a messagebox will show "Incorrect"
        frmLivingRoom.shakeMe() 'If incorrect, then form will shake
    End Sub

    Private Sub btnStatue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatue.Click
        picCandy.Visible = True
        MessageBox.Show("You found the candy!")
        candyCounter += 1 'Increment Candy Counter by 1
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & candyCounter 'Display new Candy Counter in label
        My.Computer.Audio.Play(My.Resources.Applause, AudioPlayMode.WaitToComplete) 'Play applause audio
        Me.Visible = False
        frmKitchen.Visible = True 'Move to kitchen
        MessageBox.Show("Welcome to the kitchen")
    End Sub

    Private Sub frmFoyer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & candyCounter ' Display Candy Counter in label
    End Sub

    Private Sub btnHint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHint.Click
        hintAnswer = Nothing
        hintAnswer = InputBox("What is the scariest side of a haunted house?", "Hint #1") 'Display input box for 1st hint
        If hintAnswer.ToLower = "inside" Then 'Convert hintAnswer to all lowercase letters and check if value is correct
            MessageBox.Show("The candy is above the hallway enterance") 'If correct then give hint
        Else
            MessageBox.Show("Incorrect") 'If incorrect then show "incorrect"
            frmLivingRoom.shakeMe() 'If incorrect then shake form
        End If
    End Sub
End Class