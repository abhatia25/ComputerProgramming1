'Aditya Bhatia
'Donut Delight
'2/21/2018
Public Class frmDonutDelight
    Dim dblTotalPrice As Double = 0
    Dim dblSubtotal As Double = 0
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a great day!")
        End
    End Sub

    Private Sub radGlazed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGlazed.CheckedChanged
        lblDonutChoice.Text = ""
        If radGlazed.Checked Then
            lblDonutChoice.Text &= "You chose the glazed donut" & vbCrLf & "They are only $0.50 each" & vbCrLf
            dblSubtotal += 0.5
        End If
    End Sub

    Private Sub radChocolate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radChocolate.CheckedChanged
        lblDonutChoice.Text = ""
        If radChocolate.Checked Then
            lblDonutChoice.Text &= "You chose the chocolate donut" & vbCrLf & "They are only $0.65 each" & vbCrLf
            dblSubtotal += 0.65
        End If
    End Sub

    Private Sub radBlueberry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBlueberry.CheckedChanged
        lblDonutChoice.Text = ""
        If radBlueberry.Checked Then
            lblDonutChoice.Text &= "You chose the blueberry donut" & vbCrLf & "They are only $0.75 each" & vbCrLf
            dblSubtotal += 0.75
        End If
    End Sub

    Private Sub radLemon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLemon.CheckedChanged
        lblDonutChoice.Text = ""
        If radLemon.Checked Then
            lblDonutChoice.Text &= "You chose the lemon donut" & vbCrLf & "They are only $0.60 each" & vbCrLf
            dblSubtotal += 0.6
        End If
    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        lblDonutChoice.Text = ""
        If Not (radBlueberry.Checked Or radChocolate.Checked Or radGlazed.Checked Or radLemon.Checked) Then
            MessageBox.Show("Please chose a type of donut")
        Else
            dblTotalPrice = txtDonuts.Text * dblSubtotal
            lblTotal.Text = "Your total cost is: " & dblTotalPrice.ToString("$##.00")
            MessageBox.Show("Have a great day!")
            End
        End If
    End Sub

    Private Sub StopwatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopwatchToolStripMenuItem.Click
        Me.Visible = False
        frmStopwatch.Visible = True
    End Sub
End Class
