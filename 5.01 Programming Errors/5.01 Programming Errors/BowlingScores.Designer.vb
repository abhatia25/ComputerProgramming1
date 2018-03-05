<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBowlingScores
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
        Me.btnEnterScores = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(349, 24)
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
        'btnEnterScores
        '
        Me.btnEnterScores.Location = New System.Drawing.Point(133, 70)
        Me.btnEnterScores.Name = "btnEnterScores"
        Me.btnEnterScores.Size = New System.Drawing.Size(81, 36)
        Me.btnEnterScores.TabIndex = 3
        Me.btnEnterScores.Text = "Enter Scores"
        Me.btnEnterScores.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.Location = New System.Drawing.Point(133, 137)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(81, 36)
        Me.btnStatistics.TabIndex = 4
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 186)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(325, 168)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBowlingScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 363)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnEnterScores)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBowlingScores"
        Me.Text = "Bowling Scores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEnterScores As System.Windows.Forms.Button
    Friend WithEvents btnStatistics As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
