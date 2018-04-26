'Aditya Bhatia
'Football Game
'4/26/2018
Public Class frmFootballGame
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmSavings.Show()
    End Sub

    Private Sub calcTotal(ByRef intTotalPoints As Integer, ByVal intFirstQuarter As Integer, ByVal intSecondQuarter As Integer, ByVal intThirdQuarter As Integer, ByVal intFourthQuarter As Integer)
        intTotalPoints = intFirstQuarter + intSecondQuarter + intThirdQuarter + intFourthQuarter
    End Sub

    Private Sub btnTotalPoints_Click(sender As Object, e As EventArgs) Handles btnTotalPoints.Click
        Try
            Dim intFirstQuarter As Integer
            Dim intSecondQuarter As Integer
            Dim intThirdQuarter As Integer
            Dim intFourthQuarter As Integer
            Dim intTotalPoints As Integer
            intFirstQuarter = Convert.ToInt32(txtFirstQuarter.Text)
            intSecondQuarter = Convert.ToInt32(txtSecondQuarter.Text)
            intThirdQuarter = Convert.ToInt32(txtThirdQuarter.Text)
            intFourthQuarter = Convert.ToInt32(txtFourthQuarter.Text)
            calcTotal(intTotalPoints:=intTotalPoints, intFirstQuarter:=intFirstQuarter, intSecondQuarter:=intSecondQuarter, intThirdQuarter:=intThirdQuarter, intFourthQuarter:=intFourthQuarter)
            lblTotalPoints.Text = "The total number of points is " & intTotalPoints
        Catch ex As Exception
            MessageBox.Show("Please enter integer values")
        End Try
    End Sub
End Class