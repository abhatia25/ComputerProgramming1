'Aditya Bhatia
'Haunted House Project - Instructions
'3/26/2018
Public Class frmInstructions
    Dim candyCounter As Integer = 0

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Me.lblTitle.Visible = False
        Me.lblInstructions.Visible = False
        Me.btnDone.Visible = False
        Me.BackgroundImage = My.Resources.door
        Me.btnDoor.Visible = True
        Me.lblCandyCounter.Visible = True
        Me.lblCandyCounter.Text = "Candy Counter" & vbCrLf & candyCounter
        MessageBox.Show("Please click the door to enter the haunted house and recieve your first candy.", "Message Box")
    End Sub

    Private Sub btnDoor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoor.Click
        Me.Visible = False
        frmFoyer.Visible = True
        candyCounter += 1
        MessageBox.Show("You have entered the haunted house and found your first candy")
        MessageBox.Show("Click on objects to find the candy")
    End Sub
End Class