'Aditya Bhatia
'Stones
'4/29/2018
Public Class frmStones
    Dim intStonesLeft As Integer
    Dim intPlayerStones As Integer
    Dim intComputerStones As Integer
    Dim random As New Random

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmLoanPayment.Show()
    End Sub

    Private Sub GameStart()
        intStonesLeft = random.Next(15, 30)
        DisplayStonesLeft(intStonesLeft)
    End Sub

    Private Sub btnTakeStones_Click(sender As Object, e As EventArgs) Handles btnTakeStones.Click
        PlayerMove()
        DisplayStonesLeft(intStonesLeft)
        lblComputerStones.Text = "Computer took " & intComputerStones & " stone(s)."
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        intPlayerStones = 0
        intStonesLeft = 0
        intComputerStones = 0
        lblStonesLeft.Text = ""
        lblComputerStones.Text = ""
        GameStart()
    End Sub

    Sub DisplayStonesLeft(ByRef intStonesLeft As Integer)
        lblStonesLeft.Text = "Stones left in pile: " & intStonesLeft
    End Sub

    Sub PlayerMove()
        Try
            intPlayerStones = txtPlayerStones.Text
            If intPlayerStones > 3 Then
                MessageBox.Show("Please enter an integer between 1 and 3")
            ElseIf intPlayerStones < 1 Then
                MessageBox.Show("Please enter an integer between 1 and 3")
            ElseIf intPlayerStones = intStonesLeft Then
                MessageBox.Show("Computer wins")
            Else
                If intPlayerStones > intStonesLeft Then
                    MessageBox.Show("Illegal Move")
                Else
                    intStonesLeft = intStonesLeft - intPlayerStones
                    ComputerMove()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter an integer value")
        End Try
    End Sub

    Sub ComputerMove()
        intComputerStones = random.Next(1, 3)
        If intComputerStones > intStonesLeft Then
            ComputerMove()
        ElseIf intComputerStones = intStonesLeft Then
            MessageBox.Show("Player wins")
        Else
            intStonesLeft = intStonesLeft - intComputerStones
        End If
    End Sub

    Private Sub frmStones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GameStart()
    End Sub
End Class