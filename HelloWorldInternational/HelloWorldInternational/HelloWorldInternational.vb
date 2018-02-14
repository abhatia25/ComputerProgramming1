Public Class frmHelloWorldInternational

    Private Sub radFrench_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFrench.CheckedChanged
        Me.lblGreeting.Text = " Bonjour le monde! "
    End Sub

    Private Sub radEnglish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radEnglish.CheckedChanged
        Me.lblGreeting.Text = " Hello, World! "
    End Sub

    Private Sub radSpanish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSpanish.CheckedChanged
        Me.lblGreeting.Text = " Hola, mundo! "
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub radChinese_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radChinese.CheckedChanged
        Me.lblGreeting.Text = " 你好, 世界! "
    End Sub

    Private Sub radGerman_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGerman.CheckedChanged
        Me.lblGreeting.Text = " Hallo Welt! "
    End Sub
End Class
