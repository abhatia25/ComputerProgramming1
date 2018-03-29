Public Class LoopPractice

    Private Sub btnDoWhileLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoWhileLoop.Click
        Dim BeingsAreEnteringRoom As Integer = 1

        Do While (BeingsAreEnteringRoom < 10)
            MessageBox.Show("The number of beings of light entering the room that I ask to Prom is " & BeingsAreEnteringRoom)
            BeingsAreEnteringRoom = BeingsAreEnteringRoom + 1
        Loop
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim NumberOfBeingsAskedToProm As Integer
        Dim TotalNumberOfBeingsAsked As Integer

        For NumberOfBeingsAskedToProm = 1 To 5
            TotalNumberOfBeingsAsked = TotalNumberOfBeingsAsked + TotalNumberOfBeingsAsked
            lblAnswer.Text = NumberOfBeingsAskedToProm
        Next
    End Sub
End Class
