Public Class BandInformation
    Private Sub radBlackEyedPeas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBlackEyedPeas.CheckedChanged
        Me.lblBandMember1.Text = "Will.I.Am. - Vocalist / Various Instruments"
        Me.lblBandMember2.Text = "Apl.de.Ap. - MC"
        Me.lblBandMember3.Text = "Taboo - MC"
        Me.lblBandMember4.Text = "Fergie - Vocalist"
    End Sub

    Private Sub radFooFighters_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFooFighters.CheckedChanged
        Me.lblBandMember1.Text = "Dave Grohl - Vocals / Guitar "
        Me.lblBandMember2.Text = "Taylor Hawkins - Drums / Percussion"
        Me.lblBandMember3.Text = "Nate Mendel - Bass Guitar"
        Me.lblBandMember4.Text = "Chris Shiflett - Guitar / Vocals"
    End Sub

    Private Sub radGreenDay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGreenDay.CheckedChanged
        Me.lblBandMember1.Text = "Billie Joe Armstrong - Guitar / Vocals"
        Me.lblBandMember2.Text = "Mike Dirnt - Bass / Backup Vocals"
        Me.lblBandMember3.Text = "Tre Cool - Drums / Backup Vocals"
        Me.lblBandMember4.Text = "Jason White - Guitar / Backup Vocals"
    End Sub

    Private Sub radU2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radU2.CheckedChanged
        Me.lblBandMember1.Text = "The Edge – Lead Guitar"
        Me.lblBandMember2.Text = "Bono - Lead Singer"
        Me.lblBandMember3.Text = "Adam Clayton - Bass Guitar"
        Me.lblBandMember4.Text = "Larry Mullen Jr. - Drummer"
    End Sub

    Private Sub radGooGooDolls_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGooGooDolls.CheckedChanged
        Me.lblBandMember1.Text = "Johnny Rzeznik - Vocals / Guitar"
        Me.lblBandMember2.Text = "Robby Takac - Vocals / Bass"
        Me.lblBandMember3.Text = "Mike Malinin - Drums"
        Me.lblBandMember4.Text = ""
    End Sub

    Private Sub radBeatles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBeatles.CheckedChanged
        Me.lblBandMember1.Text = "John Lennon - Guitar"
        Me.lblBandMember2.Text = "Paul McCartney - Bass"
        Me.lblBandMember3.Text = "Ringo Starr - Drums"
        Me.lblBandMember4.Text = "George Harrison - Lead Guitar"
    End Sub
End Class