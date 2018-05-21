'Aditya Bhatioa
'Introduction Form
'5/21/2018
Public Class frmIntroduction

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        GlobalVariables.PlayerName = txtName.Text
        Me.Hide()

    End Sub
End Class

Public Class GlobalVariables
    Public Shared PlayerName As String
    Public Shared Points As Integer
    Public Shared Game1Passed As Boolean = False
    Public Shared Game2Passed As Boolean = False
    Public Shared Game3Passed As Boolean = False
    Public Shared Game4Passed As Boolean = False
    Public Shared Game5Passed As Boolean = False
End Class
