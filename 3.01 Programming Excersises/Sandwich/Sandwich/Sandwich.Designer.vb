<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSandwich
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
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.radHam = New System.Windows.Forms.RadioButton()
        Me.radTurkey = New System.Windows.Forms.RadioButton()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.lblMainChoice = New System.Windows.Forms.Label()
        Me.lblChoice1 = New System.Windows.Forms.Label()
        Me.lblChoice2 = New System.Windows.Forms.Label()
        Me.lblChoice3 = New System.Windows.Forms.Label()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpMain.SuspendLayout()
        Me.grpChoices.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMain
        '
        Me.grpMain.Controls.Add(Me.radTurkey)
        Me.grpMain.Controls.Add(Me.radHam)
        Me.grpMain.Location = New System.Drawing.Point(61, 37)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(410, 100)
        Me.grpMain.TabIndex = 0
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "Main Choice"
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.chkCheese)
        Me.grpChoices.Controls.Add(Me.chkMustard)
        Me.grpChoices.Controls.Add(Me.chkMayo)
        Me.grpChoices.Location = New System.Drawing.Point(61, 167)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(410, 100)
        Me.grpChoices.TabIndex = 0
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "Condiments"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(552, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'radHam
        '
        Me.radHam.AutoSize = True
        Me.radHam.Location = New System.Drawing.Point(35, 45)
        Me.radHam.Name = "radHam"
        Me.radHam.Size = New System.Drawing.Size(47, 17)
        Me.radHam.TabIndex = 0
        Me.radHam.TabStop = True
        Me.radHam.Text = "Ham"
        Me.radHam.UseVisualStyleBackColor = True
        '
        'radTurkey
        '
        Me.radTurkey.AutoSize = True
        Me.radTurkey.Location = New System.Drawing.Point(268, 45)
        Me.radTurkey.Name = "radTurkey"
        Me.radTurkey.Size = New System.Drawing.Size(58, 17)
        Me.radTurkey.TabIndex = 1
        Me.radTurkey.TabStop = True
        Me.radTurkey.Text = "Turkey"
        Me.radTurkey.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(6, 45)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(83, 17)
        Me.chkMayo.TabIndex = 0
        Me.chkMayo.Text = "Mayonnaise"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(164, 45)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(64, 17)
        Me.chkMustard.TabIndex = 1
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(323, 45)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 2
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'lblMainChoice
        '
        Me.lblMainChoice.Font = New System.Drawing.Font("Felix Titling", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainChoice.Location = New System.Drawing.Point(19, 270)
        Me.lblMainChoice.Name = "lblMainChoice"
        Me.lblMainChoice.Size = New System.Drawing.Size(167, 42)
        Me.lblMainChoice.TabIndex = 2
        Me.lblMainChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChoice1
        '
        Me.lblChoice1.Font = New System.Drawing.Font("Felix Titling", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice1.Location = New System.Drawing.Point(19, 358)
        Me.lblChoice1.Name = "lblChoice1"
        Me.lblChoice1.Size = New System.Drawing.Size(167, 42)
        Me.lblChoice1.TabIndex = 3
        Me.lblChoice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChoice2
        '
        Me.lblChoice2.Font = New System.Drawing.Font("Felix Titling", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice2.Location = New System.Drawing.Point(372, 270)
        Me.lblChoice2.Name = "lblChoice2"
        Me.lblChoice2.Size = New System.Drawing.Size(167, 42)
        Me.lblChoice2.TabIndex = 4
        Me.lblChoice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChoice3
        '
        Me.lblChoice3.Font = New System.Drawing.Font("Felix Titling", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoice3.Location = New System.Drawing.Point(372, 358)
        Me.lblChoice3.Name = "lblChoice3"
        Me.lblChoice3.Size = New System.Drawing.Size(167, 42)
        Me.lblChoice3.TabIndex = 5
        Me.lblChoice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'frmSandwich
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 425)
        Me.Controls.Add(Me.lblChoice3)
        Me.Controls.Add(Me.lblChoice2)
        Me.Controls.Add(Me.lblChoice1)
        Me.Controls.Add(Me.lblMainChoice)
        Me.Controls.Add(Me.grpChoices)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSandwich"
        Me.Text = "Sandwich Shop"
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpMain As System.Windows.Forms.GroupBox
    Friend WithEvents radTurkey As System.Windows.Forms.RadioButton
    Friend WithEvents radHam As System.Windows.Forms.RadioButton
    Friend WithEvents grpChoices As System.Windows.Forms.GroupBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkMustard As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMainChoice As System.Windows.Forms.Label
    Friend WithEvents lblChoice1 As System.Windows.Forms.Label
    Friend WithEvents lblChoice2 As System.Windows.Forms.Label
    Friend WithEvents lblChoice3 As System.Windows.Forms.Label
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
