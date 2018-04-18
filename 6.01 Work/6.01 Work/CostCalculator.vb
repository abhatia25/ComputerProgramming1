'Aditya Bhatia
'Cost Calculator
'4/18/2018
Public Class frmCostCalculator

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim dblCostPerItem As Double = 0
        Dim strCostPerItem As String = Nothing
        Dim intNumberOfItems As Integer = 0
        Dim strNumberOfItems As String = Nothing
        Dim dblTotalCost As Double = 0

        strCostPerItem = txtPerItem.Text
        strNumberOfItems = txtNumberofItems.Text

        If Double.TryParse(strCostPerItem, dblCostPerItem) Then
            If Int32.TryParse(strNumberOfItems, intNumberOfItems) Then
                dblTotalCost = dblCostPerItem * intNumberOfItems
                lblResult.Text = "The total cost of your items is " & Format(dblTotalCost, "Currency")
            Else
                lblResult.Text = "Please enter numeric values"
            End If
        Else
            lblResult.Text = "Please enter numeric values"
        End If
    End Sub
End Class