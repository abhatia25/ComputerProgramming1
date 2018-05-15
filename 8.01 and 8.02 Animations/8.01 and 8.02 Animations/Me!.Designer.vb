<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMe
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
        Me.ShowMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picFrame = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem, Me.ShowMeToolStripMenuItem, Me.HideMeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(370, 24)
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
        'ShowMeToolStripMenuItem
        '
        Me.ShowMeToolStripMenuItem.Name = "ShowMeToolStripMenuItem"
        Me.ShowMeToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ShowMeToolStripMenuItem.Text = "&Show Me"
        '
        'HideMeToolStripMenuItem
        '
        Me.HideMeToolStripMenuItem.Name = "HideMeToolStripMenuItem"
        Me.HideMeToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.HideMeToolStripMenuItem.Text = "&Hide Me"
        '
        'picFrame
        '
        Me.picFrame.Location = New System.Drawing.Point(12, 27)
        Me.picFrame.Name = "picFrame"
        Me.picFrame.Size = New System.Drawing.Size(346, 342)
        Me.picFrame.TabIndex = 1
        Me.picFrame.TabStop = False
        '
        'frmMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 381)
        Me.Controls.Add(Me.picFrame)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMe"
        Me.Text = "Me!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideMeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picFrame As System.Windows.Forms.PictureBox
End Class
