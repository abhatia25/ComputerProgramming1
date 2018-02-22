<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrades
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
        Me.Pizza2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircleAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadyForSchoolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScopeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblQ1Prompt = New System.Windows.Forms.Label()
        Me.lblGrades = New System.Windows.Forms.Label()
        Me.lblFEGrade = New System.Windows.Forms.Label()
        Me.lblQ2Prompt = New System.Windows.Forms.Label()
        Me.txtQ1Grade = New System.Windows.Forms.TextBox()
        Me.txtQ2Grade = New System.Windows.Forms.TextBox()
        Me.txtFEGrade = New System.Windows.Forms.TextBox()
        Me.btnShowGrade = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelloAgainToolStripMenuItem, Me.Pizza2ToolStripMenuItem, Me.CircleAreaToolStripMenuItem, Me.ReadyForSchoolToolStripMenuItem, Me.ScopeToolStripMenuItem, Me.CountingToolStripMenuItem})
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
        'CountingToolStripMenuItem
        '
        Me.CountingToolStripMenuItem.Name = "CountingToolStripMenuItem"
        Me.CountingToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CountingToolStripMenuItem.Text = "Countin&g"
        '
        'lblQ1Prompt
        '
        Me.lblQ1Prompt.Location = New System.Drawing.Point(12, 43)
        Me.lblQ1Prompt.Name = "lblQ1Prompt"
        Me.lblQ1Prompt.Size = New System.Drawing.Size(189, 23)
        Me.lblQ1Prompt.TabIndex = 1
        Me.lblQ1Prompt.Text = "Enter your Quarter 1 Average:"
        Me.lblQ1Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrades
        '
        Me.lblGrades.Location = New System.Drawing.Point(12, 127)
        Me.lblGrades.Name = "lblGrades"
        Me.lblGrades.Size = New System.Drawing.Size(398, 91)
        Me.lblGrades.TabIndex = 4
        Me.lblGrades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFEGrade
        '
        Me.lblFEGrade.Location = New System.Drawing.Point(12, 89)
        Me.lblFEGrade.Name = "lblFEGrade"
        Me.lblFEGrade.Size = New System.Drawing.Size(189, 23)
        Me.lblFEGrade.TabIndex = 5
        Me.lblFEGrade.Text = "Enter your Final Exam Grade:"
        Me.lblFEGrade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQ2Prompt
        '
        Me.lblQ2Prompt.Location = New System.Drawing.Point(12, 66)
        Me.lblQ2Prompt.Name = "lblQ2Prompt"
        Me.lblQ2Prompt.Size = New System.Drawing.Size(189, 23)
        Me.lblQ2Prompt.TabIndex = 6
        Me.lblQ2Prompt.Text = "Enter your Quarter 2 Average:"
        Me.lblQ2Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQ1Grade
        '
        Me.txtQ1Grade.Location = New System.Drawing.Point(207, 46)
        Me.txtQ1Grade.Name = "txtQ1Grade"
        Me.txtQ1Grade.Size = New System.Drawing.Size(100, 20)
        Me.txtQ1Grade.TabIndex = 7
        '
        'txtQ2Grade
        '
        Me.txtQ2Grade.Location = New System.Drawing.Point(207, 69)
        Me.txtQ2Grade.Name = "txtQ2Grade"
        Me.txtQ2Grade.Size = New System.Drawing.Size(100, 20)
        Me.txtQ2Grade.TabIndex = 8
        '
        'txtFEGrade
        '
        Me.txtFEGrade.Location = New System.Drawing.Point(207, 92)
        Me.txtFEGrade.Name = "txtFEGrade"
        Me.txtFEGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtFEGrade.TabIndex = 9
        '
        'btnShowGrade
        '
        Me.btnShowGrade.Location = New System.Drawing.Point(169, 266)
        Me.btnShowGrade.Name = "btnShowGrade"
        Me.btnShowGrade.Size = New System.Drawing.Size(75, 23)
        Me.btnShowGrade.TabIndex = 10
        Me.btnShowGrade.Text = "Show Grade"
        Me.btnShowGrade.UseVisualStyleBackColor = True
        '
        'frmGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 314)
        Me.Controls.Add(Me.btnShowGrade)
        Me.Controls.Add(Me.txtFEGrade)
        Me.Controls.Add(Me.txtQ2Grade)
        Me.Controls.Add(Me.txtQ1Grade)
        Me.Controls.Add(Me.lblQ2Prompt)
        Me.Controls.Add(Me.lblFEGrade)
        Me.Controls.Add(Me.lblGrades)
        Me.Controls.Add(Me.lblQ1Prompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGrades"
        Me.Text = "Grades"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelloAgainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Pizza2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CircleAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReadyForSchoolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScopeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblQ1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblGrades As System.Windows.Forms.Label
    Friend WithEvents lblFEGrade As System.Windows.Forms.Label
    Friend WithEvents lblQ2Prompt As System.Windows.Forms.Label
    Friend WithEvents txtQ1Grade As System.Windows.Forms.TextBox
    Friend WithEvents txtQ2Grade As System.Windows.Forms.TextBox
    Friend WithEvents txtFEGrade As System.Windows.Forms.TextBox
    Friend WithEvents btnShowGrade As System.Windows.Forms.Button
End Class
