<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShapes
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
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SquareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TriangleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem, Me.OptionsToolStripMenuItem})
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
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CircleToolStripMenuItem, Me.SquareToolStripMenuItem, Me.TriangleToolStripMenuItem, Me.StarToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'CircleToolStripMenuItem
        '
        Me.CircleToolStripMenuItem.Name = "CircleToolStripMenuItem"
        Me.CircleToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.CircleToolStripMenuItem.Text = "&Circle"
        '
        'SquareToolStripMenuItem
        '
        Me.SquareToolStripMenuItem.Name = "SquareToolStripMenuItem"
        Me.SquareToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SquareToolStripMenuItem.Text = "&Square"
        '
        'TriangleToolStripMenuItem
        '
        Me.TriangleToolStripMenuItem.Name = "TriangleToolStripMenuItem"
        Me.TriangleToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.TriangleToolStripMenuItem.Text = "&Triangle"
        '
        'StarToolStripMenuItem
        '
        Me.StarToolStripMenuItem.Name = "StarToolStripMenuItem"
        Me.StarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.StarToolStripMenuItem.Text = "S&tar"
        '
        'frmShapes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmShapes"
        Me.Text = "Shapes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CircleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SquareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TriangleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
