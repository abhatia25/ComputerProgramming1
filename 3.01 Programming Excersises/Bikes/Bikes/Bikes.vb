'Aditya Bhatia
'3.01 Programming Excersises
'2/13/2018
Public Class frmBikes
    Dim Order As String
    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        lblInfo.Text = "The bike shop has been located here for 10 years. We specialize in custom bikes built just for you."
    End Sub

    Private Sub radRoad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radRoad.CheckedChanged
        Dim extras As String = ""
        If chkPaint.Checked = True Then
            extras &= "You would like to add custom paint. " 'addition to extras string
        End If
        If chkFrame.Checked = True Then
            extras &= "You would like a heavy duty frame. "
        End If
        If chkSeat.Checked = True Then
            extras &= "You would like a comfort seat. "
        End If
        Dim bike As String = ""
        If radRoad.Checked = True Then
            bike &= "You chose the road bike. " 'addition to bike string
        End If
        If radMountain.Checked = True Then
            bike &= "You chose the mountain bike. "
        End If
        If radHybrid.Checked = True Then
            bike &= "You chose the hybrid bike. "
        End If
        If radHybrid.Checked Or radMountain.Checked Or radRoad.Checked Then
            Order = bike + extras
        End If
        lblInfo.Text = CStr(Order) 'display order details in label
    End Sub

    Private Sub radMountain_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMountain.CheckedChanged
        Dim extras As String = ""
        If chkPaint.Checked = True Then
            extras &= "You would like to add custom paint. " 'addition to extras string
        End If
        If chkFrame.Checked = True Then
            extras &= "You would like a heavy duty frame. "
        End If
        If chkSeat.Checked = True Then
            extras &= "You would like a comfort seat. "
        End If
        Dim bike As String = ""
        If radRoad.Checked = True Then
            bike &= "You chose the road bike. " 'addition to bike string
        End If
        If radMountain.Checked = True Then
            bike &= "You chose the mountain bike. "
        End If
        If radHybrid.Checked = True Then
            bike &= "You chose the hybrid bike. "
        End If
        If radHybrid.Checked Or radMountain.Checked Or radRoad.Checked Then
            Order = bike + extras
        End If
        lblInfo.Text = CStr(Order) 'display order details in label
    End Sub

    Private Sub radHybrid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radHybrid.CheckedChanged
        Dim extras As String = ""
        If chkPaint.Checked = True Then
            extras &= "You would like to add custom paint. " 'addition to extras string
        End If
        If chkFrame.Checked = True Then
            extras &= "You would like a heavy duty frame. "
        End If
        If chkSeat.Checked = True Then
            extras &= "You would like a comfort seat. "
        End If
        Dim bike As String = ""
        If radRoad.Checked = True Then
            bike &= "You chose the road bike. " 'addition to bike string
        End If
        If radMountain.Checked = True Then
            bike &= "You chose the mountain bike. "
        End If
        If radHybrid.Checked = True Then
            bike &= "You chose the hybrid bike. "
        End If
        If radHybrid.Checked Or radMountain.Checked Or radRoad.Checked Then
            Order = bike + extras
        End If
        lblInfo.Text = CStr(Order) 'display order details in label
    End Sub

    Private Sub chkPaint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPaint.CheckedChanged
        Dim extras As String = ""
        If chkPaint.Checked = True Then
            extras &= "You would like to add custom paint. " 'addition to extras string
        End If
        If chkFrame.Checked = True Then
            extras &= "You would like a heavy duty frame. "
        End If
        If chkSeat.Checked = True Then
            extras &= "You would like a comfort seat. "
        End If
        Dim bike As String = ""
        If radRoad.Checked = True Then
            bike &= "You chose the road bike. " 'addition to bike string
        End If
        If radMountain.Checked = True Then
            bike &= "You chose the mountain bike. "
        End If
        If radHybrid.Checked = True Then
            bike &= "You chose the hybrid bike. "
        End If
        If radHybrid.Checked Or radMountain.Checked Or radRoad.Checked Then
            Order = bike + extras
        End If
        lblInfo.Text = CStr(Order) 'display order details in label
    End Sub

    Private Sub chkFrame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFrame.CheckedChanged
        Dim extras As String = ""
        If chkPaint.Checked = True Then
            extras &= "You would like to add custom paint. " 'addition to extras string
        End If
        If chkFrame.Checked = True Then
            extras &= "You would like a heavy duty frame. "
        End If
        If chkSeat.Checked = True Then
            extras &= "You would like a comfort seat. "
        End If
        Dim bike As String = ""
        If radRoad.Checked = True Then
            bike &= "You chose the road bike. " 'addition to bike string
        End If
        If radMountain.Checked = True Then
            bike &= "You chose the mountain bike. "
        End If
        If radHybrid.Checked = True Then
            bike &= "You chose the hybrid bike. "
        End If
        If radHybrid.Checked Or radMountain.Checked Or radRoad.Checked Then
            Order = bike + extras
        End If
        lblInfo.Text = CStr(Order) 'display order details in label
    End Sub

    Private Sub chkSeat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeat.CheckedChanged
        Dim extras As String = ""
        If chkPaint.Checked = True Then
            extras &= "You would like to add custom paint. " 'addition to extras string
        End If
        If chkFrame.Checked = True Then
            extras &= "You would like a heavy duty frame. "
        End If
        If chkSeat.Checked = True Then
            extras &= "You would like a comfort seat. "
        End If
        Dim bike As String = ""
        If radRoad.Checked = True Then
            bike &= "You chose the road bike. " 'addition to bike string
        End If
        If radMountain.Checked = True Then
            bike &= "You chose the mountain bike. "
        End If
        If radHybrid.Checked = True Then
            bike &= "You chose the hybrid bike. "
        End If
        If radHybrid.Checked Or radMountain.Checked Or radRoad.Checked Then
            Order = bike + extras
        End If
        lblInfo.Text = CStr(Order) 'display order details in label
    End Sub
End Class
