'Aditya Bhatia
'Haunted House Project - Kitchen
'3/28/2018
Public Class frmKitchen
    Dim hintAnswer As String = Nothing
    Dim candyCounter As Integer = 2

    Private Sub btnHint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHint.Click
        hintAnswer = Nothing
        hintAnswer = InputBox("It wraps you in it's ghostly arms, a gray and clammy thing. Yet if you move, it lets go and never says a thing!", "Hint #2").ToLower
        If hintAnswer = "fog" Then
            MessageBox.Show("The candy is in the fridge")
        Else
            MessageBox.Show("Incorrect")
            frmLivingRoom.shakeMe()
        End If
    End Sub

    Private Sub Correct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorrect.Click
        picCandy.Visible = True
        MessageBox.Show("You found the candy!")
        candyCounter += 1
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & candyCounter
        My.Computer.Audio.Play(My.Resources.Applause, AudioPlayMode.WaitToComplete)
        Me.Visible = False
        frmLivingRoom.Visible = True
        MessageBox.Show("Welcome to the living room")
    End Sub

    Private Sub Incorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncorrect1.Click, btnIncorrect2.Click, btnIncorrect3.Click, btnIncorrect4.Click, btnIncorrect5.Click, btnIncorrect6.Click
        MessageBox.Show("Incorrect")
        frmLivingRoom.shakeMe()
    End Sub

    Private Sub frmKitchen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & candyCounter
    End Sub
End Class