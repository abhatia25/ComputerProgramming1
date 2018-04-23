'Aditya Bhatia
'Signature
'4/23/2018
Public Class frmSignature
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmLoanCalculator.Show()
    End Sub

    Function Signature(ByVal strName As String) As String
        Dim strToReturn As String
        'create the string to return
        strToReturn = "Create By " & strName
        Return strToReturn      'sends the string back.
    End Function

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strFName As String
        strFName = Me.txtFName.Text
        Me.lblDisplay.Text = Signature(strFName)
    End Sub
End Class