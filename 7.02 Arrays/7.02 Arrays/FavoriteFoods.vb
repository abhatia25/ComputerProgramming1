'Aditya Bhatia
'Favorite Foods
'5/3/2018
Public Class frmFavoriteFoods
    Dim strFoodsArr(4) As String

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()

    End Sub
    Private Sub enterFoods(ByRef strFoodsArr() As String)
        'Add string values to the array
        For i As Integer = 0 To strFoodsArr.Length - 1
            strFoodsArr(i) = InputBox("Enter one of your favorite 
			foods", "My Favorite Foods")
        Next i
    End Sub

    Private Sub showFoods(ByVal strFoodsArr() As String)
        Array.Sort(strFoodsArr)
        For i As Integer = 0 To strFoodsArr.Length - 1
            Me.lstFavFoods.Items.Add(strFoodsArr(i))
        Next i
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        enterFoods(strFoodsArr)
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        showFoods(strFoodsArr)
    End Sub
End Class