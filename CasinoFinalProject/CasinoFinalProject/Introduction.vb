'Aditya Bhatioa
'Introduction Form
'5/21/2018
Public Class frmIntroduction

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        GlobalVariables.PlayerName = txtName.Text
        Me.Hide()
        frmMainCasinoRoom.Show()
    End Sub

    Private Sub lblIntro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblIntro.Click
        GlobalVariables.Game1Passed = True
        GlobalVariables.Game2Passed = True
        GlobalVariables.Game3Passed = True
        GlobalVariables.Game4Passed = True
        GlobalVariables.Game5Passed = True
        GlobalVariables.Game6Passed = True
        GlobalVariables.ChallengeGamePassed = True
    End Sub
End Class

Public Class GlobalVariables
    Public Shared PlayerName As String
    Public Shared Game1Passed As Boolean = False
    Public Shared Game2Passed As Boolean = False
    Public Shared Game3Passed As Boolean = False
    Public Shared Game4Passed As Boolean = False
    Public Shared Game5Passed As Boolean = False
    Public Shared Game6Passed As Boolean = False
    Public Shared Money As Decimal = 0
    Public Shared ChallengeGamePassed As Boolean = False
End Class
