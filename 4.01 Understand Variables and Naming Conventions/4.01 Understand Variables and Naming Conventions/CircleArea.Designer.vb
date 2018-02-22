<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCircleArea
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
        Me.ReadyForSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblRadiusPrompt = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.lblCircleArea = New System.Windows.Forms.Label()
        Me.btnAreaShow = New System.Windows.Forms.Button()
        Me.ScopeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(294, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelloAgainToolStripMenuItem, Me.GradesToolStripMenuItem, Me.Pizza2ToolStripMenuItem, Me.ReadyForSchoolToolStripMenuItem, Me.ScopeToolStripMenuItem, Me.CountingToolStripMenuItem})
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
        'ReadyForSchoolToolStripMenuItem
        '
        Me.ReadyForSchoolToolStripMenuItem.Name = "ReadyForSchoolToolStripMenuItem"
        Me.ReadyForSchoolToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ReadyForSchoolToolStripMenuItem.Text = "&Ready for School"
        '
        'CountingToolStripMenuItem
        '
        Me.CountingToolStripMenuItem.Name = "CountingToolStripMenuItem"
        Me.CountingToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CountingToolStripMenuItem.Text = "Countin&g"
        '
        'lblRadiusPrompt
        '
        Me.lblRadiusPrompt.Location = New System.Drawing.Point(12, 54)
        Me.lblRadiusPrompt.Name = "lblRadiusPrompt"
        Me.lblRadiusPrompt.Size = New System.Drawing.Size(104, 23)
        Me.lblRadiusPrompt.TabIndex = 1
        Me.lblRadiusPrompt.Text = "Enter the radius"
        Me.lblRadiusPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(122, 56)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtRadius.TabIndex = 2
        '
        'lblCircleArea
        '
        Me.lblCircleArea.Location = New System.Drawing.Point(12, 91)
        Me.lblCircleArea.Name = "lblCircleArea"
        Me.lblCircleArea.Size = New System.Drawing.Size(270, 131)
        Me.lblCircleArea.TabIndex = 3
        Me.lblCircleArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAreaShow
        '
        Me.btnAreaShow.Location = New System.Drawing.Point(97, 296)
        Me.btnAreaShow.Name = "btnAreaShow"
        Me.btnAreaShow.Size = New System.Drawing.Size(99, 23)
        Me.btnAreaShow.TabIndex = 4
        Me.btnAreaShow.Text = "Show the Area"
        Me.btnAreaShow.UseVisualStyleBackColor = True
        '
        'ScopeToolStripMenuItem
        '
        Me.ScopeToolStripMenuItem.Name = "ScopeToolStripMenuItem"
        Me.ScopeToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ScopeToolStripMenuItem.Text = "&Scope"
        '
        'frmCircleArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 331)
        Me.Controls.Add(Me.btnAreaShow)
        Me.Controls.Add(Me.lblCircleArea)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.lblRadiusPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCircleArea"
        Me.Text = "CircleArea"
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
    Friend WithEvents ReadyForSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblRadiusPrompt As System.Windows.Forms.Label
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents lblCircleArea As System.Windows.Forms.Label
    Friend WithEvents btnAreaShow As System.Windows.Forms.Button
    Friend WithEvents ScopeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
