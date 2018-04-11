'Aditya Bhatia
'Haunted House Project - Instructions
'3/26/2018
Public Class frmInstructions 'NEED TO COMMENT

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Try
            If txtNumber.Text < 10 Then
                txtNumber.Text = GlobalVariables.ExtraCandyInput
            Else
                MessageBox.Show("Please enter a positive integer less than 10")
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a positive integer less than 10")
        End Try
        If txtName.Text <> Nothing Then
            Me.txtName.Text = GlobalVariables.UserName
            Me.lblTitle.Visible = False
            Me.lblInstructions.Visible = False
            Me.btnDone.Visible = False
            Me.lblNamePrompt.Visible = False
            Me.txtName.Visible = False
            Me.lblNumberPrompt.Visible = False
            Me.txtNumber.Visible = False
            Me.BackgroundImage = My.Resources.door
            Me.btnDoor.Visible = True
            Me.lblCandyCounter.Visible = True
            Me.lblCandyCounter.Text = "Candy Counter" & vbCrLf & GlobalVariables.CandyCounter
            MessageBox.Show("Please click the door to enter the haunted house and recieve your first candy.", "Message Box")
        Else
            MessageBox.Show("Please enter your name")
        End If
    End Sub

    Private Sub btnDoor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoor.Click
        Me.Visible = False
        frmFoyer.Visible = True
        GlobalVariables.CandyCounter += 1
        MessageBox.Show("You have entered the haunted house and found your first candy")
        MessageBox.Show("Click on objects to find the candy")
        Me.lblCandyCounter.Text = "Candy Counter" & vbCrLf & GlobalVariables.CandyCounter
    End Sub
End Class

Public Class GlobalVariables
    Public Shared UserName As String = Nothing
    Public Shared CandyCounter As Integer = 0
    Public Shared ExtraCandyInput As Integer = 0
    Public Shared ExtraCandyCorrect As Integer = 0
End Class