'Aditya Bhatia
'Math Fun
'5/9/2018
Public Class frmMathFun

    Private Sub AbsoluteValueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsoluteValueToolStripMenuItem.Click
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

    Private Sub SquareRootToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SquareRootToolStripMenuItem.Click
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

    Private Sub SignToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignToolStripMenuItem.Click
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

    Private Sub RoundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoundToolStripMenuItem.Click
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

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmMyName.Show()
    End Sub
End Class
