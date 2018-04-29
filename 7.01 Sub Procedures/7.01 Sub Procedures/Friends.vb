'Aditya Bhatia
'Friends
'4/29/2018
Public Class frmFriends
    Private Sub btnGetInfo_Click(sender As Object, e As EventArgs) Handles btnGetInfo.Click
        Dim strFriendName As String
        strFriendName = Me.txtName.Text

        Select Case strFriendName.ToUpper
            Case "SHANA"
                SHANAInfo()
            Case "LUIZ"
                LUIZInfo()
            Case "CRIS"
                CRISInfo()
            Case Else
                MessageBox.Show("Sorry, no information available")
        End Select
    End Sub

    Sub SHANAInfo()
        Me.picFriendPhoto.BackgroundImage = My.Resources.shana
        Me.picFriendPhoto.BackgroundImageLayout = ImageLayout.Zoom
        Me.lblFriendInfo.Text = "Shana's birthday is June 24. Her favorite animal is the dolphin, her favorite color is blue, and she likes to do extreme inline skating."
    End Sub

    Sub LUIZInfo()
        Me.picFriendPhoto.BackgroundImage = My.Resources.luiz
        Me.picFriendPhoto.BackgroundImageLayout = ImageLayout.Zoom
        Me.lblFriendInfo.Text = "Luiz's birthday is August 21. His favorite animal is the tiger, his favorite color is green, and he likes to do gymnastics."
    End Sub

    Sub CRISInfo()
        Me.picFriendPhoto.BackgroundImage = My.Resources.cris
        Me.picFriendPhoto.BackgroundImageLayout = ImageLayout.Zoom
        Me.lblFriendInfo.Text = "Cris' birthday is September 20. His favorite animal is any kind of bird, his favorite color is yellow, and he likes to play the guitar."
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmStones.Show()
    End Sub
End Class