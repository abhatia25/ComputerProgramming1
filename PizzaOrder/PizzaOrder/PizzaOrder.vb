'Aditya Bhatia
'Pizza Order
'2/7/2018
Public Class frmPizzaOrder
    Dim PizzaPrice As Decimal = 0
    Dim orderNumber As Integer = 0

    Public Sub btnPlaceOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaceOrder.Click
        Const Regular As Decimal = 7
        Const Large As Decimal = 10
        Const ONE_TOPPING As Decimal = 1.0
        Const TWO_TOPPINGS As Decimal = 1.75
        Const THREE_TOPPINGS As Decimal = 2.5
        Const FOUR_TOPPINGS As Decimal = 3.25
        Const ONE_SIDE As Decimal = 1.0
        Const TWO_SIDES As Decimal = 1.5
        Const THREE_SIDES As Decimal = 2.0
        Const FOUR_SIDES As Decimal = 2.5
        Const ONE_SANDWICH As Decimal = 1.0
        Const TWO_SANDWICHES As Decimal = 1.5
        Const THREE_SANDWICHES As Decimal = 2.0
        Const FOUR_SANDWICHES As Decimal = 2.5

        Dim numToppings As Integer = 0
        Dim toppingsPrice As Decimal = 0
        Dim numSides As Integer = 0
        Dim numSandwiches As Integer = 0
        Dim sidesPrice As Decimal = 0
        Dim sandwichesPrice As Decimal = 0

        'increase order number
        orderNumber += 1

        'count selected toppings
        If Me.chkMushrooms.Checked = True Then
            numToppings += 1
        End If

        If Me.chkOnions.Checked = True Then
            numToppings += 1
        End If
        If Me.chkPepperoni.Checked = True Then
            numToppings += 1
        End If

        If Me.chkPineapple.Checked = True Then
            numToppings += 1
        End If

        'count selected sides
        If Me.chkCookie.Checked = True Then
            numSides += 1
        End If

        If Me.chkCoke.Checked = True Then
            numSides += 1
        End If

        If Me.chkCheeseFries.Checked = True Then
            numSides += 1
        End If

        If Me.chkBreadSticks.Checked = True Then
            numSides += 1
        End If

        'count selected sanwiches
        If Me.chkChickenParm.Checked = True Then
            numSandwiches += 1
        End If

        If Me.chkItalianSub.Checked = True Then
            numSandwiches += 1
        End If

        If Me.chkMeatBallParm.Checked = True Then
            numSandwiches += 1
        End If

        If Me.chkTunaSub.Checked = True Then
            numSandwiches += 1
        End If

        'Determine the toppings Price using a Select Case Statement
        Select Case numToppings
            Case 1
                toppingsPrice = ONE_TOPPING
            Case 2
                toppingsPrice = TWO_TOPPINGS
            Case 3
                toppingsPrice = THREE_TOPPINGS
            Case 4
                toppingsPrice = FOUR_TOPPINGS
        End Select

        'Determine sides price
        Select Case numSides
            Case 1
                sidesPrice = ONE_SIDE
            Case 2
                sidesPrice = TWO_SIDES
            Case 3
                sidesPrice = THREE_SIDES
            Case 4
                sidesPrice = FOUR_SIDES
        End Select

        'Determine sandwich price
        Select Case numSandwiches
            Case 1
                sandwichesPrice = ONE_SANDWICH
            Case 2
                sandwichesPrice = TWO_SANDWICHES
            Case 3
                sandwichesPrice = THREE_SANDWICHES
            Case 4
                sandwichesPrice = FOUR_SANDWICHES
        End Select

        'Display pizza price
        If Me.radLarge.Checked Then
            PizzaPrice = PizzaPrice + Large + toppingsPrice + sandwichesPrice + sidesPrice
        Else
            PizzaPrice = PizzaPrice + Regular + toppingsPrice + sandwichesPrice + sidesPrice
        End If


        'Display pizza price and order number
        lblOrder.Text = "Order Number:"
        Me.lblOrderNumber.Text = orderNumber
        Me.lblPrice.Text = "Price:  $"
        Me.lblPizzaPrice.Text = CStr(PizzaPrice)
    End Sub

    Public Sub btnNewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewOrder.Click
        'When a new order is started, select the regular radio button and clear the check boxes and labels
        PizzaPrice = 0
        Me.radLarge.Checked = False
        Me.radRegular.Checked = True
        Me.chkPineapple.Checked = False
        Me.chkMushrooms.Checked = False
        Me.chkOnions.Checked = False
        Me.chkPepperoni.Checked = False
        Me.chkCookie.Checked = False
        Me.chkCoke.Checked = False
        Me.chkCheeseFries.Checked = False
        Me.chkBreadSticks.Checked = False
        Me.chkMeatBallParm.Checked = False
        Me.chkChickenParm.Checked = False
        Me.chkTunaSub.Checked = False
        Me.chkItalianSub.Checked = False
        Me.lblOrder.Text = ""
        Me.lblOrderNumber.Text = ""
        Me.lblPrice.Text = ""
        Me.lblPizzaPrice.Text = ""
    End Sub
End Class
