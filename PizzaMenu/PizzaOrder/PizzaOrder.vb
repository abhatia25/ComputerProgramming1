'Aditya Bhatia
'2/6/2018
'Pizza Order Form
Public Class frmPizzaOrder
    Private Sub radOrderPizza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOrderPizza.Click
        Dim toppings As String = "" 'creates toppings string
        If chkCheese.Checked = True Then
            toppings &= "Cheese " 'addition to toppings string
        End If
        If chkPeppers.Checked = True Then
            toppings &= "Peppers "
        End If
        If chkMushrooms.Checked = True Then
            toppings &= "Mushrooms "
        End If
        If chkPepperoni.Checked = True Then
            toppings &= "Pepperoni "
        End If
        If toppings <> "" Then
            MsgBox("Your pizza has the following toppings: " & toppings) 'messagebox with toppings
        End If
        If radRegular.Checked = True Then
            MsgBox("You chose regular sauce")
        Else
            MsgBox("You chose spicy sauce")
        End If
        If radDelivery.Checked = True Then
            MsgBox("You chose delivery")
        Else
            MsgBox("You chose pickup")
        End If
        picPizza.Visible = False 'hide picture
        wait("1")
        picPizza.Visible = True 'show picture
        MsgBox("Have a nice day!")
        End
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        picPizza.Visible = False 'hide picture
        wait("1")
        picPizza.Visible = True 'show picture
        MsgBox("Have a nice day!")
        End
    End Sub
    Private Sub wait(ByVal seconds As Decimal)
        For i As Decimal = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
End Class
