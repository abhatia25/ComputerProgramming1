Public Class frmManufacureGuy

    Private Sub cboTalk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTalk.SelectedIndexChanged
        btnAsk.Visible = True
    End Sub

    Private Sub btnAsk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsk.Click

        If cboTalk.Text = "Can you help us fix these resources?" Then

            lblName.Visible = True

            MessageBox.Show("Can I get a hello first? Nah just kidding, I'm Mr.harold. Plus if you want me to do it, that'll cost you a please.")

            btnThankyou.Visible = True
            btnNoThankYou.Visible = True
        End If

        If cboTalk.Text = "Hello, I want to take over this company!" Then

            lblName.Visible = True

            MessageBox.Show("You know we have lasers right? No I'm just kidding. I'm Harold, the manufacture and I can fix anything in the world.")

            btnJK.Visible = True
            btnNoForeal.Visible = True

        End If

        If cboTalk.Text = "What is this place?" Then

            lblName.Visible = True

            MessageBox.Show("HAHAHAHAHAH, this is the manufacturing Planet, and I, Mr. Harold, just happen to be the best manufacture in the world so ...")

            btnSoo.Visible = True

        End If

        If cboTalk.Text = "Where is the Manufacture?" Then

            lblName.Visible = True

            MessageBox.Show("Well that happens to be me. Hi I'm Mr.Harold. What do you need help with?")

            btnDie.Visible = True
            btnLive.Visible = True
        End If

    End Sub

    Private Sub btnThankyou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThankyou.Click

        MessageBox.Show("Ok, i guess that works, put your resources in the crate and in get to it.")

        picBox.Visible = True
        lstPlaceItems.Visible = True
        btnPlace.Visible = True
    End Sub

    Private Sub btnJK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJK.Click

        MessageBox.Show("Oh good, now I can get started. Place you items in the box.")

        picBox.Visible = True
        lstPlaceItems.Visible = True
        btnPlace.Visible = True
    End Sub

    Private Sub btnNoForeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoForeal.Click

        MessageBox.Show("Sorry I had to do it to you.")

        Me.Hide()
        frmLaserRoom.Show()
    End Sub

    Private Sub btnNoThankYou_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoThankYou.Click

        MessageBox.Show("Good to know, good to know you pal.")

        Me.Hide()
        frmLaserRoom.Show()

    End Sub

    Private Sub btnSoo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoo.Click

        MessageBox.Show("Soo ... I can fix anything in the world. Just put resources or materials in the box and I can fix it right up.")

        picBox.Visible = True
        lstPlaceItems.Visible = True
        btnPlace.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLive.Click
        MessageBox.Show("Oh I see, you can just place materials or resources into that box over there.")

        picBox.Visible = True
        lstPlaceItems.Visible = True
        btnPlace.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDie.Click
        MessageBox.Show("Well that's not very nice. BUT I have no problems at all with doing this...")

        Me.Hide()
        frmLaserRoom.Show()
    End Sub

    Private Sub btnPlace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlace.Click
        lstPlaceItems.Items.Add("Power Crystal")
        lstPlaceItems.Items.Add("Shape Shifting Orb")
        lstPlaceItems.Items.Add("HandGun")
        lstPlaceItems.Items.Add("Shield Reflector")
        btnMake.Visible = True
    End Sub

    Private Sub btnMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMake.Click

        lstPlaceItems.Items.Clear()

        picShield.Visible = True

    End Sub

    Private Sub picShield_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picShield.Click

        MessageBox.Show("You have obtained the Protective Shield")
        GlobalVariables.intInventory5 += 1
        picShield.Visible = False
        MessageBox.Show("Now you will go back to the space station")

    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        frmSpaceship.InventoryDialogBox()
    End Sub

End Class