<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFootballGame
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
        Me.lblFirstQuarterPrompt = New System.Windows.Forms.Label()
        Me.txtFirstQuarter = New System.Windows.Forms.TextBox()
        Me.lblSecondQuarterPrompt = New System.Windows.Forms.Label()
        Me.lblThirdQuarterPrompt = New System.Windows.Forms.Label()
        Me.lblFourthQuarterPrompt = New System.Windows.Forms.Label()
        Me.txtSecondQuarter = New System.Windows.Forms.TextBox()
        Me.txtThirdQuarter = New System.Windows.Forms.TextBox()
        Me.txtFourthQuarter = New System.Windows.Forms.TextBox()
        Me.btnTotalPoints = New System.Windows.Forms.Button()
        Me.lblTotalPoints = New System.Windows.Forms.Label()
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
        'lblFirstQuarterPrompt
        '
        Me.lblFirstQuarterPrompt.Location = New System.Drawing.Point(12, 24)
        Me.lblFirstQuarterPrompt.Name = "lblFirstQuarterPrompt"
        Me.lblFirstQuarterPrompt.Size = New System.Drawing.Size(163, 23)
        Me.lblFirstQuarterPrompt.TabIndex = 1
        Me.lblFirstQuarterPrompt.Text = "Enter the first quarter points"
        Me.lblFirstQuarterPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirstQuarter
        '
        Me.txtFirstQuarter.Location = New System.Drawing.Point(181, 26)
        Me.txtFirstQuarter.Name = "txtFirstQuarter"
        Me.txtFirstQuarter.Size = New System.Drawing.Size(91, 20)
        Me.txtFirstQuarter.TabIndex = 2
        '
        'lblSecondQuarterPrompt
        '
        Me.lblSecondQuarterPrompt.Location = New System.Drawing.Point(12, 60)
        Me.lblSecondQuarterPrompt.Name = "lblSecondQuarterPrompt"
        Me.lblSecondQuarterPrompt.Size = New System.Drawing.Size(163, 23)
        Me.lblSecondQuarterPrompt.TabIndex = 3
        Me.lblSecondQuarterPrompt.Text = "Enter the second quarter points"
        Me.lblSecondQuarterPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblThirdQuarterPrompt
        '
        Me.lblThirdQuarterPrompt.Location = New System.Drawing.Point(12, 95)
        Me.lblThirdQuarterPrompt.Name = "lblThirdQuarterPrompt"
        Me.lblThirdQuarterPrompt.Size = New System.Drawing.Size(163, 23)
        Me.lblThirdQuarterPrompt.TabIndex = 4
        Me.lblThirdQuarterPrompt.Text = "Enter the third quarter points"
        Me.lblThirdQuarterPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFourthQuarterPrompt
        '
        Me.lblFourthQuarterPrompt.Location = New System.Drawing.Point(12, 128)
        Me.lblFourthQuarterPrompt.Name = "lblFourthQuarterPrompt"
        Me.lblFourthQuarterPrompt.Size = New System.Drawing.Size(163, 23)
        Me.lblFourthQuarterPrompt.TabIndex = 5
        Me.lblFourthQuarterPrompt.Text = "Enter the fourth quarter points"
        Me.lblFourthQuarterPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSecondQuarter
        '
        Me.txtSecondQuarter.Location = New System.Drawing.Point(181, 62)
        Me.txtSecondQuarter.Name = "txtSecondQuarter"
        Me.txtSecondQuarter.Size = New System.Drawing.Size(91, 20)
        Me.txtSecondQuarter.TabIndex = 6
        '
        'txtThirdQuarter
        '
        Me.txtThirdQuarter.Location = New System.Drawing.Point(181, 97)
        Me.txtThirdQuarter.Name = "txtThirdQuarter"
        Me.txtThirdQuarter.Size = New System.Drawing.Size(91, 20)
        Me.txtThirdQuarter.TabIndex = 7
        '
        'txtFourthQuarter
        '
        Me.txtFourthQuarter.Location = New System.Drawing.Point(181, 130)
        Me.txtFourthQuarter.Name = "txtFourthQuarter"
        Me.txtFourthQuarter.Size = New System.Drawing.Size(91, 20)
        Me.txtFourthQuarter.TabIndex = 8
        '
        'btnTotalPoints
        '
        Me.btnTotalPoints.Location = New System.Drawing.Point(12, 163)
        Me.btnTotalPoints.Name = "btnTotalPoints"
        Me.btnTotalPoints.Size = New System.Drawing.Size(260, 23)
        Me.btnTotalPoints.TabIndex = 9
        Me.btnTotalPoints.Text = "Compute the total number of points"
        Me.btnTotalPoints.UseVisualStyleBackColor = True
        '
        'lblTotalPoints
        '
        Me.lblTotalPoints.Location = New System.Drawing.Point(12, 189)
        Me.lblTotalPoints.Name = "lblTotalPoints"
        Me.lblTotalPoints.Size = New System.Drawing.Size(260, 63)
        Me.lblTotalPoints.TabIndex = 10
        Me.lblTotalPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmFootballGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblTotalPoints)
        Me.Controls.Add(Me.btnTotalPoints)
        Me.Controls.Add(Me.txtFourthQuarter)
        Me.Controls.Add(Me.txtThirdQuarter)
        Me.Controls.Add(Me.txtSecondQuarter)
        Me.Controls.Add(Me.lblFourthQuarterPrompt)
        Me.Controls.Add(Me.lblThirdQuarterPrompt)
        Me.Controls.Add(Me.lblSecondQuarterPrompt)
        Me.Controls.Add(Me.txtFirstQuarter)
        Me.Controls.Add(Me.lblFirstQuarterPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFootballGame"
        Me.Text = "Football Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblFirstQuarterPrompt As Label
    Friend WithEvents txtFirstQuarter As TextBox
    Friend WithEvents lblSecondQuarterPrompt As Label
    Friend WithEvents lblThirdQuarterPrompt As Label
    Friend WithEvents lblFourthQuarterPrompt As Label
    Friend WithEvents txtSecondQuarter As TextBox
    Friend WithEvents txtThirdQuarter As TextBox
    Friend WithEvents txtFourthQuarter As TextBox
    Friend WithEvents btnTotalPoints As Button
    Friend WithEvents lblTotalPoints As Label
End Class
