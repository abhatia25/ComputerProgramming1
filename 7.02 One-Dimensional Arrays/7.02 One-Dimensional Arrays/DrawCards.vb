'Aditya Bhatia
'Draw Cards
'5/7/2018
Public Class frmDrawCards
    Dim intNumDraws As Integer = 0
    Dim int2Times As Integer = 0
    Dim int3Times As Integer = 0
    Dim int4Times As Integer = 0
    Dim int5Times As Integer = 0
    Dim int6Times As Integer = 0
    Dim int7Times As Integer = 0
    Dim int8Times As Integer = 0
    Dim int9Times As Integer = 0
    Dim int10Times As Integer = 0

    Private Sub btnDrawCards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawCards.Click
        intNumDraws = 0
        int2Times = 0
        int3Times = 0
        int4Times = 0
        int5Times = 0
        int6Times = 0
        int7Times = 0
        int8Times = 0
        int9Times = 0
        int10Times = 0
        Try
            intNumDraws = txtDraws.Text
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value")
        End Try

        Dim intCardDraws(intNumDraws - 1) As Integer

        For i As Integer = 0 To intCardDraws.Length - 1
            Randomize()
            intCardDraws(i) = (Rnd() * 10) + 2
        Next i

        Array.Sort(intCardDraws)

        For i As Integer = 0 To intCardDraws.Length - 1
            Select Case intCardDraws(i)
                Case 2
                    int2Times += 1
                Case 3
                    int3Times += 1
                Case 4
                    int4Times += 1
                Case 5
                    int5Times += 1
                Case 6
                    int6Times += 1
                Case 7
                    int7Times += 1
                Case 8
                    int8Times += 1
                Case 9
                    int9Times += 1
                Case 10
                    int10Times += 1
            End Select
        Next i

        lblAnswer.Text = "Card #2 was drawn " & int2Times & " times." & vbCrLf & "Card #3 was drawn " & int3Times & " times." & vbCrLf & "Card #4 was drawn " & int4Times & " times." & vbCrLf & "Card #5 was drawn " & int5Times & " times." & vbCrLf & "Card #6 was drawn " & int6Times & " times." & vbCrLf & "Card #7 was drawn " & int7Times & " times." & vbCrLf & "Card #8 was drawn " & int8Times & " times." & vbCrLf & "Card #9 was drawn " & int9Times & " times." & vbCrLf & "Card #10 was drawn " & int10Times & " times." & vbCrLf
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmRandomNums.Show()
    End Sub
End Class