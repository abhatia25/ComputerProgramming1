<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonutDelight
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
        Me.mnuExit = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDonutPrompt = New System.Windows.Forms.Label()
        Me.txtDonuts = New System.Windows.Forms.TextBox()
        Me.grpDonutType = New System.Windows.Forms.GroupBox()
        Me.radLemon = New System.Windows.Forms.RadioButton()
        Me.radBlueberry = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.lblDonutChoice = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.OtherProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopwatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit.SuspendLayout()
        Me.grpDonutType.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuExit
        '
        Me.mnuExit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.mnuExit.Location = New System.Drawing.Point(0, 0)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(395, 24)
        Me.mnuExit.TabIndex = 0
        Me.mnuExit.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblDonutPrompt
        '
        Me.lblDonutPrompt.Location = New System.Drawing.Point(12, 39)
        Me.lblDonutPrompt.Name = "lblDonutPrompt"
        Me.lblDonutPrompt.Size = New System.Drawing.Size(222, 20)
        Me.lblDonutPrompt.TabIndex = 1
        Me.lblDonutPrompt.Text = "How many donuts would you like?"
        Me.lblDonutPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDonuts
        '
        Me.txtDonuts.Location = New System.Drawing.Point(240, 39)
        Me.txtDonuts.Name = "txtDonuts"
        Me.txtDonuts.Size = New System.Drawing.Size(28, 20)
        Me.txtDonuts.TabIndex = 2
        '
        'grpDonutType
        '
        Me.grpDonutType.Controls.Add(Me.radLemon)
        Me.grpDonutType.Controls.Add(Me.radBlueberry)
        Me.grpDonutType.Controls.Add(Me.radChocolate)
        Me.grpDonutType.Controls.Add(Me.radGlazed)
        Me.grpDonutType.Location = New System.Drawing.Point(15, 72)
        Me.grpDonutType.Name = "grpDonutType"
        Me.grpDonutType.Size = New System.Drawing.Size(368, 148)
        Me.grpDonutType.TabIndex = 3
        Me.grpDonutType.TabStop = False
        Me.grpDonutType.Text = "Type of Doughnuts"
        '
        'radLemon
        '
        Me.radLemon.AutoSize = True
        Me.radLemon.Location = New System.Drawing.Point(251, 100)
        Me.radLemon.Name = "radLemon"
        Me.radLemon.Size = New System.Drawing.Size(87, 17)
        Me.radLemon.TabIndex = 3
        Me.radLemon.TabStop = True
        Me.radLemon.Text = "Lemon $0.60"
        Me.radLemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radLemon.UseVisualStyleBackColor = True
        '
        'radBlueberry
        '
        Me.radBlueberry.AutoSize = True
        Me.radBlueberry.Location = New System.Drawing.Point(251, 24)
        Me.radBlueberry.Name = "radBlueberry"
        Me.radBlueberry.Size = New System.Drawing.Size(99, 17)
        Me.radBlueberry.TabIndex = 2
        Me.radBlueberry.TabStop = True
        Me.radBlueberry.Text = "Blueberry $0.75"
        Me.radBlueberry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radBlueberry.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(19, 100)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(103, 17)
        Me.radChocolate.TabIndex = 1
        Me.radChocolate.TabStop = True
        Me.radChocolate.Text = "Chocolate $0.65"
        Me.radChocolate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(19, 24)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(88, 17)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.TabStop = True
        Me.radGlazed.Text = "Glazed $0.50"
        Me.radGlazed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'lblDonutChoice
        '
        Me.lblDonutChoice.Location = New System.Drawing.Point(34, 223)
        Me.lblDonutChoice.Name = "lblDonutChoice"
        Me.lblDonutChoice.Size = New System.Drawing.Size(319, 110)
        Me.lblDonutChoice.TabIndex = 4
        Me.lblDonutChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(47, 350)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 5
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(140, 337)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(213, 46)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OtherProgramsToolStripMenuItem
        '
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StopwatchToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'StopwatchToolStripMenuItem
        '
        Me.StopwatchToolStripMenuItem.Name = "StopwatchToolStripMenuItem"
        Me.StopwatchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StopwatchToolStripMenuItem.Text = "&Stopwatch"
        '
        'frmDonutDelight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 388)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblDonutChoice)
        Me.Controls.Add(Me.grpDonutType)
        Me.Controls.Add(Me.txtDonuts)
        Me.Controls.Add(Me.lblDonutPrompt)
        Me.Controls.Add(Me.mnuExit)
        Me.MainMenuStrip = Me.mnuExit
        Me.Name = "frmDonutDelight"
        Me.Text = "Donut Delight"
        Me.mnuExit.ResumeLayout(False)
        Me.mnuExit.PerformLayout()
        Me.grpDonutType.ResumeLayout(False)
        Me.grpDonutType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuExit As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDonutPrompt As System.Windows.Forms.Label
    Friend WithEvents txtDonuts As System.Windows.Forms.TextBox
    Friend WithEvents grpDonutType As System.Windows.Forms.GroupBox
    Friend WithEvents radLemon As System.Windows.Forms.RadioButton
    Friend WithEvents radBlueberry As System.Windows.Forms.RadioButton
    Friend WithEvents radChocolate As System.Windows.Forms.RadioButton
    Friend WithEvents radGlazed As System.Windows.Forms.RadioButton
    Friend WithEvents lblDonutChoice As System.Windows.Forms.Label
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopwatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
