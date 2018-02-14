'Aditya Bhatia'
'2/1/2018'
'Morning To Do List'
Public Class frmMorningToDo
    Private Sub chkShower_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShower.CheckedChanged
        If Me.chkShower.Checked Then
            MessageBox.Show("Don't forget to use underarm deodorant!")
        End If
    End Sub

    Private Sub btnAllDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllDone.Click
        If Not (Me.chkMakeBed.Checked And Me.chkBrushTeeth.Checked And Me.chkStyleHair.Checked And Me.chkGetDressed.Checked And Me.chkEatBreakfast.Checked And Me.chkSchoolWork.Checked And Me.chkKissMom.Checked) Then
            MessageBox.Show("Did you forget something?")
        Else
            End
        End If
    End Sub

    Private Sub chkBrushTeeth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBrushTeeth.CheckedChanged
        If Me.chkBrushTeeth.Checked Then
            MessageBox.Show("Don't forget to use mouth wash!")
        End If
    End Sub

    Private Sub chkStyleHair_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStyleHair.CheckedChanged
        If Me.chkStyleHair.Checked Then
            MessageBox.Show("Don't forget to use gel!")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
