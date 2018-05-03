'Aditya Bhatia
'Friends Array
'5/3/2018
Public Class frmFriendsArray
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FriendArr(4) As String  'declare the array - size 5

        'Loop to add strings from InputBoxes to the array
        For i As Integer = 0 To FriendArr.Length - 1
            FriendArr(i) = InputBox("Enter a friend's name.", "BFF")
        Next i

        'Sort the array, ascending
        Array.Sort(FriendArr)

        'Loop to add the values from the array to the label using 
        'concatenation
        For i As Integer = 0 To FriendArr.Length - 1
            Me.lblDisplay.Text &= FriendArr(i) & vbCrLf
        Next i

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()

    End Sub
End Class