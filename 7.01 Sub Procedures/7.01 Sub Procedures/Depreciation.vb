'Aditya Bhatia
'Depreciation
'4/27/2018
Public Class frmDepreciation

    Private Sub DepreciationCalculate(ByRef decNumberYears As Decimal, ByVal dblInitialValue As Double, ByVal dblEndValue As Double, ByVal dblDepreciationRate As Double)
        decNumberYears = Math.Log(dblEndValue / dblInitialValue) / Math.Log(1 - dblDepreciationRate)
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            Dim dblInitialValue As Double
            Dim dblEndValue As Double
            Dim dblDepreciationRate As Double
            Dim decNumberYears As Decimal
            dblInitialValue = Convert.ToDouble(txtInitialValue.Text)
            dblEndValue = Convert.ToDouble(txtEndingValue.Text)
            dblDepreciationRate = Convert.ToDouble(txtDepreciationRate.Text)
            dblDepreciationRate = dblDepreciationRate / 100
            DepreciationCalculate(decNumberYears:=decNumberYears, dblInitialValue:=dblInitialValue, dblEndValue:=dblEndValue, dblDepreciationRate:=dblDepreciationRate)
            lblAnswer.Text = "It will take " & decNumberYears & " years for a piece of equipment to depreciate to " & Format(dblEndValue, "Currency") & " if it's initial value was " & Format(dblInitialValue, "Currency") & " and the rate of depreciation is " & Format(dblDepreciationRate, "Percent")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmBookstore.Show()
    End Sub
End Class