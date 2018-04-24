<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReasons
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
        Me.btnCompSci = New System.Windows.Forms.Button()
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
        'btnCompSci
        '
        Me.btnCompSci.Location = New System.Drawing.Point(12, 37)
        Me.btnCompSci.Name = "btnCompSci"
        Me.btnCompSci.Size = New System.Drawing.Size(260, 23)
        Me.btnCompSci.TabIndex = 1
        Me.btnCompSci.Text = "Why Take Computer Science?"
        Me.btnCompSci.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 63)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(260, 100)
        Me.lblAnswer.TabIndex = 2
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmReasons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 174)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCompSci)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReasons"
        Me.Text = "Reasons"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCompSci As Button
    Friend WithEvents lblAnswer As Label
End Class
