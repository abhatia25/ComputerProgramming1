<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScope
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
        Me.CountingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblScopeAnswer = New System.Windows.Forms.Label()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btnGlobal = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(235, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelloAgainToolStripMenuItem, Me.GradesToolStripMenuItem, Me.Pizza2ToolStripMenuItem, Me.CircleAreaToolStripMenuItem, Me.ReadyForSchoolToolStripMenuItem, Me.CountingToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'HelloAgainToolStripMenuItem
        '
        Me.HelloAgainToolStripMenuItem.Name = "HelloAgainToolStripMenuItem"
        Me.HelloAgainToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.HelloAgainToolStripMenuItem.Text = "&Hello Again"
        '
        'GradesToolStripMenuItem
        '
        Me.GradesToolStripMenuItem.Name = "GradesToolStripMenuItem"
        Me.GradesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.GradesToolStripMenuItem.Text = "&Grades"
        '
        'Pizza2ToolStripMenuItem
        '
        Me.Pizza2ToolStripMenuItem.Name = "Pizza2ToolStripMenuItem"
        Me.Pizza2ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.Pizza2ToolStripMenuItem.Text = "&Pizza2"
        '
        'CircleAreaToolStripMenuItem
        '
        Me.CircleAreaToolStripMenuItem.Name = "CircleAreaToolStripMenuItem"
        Me.CircleAreaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CircleAreaToolStripMenuItem.Text = "&Circle Area"
        '
        'ReadyForSchoolToolStripMenuItem
        '
        Me.ReadyForSchoolToolStripMenuItem.Name = "ReadyForSchoolToolStripMenuItem"
        Me.ReadyForSchoolToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ReadyForSchoolToolStripMenuItem.Text = "&Ready For School"
        '
        'CountingToolStripMenuItem
        '
        Me.CountingToolStripMenuItem.Name = "CountingToolStripMenuItem"
        Me.CountingToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CountingToolStripMenuItem.Text = "Countin&g"
        '
        'lblScopeAnswer
        '
        Me.lblScopeAnswer.Location = New System.Drawing.Point(12, 35)
        Me.lblScopeAnswer.Name = "lblScopeAnswer"
        Me.lblScopeAnswer.Size = New System.Drawing.Size(211, 133)
        Me.lblScopeAnswer.TabIndex = 1
        Me.lblScopeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLocal
        '
        Me.btnLocal.Location = New System.Drawing.Point(78, 171)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(75, 23)
        Me.btnLocal.TabIndex = 2
        Me.btnLocal.Text = "Local"
        Me.btnLocal.UseVisualStyleBackColor = True
        '
        'btnGlobal
        '
        Me.btnGlobal.Location = New System.Drawing.Point(78, 224)
        Me.btnGlobal.Name = "btnGlobal"
        Me.btnGlobal.Size = New System.Drawing.Size(75, 23)
        Me.btnGlobal.TabIndex = 3
        Me.btnGlobal.Text = "Global"
        Me.btnGlobal.UseVisualStyleBackColor = True
        '
        'frmScope
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 276)
        Me.Controls.Add(Me.btnGlobal)
        Me.Controls.Add(Me.btnLocal)
        Me.Controls.Add(Me.lblScopeAnswer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmScope"
        Me.Text = "Scope"
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
    Friend WithEvents CountingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblScopeAnswer As System.Windows.Forms.Label
    Friend WithEvents btnLocal As System.Windows.Forms.Button
    Friend WithEvents btnGlobal As System.Windows.Forms.Button
End Class
