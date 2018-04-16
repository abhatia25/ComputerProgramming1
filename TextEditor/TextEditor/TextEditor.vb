'Aditya Bhatia
'Menu Strips Using MDI
'4/13/2018
Public Class frmTextEditor

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Static docNum As Integer = 0  'document number
        Dim doc As New NewDocument  'create new document window
        'Assign document parent
        doc.MdiParent = Me
        'create title bar that includes document number
        doc.Text = "New Document " & docNum
        'Show Window
        doc.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.ActiveMdiChild.Close() 'close current child window
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End 'end program
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal) 'sort child windows horizontally
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical) 'sort child windows vertically
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade) 'sort child windows cascading
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Dim activeDoc As NewDocument = Me.ActiveMdiChild
        activeDoc.txtDocument.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim activeDoc As NewDocument = Me.ActiveMdiChild
        activeDoc.txtDocument.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Dim activeDoc As NewDocument = Me.ActiveMdiChild
        activeDoc.txtDocument.Paste()
    End Sub

    Private Sub AlignmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlignmentToolStripMenuItem.Click
        Dim alignmentDB As New frmAlignmentDialogBox()
        Dim activeDoc As NewDocument = Me.ActiveMdiChild
        'Show dialog box
        alignmentDB.ShowDialog()
        'change alignment of text in active document
        If alignmentDB.DialogResult = Windows.Forms.DialogResult.OK Then
            If alignmentDB.radLeft.Checked Then
                activeDoc.txtDocument.TextAlign = HorizontalAlignment.Left
            ElseIf alignmentDB.radCenter.Checked Then
                activeDoc.txtDocument.TextAlign = HorizontalAlignment.Center
            Else
                activeDoc.txtDocument.TextAlign = HorizontalAlignment.Right
            End If
        End If
    End Sub
End Class
