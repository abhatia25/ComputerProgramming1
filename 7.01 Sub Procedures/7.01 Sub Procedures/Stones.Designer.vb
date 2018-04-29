<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStones
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
        Me.lblStonesLeft = New System.Windows.Forms.Label()
        Me.lblPlayerStonesPrompt = New System.Windows.Forms.Label()
        Me.txtPlayerStones = New System.Windows.Forms.TextBox()
        Me.btnTakeStones = New System.Windows.Forms.Button()
        Me.lblComputerStones = New System.Windows.Forms.Label()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(360, 24)
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
        'lblStonesLeft
        '
        Me.lblStonesLeft.Location = New System.Drawing.Point(12, 35)
        Me.lblStonesLeft.Name = "lblStonesLeft"
        Me.lblStonesLeft.Size = New System.Drawing.Size(336, 28)
        Me.lblStonesLeft.TabIndex = 1
        Me.lblStonesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerStonesPrompt
        '
        Me.lblPlayerStonesPrompt.AutoSize = True
        Me.lblPlayerStonesPrompt.Location = New System.Drawing.Point(12, 75)
        Me.lblPlayerStonesPrompt.Name = "lblPlayerStonesPrompt"
        Me.lblPlayerStonesPrompt.Size = New System.Drawing.Size(157, 13)
        Me.lblPlayerStonesPrompt.TabIndex = 2
        Me.lblPlayerStonesPrompt.Text = "Number of stones to take away:"
        '
        'txtPlayerStones
        '
        Me.txtPlayerStones.Location = New System.Drawing.Point(172, 72)
        Me.txtPlayerStones.Name = "txtPlayerStones"
        Me.txtPlayerStones.Size = New System.Drawing.Size(71, 20)
        Me.txtPlayerStones.TabIndex = 3
        '
        'btnTakeStones
        '
        Me.btnTakeStones.Location = New System.Drawing.Point(268, 70)
        Me.btnTakeStones.Name = "btnTakeStones"
        Me.btnTakeStones.Size = New System.Drawing.Size(87, 23)
        Me.btnTakeStones.TabIndex = 4
        Me.btnTakeStones.Text = "Take Stones"
        Me.btnTakeStones.UseVisualStyleBackColor = True
        '
        'lblComputerStones
        '
        Me.lblComputerStones.Location = New System.Drawing.Point(12, 117)
        Me.lblComputerStones.Name = "lblComputerStones"
        Me.lblComputerStones.Size = New System.Drawing.Size(231, 23)
        Me.lblComputerStones.TabIndex = 5
        Me.lblComputerStones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(268, 117)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(87, 23)
        Me.btnNewGame.TabIndex = 6
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'frmStones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 166)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.lblComputerStones)
        Me.Controls.Add(Me.btnTakeStones)
        Me.Controls.Add(Me.txtPlayerStones)
        Me.Controls.Add(Me.lblPlayerStonesPrompt)
        Me.Controls.Add(Me.lblStonesLeft)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmStones"
        Me.Text = "Stones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblStonesLeft As Label
    Friend WithEvents lblPlayerStonesPrompt As Label
    Friend WithEvents txtPlayerStones As TextBox
    Friend WithEvents btnTakeStones As Button
    Friend WithEvents lblComputerStones As Label
    Friend WithEvents btnNewGame As Button
End Class
