'Aditya Bhatia
'Bank Protection
'3/16/2018
Public Class frmWelcome
    Dim intTries As Integer = 0
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If mtxAccountNumber.Text = "937281723" And mtxPin.Text = "37298" Then
            MessageBox.Show("Access Granted")
            If radDeposit.Checked Then
                Me.Visible = False
                frmDeposit.Visible = True
            ElseIf radWithdraw.Checked Then
                Me.Visible = False
                frmWithdraw.Visible = True
            Else
                MessageBox.Show("Please chose to widthdraw or deposit")
            End If
        Else
            shakeMe()
            MessageBox.Show("Access Denied" & vbCrLf & "Please try again")
            intTries = +1
            mtxAccountNumber.Text = ""
            mtxPin.Text = ""
        End If
        If intTries > 5 Then
            MessageBox.Show("Your account has been disabled. Please see a clerk to get it reenabled")
        End If

    End Sub

    Private Sub shakeMe()
        Dim myLoc As Point, myLocDef As Point
        myLocDef = Me.Location
        myLoc = Me.Location
        For i As Integer = 0 To 2
            For x As Integer = 0 To 4
                Select Case x
                    Case 0
                        myLoc.X = myLocDef.X + 10
                    Case 1
                        myLoc.X = myLocDef.X - 10
                    Case 2
                        myLoc.Y = myLocDef.Y - 10
                    Case 3
                        myLoc.Y = myLocDef.Y + 10
                    Case 4
                        myLoc = myLocDef
                End Select
                Me.Location = myLoc
                Me.Refresh()
            Next
        Next
        Me.Location = myLocDef
        Me.Refresh()
    End Sub
End Class

