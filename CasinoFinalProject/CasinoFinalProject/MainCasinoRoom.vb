'Aditya Bhatia
'Main Casino Room
'5/21/2018
Public Class frmMainCasinoRoom

    Private Sub STOREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOREToolStripMenuItem.Click
        If GlobalVariables.Game6Passed = True Then
            Me.Hide()
            frmStore.Show()
        Else
            MessageBox.Show("You cannot the store yet, please complete all the games first")
        End If
    End Sub

    Private Sub MainCasinoRoom_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        frmTimer.Show()
        My.Computer.Audio.Play(My.Resources.casino_background, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub GAME1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GAME1ToolStripMenuItem.Click
        Me.Hide()
        frmCandyJar.Show()
    End Sub

    Private Sub GAME2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GAME2ToolStripMenuItem.Click
        If GlobalVariables.Game1Passed = True Then
            Me.Hide()
            frmRockPaperScissors.Show()
        Else
            MessageBox.Show("You cannot enter this game yet, please complete the previous game first")
        End If
    End Sub

    Private Sub GAME3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GAME3ToolStripMenuItem.Click
        If GlobalVariables.Game2Passed = True Then
            Me.Hide()
            frmMastermind.Show()
        Else
            MessageBox.Show("You cannot enter this game yet, please complete the previous game first")
        End If
    End Sub

    Private Sub GAME4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GAME4ToolStripMenuItem.Click
        If GlobalVariables.Game3Passed = True Then
            Me.Hide()
            frmLucky7.Show()
        Else
            MessageBox.Show("You cannot enter this game yet, please complete the previous game first")
        End If
    End Sub

    Private Sub GAME5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GAME5ToolStripMenuItem.Click
        If GlobalVariables.Game4Passed = True Then
            Me.Hide()
            frmDiceGame.Show()
        Else
            MessageBox.Show("You cannot enter this game yet, please complete the previous game first")
        End If
    End Sub

    Private Sub GAME6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GAME6ToolStripMenuItem.Click
        If GlobalVariables.Game5Passed = True Then
            Me.Hide()
            frmCardGame.Show()
        Else
            MessageBox.Show("You cannot enter this game yet, please complete the previous game first")
        End If
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        InventoryDB()
    End Sub

    Sub InventoryDB()
        Dim InventoryDB As New frmInventory()
        'Show dialog box
        InventoryDB.ShowDialog()
    End Sub
End Class