'Aditya Bhatia
'Position Project
'2/9/2018
Public Class frmPositionProject

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub TopLeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopLeftToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.TopLeft
    End Sub

    Private Sub TopCenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopCenterToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.TopCenter
    End Sub

    Private Sub TopRightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopRightToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.TopRight
    End Sub

    Private Sub MiddleLeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiddleLeftToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub MiddleCenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiddleCenterToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub MiddleRightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiddleRightToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub BottomLeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottomLeftToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.BottomLeft
    End Sub

    Private Sub BottomCenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottomCenterToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.BottomCenter
    End Sub

    Private Sub BottomRightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottomRightToolStripMenuItem.Click
        Me.lblHere.TextAlign = ContentAlignment.BottomRight
    End Sub

    Private Sub frmPositionProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome!")
    End Sub
End Class