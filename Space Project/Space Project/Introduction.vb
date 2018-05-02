'Aditya Bhatia
'Introduction
'4/30/2018
Public Class frmIntroduction

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.Hide()
        frmSpaceship.Show()
    End Sub
End Class

Public Class GlobalVariables
    Public Shared intInventory1 As Integer = 0 'Handgun
    Public Shared intInventory2 As Integer = 0 'Orb
    Public Shared intInventory3 As Integer = 0 'Reflector
    Public Shared intInventory4 As Integer = 0 'Crystal
End Class