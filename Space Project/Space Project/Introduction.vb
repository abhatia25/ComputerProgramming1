'Aditya Bhatia
'Introduction
'4/30/2018
Public Class frmIntroduction

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Hide()
        frmSpaceship.Show()
    End Sub

    Private Sub btnCheat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheat.Click

        GlobalVariables.intInventory1 = 1
        GlobalVariables.intInventory2 = 1
        GlobalVariables.intInventory3 = 1
        GlobalVariables.intInventory4 = 1
        GlobalVariables.intInventory5 = 1
    End Sub
End Class

Public Class GlobalVariables
    Public Shared intInventory1 As Integer = 0 'Handgun
    Public Shared intInventory2 As Integer = 0 'Orb
    Public Shared intInventory3 As Integer = 0 'Reflector
    Public Shared intInventory4 As Integer = 0 'Crystal
    Public Shared intInventory5 As Integer = 0 'Shield
End Class