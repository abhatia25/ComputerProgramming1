'Aditya Bhatia
'Temperature Converter
'2/16/2018
Public Class frmTemperatureConversion
    Private Sub btnCelsius_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCelsius.Click
        Dim fahren As Double
        Dim celsius As Double

        fahren = Val(Me.txtTemp.Text)
        celsius = 5 / 9 * (fahren - 32)
        Me.lblAnswerLabel.Text = "The temperature in Celsius is:"
        Me.lblAnswer.Text = celsius
    End Sub

    Private Sub txtTemp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTemp.TextChanged
        Me.lblAnswerLabel.Text = ""
        Me.lblAnswer.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
        End
    End Sub

    Private Sub HelloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelloToolStripMenuItem.Click
        Me.Visible = False
        frmHello.Visible = True
    End Sub
End Class
