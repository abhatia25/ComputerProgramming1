'Aditya Bhatia
'Math Example
'5/9/2018
Public Class frmMathExample

    Private Sub btnAbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbs.Click
        Dim dblNum As Double
        Dim input As String
        Try
            input = txtInput.Text
            dblNum = Convert.ToDouble(input)
            lblAnswer.Text = "The Absolute Value is " & Math.Abs(dblNum)
        Catch ex As Exception
            MessageBox.Show("Enter numeric values")
        End Try
    End Sub

    Private Sub btnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSqrt.Click
        Dim dblNum As Double
        Dim input As String

        Try
            input = txtInput.Text
            dblNum = Convert.ToDouble(input)
            lblAnswer.Text = "The Square Root is " & Math.Sqrt(dblNum)
        Catch ex As Exception
            MessageBox.Show("Enter numeric values")
        End Try
    End Sub

    Private Sub btnSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSign.Click
        Dim dblNum As Double
        Dim input As Double

        Try
            input = txtInput.Text
            dblNum = Convert.ToDouble(input)

            If Math.Sign(dblNum) > 0 Then
                lblAnswer.Text = dblNum & " is a positive number."
            ElseIf Math.Sign(dblNum) < 0 Then
                lblAnswer.Text = dblNum & " is a negative number."
            Else
                lblAnswer.Text = dblNum & " is zero."
            End If
        Catch ex As Exception
            MessageBox.Show("Enter numeric values")
        End Try
    End Sub

    Private Sub btnRound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRound.Click
        Dim dblNum As Double
        Dim input As String
        Dim intPlaces As Integer

        Try
            input = txtInput.Text
            dblNum = Convert.ToDouble(input)
            intPlaces = Convert.ToInt16(InputBox("Enter the number of places", "Places to round"))
            lblAnswer.Text = "The Rounded Value is " & Math.Round(dblNum, intPlaces)
        Catch ex As Exception
            MessageBox.Show("Enter numeric values")
        End Try
    End Sub
End Class
