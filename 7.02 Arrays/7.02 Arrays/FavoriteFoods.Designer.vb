<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFavoriteFoods
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
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstFavFoods = New System.Windows.Forms.ListBox()
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
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 27)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(260, 23)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Enter your favorite foods"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 56)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(260, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display your favorite foods"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstFavFoods
        '
        Me.lstFavFoods.FormattingEnabled = True
        Me.lstFavFoods.Location = New System.Drawing.Point(12, 85)
        Me.lstFavFoods.Name = "lstFavFoods"
        Me.lstFavFoods.Size = New System.Drawing.Size(260, 121)
        Me.lstFavFoods.TabIndex = 3
        '
        'frmFavoriteFoods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 221)
        Me.Controls.Add(Me.lstFavFoods)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFavoriteFoods"
        Me.Text = "My Favorite Foods"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnInput As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents lstFavFoods As ListBox
End Class
