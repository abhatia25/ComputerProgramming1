'Aditya Bhatia
'3.01 Programming Excersises
'2/9/2018
Public Class frmGames
    Private Sub btnGame4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGame4.Click
        lblGameInfo.Text = "Madden NFL is an American football video game series developed by EA Tiburon for EA Sports. It is named after Pro Football Hall of Famer John Madden."
    End Sub

    Private Sub btnGame3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGame3.Click
        lblGameInfo.Text = "Tetris is a tile-matching puzzle video game, originally designed and programmed by Russian game designer Alexey Pajitnov."
    End Sub

    Private Sub btnGame2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGame2.Click
        lblGameInfo.Text = "Grand Theft Auto is an action-adventure video game developed by Rockstar North and published by Rockstar Games."
    End Sub

    Private Sub btnGame1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGame1.Click
        lblGameInfo.Text = "Minecraft is a sandbox video game created and designed by Swedish game designer Markus Persson, and later fully developed and published by Mojang."
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Thank you for visiting!")
        End
    End Sub

    Private Sub frmGames_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome! Please select a video game to find out information about that game.")
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        lblGameInfo.Text = ""
    End Sub
End Class
