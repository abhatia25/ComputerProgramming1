<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackageCheck
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
        Me.lblWeightPrompt = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWidthPrompt = New System.Windows.Forms.Label()
        Me.lblLengthPrompt = New System.Windows.Forms.Label()
        Me.lblHeightPrompt = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnCheckPackage = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(289, 24)
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
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Next Program"
        '
        'lblWeightPrompt
        '
        Me.lblWeightPrompt.Location = New System.Drawing.Point(9, 38)
        Me.lblWeightPrompt.Name = "lblWeightPrompt"
        Me.lblWeightPrompt.Size = New System.Drawing.Size(100, 20)
        Me.lblWeightPrompt.TabIndex = 1
        Me.lblWeightPrompt.Text = "Package Weight"
        Me.lblWeightPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(115, 39)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 2
        '
        'lblWidthPrompt
        '
        Me.lblWidthPrompt.Location = New System.Drawing.Point(9, 72)
        Me.lblWidthPrompt.Name = "lblWidthPrompt"
        Me.lblWidthPrompt.Size = New System.Drawing.Size(100, 20)
        Me.lblWidthPrompt.TabIndex = 3
        Me.lblWidthPrompt.Text = "Package Width"
        Me.lblWidthPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLengthPrompt
        '
        Me.lblLengthPrompt.Location = New System.Drawing.Point(9, 108)
        Me.lblLengthPrompt.Name = "lblLengthPrompt"
        Me.lblLengthPrompt.Size = New System.Drawing.Size(100, 20)
        Me.lblLengthPrompt.TabIndex = 4
        Me.lblLengthPrompt.Text = "Package Length"
        Me.lblLengthPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeightPrompt
        '
        Me.lblHeightPrompt.Location = New System.Drawing.Point(9, 140)
        Me.lblHeightPrompt.Name = "lblHeightPrompt"
        Me.lblHeightPrompt.Size = New System.Drawing.Size(100, 20)
        Me.lblHeightPrompt.TabIndex = 5
        Me.lblHeightPrompt.Text = "Package Height"
        Me.lblHeightPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(115, 73)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 6
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(115, 108)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 7
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(115, 140)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 8
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 265)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(265, 110)
        Me.lblAnswer.TabIndex = 9
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheckPackage
        '
        Me.btnCheckPackage.Location = New System.Drawing.Point(85, 202)
        Me.btnCheckPackage.Name = "btnCheckPackage"
        Me.btnCheckPackage.Size = New System.Drawing.Size(83, 34)
        Me.btnCheckPackage.TabIndex = 10
        Me.btnCheckPackage.Text = "Check Package"
        Me.btnCheckPackage.UseVisualStyleBackColor = True
        '
        'frmPackageCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 384)
        Me.Controls.Add(Me.btnCheckPackage)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.lblHeightPrompt)
        Me.Controls.Add(Me.lblLengthPrompt)
        Me.Controls.Add(Me.lblWidthPrompt)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblWeightPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPackageCheck"
        Me.Text = "Package Check"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblWeightPrompt As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblWidthPrompt As System.Windows.Forms.Label
    Friend WithEvents lblLengthPrompt As System.Windows.Forms.Label
    Friend WithEvents lblHeightPrompt As System.Windows.Forms.Label
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btnCheckPackage As System.Windows.Forms.Button

End Class
