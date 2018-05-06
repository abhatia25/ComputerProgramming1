'Aditya Bhatia
'Bacteria Growth
'4/26/2018
Public Class frmBacteriaGrowth

    Private Sub bacteriaCalculate(ByRef dblTotalBacteria As Double, ByVal dblInitialBacteria As Double, ByVal dblK As Double, ByVal dblTime As Double)
        dblTotalBacteria = dblInitialBacteria * (Math.E ^ dblK * dblTime)
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim dblInitialBacteria As Double
            Dim dblK As Double
            Dim dblTime As Double
            Dim dblTotalBacteria As Double
            dblInitialBacteria = Convert.ToDouble(txtInitialBacteria.Text)
            dblK = Convert.ToDouble(txtK.Text)
            dblTime = Convert.ToDouble(txtTime.Text)
            bacteriaCalculate(dblTotalBacteria:=dblTotalBacteria, dblInitialBacteria:=dblInitialBacteria, dblK:=dblK, dblTime:=dblTime)
            lblAnswer.Text = dblTotalBacteria & " bacteria will be present after " & dblTime & " hours if there were initially " & dblInitialBacteria & " bacteria and k is " & dblK
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmDepreciation.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class