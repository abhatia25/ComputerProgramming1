<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInitials
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
        Me.lblNamePrompt = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnInitials = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
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
        'lblNamePrompt
        '
        Me.lblNamePrompt.Location = New System.Drawing.Point(12, 69)
        Me.lblNamePrompt.Name = "lblNamePrompt"
        Me.lblNamePrompt.Size = New System.Drawing.Size(100, 20)
        Me.lblNamePrompt.TabIndex = 1
        Me.lblNamePrompt.Text = "Your Name"
        Me.lblNamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(118, 69)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 190)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(268, 162)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInitials
        '
        Me.btnInitials.Location = New System.Drawing.Point(98, 120)
        Me.btnInitials.Name = "btnInitials"
        Me.btnInitials.Size = New System.Drawing.Size(75, 23)
        Me.btnInitials.TabIndex = 4
        Me.btnInitials.Text = "Initials"
        Me.btnInitials.UseVisualStyleBackColor = True
        '
        'frmInitials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 361)
        Me.Controls.Add(Me.btnInitials)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblNamePrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmInitials"
        Me.Text = "Initials"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNamePrompt As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btnInitials As System.Windows.Forms.Button
End Class
