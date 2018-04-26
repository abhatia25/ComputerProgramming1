'Aditya Bhatia
'Sort Numbers
'4/26/2018
Public Class frmSortNums
    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmFootballGame.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub sortNum(ByRef intNum1 As Integer, ByRef intNum2 As Integer)
        Dim intTemp As Integer
        If intNum1 > intNum2 Then
            intTemp = intNum1
            intNum1 = intNum2
            intNum2 = intTemp
        ElseIf intNum1 < intNum2 Then
            intNum1 = intNum1
            intNum2 = intNum2
        End If
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim strNum1 As String
        Dim strNum2 As String
        strNum1 = InputBox("Please enter the first number", "First number")
        strNum2 = InputBox("Please enter the second number", "Second number")
        Int32.TryParse(strNum1, intNum1)
        Int32.TryParse(strNum2, intNum2)
        sortNum(intNum1:=intNum1, intNum2:=intNum2)
        lblResult.Text = "The low number is " & intNum1 & " and the high number is " & intNum2
    End Sub
End Class