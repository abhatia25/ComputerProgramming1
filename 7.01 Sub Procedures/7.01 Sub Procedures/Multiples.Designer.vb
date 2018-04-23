<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiples
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
        Me.lblNumberPrompt = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnShowMultiples = New System.Windows.Forms.Button()
        Me.lblShowMultiples = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(210, 24)
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
        'lblNumberPrompt
        '
        Me.lblNumberPrompt.Location = New System.Drawing.Point(12, 40)
        Me.lblNumberPrompt.Name = "lblNumberPrompt"
        Me.lblNumberPrompt.Size = New System.Drawing.Size(84, 20)
        Me.lblNumberPrompt.TabIndex = 1
        Me.lblNumberPrompt.Text = "Enter a number"
        Me.lblNumberPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(102, 40)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(88, 20)
        Me.txtNum.TabIndex = 2
        '
        'btnShowMultiples
        '
        Me.btnShowMultiples.Location = New System.Drawing.Point(60, 66)
        Me.btnShowMultiples.Name = "btnShowMultiples"
        Me.btnShowMultiples.Size = New System.Drawing.Size(93, 23)
        Me.btnShowMultiples.TabIndex = 3
        Me.btnShowMultiples.Text = "Show Multiples"
        Me.btnShowMultiples.UseVisualStyleBackColor = True
        '
        'lblShowMultiples
        '
        Me.lblShowMultiples.Location = New System.Drawing.Point(12, 92)
        Me.lblShowMultiples.Name = "lblShowMultiples"
        Me.lblShowMultiples.Size = New System.Drawing.Size(186, 161)
        Me.lblShowMultiples.TabIndex = 4
        Me.lblShowMultiples.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMultiples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 262)
        Me.Controls.Add(Me.lblShowMultiples)
        Me.Controls.Add(Me.btnShowMultiples)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblNumberPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMultiples"
        Me.Text = "Multiples"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNumberPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents btnShowMultiples As System.Windows.Forms.Button
    Friend WithEvents lblShowMultiples As System.Windows.Forms.Label
End Class
