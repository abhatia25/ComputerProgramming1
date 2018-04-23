<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCostCalculator
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
        Me.lblCostPerItemPrompt = New System.Windows.Forms.Label()
        Me.txtPerItem = New System.Windows.Forms.TextBox()
        Me.lblTotalItemsPrompt = New System.Windows.Forms.Label()
        Me.txtNumberofItems = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        'lblCostPerItemPrompt
        '
        Me.lblCostPerItemPrompt.Location = New System.Drawing.Point(12, 33)
        Me.lblCostPerItemPrompt.Name = "lblCostPerItemPrompt"
        Me.lblCostPerItemPrompt.Size = New System.Drawing.Size(139, 23)
        Me.lblCostPerItemPrompt.TabIndex = 1
        Me.lblCostPerItemPrompt.Text = "Enter the cost per item:"
        Me.lblCostPerItemPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPerItem
        '
        Me.txtPerItem.Location = New System.Drawing.Point(157, 35)
        Me.txtPerItem.Name = "txtPerItem"
        Me.txtPerItem.Size = New System.Drawing.Size(100, 20)
        Me.txtPerItem.TabIndex = 2
        '
        'lblTotalItemsPrompt
        '
        Me.lblTotalItemsPrompt.Location = New System.Drawing.Point(12, 67)
        Me.lblTotalItemsPrompt.Name = "lblTotalItemsPrompt"
        Me.lblTotalItemsPrompt.Size = New System.Drawing.Size(139, 23)
        Me.lblTotalItemsPrompt.TabIndex = 3
        Me.lblTotalItemsPrompt.Text = "Enter the number of items:"
        Me.lblTotalItemsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumberofItems
        '
        Me.txtNumberofItems.Location = New System.Drawing.Point(157, 69)
        Me.txtNumberofItems.Name = "txtNumberofItems"
        Me.txtNumberofItems.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberofItems.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(60, 105)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(156, 22)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(12, 130)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(260, 93)
        Me.lblResult.TabIndex = 6
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'frmCostCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 234)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumberofItems)
        Me.Controls.Add(Me.lblTotalItemsPrompt)
        Me.Controls.Add(Me.txtPerItem)
        Me.Controls.Add(Me.lblCostPerItemPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCostCalculator"
        Me.Text = "Cost Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCostPerItemPrompt As System.Windows.Forms.Label
    Friend WithEvents txtPerItem As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalItemsPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumberofItems As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
