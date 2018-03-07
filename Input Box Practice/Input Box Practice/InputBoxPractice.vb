Public Class frmInputBoxPractice

    Private Sub frmInputBoxPractice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim userName As String = Nothing
        userName = InputBox("What is your name?", "hello", , , ) '
        lblHelloUser.Text = "Hello, " & userName
    End Sub
End Class
