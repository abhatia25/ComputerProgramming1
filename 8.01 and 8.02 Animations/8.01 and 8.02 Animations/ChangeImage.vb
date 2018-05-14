'Aditya Bhatia
'Change Image
'5/14/2018
Public Class frmChangeImage
    Private Sub Button_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeart.Click, btnClock.Click, btnStar.Click, btnHappyFace.Click
        Dim btnButtonClicked As Button = sender

        Select Case btnButtonClicked.Tag
            Case "Heart"
                Me.BackgroundImage = My.Resources.heart
            Case "HappyFace"
                Me.BackgroundImage = My.Resources.happyface
            Case "Clock"
                Me.BackgroundImage = My.Resources.clock
            Case "Star"
                Me.BackgroundImage = My.Resources.star
        End Select
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmDrawAFace.Show()
    End Sub
End Class