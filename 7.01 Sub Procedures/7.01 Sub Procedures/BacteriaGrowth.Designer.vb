<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBacteriaGrowth
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
        Me.lblInitialBacteriaPrompt = New System.Windows.Forms.Label()
        Me.txtInitialBacteria = New System.Windows.Forms.TextBox()
        Me.lblKPrompt = New System.Windows.Forms.Label()
        Me.txtK = New System.Windows.Forms.TextBox()
        Me.lblTimePrompt = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(255, 24)
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
        'lblInitialBacteriaPrompt
        '
        Me.lblInitialBacteriaPrompt.AutoSize = True
        Me.lblInitialBacteriaPrompt.Location = New System.Drawing.Point(12, 24)
        Me.lblInitialBacteriaPrompt.Name = "lblInitialBacteriaPrompt"
        Me.lblInitialBacteriaPrompt.Size = New System.Drawing.Size(110, 13)
        Me.lblInitialBacteriaPrompt.TabIndex = 1
        Me.lblInitialBacteriaPrompt.Text = "Initial bacteria amount"
        '
        'txtInitialBacteria
        '
        Me.txtInitialBacteria.Location = New System.Drawing.Point(128, 21)
        Me.txtInitialBacteria.Name = "txtInitialBacteria"
        Me.txtInitialBacteria.Size = New System.Drawing.Size(54, 20)
        Me.txtInitialBacteria.TabIndex = 2
        '
        'lblKPrompt
        '
        Me.lblKPrompt.AutoSize = True
        Me.lblKPrompt.Location = New System.Drawing.Point(12, 51)
        Me.lblKPrompt.Name = "lblKPrompt"
        Me.lblKPrompt.Size = New System.Drawing.Size(13, 13)
        Me.lblKPrompt.TabIndex = 3
        Me.lblKPrompt.Text = "k"
        '
        'txtK
        '
        Me.txtK.Location = New System.Drawing.Point(31, 48)
        Me.txtK.Name = "txtK"
        Me.txtK.Size = New System.Drawing.Size(54, 20)
        Me.txtK.TabIndex = 4
        '
        'lblTimePrompt
        '
        Me.lblTimePrompt.AutoSize = True
        Me.lblTimePrompt.Location = New System.Drawing.Point(12, 84)
        Me.lblTimePrompt.Name = "lblTimePrompt"
        Me.lblTimePrompt.Size = New System.Drawing.Size(30, 13)
        Me.lblTimePrompt.TabIndex = 5
        Me.lblTimePrompt.Text = "Time"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(48, 81)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(54, 20)
        Me.txtTime.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(168, 82)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoEllipsis = True
        Me.lblAnswer.Location = New System.Drawing.Point(12, 116)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(231, 79)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBacteriaGrowth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 208)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblTimePrompt)
        Me.Controls.Add(Me.txtK)
        Me.Controls.Add(Me.lblKPrompt)
        Me.Controls.Add(Me.txtInitialBacteria)
        Me.Controls.Add(Me.lblInitialBacteriaPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBacteriaGrowth"
        Me.Text = "Bacteria Growth"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblInitialBacteriaPrompt As Label
    Friend WithEvents txtInitialBacteria As TextBox
    Friend WithEvents lblKPrompt As Label
    Friend WithEvents txtK As TextBox
    Friend WithEvents lblTimePrompt As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblAnswer As Label
End Class
