<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewWord
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
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWordPrompt = New System.Windows.Forms.Label()
        Me.lblReplacePrompt = New System.Windows.Forms.Label()
        Me.lblNewPrompt = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'lblWordPrompt
        '
        Me.lblWordPrompt.AutoSize = True
        Me.lblWordPrompt.Location = New System.Drawing.Point(12, 35)
        Me.lblWordPrompt.Name = "lblWordPrompt"
        Me.lblWordPrompt.Size = New System.Drawing.Size(70, 13)
        Me.lblWordPrompt.TabIndex = 1
        Me.lblWordPrompt.Text = "Enter a word:"
        '
        'lblReplacePrompt
        '
        Me.lblReplacePrompt.AutoSize = True
        Me.lblReplacePrompt.Location = New System.Drawing.Point(12, 61)
        Me.lblReplacePrompt.Name = "lblReplacePrompt"
        Me.lblReplacePrompt.Size = New System.Drawing.Size(129, 13)
        Me.lblReplacePrompt.TabIndex = 2
        Me.lblReplacePrompt.Text = "Enter the letter to replace:"
        '
        'lblNewPrompt
        '
        Me.lblNewPrompt.AutoSize = True
        Me.lblNewPrompt.Location = New System.Drawing.Point(12, 86)
        Me.lblNewPrompt.Name = "lblNewPrompt"
        Me.lblNewPrompt.Size = New System.Drawing.Size(140, 13)
        Me.lblNewPrompt.TabIndex = 3
        Me.lblNewPrompt.Text = "Enter the replacement letter:"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(88, 32)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(184, 20)
        Me.txtWord.TabIndex = 4
        '
        'txtReplace
        '
        Me.txtReplace.Location = New System.Drawing.Point(147, 58)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(125, 20)
        Me.txtReplace.TabIndex = 5
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(158, 82)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.Size = New System.Drawing.Size(114, 20)
        Me.txtNew.TabIndex = 6
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(87, 116)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(98, 23)
        Me.btnReplace.TabIndex = 7
        Me.btnReplace.Text = "Replace Letter"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 141)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(260, 57)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmNewWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 213)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.txtReplace)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblNewPrompt)
        Me.Controls.Add(Me.lblReplacePrompt)
        Me.Controls.Add(Me.lblWordPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNewWord"
        Me.Text = "New Word"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblWordPrompt As System.Windows.Forms.Label
    Friend WithEvents lblReplacePrompt As System.Windows.Forms.Label
    Friend WithEvents lblNewPrompt As System.Windows.Forms.Label
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
