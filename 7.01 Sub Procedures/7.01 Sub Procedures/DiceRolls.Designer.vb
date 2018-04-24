<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiceRolls
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
        Me.lblRollsPrompt = New System.Windows.Forms.Label()
        Me.txtRolls = New System.Windows.Forms.TextBox()
        Me.btnRollDice = New System.Windows.Forms.Button()
        Me.lstRollsOutcomes = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(220, 24)
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
        'lblRollsPrompt
        '
        Me.lblRollsPrompt.Location = New System.Drawing.Point(12, 37)
        Me.lblRollsPrompt.Name = "lblRollsPrompt"
        Me.lblRollsPrompt.Size = New System.Drawing.Size(84, 23)
        Me.lblRollsPrompt.TabIndex = 1
        Me.lblRollsPrompt.Text = "Number of rolls:"
        Me.lblRollsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRolls
        '
        Me.txtRolls.Location = New System.Drawing.Point(102, 40)
        Me.txtRolls.Name = "txtRolls"
        Me.txtRolls.Size = New System.Drawing.Size(100, 20)
        Me.txtRolls.TabIndex = 2
        '
        'btnRollDice
        '
        Me.btnRollDice.Location = New System.Drawing.Point(67, 66)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(75, 23)
        Me.btnRollDice.TabIndex = 3
        Me.btnRollDice.Text = "Roll Dice"
        Me.btnRollDice.UseVisualStyleBackColor = True
        '
        'lstRollsOutcomes
        '
        Me.lstRollsOutcomes.FormattingEnabled = True
        Me.lstRollsOutcomes.Location = New System.Drawing.Point(12, 95)
        Me.lstRollsOutcomes.Name = "lstRollsOutcomes"
        Me.lstRollsOutcomes.Size = New System.Drawing.Size(196, 160)
        Me.lstRollsOutcomes.TabIndex = 4
        '
        'frmDiceRolls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 262)
        Me.Controls.Add(Me.lstRollsOutcomes)
        Me.Controls.Add(Me.btnRollDice)
        Me.Controls.Add(Me.txtRolls)
        Me.Controls.Add(Me.lblRollsPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDiceRolls"
        Me.Text = "Dice Rolls"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblRollsPrompt As System.Windows.Forms.Label
    Friend WithEvents txtRolls As System.Windows.Forms.TextBox
    Friend WithEvents btnRollDice As System.Windows.Forms.Button
    Friend WithEvents lstRollsOutcomes As System.Windows.Forms.ListBox
End Class
