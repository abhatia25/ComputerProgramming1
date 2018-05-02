'Aditya Bhatia
'Home Planet
'4/30/2018
Public Class frmSpaceStation
    Sub InventoryDialogBox()
        Dim InventoryDB As New frmInventory()
        'Show dialog box
        InventoryDB.ShowDialog()
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        InventoryDialogBox()
    End Sub

    Private Sub btnPlanet1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanet1.Click
        If GlobalVariables.intInventory1 < 1 Then
            MessageBox.Show("You need to find the handgun to enter this planet")
        Else
            Me.Hide()
            'frmResourceNum1.Show()
        End If
    End Sub

    Private Sub btnPlanet4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanet4.Click
        If GlobalVariables.intInventory4 < 1 Then
            MessageBox.Show("You need to find the crystal to enter this planet")
        Else
            Me.Hide()
            'frmResourceNum4.Show()
        End If
    End Sub

    Private Sub btnPlanet3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanet3.Click
        If GlobalVariables.intInventory3 < 1 Then
            MessageBox.Show("You need to find the reflector to enter this planet")
        Else
            Me.Hide()
            'frmResourceNum3.Show()
        End If
    End Sub

    Private Sub btnAliens_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAliens.Click
        MessageBox.Show("Aliens have entered your space station. GAME OVER")
        Me.Hide()
        frmGameOver.Show()
    End Sub

    Private Sub btnPlanet2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanet2.Click
        If GlobalVariables.intInventory2 < 1 Then
            MessageBox.Show("You need to find the orb to enter this planet")
        Else
            Me.Hide()
            'frmResourceNum2.Show()
        End If
    End Sub

    Private Sub btnSpaceship_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpaceship.Click
        If GlobalVariables.intInventory1 = 1 And GlobalVariables.intInventory2 = 1 And GlobalVariables.intInventory3 = 1 And GlobalVariables.intInventory4 = 1 Then
            MessageBox.Show("You win!")
            Me.Hide()
            frmSpaceship.Show()
        Else
            MessageBox.Show("You have not collected all the resources")
        End If
    End Sub
End Class
