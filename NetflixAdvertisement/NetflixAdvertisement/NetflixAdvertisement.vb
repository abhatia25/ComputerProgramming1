'Aditya Bhatia
'Netflix Advertisement
'2/14/2018
Public Class frmNetflixAdvertisement
    Dim endMessage As String 'declares that endMessage is a string
    Dim clicks As String
    Dim feedback As String
    Private Sub btnShow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow1.Click
        lblShowInfo.Text = "Drama. When a young boy disappears, his mother, a police chief, and his friends, must confront terrifying forces in order to get him back." 'display show description in lblShowInfo
        clicks &= "Stranger Things, " 'add show title to clicks string
    End Sub

    Private Sub btnShow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow2.Click
        lblShowInfo.Text = "Crime. A family saga with a supernatural twist, set in a German town, where the disappearance of two young children exposes the relationships among four families."
        clicks &= "Dark, "
    End Sub

    Private Sub btnShow3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow3.Click
        lblShowInfo.Text = "Drama. A Congressman works with his equally conniving wife to exact revenge on the people who betrayed him."
        clicks &= "House of Cards, "
    End Sub

    Private Sub btnShow4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow4.Click
        lblShowInfo.Text = "Drama. Follows the political rivalries and romance of Queen Elizabeth II's reign and the events that shaped the second half of the 20th century."
        clicks &= "The Crown, "
    End Sub

    Private Sub btnShow5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow5.Click
        lblShowInfo.Text = "Comedy. The personal and professional life of Dev, a 30-year-old actor in New York."
        clicks &= "Master of None, "
    End Sub

    Private Sub btnShow6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow6.Click
        lblShowInfo.Text = "Drama. Frank Griffin, an outlaw terrorizing the 1880s American West, hunts down Roy Goode, his partner turned enemy. Roy hides out at a ranch as Frank's chase leads him to La Belle, New Mexico - a town mysteriously made up almost entirely of women."
        clicks &= "Godless, "
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If chkYes.Checked Or chkNo.Checked Then
            endMessage = "Enjoy " + clicks + feedback 'if feedback is given then display enjoy clicked shows and feedback message
        Else
            endMessage = "Enjoy" + clicks 'if no feedback is given then display enjoy clicked shows
        End If
        MessageBox.Show(CStr(endMessage)) 'show endMessage string in a Message Box with appropriate strings
        End 'end program
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        lblShowInfo.Text = "" 'clear label
        endMessage = "" 'clear appropriate string
        clicks = ""
        feedback = ""
        chkNo.Checked = False 'uncheck checkbox
        chkYes.Checked = False
        MessageBox.Show("Cleared") 'show "cleared" message box
    End Sub

    Private Sub chkYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkYes.CheckedChanged
        If chkYes.Checked Then
            feedback &= "Thanks for the positive feedback! " 'if positive feedback is given, add message to string
        End If
    End Sub

    Private Sub chkNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNo.CheckedChanged
        If chkNo.Checked Then
            feedback &= "Thanks for the  feedback! " 'if negative feedback is given, add message to string
        End If
    End Sub
End Class