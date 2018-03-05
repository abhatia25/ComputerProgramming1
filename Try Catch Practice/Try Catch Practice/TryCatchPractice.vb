'Aditya Bhatia
'Try Catch Practice
'2/28/2018
Public Class frmTryCatchPractice

    Private myArray() As Integer = {5, 4, 3, 2, 1}

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try 'Attempt following code
            For index As Integer = 0 To 5
                lstListBox.Items.Add(myArray(index))
            Next
        Catch ex As Exception
            MessageBox.Show("An error has occurred")
        End Try
    End Sub
End Class
