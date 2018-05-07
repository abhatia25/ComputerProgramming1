'Aditya Bhatia
'GPA Array
'5/7/2018
Public Class frmGPAArray

    Private Sub btnAddGPA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddGPA.Click
        Dim dblGPAArray(4) As Double
        For i As Integer = 0 To dblGPAArray.Length - 1
            dblGPAArray(i) = InputBox("Please enter a GPA", "GPAs")
        Next i
        Array.Sort(dblGPAArray)
        For i As Integer = 0 To dblGPAArray.Length - 1
            lstGPA.Items.Add("GPA #" & i & " is " & dblGPAArray(i))
        Next i
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmDrawCards.show()
    End Sub
End Class