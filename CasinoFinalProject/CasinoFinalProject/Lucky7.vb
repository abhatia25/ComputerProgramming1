﻿'Aditya Bhatia
'Lucky 7
'5/21/2018
Public Class frmLucky7

    Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpin.Click
        lblWinner1.Text = "" 'Set all to blank
        lblWinner2.Text = ""
        lblWinner3.Text = ""
        picMoney.Visible = False ' hide picture 
        lblNumber1.Text = CStr(Int(Rnd() * 100)) ' pick numbers 
        lblNumber2.Text = CStr(Int(Rnd() * 100))
        lblNumber3.Text = CStr(Int(Rnd() * 100))
        ' if any number is 7 display picture and beep 
        If (lblNumber1.Text = "7") Or (lblNumber2.Text = "7") Or (lblNumber3.Text = "7") Then picMoney.Visible = True
        If (lblNumber1.Text = "7") Or (lblNumber2.Text = "7") Or (lblNumber3.Text = "7") Then lblWinner1.Text = "Great!" 'Winning messages
        If (lblNumber1.Text = "7") And (lblNumber2.Text = "7") Or (lblNumber3.Text = "7") Then lblWinner2.Text = "Nice Job!"
        If (lblNumber1.Text = "7") And (lblNumber2.Text = "7") And (lblNumber3.Text = "7") Then lblWinner3.Text = "You Win!"
    End Sub
End Class