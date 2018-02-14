'Aditya Bhatia
'3.01 Programming Excersises
'2/12/2018
Public Class frmCookies

    Private Sub radChocChip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radChocChip.CheckedChanged
        lblChoice.Text = "You chose our Chocolate Chip cookies."
    End Sub

    Private Sub radOatmeal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOatmeal.CheckedChanged
        lblChoice.Text = "You chose our Oatmeal Raisin cookies."
    End Sub

    Private Sub radPeanutButter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPeanutButter.CheckedChanged
        lblChoice.Text = "You chose our Peanut Butter cookies."
    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        lblChoice.Text = "Order MORE cookies."
    End Sub

    Private Sub frmCookies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to the Cookie Order Form")
    End Sub
End Class
