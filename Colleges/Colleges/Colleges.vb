'Aditya Bhatia
'Colleges
'2/23/2018
Public Class frmColleges
    Dim collegeSelected As String = ""
    Private Sub radGeorgiaTech_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGeorgiaTech.CheckedChanged
        collegeSelected = ""
        lblCollegeInfo.Text = ""
        If radGeorgiaTech.Checked Then
            collegeSelected = "Technology Square" & vbCrLf & "Bobby Dodd Stadium" & vbCrLf & "Scheller College of Business"
            lblCollegeInfo.Text = "Atlanta, Georgia" & vbCrLf & collegeSelected
            picMascot.Image = My.Resources.GeorgiaTech
        End If
    End Sub

    Private Sub radStanford_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radStanford.CheckedChanged
        collegeSelected = ""
        lblCollegeInfo.Text = ""
        If radStanford.Checked Then
            collegeSelected = "Main Quad" & vbCrLf & "Hoover Tower" & vbCrLf & "Stanford Memorial Church"
            lblCollegeInfo.Text = "Stanford, California" & vbCrLf & collegeSelected
            picMascot.Image = My.Resources.Stanford_Tree_Logo_Mascot_Monday
        End If
    End Sub

    Private Sub radMichigan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMichigan.CheckedChanged
        collegeSelected = ""
        lblCollegeInfo.Text = ""
        If radMichigan.Checked Then
            collegeSelected = "Michigan Stadium" & vbCrLf & "U-M Golf Course" & vbCrLf & "Gerald R. Ford Presidential Library"
            lblCollegeInfo.Text = "Ann Arbor, Michigan" & vbCrLf & collegeSelected
            picMascot.Image = My.Resources.university_of_michigan_clipart_13
        End If
    End Sub

    Private Sub radTexas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radTexas.CheckedChanged
        collegeSelected = ""
        lblCollegeInfo.Text = ""
        If radTexas.Checked Then
            collegeSelected = "Beaux-Arts Main Building" & vbCrLf & "Harry Ransom Humanities Research Center" & vbCrLf & "Norman Hackerman Building"
            lblCollegeInfo.Text = "Austin, Texas" & vbCrLf & collegeSelected
            picMascot.Image = My.Resources.texas
        End If
    End Sub

    Private Sub radMIT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMIT.CheckedChanged
        collegeSelected = ""
        lblCollegeInfo.Text = ""
        If radMIT.Checked Then
            collegeSelected = "Massachusetts Avenue" & vbCrLf & "MIT Museum" & vbCrLf & "Kendall Square"
            lblCollegeInfo.Text = "Cambridge, Massachusetts" & vbCrLf & collegeSelected
            picMascot.Image = My.Resources.mit
        End If
    End Sub

    Private Sub radUPenn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radUPenn.CheckedChanged
        collegeSelected = ""
        lblCollegeInfo.Text = ""
        If radUPenn.Checked Then
            collegeSelected = "University City" & vbCrLf & "Schuylkill River" & vbCrLf & "Franklin Field"
            lblCollegeInfo.Text = "Philadelphia, Pennsylvania" & vbCrLf & collegeSelected
            picMascot.Image = My.Resources.upenn
        End If
    End Sub

    Private Sub radCalTech_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCalTech.CheckedChanged
        collegeSelected = ""
        lblCollegeInfo.Text = ""
        If radCalTech.Checked Then
            collegeSelected = "Old Town Pasadena" & vbCrLf & "Pasadena Playhouse District" & vbCrLf & "Beckman Auditorium"
            lblCollegeInfo.Text = "Pasadena, California" & vbCrLf & collegeSelected
            picMascot.Image = My.Resources.caltech
        End If
    End Sub

    Private Sub radCarnegieMellon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCarnegieMellon.CheckedChanged
        collegeSelected = ""
        lblCollegeInfo.Text = ""
        If radCarnegieMellon.Checked Then
            collegeSelected = "Cohon University Center" & vbCrLf & "The Cut" & vbCrLf & "Walking to the Sky"
            lblCollegeInfo.Text = "Pittsburgh, Pennsylvania" & vbCrLf & collegeSelected
            picMascot.Image = My.Resources.carnegiemellon
        End If
    End Sub
End Class
