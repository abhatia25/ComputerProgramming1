<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanCalculator
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
        Me.lblMontlyPayPrompt = New System.Windows.Forms.Label()
        Me.txtMonthlyPay = New System.Windows.Forms.TextBox()
        Me.lblInterestRatePrompt = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.cboLengthYears = New System.Windows.Forms.ComboBox()
        Me.lblLengthPrompt = New System.Windows.Forms.Label()
        Me.btnLoanAmount = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(223, 24)
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
        'lblMontlyPayPrompt
        '
        Me.lblMontlyPayPrompt.Location = New System.Drawing.Point(12, 39)
        Me.lblMontlyPayPrompt.Name = "lblMontlyPayPrompt"
        Me.lblMontlyPayPrompt.Size = New System.Drawing.Size(72, 23)
        Me.lblMontlyPayPrompt.TabIndex = 1
        Me.lblMontlyPayPrompt.Text = "Monthly Pay"
        Me.lblMontlyPayPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMonthlyPay
        '
        Me.txtMonthlyPay.Location = New System.Drawing.Point(90, 39)
        Me.txtMonthlyPay.Name = "txtMonthlyPay"
        Me.txtMonthlyPay.Size = New System.Drawing.Size(93, 20)
        Me.txtMonthlyPay.TabIndex = 2
        '
        'lblInterestRatePrompt
        '
        Me.lblInterestRatePrompt.Location = New System.Drawing.Point(12, 72)
        Me.lblInterestRatePrompt.Name = "lblInterestRatePrompt"
        Me.lblInterestRatePrompt.Size = New System.Drawing.Size(72, 23)
        Me.lblInterestRatePrompt.TabIndex = 3
        Me.lblInterestRatePrompt.Text = "Interest Rate"
        Me.lblInterestRatePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(90, 74)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(93, 20)
        Me.txtRate.TabIndex = 4
        '
        'cboLengthYears
        '
        Me.cboLengthYears.FormattingEnabled = True
        Me.cboLengthYears.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "35"})
        Me.cboLengthYears.Location = New System.Drawing.Point(90, 110)
        Me.cboLengthYears.Name = "cboLengthYears"
        Me.cboLengthYears.Size = New System.Drawing.Size(93, 21)
        Me.cboLengthYears.TabIndex = 5
        '
        'lblLengthPrompt
        '
        Me.lblLengthPrompt.Location = New System.Drawing.Point(12, 108)
        Me.lblLengthPrompt.Name = "lblLengthPrompt"
        Me.lblLengthPrompt.Size = New System.Drawing.Size(72, 23)
        Me.lblLengthPrompt.TabIndex = 6
        Me.lblLengthPrompt.Text = "Length"
        Me.lblLengthPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLoanAmount
        '
        Me.btnLoanAmount.Location = New System.Drawing.Point(67, 150)
        Me.btnLoanAmount.Name = "btnLoanAmount"
        Me.btnLoanAmount.Size = New System.Drawing.Size(75, 23)
        Me.btnLoanAmount.TabIndex = 7
        Me.btnLoanAmount.Text = "Calculate"
        Me.btnLoanAmount.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 176)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(199, 76)
        Me.lblAnswer.TabIndex = 8
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLoanCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 261)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnLoanAmount)
        Me.Controls.Add(Me.lblLengthPrompt)
        Me.Controls.Add(Me.cboLengthYears)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.lblInterestRatePrompt)
        Me.Controls.Add(Me.txtMonthlyPay)
        Me.Controls.Add(Me.lblMontlyPayPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLoanCalculator"
        Me.Text = "Loan Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblMontlyPayPrompt As Label
    Friend WithEvents txtMonthlyPay As TextBox
    Friend WithEvents lblInterestRatePrompt As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents cboLengthYears As ComboBox
    Friend WithEvents lblLengthPrompt As Label
    Friend WithEvents btnLoanAmount As Button
    Friend WithEvents lblAnswer As Label
End Class
