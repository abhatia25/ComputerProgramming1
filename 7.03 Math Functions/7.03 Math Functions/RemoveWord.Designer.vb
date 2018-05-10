<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemoveWord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStringPrompt = New System.Windows.Forms.Label()
        Me.lblWordPrompt = New System.Windows.Forms.Label()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExityToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExityToolStripMenuItem
        '
        Me.ExityToolStripMenuItem.Name = "ExityToolStripMenuItem"
        Me.ExityToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExityToolStripMenuItem.Text = "E&xit"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'lblStringPrompt
        '
        Me.lblStringPrompt.AutoSize = True
        Me.lblStringPrompt.Location = New System.Drawing.Point(12, 33)
        Me.lblStringPrompt.Name = "lblStringPrompt"
        Me.lblStringPrompt.Size = New System.Drawing.Size(72, 13)
        Me.lblStringPrompt.TabIndex = 1
        Me.lblStringPrompt.Text = "Enter a string:"
        '
        'lblWordPrompt
        '
        Me.lblWordPrompt.AutoSize = True
        Me.lblWordPrompt.Location = New System.Drawing.Point(12, 59)
        Me.lblWordPrompt.Name = "lblWordPrompt"
        Me.lblWordPrompt.Size = New System.Drawing.Size(111, 13)
        Me.lblWordPrompt.TabIndex = 2
        Me.lblWordPrompt.Text = "Enter word to remove:"
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(90, 30)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(182, 20)
        Me.txtString.TabIndex = 3
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(129, 56)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(143, 20)
        Me.txtWord.TabIndex = 4
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 86)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(260, 58)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(106, 156)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'frmRemoveWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 191)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.lblWordPrompt)
        Me.Controls.Add(Me.lblStringPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRemoveWord"
        Me.Text = "Remove Word"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStringPrompt As System.Windows.Forms.Label
    Friend WithEvents lblWordPrompt As System.Windows.Forms.Label
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
End Class
