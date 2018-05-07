<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrawCards
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
        Me.btnDrawCards = New System.Windows.Forms.Button()
        Me.txtDraws = New System.Windows.Forms.TextBox()
        Me.lblDrawsPrompt = New System.Windows.Forms.Label()
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
        'btnDrawCards
        '
        Me.btnDrawCards.Location = New System.Drawing.Point(12, 28)
        Me.btnDrawCards.Name = "btnDrawCards"
        Me.btnDrawCards.Size = New System.Drawing.Size(260, 23)
        Me.btnDrawCards.TabIndex = 1
        Me.btnDrawCards.Text = "Draw Cards"
        Me.btnDrawCards.UseVisualStyleBackColor = True
        '
        'txtDraws
        '
        Me.txtDraws.Location = New System.Drawing.Point(193, 57)
        Me.txtDraws.Name = "txtDraws"
        Me.txtDraws.Size = New System.Drawing.Size(79, 20)
        Me.txtDraws.TabIndex = 2
        '
        'lblDrawsPrompt
        '
        Me.lblDrawsPrompt.Location = New System.Drawing.Point(9, 57)
        Me.lblDrawsPrompt.Name = "lblDrawsPrompt"
        Me.lblDrawsPrompt.Size = New System.Drawing.Size(175, 20)
        Me.lblDrawsPrompt.TabIndex = 3
        Me.lblDrawsPrompt.Text = "How many draws?"
        Me.lblDrawsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 86)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(260, 167)
        Me.lblAnswer.TabIndex = 4
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDrawCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblDrawsPrompt)
        Me.Controls.Add(Me.txtDraws)
        Me.Controls.Add(Me.btnDrawCards)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDrawCards"
        Me.Text = "Draw Cards"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDrawCards As System.Windows.Forms.Button
    Friend WithEvents txtDraws As System.Windows.Forms.TextBox
    Friend WithEvents lblDrawsPrompt As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
