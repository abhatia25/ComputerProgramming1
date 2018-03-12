<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentGrouping
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
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblStudentNamePrompt = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnDetermineGroup = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(267, 24)
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
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(156, 28)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(100, 20)
        Me.txtStudentName.TabIndex = 1
        '
        'lblStudentNamePrompt
        '
        Me.lblStudentNamePrompt.Location = New System.Drawing.Point(12, 27)
        Me.lblStudentNamePrompt.Name = "lblStudentNamePrompt"
        Me.lblStudentNamePrompt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStudentNamePrompt.Size = New System.Drawing.Size(138, 20)
        Me.lblStudentNamePrompt.TabIndex = 2
        Me.lblStudentNamePrompt.Text = "Please enter student name"
        Me.lblStudentNamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 47)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAnswer.Size = New System.Drawing.Size(243, 88)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDetermineGroup
        '
        Me.btnDetermineGroup.Location = New System.Drawing.Point(99, 149)
        Me.btnDetermineGroup.Name = "btnDetermineGroup"
        Me.btnDetermineGroup.Size = New System.Drawing.Size(75, 37)
        Me.btnDetermineGroup.TabIndex = 4
        Me.btnDetermineGroup.Text = "Determine Group"
        Me.btnDetermineGroup.UseVisualStyleBackColor = True
        '
        'frmStudentGrouping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 291)
        Me.Controls.Add(Me.btnDetermineGroup)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblStudentNamePrompt)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmStudentGrouping"
        Me.Text = "Student Grouping"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentNamePrompt As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btnDetermineGroup As System.Windows.Forms.Button
End Class
