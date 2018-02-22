<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll
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
        Me.GameOf21ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PricesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblHoursPrompt = New System.Windows.Forms.Label()
        Me.lblWagePrompt = New System.Windows.Forms.Label()
        Me.lblAnswerLabel = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(348, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameOf21ToolStripMenuItem, Me.PricesToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'GameOf21ToolStripMenuItem
        '
        Me.GameOf21ToolStripMenuItem.Name = "GameOf21ToolStripMenuItem"
        Me.GameOf21ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GameOf21ToolStripMenuItem.Text = "&Game of 21"
        '
        'PricesToolStripMenuItem
        '
        Me.PricesToolStripMenuItem.Name = "PricesToolStripMenuItem"
        Me.PricesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PricesToolStripMenuItem.Text = "P&rices"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(187, 51)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 1
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(187, 113)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 2
        '
        'lblHoursPrompt
        '
        Me.lblHoursPrompt.Location = New System.Drawing.Point(81, 51)
        Me.lblHoursPrompt.Name = "lblHoursPrompt"
        Me.lblHoursPrompt.Size = New System.Drawing.Size(100, 20)
        Me.lblHoursPrompt.TabIndex = 3
        Me.lblHoursPrompt.Text = "Hours Worked"
        Me.lblHoursPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWagePrompt
        '
        Me.lblWagePrompt.Location = New System.Drawing.Point(81, 113)
        Me.lblWagePrompt.Name = "lblWagePrompt"
        Me.lblWagePrompt.Size = New System.Drawing.Size(100, 20)
        Me.lblWagePrompt.TabIndex = 4
        Me.lblWagePrompt.Text = "Wage"
        Me.lblWagePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAnswerLabel
        '
        Me.lblAnswerLabel.Location = New System.Drawing.Point(12, 186)
        Me.lblAnswerLabel.Name = "lblAnswerLabel"
        Me.lblAnswerLabel.Size = New System.Drawing.Size(100, 20)
        Me.lblAnswerLabel.TabIndex = 5
        Me.lblAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(118, 186)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(100, 20)
        Me.lblAnswer.TabIndex = 6
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(121, 154)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 7
        Me.btnPay.Text = "Calculate"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 215)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblAnswerLabel)
        Me.Controls.Add(Me.lblWagePrompt)
        Me.Controls.Add(Me.lblHoursPrompt)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPayroll"
        Me.Text = "Payroll"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameOf21ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PricesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents lblHoursPrompt As Label
    Friend WithEvents lblWagePrompt As Label
    Friend WithEvents lblAnswerLabel As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnPay As Button
End Class
