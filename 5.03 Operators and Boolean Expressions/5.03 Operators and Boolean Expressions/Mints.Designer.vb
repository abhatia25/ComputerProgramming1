<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMints
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
        Me.lblMintsPrompt = New System.Windows.Forms.Label()
        Me.txtMints = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lblServingsPrompt = New System.Windows.Forms.Label()
        Me.lblMintsLeftPrompt = New System.Windows.Forms.Label()
        Me.lblServings = New System.Windows.Forms.Label()
        Me.lblMintsLeft = New System.Windows.Forms.Label()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMintsPrompt
        '
        Me.lblMintsPrompt.Location = New System.Drawing.Point(11, 24)
        Me.lblMintsPrompt.Name = "lblMintsPrompt"
        Me.lblMintsPrompt.Size = New System.Drawing.Size(182, 23)
        Me.lblMintsPrompt.TabIndex = 0
        Me.lblMintsPrompt.Text = "Enter the number of mints in the bag"
        Me.lblMintsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMints
        '
        Me.txtMints.Location = New System.Drawing.Point(199, 27)
        Me.txtMints.Name = "txtMints"
        Me.txtMints.Size = New System.Drawing.Size(100, 20)
        Me.txtMints.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(96, 99)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(311, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblServingsPrompt
        '
        Me.lblServingsPrompt.Location = New System.Drawing.Point(108, 50)
        Me.lblServingsPrompt.Name = "lblServingsPrompt"
        Me.lblServingsPrompt.Size = New System.Drawing.Size(182, 23)
        Me.lblServingsPrompt.TabIndex = 2
        Me.lblServingsPrompt.Text = "Number of servings per bag"
        Me.lblServingsPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMintsLeftPrompt
        '
        Me.lblMintsLeftPrompt.Location = New System.Drawing.Point(109, 73)
        Me.lblMintsLeftPrompt.Name = "lblMintsLeftPrompt"
        Me.lblMintsLeftPrompt.Size = New System.Drawing.Size(182, 23)
        Me.lblMintsLeftPrompt.TabIndex = 3
        Me.lblMintsLeftPrompt.Text = "Mints Left Over"
        Me.lblMintsLeftPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServings
        '
        Me.lblServings.Location = New System.Drawing.Point(38, 50)
        Me.lblServings.Name = "lblServings"
        Me.lblServings.Size = New System.Drawing.Size(65, 23)
        Me.lblServings.TabIndex = 4
        Me.lblServings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMintsLeft
        '
        Me.lblMintsLeft.Location = New System.Drawing.Point(38, 73)
        Me.lblMintsLeft.Name = "lblMintsLeft"
        Me.lblMintsLeft.Size = New System.Drawing.Size(65, 23)
        Me.lblMintsLeft.TabIndex = 5
        Me.lblMintsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'frmMints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 262)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMintsLeft)
        Me.Controls.Add(Me.lblServings)
        Me.Controls.Add(Me.lblMintsLeftPrompt)
        Me.Controls.Add(Me.lblServingsPrompt)
        Me.Controls.Add(Me.txtMints)
        Me.Controls.Add(Me.lblMintsPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMints"
        Me.Text = "Mints"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMintsPrompt As System.Windows.Forms.Label
    Friend WithEvents txtMints As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents lblServingsPrompt As System.Windows.Forms.Label
    Friend WithEvents lblMintsLeftPrompt As System.Windows.Forms.Label
    Friend WithEvents lblServings As System.Windows.Forms.Label
    Friend WithEvents lblMintsLeft As System.Windows.Forms.Label
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
