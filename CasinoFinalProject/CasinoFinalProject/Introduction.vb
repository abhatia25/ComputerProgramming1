﻿'Aditya Bhatioa
'Introduction Form
'5/11/2018
Public Class frmIntroduction

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        GlobalVariables.PlayerName = txtName.Text
        Me.Hide()

    End Sub
End Class

Public Class GlobalVariables
    Public Shared PlayerName As String
    Public Shared Points As Integer
End Class
