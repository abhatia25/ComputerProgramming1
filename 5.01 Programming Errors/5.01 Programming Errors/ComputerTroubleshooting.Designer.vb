<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputerTroubleshooting
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
        Me.NextProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBeepPrompt = New System.Windows.Forms.Label()
        Me.txtBeep = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSpin = New System.Windows.Forms.TextBox()
        Me.btnWhatToDo = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(267, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'lblBeepPrompt
        '
        Me.lblBeepPrompt.Location = New System.Drawing.Point(12, 58)
        Me.lblBeepPrompt.Name = "lblBeepPrompt"
        Me.lblBeepPrompt.Size = New System.Drawing.Size(100, 20)
        Me.lblBeepPrompt.TabIndex = 1
        Me.lblBeepPrompt.Text = "Computer Beeps?"
        Me.lblBeepPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBeep
        '
        Me.txtBeep.Location = New System.Drawing.Point(118, 58)
        Me.txtBeep.Name = "txtBeep"
        Me.txtBeep.Size = New System.Drawing.Size(100, 20)
        Me.txtBeep.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hard Drive Spins?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSpin
        '
        Me.txtSpin.Location = New System.Drawing.Point(118, 97)
        Me.txtSpin.Name = "txtSpin"
        Me.txtSpin.Size = New System.Drawing.Size(100, 20)
        Me.txtSpin.TabIndex = 4
        '
        'btnWhatToDo
        '
        Me.btnWhatToDo.Location = New System.Drawing.Point(73, 133)
        Me.btnWhatToDo.Name = "btnWhatToDo"
        Me.btnWhatToDo.Size = New System.Drawing.Size(86, 39)
        Me.btnWhatToDo.TabIndex = 5
        Me.btnWhatToDo.Text = "What to Do"
        Me.btnWhatToDo.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 187)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(243, 198)
        Me.lblAnswer.TabIndex = 6
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmComputerTroubleshooting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 394)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnWhatToDo)
        Me.Controls.Add(Me.txtSpin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBeep)
        Me.Controls.Add(Me.lblBeepPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmComputerTroubleshooting"
        Me.Text = "ComputerTroubleshooting"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblBeepPrompt As System.Windows.Forms.Label
    Friend WithEvents txtBeep As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSpin As System.Windows.Forms.TextBox
    Friend WithEvents btnWhatToDo As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
