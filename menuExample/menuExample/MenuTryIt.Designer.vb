<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuTryIt
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
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChgClr = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChgBlu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChgRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChgClr, Me.mnuExit})
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(65, 20)
        Me.mnuMenu.Text = "Program"
        '
        'mnuChgClr
        '
        Me.mnuChgClr.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChgBlu, Me.mnuChgRed})
        Me.mnuChgClr.Name = "mnuChgClr"
        Me.mnuChgClr.Size = New System.Drawing.Size(152, 22)
        Me.mnuChgClr.Text = "Change Color"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuChgBlu
        '
        Me.mnuChgBlu.Name = "mnuChgBlu"
        Me.mnuChgBlu.Size = New System.Drawing.Size(152, 22)
        Me.mnuChgBlu.Text = "Blue"
        '
        'mnuChgRed
        '
        Me.mnuChgRed.Name = "mnuChgRed"
        Me.mnuChgRed.Size = New System.Drawing.Size(152, 22)
        Me.mnuChgRed.Text = "Red"
        '
        'frmMenuTryIt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuTryIt"
        Me.Text = "Menu Try It!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChgClr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChgBlu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChgRed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem

End Class
