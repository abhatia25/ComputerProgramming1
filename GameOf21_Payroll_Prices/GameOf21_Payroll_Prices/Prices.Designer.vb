<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrices
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
        Me.GameFo21ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNumCopies = New System.Windows.Forms.TextBox()
        Me.lblNumCopiesPrompt = New System.Windows.Forms.Label()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.lblPerCopyLabel = New System.Windows.Forms.Label()
        Me.lblPerCopyAnswer = New System.Windows.Forms.Label()
        Me.lblTotalPriceAnswer = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(363, 24)
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
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameFo21ToolStripMenuItem, Me.PayrollToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'GameFo21ToolStripMenuItem
        '
        Me.GameFo21ToolStripMenuItem.Name = "GameFo21ToolStripMenuItem"
        Me.GameFo21ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GameFo21ToolStripMenuItem.Text = "&Game of 21"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PayrollToolStripMenuItem.Text = "&Payroll"
        '
        'txtNumCopies
        '
        Me.txtNumCopies.Location = New System.Drawing.Point(192, 46)
        Me.txtNumCopies.Name = "txtNumCopies"
        Me.txtNumCopies.Size = New System.Drawing.Size(100, 20)
        Me.txtNumCopies.TabIndex = 1
        '
        'lblNumCopiesPrompt
        '
        Me.lblNumCopiesPrompt.Location = New System.Drawing.Point(86, 46)
        Me.lblNumCopiesPrompt.Name = "lblNumCopiesPrompt"
        Me.lblNumCopiesPrompt.Size = New System.Drawing.Size(100, 20)
        Me.lblNumCopiesPrompt.TabIndex = 2
        Me.lblNumCopiesPrompt.Text = "Number of Copies"
        Me.lblNumCopiesPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(128, 94)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(75, 23)
        Me.btnPrice.TabIndex = 3
        Me.btnPrice.Text = "Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'lblPerCopyLabel
        '
        Me.lblPerCopyLabel.Location = New System.Drawing.Point(86, 146)
        Me.lblPerCopyLabel.Name = "lblPerCopyLabel"
        Me.lblPerCopyLabel.Size = New System.Drawing.Size(100, 20)
        Me.lblPerCopyLabel.TabIndex = 4
        Me.lblPerCopyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPerCopyAnswer
        '
        Me.lblPerCopyAnswer.Location = New System.Drawing.Point(189, 146)
        Me.lblPerCopyAnswer.Name = "lblPerCopyAnswer"
        Me.lblPerCopyAnswer.Size = New System.Drawing.Size(100, 20)
        Me.lblPerCopyAnswer.TabIndex = 5
        Me.lblPerCopyAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalPriceAnswer
        '
        Me.lblTotalPriceAnswer.Location = New System.Drawing.Point(189, 189)
        Me.lblTotalPriceAnswer.Name = "lblTotalPriceAnswer"
        Me.lblTotalPriceAnswer.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalPriceAnswer.TabIndex = 7
        Me.lblTotalPriceAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.Location = New System.Drawing.Point(86, 189)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalLabel.TabIndex = 6
        Me.lblTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPrices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 245)
        Me.Controls.Add(Me.lblTotalPriceAnswer)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.lblPerCopyAnswer)
        Me.Controls.Add(Me.lblPerCopyLabel)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.lblNumCopiesPrompt)
        Me.Controls.Add(Me.txtNumCopies)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrices"
        Me.Text = "Prices"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameFo21ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtNumCopies As TextBox
    Friend WithEvents lblNumCopiesPrompt As Label
    Friend WithEvents btnPrice As Button
    Friend WithEvents lblPerCopyLabel As Label
    Friend WithEvents lblPerCopyAnswer As Label
    Friend WithEvents lblTotalPriceAnswer As Label
    Friend WithEvents lblTotalLabel As Label
End Class
