<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanAnalyzer
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
        Me.lstTerm = New System.Windows.Forms.ListBox()
        Me.lblTermPrompt = New System.Windows.Forms.Label()
        Me.btnNewLoan = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpWhatToKnow = New System.Windows.Forms.GroupBox()
        Me.radPaymentSize = New System.Windows.Forms.RadioButton()
        Me.radHowMuch = New System.Windows.Forms.RadioButton()
        Me.lblPrincipalOrPaymentPrompt = New System.Windows.Forms.Label()
        Me.txtPrincipalOrPayment = New System.Windows.Forms.TextBox()
        Me.lblRatePrompt = New System.Windows.Forms.Label()
        Me.cboInterestRate = New System.Windows.Forms.ComboBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.picHome = New System.Windows.Forms.PictureBox()
        Me.picAuto = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.grpWhatToKnow.SuspendLayout()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 24)
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
        'lstTerm
        '
        Me.lstTerm.FormattingEnabled = True
        Me.lstTerm.Location = New System.Drawing.Point(12, 113)
        Me.lstTerm.Name = "lstTerm"
        Me.lstTerm.Size = New System.Drawing.Size(120, 147)
        Me.lstTerm.TabIndex = 3
        Me.lstTerm.Visible = False
        '
        'lblTermPrompt
        '
        Me.lblTermPrompt.Location = New System.Drawing.Point(12, 87)
        Me.lblTermPrompt.Name = "lblTermPrompt"
        Me.lblTermPrompt.Size = New System.Drawing.Size(120, 23)
        Me.lblTermPrompt.TabIndex = 4
        Me.lblTermPrompt.Text = "Loan Length"
        Me.lblTermPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTermPrompt.Visible = False
        '
        'btnNewLoan
        '
        Me.btnNewLoan.Location = New System.Drawing.Point(140, 346)
        Me.btnNewLoan.Name = "btnNewLoan"
        Me.btnNewLoan.Size = New System.Drawing.Size(75, 23)
        Me.btnNewLoan.TabIndex = 5
        Me.btnNewLoan.Text = "New Loan"
        Me.btnNewLoan.UseVisualStyleBackColor = True
        Me.btnNewLoan.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(357, 346)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        Me.btnCalculate.Visible = False
        '
        'grpWhatToKnow
        '
        Me.grpWhatToKnow.Controls.Add(Me.radPaymentSize)
        Me.grpWhatToKnow.Controls.Add(Me.radHowMuch)
        Me.grpWhatToKnow.Location = New System.Drawing.Point(165, 167)
        Me.grpWhatToKnow.Name = "grpWhatToKnow"
        Me.grpWhatToKnow.Size = New System.Drawing.Size(123, 122)
        Me.grpWhatToKnow.TabIndex = 7
        Me.grpWhatToKnow.TabStop = False
        Me.grpWhatToKnow.Text = "What do you want to know?"
        Me.grpWhatToKnow.Visible = False
        '
        'radPaymentSize
        '
        Me.radPaymentSize.AutoSize = True
        Me.radPaymentSize.Location = New System.Drawing.Point(6, 87)
        Me.radPaymentSize.Name = "radPaymentSize"
        Me.radPaymentSize.Size = New System.Drawing.Size(89, 17)
        Me.radPaymentSize.TabIndex = 1
        Me.radPaymentSize.TabStop = True
        Me.radPaymentSize.Tag = "payment size"
        Me.radPaymentSize.Text = "Payment Size"
        Me.radPaymentSize.UseVisualStyleBackColor = True
        Me.radPaymentSize.Visible = False
        '
        'radHowMuch
        '
        Me.radHowMuch.AutoSize = True
        Me.radHowMuch.Location = New System.Drawing.Point(6, 35)
        Me.radHowMuch.Name = "radHowMuch"
        Me.radHowMuch.Size = New System.Drawing.Size(76, 17)
        Me.radHowMuch.TabIndex = 0
        Me.radHowMuch.TabStop = True
        Me.radHowMuch.Tag = "how much"
        Me.radHowMuch.Text = "How much"
        Me.radHowMuch.UseVisualStyleBackColor = True
        Me.radHowMuch.Visible = False
        '
        'lblPrincipalOrPaymentPrompt
        '
        Me.lblPrincipalOrPaymentPrompt.Location = New System.Drawing.Point(336, 170)
        Me.lblPrincipalOrPaymentPrompt.Name = "lblPrincipalOrPaymentPrompt"
        Me.lblPrincipalOrPaymentPrompt.Size = New System.Drawing.Size(120, 20)
        Me.lblPrincipalOrPaymentPrompt.TabIndex = 8
        Me.lblPrincipalOrPaymentPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPrincipalOrPaymentPrompt.Visible = False
        '
        'txtPrincipalOrPayment
        '
        Me.txtPrincipalOrPayment.Location = New System.Drawing.Point(462, 170)
        Me.txtPrincipalOrPayment.Name = "txtPrincipalOrPayment"
        Me.txtPrincipalOrPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtPrincipalOrPayment.TabIndex = 9
        Me.txtPrincipalOrPayment.Visible = False
        '
        'lblRatePrompt
        '
        Me.lblRatePrompt.Location = New System.Drawing.Point(315, 224)
        Me.lblRatePrompt.Name = "lblRatePrompt"
        Me.lblRatePrompt.Size = New System.Drawing.Size(120, 20)
        Me.lblRatePrompt.TabIndex = 10
        Me.lblRatePrompt.Text = "Rate:"
        Me.lblRatePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblRatePrompt.Visible = False
        '
        'cboInterestRate
        '
        Me.cboInterestRate.FormattingEnabled = True
        Me.cboInterestRate.Location = New System.Drawing.Point(441, 224)
        Me.cboInterestRate.Name = "cboInterestRate"
        Me.cboInterestRate.Size = New System.Drawing.Size(121, 21)
        Me.cboInterestRate.TabIndex = 11
        Me.cboInterestRate.Visible = False
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(318, 254)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(262, 86)
        Me.lblResult.TabIndex = 13
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblResult.Visible = False
        '
        'picHome
        '
        Me.picHome.BackgroundImage = Global._6._01_Work.My.Resources.Resources.house
        Me.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHome.Location = New System.Drawing.Point(339, 27)
        Me.picHome.Name = "picHome"
        Me.picHome.Size = New System.Drawing.Size(123, 115)
        Me.picHome.TabIndex = 2
        Me.picHome.TabStop = False
        Me.picHome.Tag = "home"
        '
        'picAuto
        '
        Me.picAuto.BackgroundImage = Global._6._01_Work.My.Resources.Resources.car
        Me.picAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picAuto.Location = New System.Drawing.Point(165, 27)
        Me.picAuto.Name = "picAuto"
        Me.picAuto.Size = New System.Drawing.Size(123, 115)
        Me.picAuto.TabIndex = 1
        Me.picAuto.TabStop = False
        Me.picAuto.Tag = "auto"
        '
        'frmLoanAnalyzer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 379)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.cboInterestRate)
        Me.Controls.Add(Me.lblRatePrompt)
        Me.Controls.Add(Me.txtPrincipalOrPayment)
        Me.Controls.Add(Me.lblPrincipalOrPaymentPrompt)
        Me.Controls.Add(Me.grpWhatToKnow)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnNewLoan)
        Me.Controls.Add(Me.lblTermPrompt)
        Me.Controls.Add(Me.lstTerm)
        Me.Controls.Add(Me.picHome)
        Me.Controls.Add(Me.picAuto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLoanAnalyzer"
        Me.Text = "Loan Analyzer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpWhatToKnow.ResumeLayout(False)
        Me.grpWhatToKnow.PerformLayout()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picAuto As System.Windows.Forms.PictureBox
    Friend WithEvents picHome As System.Windows.Forms.PictureBox
    Friend WithEvents lstTerm As System.Windows.Forms.ListBox
    Friend WithEvents lblTermPrompt As System.Windows.Forms.Label
    Friend WithEvents btnNewLoan As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents grpWhatToKnow As System.Windows.Forms.GroupBox
    Friend WithEvents radPaymentSize As System.Windows.Forms.RadioButton
    Friend WithEvents radHowMuch As System.Windows.Forms.RadioButton
    Friend WithEvents lblPrincipalOrPaymentPrompt As System.Windows.Forms.Label
    Friend WithEvents txtPrincipalOrPayment As System.Windows.Forms.TextBox
    Friend WithEvents lblRatePrompt As System.Windows.Forms.Label
    Friend WithEvents cboInterestRate As System.Windows.Forms.ComboBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
End Class
