<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSlotMachine
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
        Me.lblTokensPrompt = New System.Windows.Forms.Label()
        Me.lblTokens = New System.Windows.Forms.Label()
        Me.lblWheel1 = New System.Windows.Forms.Label()
        Me.lblWheel2 = New System.Windows.Forms.Label()
        Me.lblWheel3 = New System.Windows.Forms.Label()
        Me.btnPull = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTokensPrompt
        '
        Me.lblTokensPrompt.Location = New System.Drawing.Point(98, 416)
        Me.lblTokensPrompt.Name = "lblTokensPrompt"
        Me.lblTokensPrompt.Size = New System.Drawing.Size(100, 23)
        Me.lblTokensPrompt.TabIndex = 0
        Me.lblTokensPrompt.Text = "Tokens:"
        Me.lblTokensPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTokens
        '
        Me.lblTokens.Location = New System.Drawing.Point(204, 416)
        Me.lblTokens.Name = "lblTokens"
        Me.lblTokens.Size = New System.Drawing.Size(100, 23)
        Me.lblTokens.TabIndex = 1
        Me.lblTokens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWheel1
        '
        Me.lblWheel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWheel1.Font = New System.Drawing.Font("Franklin Gothic Book", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel1.Location = New System.Drawing.Point(28, 61)
        Me.lblWheel1.Name = "lblWheel1"
        Me.lblWheel1.Size = New System.Drawing.Size(114, 236)
        Me.lblWheel1.TabIndex = 2
        Me.lblWheel1.Text = "0"
        Me.lblWheel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWheel2
        '
        Me.lblWheel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWheel2.Font = New System.Drawing.Font("Franklin Gothic Book", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel2.Location = New System.Drawing.Point(148, 61)
        Me.lblWheel2.Name = "lblWheel2"
        Me.lblWheel2.Size = New System.Drawing.Size(114, 236)
        Me.lblWheel2.TabIndex = 3
        Me.lblWheel2.Text = "0"
        Me.lblWheel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWheel3
        '
        Me.lblWheel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWheel3.Font = New System.Drawing.Font("Franklin Gothic Book", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWheel3.Location = New System.Drawing.Point(268, 61)
        Me.lblWheel3.Name = "lblWheel3"
        Me.lblWheel3.Size = New System.Drawing.Size(114, 236)
        Me.lblWheel3.TabIndex = 4
        Me.lblWheel3.Text = "0"
        Me.lblWheel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPull
        '
        Me.btnPull.Location = New System.Drawing.Point(156, 356)
        Me.btnPull.Name = "btnPull"
        Me.btnPull.Size = New System.Drawing.Size(106, 23)
        Me.btnPull.TabIndex = 5
        Me.btnPull.Text = "Pull"
        Me.btnPull.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(425, 24)
        Me.MenuStrip1.TabIndex = 6
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
        'frmSlotMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 448)
        Me.Controls.Add(Me.btnPull)
        Me.Controls.Add(Me.lblWheel3)
        Me.Controls.Add(Me.lblWheel2)
        Me.Controls.Add(Me.lblWheel1)
        Me.Controls.Add(Me.lblTokens)
        Me.Controls.Add(Me.lblTokensPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSlotMachine"
        Me.Text = "Slot Machine"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTokensPrompt As System.Windows.Forms.Label
    Friend WithEvents lblTokens As System.Windows.Forms.Label
    Friend WithEvents lblWheel1 As System.Windows.Forms.Label
    Friend WithEvents lblWheel2 As System.Windows.Forms.Label
    Friend WithEvents lblWheel3 As System.Windows.Forms.Label
    Friend WithEvents btnPull As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
