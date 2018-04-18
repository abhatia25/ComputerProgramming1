'Aditya Bhatia
'Alarm System
'4/18/2018
Public Class frmAlarmSystem
    Const MASTER_CODE As Integer = 62498
    Dim codeEntered As Integer
    Private Sub btnNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnZero.Click, btnOne.Click, btnTwo.Click, btnThree.Click, btnFour.Click, btnFive.Click, btnSix.Click, btnSeven.Click, btnEight.Click, btnNine.Click
        Dim btnNumberClicked As Button = sender
        Me.txtDisplay.Text &= btnNumberClicked.Tag
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        codeEntered = Val(Me.txtDisplay.Text)
        If codeEntered = MASTER_CODE Then
            MessageBox.Show("Code accepted")
            Me.txtDisplay.Text = Nothing
        Else
            MessageBox.Show("Code not accepted")
            Me.txtDisplay.Text = Nothing
            codeEntered = 0
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtDisplay.Text = Nothing
        codeEntered = Nothing
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmCandyJar.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class