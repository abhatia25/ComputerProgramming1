<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCounting
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
        Me.OtherProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelloAgainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pizza2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircleAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadyForSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScopeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStatic = New System.Windows.Forms.Button()
        Me.btnDim = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(437, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OtherProgramsToolStripMenuItem
        '
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelloAgainToolStripMenuItem, Me.GradesToolStripMenuItem, Me.Pizza2ToolStripMenuItem, Me.CircleAreaToolStripMenuItem, Me.ReadyForSchoolToolStripMenuItem, Me.ScopeToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'HelloAgainToolStripMenuItem
        '
        Me.HelloAgainToolStripMenuItem.Name = "HelloAgainToolStripMenuItem"
        Me.HelloAgainToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.HelloAgainToolStripMenuItem.Text = "&Hello Again"
        '
        'GradesToolStripMenuItem
        '
        Me.GradesToolStripMenuItem.Name = "GradesToolStripMenuItem"
        Me.GradesToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.GradesToolStripMenuItem.Text = "&Grades"
        '
        'Pizza2ToolStripMenuItem
        '
        Me.Pizza2ToolStripMenuItem.Name = "Pizza2ToolStripMenuItem"
        Me.Pizza2ToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.Pizza2ToolStripMenuItem.Text = "&Pizza2"
        '
        'CircleAreaToolStripMenuItem
        '
        Me.CircleAreaToolStripMenuItem.Name = "CircleAreaToolStripMenuItem"
        Me.CircleAreaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CircleAreaToolStripMenuItem.Text = "&Circle Area"
        '
        'ReadyForSchoolToolStripMenuItem
        '
        Me.ReadyForSchoolToolStripMenuItem.Name = "ReadyForSchoolToolStripMenuItem"
        Me.ReadyForSchoolToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ReadyForSchoolToolStripMenuItem.Text = "&Ready for School"
        '
        'ScopeToolStripMenuItem
        '
        Me.ScopeToolStripMenuItem.Name = "ScopeToolStripMenuItem"
        Me.ScopeToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ScopeToolStripMenuItem.Text = "&Scope"
        '
        'btnStatic
        '
        Me.btnStatic.Location = New System.Drawing.Point(297, 86)
        Me.btnStatic.Name = "btnStatic"
        Me.btnStatic.Size = New System.Drawing.Size(128, 23)
        Me.btnStatic.TabIndex = 1
        Me.btnStatic.Text = "Static Variable"
        Me.btnStatic.UseVisualStyleBackColor = True
        '
        'btnDim
        '
        Me.btnDim.Location = New System.Drawing.Point(12, 86)
        Me.btnDim.Name = "btnDim"
        Me.btnDim.Size = New System.Drawing.Size(128, 23)
        Me.btnDim.TabIndex = 2
        Me.btnDim.Text = "Dim Variable"
        Me.btnDim.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 112)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(413, 116)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 237)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnDim)
        Me.Controls.Add(Me.btnStatic)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCounting"
        Me.Text = "Counting"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelloAgainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pizza2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CircleAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReadyForSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScopeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStatic As System.Windows.Forms.Button
    Friend WithEvents btnDim As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
