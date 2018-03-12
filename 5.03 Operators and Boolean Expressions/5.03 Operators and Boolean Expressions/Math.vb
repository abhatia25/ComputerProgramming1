'Aditya Bhatia
'Math
'3/12/2018
Public Class frmMath
    Dim dblAdd As Double = 0
    Dim dblParentheses As Double = 0
    Dim dblMult As Double = 0
    Dim dblDecMult As Double = 0
    Dim dblDiv As Double = 0
    Dim dblIntDiv As Double = 0
    Dim dblMod As Double = 0
    Dim strAnswer As String = Nothing
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmMints.Visible = True
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        strAnswer = Nothing
        dblAdd = 6 + 3 / 2
        strAnswer = dblAdd
        Me.lblAdd.Text = strAnswer
    End Sub

    Private Sub btnParentheses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParentheses.Click
        strAnswer = Nothing
        dblParentheses = (6 + 3) / 2
        strAnswer = dblParentheses
        Me.lblParentheses.Text = strAnswer
    End Sub

    Private Sub btnMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMult.Click
        strAnswer = Nothing
        dblMult = 9 * 2 / 5
        strAnswer = dblMult
        Me.lblMult.Text = strAnswer
    End Sub

    Private Sub btnDecMult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecMult.Click
        strAnswer = Nothing
        dblDecMult = 9.0 * 2 / 5
        strAnswer = dblDecMult
        Me.lblDecMult.Text = strAnswer
    End Sub

    Private Sub btnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiv.Click
        strAnswer = Nothing
        dblDiv = 7 / 2
        strAnswer = dblDiv
        Me.lblDiv.Text = strAnswer
    End Sub

    Private Sub btnIntDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIntDiv.Click
        strAnswer = Nothing
        dblIntDiv = 7 \ 2
        strAnswer = dblIntDiv
        Me.lblIntDiv.Text = strAnswer
    End Sub

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        strAnswer = Nothing
        dblMod = 7 Mod 2
        strAnswer = dblMod
        Me.lblMod.Text = strAnswer
    End Sub
End Class
