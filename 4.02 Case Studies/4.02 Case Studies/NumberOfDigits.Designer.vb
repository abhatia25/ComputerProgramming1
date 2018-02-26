<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumberOfDigits
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
        Me.CaseStudyCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShellGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNumberPrompt = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnCheckNumber = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(293, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaseStudyCalculatorToolStripMenuItem, Me.ShellGameToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'CaseStudyCalculatorToolStripMenuItem
        '
        Me.CaseStudyCalculatorToolStripMenuItem.Name = "CaseStudyCalculatorToolStripMenuItem"
        Me.CaseStudyCalculatorToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CaseStudyCalculatorToolStripMenuItem.Text = "&Case Study Calculator"
        '
        'ShellGameToolStripMenuItem
        '
        Me.ShellGameToolStripMenuItem.Name = "ShellGameToolStripMenuItem"
        Me.ShellGameToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ShellGameToolStripMenuItem.Text = "&Shell Game"
        '
        'lblNumberPrompt
        '
        Me.lblNumberPrompt.Location = New System.Drawing.Point(12, 86)
        Me.lblNumberPrompt.Name = "lblNumberPrompt"
        Me.lblNumberPrompt.Size = New System.Drawing.Size(126, 20)
        Me.lblNumberPrompt.TabIndex = 1
        Me.lblNumberPrompt.Text = "Please enter a number:"
        Me.lblNumberPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(144, 86)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 2
        '
        'btnCheckNumber
        '
        Me.btnCheckNumber.Location = New System.Drawing.Point(100, 124)
        Me.btnCheckNumber.Name = "btnCheckNumber"
        Me.btnCheckNumber.Size = New System.Drawing.Size(79, 37)
        Me.btnCheckNumber.TabIndex = 3
        Me.btnCheckNumber.Text = "Check Number"
        Me.btnCheckNumber.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 164)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(269, 63)
        Me.lblAnswer.TabIndex = 4
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmNumberOfDigits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 273)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCheckNumber)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumberPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNumberOfDigits"
        Me.Text = "Number Of Digits"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaseStudyCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShellGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblNumberPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnCheckNumber As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
