'Aditya Bhatia
'Lucky 7
'5/21/2018
Public Class frmLucky7

    Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpin.Click
        lblWinner1.Text = "" 'Set all to blank
        lblWinner2.Text = ""
        lblWinner3.Text = ""
        picMoney.Visible = False ' hide picture 
        lblNumber1.Text = CStr(Int(Rnd() * 10)) ' pick numbers 
        lblNumber2.Text = CStr(Int(Rnd() * 10))
        lblNumber3.Text = CStr(Int(Rnd() * 10))
        If (lblNumber1.Text = "7") Or (lblNumber2.Text = "7") Or (lblNumber3.Text = "7") Then
            picMoney.Visible = True
            My.Computer.Audio.Play(My.Resources.cash_register, AudioPlayMode.Background)
            lblWinner1.Text = "You Win!" 'Winning message
            btnNext.Visible = True
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        GlobalVariables.Game4Passed = True
        Me.Hide()
        frmMainCasinoRoom.Show()
    End Sub
End Class
