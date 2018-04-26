'Aditya Bhatia
'Shakespearean Insults
'4/26/2018
Public Class frmShakespeare
    Dim intRandomNumber As Integer
    Dim strInsult As String
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()

    End Sub

    Private Sub showInsult()
        Randomize()
        intRandomNumber = Rnd() * 4 + 1
        Select Case intRandomNumber
            Case "1"
                strInsult = "I think he be transformed into a beast; for I can nowhere find him like a man"
            Case "2"
                strInsult = "Lets meet as little as we can"
            Case "3"
                strInsult = "I desire that we be better strangers"
            Case "4"
                strInsult = "Boys, apes, braggarts, jacks, milksops!"
            Case "5"
                strInsult = "This is the silliest stuff that I ever heard"
        End Select
    End Sub

    Private Sub btnGenerateInsult_Click(sender As Object, e As EventArgs) Handles btnGenerateInsult.Click
        showInsult()
        lblInsult.Text = strInsult
    End Sub
End Class