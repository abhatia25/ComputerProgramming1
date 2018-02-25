'Aditya Bhatia
'Select Case Practice
'2/23/2018
Public Class frmSelectCasePractice

    Private Sub btnHello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHello.Click
        Dim yourName As String = lstName.Items(lstName.SelectedIndex).ToString
        Select Case yourName.ToLower
            Case "bryan"
                MessageBox.Show("Hello Bryan!")
            Case "sam"
                MessageBox.Show("Hello Sam!")
            Case "julia"
                MessageBox.Show("Hello Julia!")
            Case "robert"
                MessageBox.Show("Hello Robert!")
            Case "christian"
                MessageBox.Show("Hello Christian!")
            Case Else
                MessageBox.Show("Who are you?!?!?")
        End Select
    End Sub
End Class
