'Aditya Bhatia
'Else If Statements
'2/15/2018
Public Class frmElseIf

    Private Sub btnHello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHello.Click


        Dim yourName As String = lstName.Items(lstName.SelectedIndex).ToString 'Assign list items to string yourName

        If yourName = "Cathy" Then 'If Cathy is selected then show MessageBox - Hello Cathy
            MessageBox.Show("Hello Cathy")
        ElseIf yourName = "Kristy" Then
            MessageBox.Show("Hello Kristy")
        ElseIf yourName = "Carl" Then
            MessageBox.Show("Hello Carl")
        Else
            MessageBox.Show("Who Are You?")
        End If

    End Sub

    Private Sub SumOf4NumbersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SumOf4NumbersToolStripMenuItem.Click
        Me.Visible = False 'Hide current form
        frmSumof4Numbers.Visible = True 'Show frmSumof4Numbers
    End Sub

    Private Sub SimpleDiceRollingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleDiceRollingToolStripMenuItem.Click
        Me.Visible = False
        frmSimpleDiceRolling.Visible = True
    End Sub

    Private Sub SimpleCalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleCalculatorToolStripMenuItem.Click
        Me.Visible = False
        frmSimpleCalculator.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a good day!")
        End
    End Sub
End Class

