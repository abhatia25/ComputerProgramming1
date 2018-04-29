<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanPayment
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
        Me.lblRatePrompt = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblTermPrompt = New System.Windows.Forms.Label()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.lblPrincipalPrompt = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
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
        'lblRatePrompt
        '
        Me.lblRatePrompt.AutoSize = True
        Me.lblRatePrompt.Location = New System.Drawing.Point(12, 38)
        Me.lblRatePrompt.Name = "lblRatePrompt"
        Me.lblRatePrompt.Size = New System.Drawing.Size(88, 13)
        Me.lblRatePrompt.TabIndex = 1
        Me.lblRatePrompt.Text = "Interest Rate (%):"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(106, 35)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 2
        '
        'lblTermPrompt
        '
        Me.lblTermPrompt.AutoSize = True
        Me.lblTermPrompt.Location = New System.Drawing.Point(12, 75)
        Me.lblTermPrompt.Name = "lblTermPrompt"
        Me.lblTermPrompt.Size = New System.Drawing.Size(103, 13)
        Me.lblTermPrompt.TabIndex = 3
        Me.lblTermPrompt.Text = "Term of loan (years):"
        '
        'txtTerm
        '
        Me.txtTerm.Location = New System.Drawing.Point(121, 72)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(100, 20)
        Me.txtTerm.TabIndex = 4
        '
        'lblPrincipalPrompt
        '
        Me.lblPrincipalPrompt.AutoSize = True
        Me.lblPrincipalPrompt.Location = New System.Drawing.Point(12, 114)
        Me.lblPrincipalPrompt.Name = "lblPrincipalPrompt"
        Me.lblPrincipalPrompt.Size = New System.Drawing.Size(65, 13)
        Me.lblPrincipalPrompt.TabIndex = 5
        Me.lblPrincipalPrompt.Text = "Principal ($):"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(83, 111)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(100, 20)
        Me.txtPrincipal.TabIndex = 6
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(107, 139)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(75, 23)
        Me.btnPayment.TabIndex = 7
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(12, 172)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(260, 80)
        Me.lblMonthlyPayment.TabIndex = 8
        Me.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLoanPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.lblPrincipalPrompt)
        Me.Controls.Add(Me.txtTerm)
        Me.Controls.Add(Me.lblTermPrompt)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.lblRatePrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLoanPayment"
        Me.Text = "Loan Payment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblRatePrompt As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents lblTermPrompt As Label
    Friend WithEvents txtTerm As TextBox
    Friend WithEvents lblPrincipalPrompt As Label
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents btnPayment As Button
    Friend WithEvents lblMonthlyPayment As Label
End Class
