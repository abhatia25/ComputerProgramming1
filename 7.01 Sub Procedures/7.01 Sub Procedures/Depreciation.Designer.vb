<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepreciation
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
        Me.lblInitialValuePrompt = New System.Windows.Forms.Label()
        Me.lblEndingValuePrompt = New System.Windows.Forms.Label()
        Me.lblDepreciationRatePrompt = New System.Windows.Forms.Label()
        Me.txtInitialValue = New System.Windows.Forms.TextBox()
        Me.txtEndingValue = New System.Windows.Forms.TextBox()
        Me.txtDepreciationRate = New System.Windows.Forms.TextBox()
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
        'lblInitialValuePrompt
        '
        Me.lblInitialValuePrompt.AutoSize = True
        Me.lblInitialValuePrompt.Location = New System.Drawing.Point(12, 33)
        Me.lblInitialValuePrompt.Name = "lblInitialValuePrompt"
        Me.lblInitialValuePrompt.Size = New System.Drawing.Size(76, 13)
        Me.lblInitialValuePrompt.TabIndex = 1
        Me.lblInitialValuePrompt.Text = "Initial Value ($)"
        '
        'lblEndingValuePrompt
        '
        Me.lblEndingValuePrompt.AutoSize = True
        Me.lblEndingValuePrompt.Location = New System.Drawing.Point(12, 71)
        Me.lblEndingValuePrompt.Name = "lblEndingValuePrompt"
        Me.lblEndingValuePrompt.Size = New System.Drawing.Size(85, 13)
        Me.lblEndingValuePrompt.TabIndex = 2
        Me.lblEndingValuePrompt.Text = "Ending Value ($)"
        '
        'lblDepreciationRatePrompt
        '
        Me.lblDepreciationRatePrompt.AutoSize = True
        Me.lblDepreciationRatePrompt.Location = New System.Drawing.Point(12, 107)
        Me.lblDepreciationRatePrompt.Name = "lblDepreciationRatePrompt"
        Me.lblDepreciationRatePrompt.Size = New System.Drawing.Size(120, 13)
        Me.lblDepreciationRatePrompt.TabIndex = 3
        Me.lblDepreciationRatePrompt.Text = "Rate of depreciation (%)"
        '
        'txtInitialValue
        '
        Me.txtInitialValue.Location = New System.Drawing.Point(94, 30)
        Me.txtInitialValue.Name = "txtInitialValue"
        Me.txtInitialValue.Size = New System.Drawing.Size(86, 20)
        Me.txtInitialValue.TabIndex = 4
        '
        'txtEndingValue
        '
        Me.txtEndingValue.Location = New System.Drawing.Point(103, 68)
        Me.txtEndingValue.Name = "txtEndingValue"
        Me.txtEndingValue.Size = New System.Drawing.Size(86, 20)
        Me.txtEndingValue.TabIndex = 5
        '
        'txtDepreciationRate
        '
        Me.txtDepreciationRate.Location = New System.Drawing.Point(138, 104)
        Me.txtDepreciationRate.Name = "txtDepreciationRate"
        Me.txtDepreciationRate.Size = New System.Drawing.Size(86, 20)
        Me.txtDepreciationRate.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(103, 141)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 174)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(260, 79)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDepreciation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtDepreciationRate)
        Me.Controls.Add(Me.txtEndingValue)
        Me.Controls.Add(Me.txtInitialValue)
        Me.Controls.Add(Me.lblDepreciationRatePrompt)
        Me.Controls.Add(Me.lblEndingValuePrompt)
        Me.Controls.Add(Me.lblInitialValuePrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDepreciation"
        Me.Text = "Depreciation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblInitialValuePrompt As System.Windows.Forms.Label
    Friend WithEvents lblEndingValuePrompt As System.Windows.Forms.Label
    Friend WithEvents lblDepreciationRatePrompt As System.Windows.Forms.Label
    Friend WithEvents txtInitialValue As System.Windows.Forms.TextBox
    Friend WithEvents txtEndingValue As System.Windows.Forms.TextBox
    Friend WithEvents txtDepreciationRate As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
End Class
