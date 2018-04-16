'Aditya Bhatia
'Ice Cream Example
'4/13/2018
Public Class frmIceCream

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        Dim Cone As String
        Dim Flavor As String
        Dim iceCreamPrice As Decimal = 0
        Dim conePrice As Decimal = 0

        Cone = cboCone.Text
        Flavor = lstFlavors.SelectedItem

        If lstFlavors.SelectedIndex = 0 Then
            iceCreamPrice = 1.5
        ElseIf lstFlavors.SelectedIndex = 1 Then
            iceCreamPrice = 2
        Else
            iceCreamPrice = 1
        End If

        If cboCone.SelectedIndex = 0 Then
            conePrice = 1
        ElseIf cboCone.SelectedIndex = 1 Then
            conePrice = 1.5
        Else
            conePrice = 2
        End If

        lblOrder.Text = "You ordered: " & Flavor & " ice cream ($" & iceCreamPrice & ") on/in a " & Cone & " ($" & conePrice & ")"
    End Sub
End Class
