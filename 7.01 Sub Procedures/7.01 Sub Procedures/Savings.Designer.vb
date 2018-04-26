<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSavings
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
        Me.lblSavingsAmountPrompt = New System.Windows.Forms.Label()
        Me.lblSavingsTimePrompt = New System.Windows.Forms.Label()
        Me.txtSavingsTime = New System.Windows.Forms.TextBox()
        Me.txtSavingsAmount = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(407, 24)
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
        'lblSavingsAmountPrompt
        '
        Me.lblSavingsAmountPrompt.AutoSize = True
        Me.lblSavingsAmountPrompt.Location = New System.Drawing.Point(12, 37)
        Me.lblSavingsAmountPrompt.Name = "lblSavingsAmountPrompt"
        Me.lblSavingsAmountPrompt.Size = New System.Drawing.Size(215, 13)
        Me.lblSavingsAmountPrompt.TabIndex = 1
        Me.lblSavingsAmountPrompt.Text = "Enter the amount put in savings each month"
        Me.lblSavingsAmountPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSavingsTimePrompt
        '
        Me.lblSavingsTimePrompt.AutoSize = True
        Me.lblSavingsTimePrompt.Location = New System.Drawing.Point(12, 61)
        Me.lblSavingsTimePrompt.Name = "lblSavingsTimePrompt"
        Me.lblSavingsTimePrompt.Size = New System.Drawing.Size(276, 13)
        Me.lblSavingsTimePrompt.TabIndex = 2
        Me.lblSavingsTimePrompt.Text = "Enter the number of months saving money was deposited"
        Me.lblSavingsTimePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSavingsTime
        '
        Me.txtSavingsTime.Location = New System.Drawing.Point(294, 58)
        Me.txtSavingsTime.Name = "txtSavingsTime"
        Me.txtSavingsTime.Size = New System.Drawing.Size(100, 20)
        Me.txtSavingsTime.TabIndex = 3
        '
        'txtSavingsAmount
        '
        Me.txtSavingsAmount.Location = New System.Drawing.Point(233, 34)
        Me.txtSavingsAmount.Name = "txtSavingsAmount"
        Me.txtSavingsAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtSavingsAmount.TabIndex = 4
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 85)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(383, 78)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(106, 180)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(194, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate the total amount of savings"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmSavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 212)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.txtSavingsAmount)
        Me.Controls.Add(Me.txtSavingsTime)
        Me.Controls.Add(Me.lblSavingsTimePrompt)
        Me.Controls.Add(Me.lblSavingsAmountPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSavings"
        Me.Text = "Savings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSavingsAmountPrompt As Label
    Friend WithEvents lblSavingsTimePrompt As Label
    Friend WithEvents txtSavingsTime As TextBox
    Friend WithEvents txtSavingsAmount As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnCalculate As Button
End Class
