'Aditya Bhatia
'Super Size
'3/19/2018
Public Class frmSuperSize
    Const Hamburger As Decimal = 2.95
    Const Cheeseburger As Decimal = 3.95
    Const Fries As Decimal = 1.95
    Const OnionRings As Decimal = 2.5
    Dim TotalPrice As Decimal = 0
    Dim Tax As Decimal = 0
    Dim OrderNumber As Integer = 0

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        TotalPrice = 0
        Tax = 0
        OrderNumber = 0
        If chkCheeseburger.Checked Then
            TotalPrice += Cheeseburger
        End If
        If chkFries.Checked Then
            TotalPrice += Fries
        End If
        If chkHamburger.Checked Then
            TotalPrice += Hamburger
        End If
        If chkOnionRings.Checked Then
            TotalPrice += OnionRings
        End If
        If radSuperSize.Checked Then
            TotalPrice += 2
        End If
        Randomize()
        OrderNumber = Rnd() * 900 + 100
        Tax = 0.07 * TotalPrice
        TotalPrice = TotalPrice + Tax
        lblOrderNumber.Text = OrderNumber
        lblTotalCost.Text = "Please pay: $" & TotalPrice
    End Sub
End Class