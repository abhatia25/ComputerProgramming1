Public Class frmArrayPractice

    Private Sub btnAddArrays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddArrays.Click
        clearList()

        Dim strClasses(5) As String

        strClasses(0) = "Web Design"
        strClasses(1) = "Spanish"
        strClasses(2) = "Chemistry"
        strClasses(3) = "English"
        strClasses(4) = "History"
        strClasses(5) = "Calculus"

        For num As Integer = 0 To strClasses.Length - 1
            lstArrays.Items.Add(strClasses(num))
        Next
    End Sub

    Private Sub clearList()
        lstArrays.Items.Clear()
    End Sub
End Class
