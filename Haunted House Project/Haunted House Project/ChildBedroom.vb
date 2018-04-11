Public Class frmChildBedroom
    Dim shakeCount As Integer = 0
    Dim message As String
    Dim intCandyCounter As Integer
    Private Sub frmChildBedroom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCandyCounter.Text = "Candy Counter:" & vbCrLf & "5"
        MessageBox.Show("You have now entered the child's bedroom, find the candy by clicking diffrent objects. YOU HAVE A TIME LIMIT, GO")
        Timer1.Start()
    End Sub

    Private Sub btnCandy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandy.Click
        btnCandy.BackgroundImage = My.Resources.Butterfinger
        intCandyCounter = 5
        Timer1.Stop()
        ProgressBar1.Value = 0
        lblProgress.Text = 0
        MessageBox.Show("You found the candy! Click Next to enter into the next room IF YOU DARE")
        btnNext.Visible = True
        intCandyCounter = 5 + 1
        lblCandyCounter.Text = "Candy Counter:" & vbCrLf & intCandyCounter
    End Sub

    Private Sub btnButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton11.Click
        If shakeCount >= 1000 Then
            shakeCount = 0
        End If

        Do Until shakeCount = 1000
            Me.Left -= 5
            Me.Left += 5
            shakeCount += 1
        Loop
        MessageBox.Show("Its Not There")
    End Sub

    Private Sub btnButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton5.Click
        If shakeCount >= 1000 Then
            shakeCount = 0
        End If

        Do Until shakeCount = 1000
            Me.Left -= 5
            Me.Left += 5
            shakeCount += 1
        Loop

        MessageBox.Show("Its Not There")
    End Sub

    Private Sub btnButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton4.Click
        If shakeCount >= 1000 Then
            shakeCount = 0
        End If

        Do Until shakeCount = 1000
            Me.Left -= 5
            Me.Left += 5
            shakeCount += 1
        Loop
        MessageBox.Show("Its Not There")
    End Sub

    Private Sub btnButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton3.Click
        If shakeCount >= 1000 Then
            shakeCount = 0
        End If

        Do Until shakeCount = 1000
            Me.Left -= 5
            Me.Left += 5
            shakeCount += 1
        Loop
        MessageBox.Show("Its Not There")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If shakeCount >= 1000 Then
            shakeCount = 0
        End If

        Do Until shakeCount = 1000
            Me.Left -= 5
            Me.Left += 5
            shakeCount += 1
        Loop

        MessageBox.Show("Its Not There")
    End Sub

    Private Sub btnButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton8.Click
        If shakeCount >= 1000 Then
            shakeCount = 0
        End If

        Do Until shakeCount = 1000
            Me.Left -= 5
            Me.Left += 5
            shakeCount += 1
        Loop

        MessageBox.Show("Its Not There")
    End Sub

    Private Sub btnButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton12.Click
        If shakeCount >= 1000 Then
            shakeCount = 0
        End If

        Do Until shakeCount = 1000
            Me.Left -= 5
            Me.Left += 5
            shakeCount += 1
        Loop
        MessageBox.Show("Its Not There")
    End Sub

    Private Sub btnButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton9.Click
        If shakeCount >= 1000 Then
            shakeCount = 0
        End If

        Do Until shakeCount = 1000
            Me.Left -= 5
            Me.Left += 5
            shakeCount += 1
        Loop
        MessageBox.Show("Its Not There")
    End Sub

    Private Sub btnButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton2.Click
        If shakeCount >= 1000 Then
            shakeCount = 0
        End If

        Do Until shakeCount = 1000
            Me.Left -= 5
            Me.Left += 5
            shakeCount += 1
        Loop
        MessageBox.Show("Its Not There")
    End Sub

    Private Sub btnButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton1.Click
        If shakeCount >= 1000 Then
            shakeCount = 0
        End If

        Do Until shakeCount = 1000
            Me.Left -= 5
            Me.Left += 5
            shakeCount += 1
        Loop
        MessageBox.Show("Its Not There")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            ProgressBar1.Value = 0
            lblProgress.Text = 0
            PictureBox1.Visible = True
            MessageBox.Show("You did not find the candy in time, the Ghost found you. GAME OVER")
            Me.Visible = False
            frmGameOver.Visible = True
        End If
        lblProgress.Text = ProgressBar1.Value & ("%")
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        MessageBox.Show("The Attic is locked you must answer a riddle to get the key")
        message = InputBox("Riddle me this: What has one eye but can't see?", )

        If message = "needle" Then
            MessageBox.Show("CORRECT")

            frmAttic.Show()
            Me.Hide()
        Else
            MessageBox.Show("WRONG, last try or you die")

            message = InputBox("Riddle me this: What has one eye but cant see?", )


        End If
        If message = "Needle" Then
            MessageBox.Show("CORRECT")
            frmAttic.Show()
            Me.Hide()
        Else
            PictureBox1.Visible = True
            Me.Close()
            frmGameOver.Visible = True
        End If
    End Sub
End Class