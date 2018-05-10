Public Class frmStringExample
    Private Sub btnCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompare.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text

        If String.Compare(strA, strB) = 0 Then
            lblAnswer.Text = strA & " is equal to " & strB
        ElseIf String.Compare(strA, strB) < 0 Then
            lblAnswer.Text = strA & " comes before " & strB
        ElseIf String.Compare(strA, strB) > 0 Then
            lblAnswer.Text = strA & " comes after " & strB
        End If
    End Sub
    Private Sub btnConcat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConcat.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text
        Dim strNew As String
        strNew = String.Concat(strA, strB)
        lblAnswer.Text = strNew
    End Sub

    Private Sub btnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquals.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text
        If strA.Equals(strB) Then
            lblAnswer.Text = "The strings are the same."
        Else
            lblAnswer.Text = "The strings are the different."
        End If
    End Sub
    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text
        Dim strNew, strNew2 As String
        strNew = strA.Replace(strB, "b")
        lblAnswer.Text = strNew & " " & strNew2
    End Sub

    Private Sub btnIndexOf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIndexOf.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text
        Dim intIndex As Integer
        intIndex = strA.IndexOf(strB)
        lblAnswer.Text = intIndex
    End Sub
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text
        Dim strNew As String
        strNew = strA.Insert(0, "s")
        lblAnswer.Text = strNew
    End Sub
    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text
        Dim strNew, strNew2 As String
        strNew = strA.Remove(0)
        strNew2 = strB.Remove(0, 1)
        lblAnswer.Text = strNew2 & " " & strNew
    End Sub

    Private Sub btnToLower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToLower.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text
        lblAnswer.Text = strA.ToLower
    End Sub
    Private Sub btnToUpper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToUpper.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text
        lblAnswer.Text = strA.ToUpper
    End Sub
    Private Sub btnTrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrim.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text
        Dim strEx As String = "Example: "
        Dim strNew As String
        strNew = strA.Trim
        lblAnswer.Text = strEx & strNew
    End Sub

    Private Sub btnTrimEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrimEnd.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text
        Dim strEx As String = "Example: "
        Dim strNew As String
        strNew = strA.TrimEnd
        lblAnswer.Text = strEx & strNew
    End Sub
    Private Sub btnTrimStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrimStart.Click
        Dim strA As String = Me.txtWord1.Text
        Dim strB As String = Me.txtWord2.Text
        Dim strEx As String = "Example: "
        Dim strNew As String
        strNew = strA.TrimStart
        lblAnswer.Text = strEx & strNew
    End Sub
End Class
