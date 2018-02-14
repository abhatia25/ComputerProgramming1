'Aditya Bhatia
'2/1/2018
'Events Practice
Public Class EventsPractice

    Private Sub EventsPractice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome!")
    End Sub

    Private Sub btnButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton1.Click
        lblLabel1.Text = "Hello World"
    End Sub

    Private Sub btnButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton2.Click
        End
    End Sub

    Private Sub lblLabel1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLabel1.MouseEnter
        lblLabel1.Text = "The Mouse is Over Me"
    End Sub

    Private Sub lblLabel1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLabel1.MouseLeave
        lblLabel1.Text = "The Mouse Left Me"
    End Sub
End Class
