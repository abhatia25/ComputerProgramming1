'Aditya Bhatia
'Hello
'2/16/2018
Public Class frmHello

    Private Sub btnHello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHello.Click
        lblHello.Text = "Hello" 'Adds "Hello" to lblHello when button is pressed
    End Sub

    Private Sub radEnglish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radEnglish.CheckedChanged
        lblHello.Text = "Hello" 'Adds "Hello" to lblHello when radEnglish is checked
    End Sub

    Private Sub radFrench_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFrench.CheckedChanged
        lblHello.Text = "Bonjour"
    End Sub

    Private Sub radGerman_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGerman.CheckedChanged
        lblHello.Text = "Guten Tag"
    End Sub

    Private Sub radNorwegian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNorwegian.CheckedChanged
        lblHello.Text = "Hallo"
    End Sub

    Private Sub radDutch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDutch.CheckedChanged
        lblHello.Text = "Dag"
    End Sub

    Private Sub radSwedish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSwedish.CheckedChanged
        lblHello.Text = "Hallå"
    End Sub

    Private Sub radItalian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radItalian.CheckedChanged
        lblHello.Text = "Ciao"
    End Sub

    Private Sub radKorean_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radKorean.CheckedChanged
        lblHello.Text = "여보세요"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
        End
    End Sub

    Private Sub TemperatureConversionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemperatureConversionToolStripMenuItem.Click
        Me.Visible = False 'Hides current form
        frmTemperatureConversion.Visible = True 'opens Temperature Conversion form
    End Sub

    Private Sub btnGoodbye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoodbye.Click
        lblGoodbye.Text = "Goodbye"
    End Sub

    Private Sub chkEnglish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnglish.CheckedChanged
        lblGoodbye.Text = "Goodbye"
    End Sub

    Private Sub chkFrench_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFrench.CheckedChanged
        lblGoodbye.Text = "Au Revoir"
    End Sub

    Private Sub chkGerman_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGerman.CheckedChanged
        lblGoodbye.Text = "Auf wiedersehen"
    End Sub

    Private Sub chkNorwegian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNorwegian.CheckedChanged
        lblGoodbye.Text = "Ha det"
    End Sub

    Private Sub chkDutch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDutch.CheckedChanged
        lblGoodbye.Text = "Vaarwel"
    End Sub

    Private Sub chkSwedish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSwedish.CheckedChanged
        lblGoodbye.Text = "Adjö"
    End Sub

    Private Sub chkItalian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItalian.CheckedChanged
        lblGoodbye.Text = "Addio"
    End Sub

    Private Sub chkKorean_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKorean.CheckedChanged
        lblGoodbye.Text = "안녕"
    End Sub
End Class