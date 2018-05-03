<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLumberyardHelper
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
        Me.lblThicknessPrompt = New System.Windows.Forms.Label()
        Me.txtThickness = New System.Windows.Forms.TextBox()
        Me.lblLengthPrompt = New System.Windows.Forms.Label()
        Me.lblWidthPrompt = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(336, 24)
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
        'lblThicknessPrompt
        '
        Me.lblThicknessPrompt.AutoSize = True
        Me.lblThicknessPrompt.Location = New System.Drawing.Point(12, 40)
        Me.lblThicknessPrompt.Name = "lblThicknessPrompt"
        Me.lblThicknessPrompt.Size = New System.Drawing.Size(99, 13)
        Me.lblThicknessPrompt.TabIndex = 1
        Me.lblThicknessPrompt.Text = "Thickness (inches):"
        '
        'txtThickness
        '
        Me.txtThickness.Location = New System.Drawing.Point(117, 37)
        Me.txtThickness.Name = "txtThickness"
        Me.txtThickness.Size = New System.Drawing.Size(51, 20)
        Me.txtThickness.TabIndex = 2
        '
        'lblLengthPrompt
        '
        Me.lblLengthPrompt.AutoSize = True
        Me.lblLengthPrompt.Location = New System.Drawing.Point(12, 77)
        Me.lblLengthPrompt.Name = "lblLengthPrompt"
        Me.lblLengthPrompt.Size = New System.Drawing.Size(70, 13)
        Me.lblLengthPrompt.TabIndex = 3
        Me.lblLengthPrompt.Text = "Length (feet):"
        '
        'lblWidthPrompt
        '
        Me.lblWidthPrompt.AutoSize = True
        Me.lblWidthPrompt.Location = New System.Drawing.Point(12, 119)
        Me.lblWidthPrompt.Name = "lblWidthPrompt"
        Me.lblWidthPrompt.Size = New System.Drawing.Size(78, 13)
        Me.lblWidthPrompt.TabIndex = 4
        Me.lblWidthPrompt.Text = "Width (inches):"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(88, 74)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(51, 20)
        Me.txtLength.TabIndex = 5
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(96, 116)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(51, 20)
        Me.txtWidth.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(222, 35)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(189, 61)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(135, 85)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLumberyardHelper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 155)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblWidthPrompt)
        Me.Controls.Add(Me.lblLengthPrompt)
        Me.Controls.Add(Me.txtThickness)
        Me.Controls.Add(Me.lblThicknessPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLumberyardHelper"
        Me.Text = "Lumberyard Helper"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblThicknessPrompt As Label
    Friend WithEvents txtThickness As TextBox
    Friend WithEvents lblLengthPrompt As Label
    Friend WithEvents lblWidthPrompt As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblAnswer As Label
End Class
