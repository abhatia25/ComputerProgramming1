'Aditya Bhatia
'Hot Dog
'4/29/2018
Public Class frmHotDog
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmFriends.Show()
    End Sub

    Private Sub Toppings_Click(sender As Object, e As EventArgs) Handles chkCheese.Click, chkRelish.Click, chkKraut.Click

        Const decRELISH As Decimal = 0.1
        Const decKRAUT As Decimal = 0.25
        Const decCHEESE As Decimal = 0.5
        Static decPrice As Decimal = 2

        Dim chkSelectedTopping As CheckBox = sender
        If chkSelectedTopping.Checked Then
            Select Case chkSelectedTopping.Tag
                Case "Relish"
                    decPrice = decPrice + decRELISH
                Case "Kraut"
                    decPrice = decPrice + decKRAUT
                Case "Cheese"
                    decPrice = decPrice + decCHEESE
            End Select
        Else
            Select Case chkSelectedTopping.Tag
                Case "Relish"
                    decPrice = decPrice - decRELISH
                Case "Kraut"
                    decPrice = decPrice - decKRAUT
                Case "Cheese"
                    decPrice = decPrice - decCHEESE
            End Select
        End If

        Me.lblCurrentPrice.Text = "$" & decPrice
    End Sub
End Class