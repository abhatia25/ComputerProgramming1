<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuessingGame
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
        Me.lblGuessPrompt = New System.Windows.Forms.Label()
        Me.txtPlayerGuess = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCheckGuess = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGuessPrompt
        '
        Me.lblGuessPrompt.Location = New System.Drawing.Point(26, 50)
        Me.lblGuessPrompt.Name = "lblGuessPrompt"
        Me.lblGuessPrompt.Size = New System.Drawing.Size(117, 20)
        Me.lblGuessPrompt.TabIndex = 0
        Me.lblGuessPrompt.Text = "Please enter a number"
        Me.lblGuessPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPlayerGuess
        '
        Me.txtPlayerGuess.Location = New System.Drawing.Point(149, 50)
        Me.txtPlayerGuess.Name = "txtPlayerGuess"
        Me.txtPlayerGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayerGuess.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(285, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'NextProgramToolStripMenuItem
        '
        Me.NextProgramToolStripMenuItem.Name = "NextProgramToolStripMenuItem"
        Me.NextProgramToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.NextProgramToolStripMenuItem.Text = "&Next Program"
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(12, 132)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(269, 110)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheckGuess
        '
        Me.btnCheckGuess.Location = New System.Drawing.Point(107, 88)
        Me.btnCheckGuess.Name = "btnCheckGuess"
        Me.btnCheckGuess.Size = New System.Drawing.Size(83, 41)
        Me.btnCheckGuess.TabIndex = 4
        Me.btnCheckGuess.Text = "Check Guess"
        Me.btnCheckGuess.UseVisualStyleBackColor = True
        '
        'frmGuessingGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 251)
        Me.Controls.Add(Me.btnCheckGuess)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtPlayerGuess)
        Me.Controls.Add(Me.lblGuessPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGuessingGame"
        Me.Text = "Guessing Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGuessPrompt As System.Windows.Forms.Label
    Friend WithEvents txtPlayerGuess As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnCheckGuess As System.Windows.Forms.Button

End Class
