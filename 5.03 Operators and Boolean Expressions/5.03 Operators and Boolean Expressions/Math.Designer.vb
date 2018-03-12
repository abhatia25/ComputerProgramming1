<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMath
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnParentheses = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDecMult = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnIntDiv = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblParentheses = New System.Windows.Forms.Label()
        Me.lblMult = New System.Windows.Forms.Label()
        Me.lblDecMult = New System.Windows.Forms.Label()
        Me.lblDiv = New System.Windows.Forms.Label()
        Me.lblIntDiv = New System.Windows.Forms.Label()
        Me.lblMod = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(249, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 27)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "6 + 3 / 2"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnParentheses
        '
        Me.btnParentheses.Location = New System.Drawing.Point(12, 56)
        Me.btnParentheses.Name = "btnParentheses"
        Me.btnParentheses.Size = New System.Drawing.Size(75, 23)
        Me.btnParentheses.TabIndex = 2
        Me.btnParentheses.Text = "(6 + 3) / 2"
        Me.btnParentheses.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(12, 85)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(75, 23)
        Me.btnMult.TabIndex = 3
        Me.btnMult.Text = "9 * 2 / 5"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btnDecMult
        '
        Me.btnDecMult.Location = New System.Drawing.Point(12, 114)
        Me.btnDecMult.Name = "btnDecMult"
        Me.btnDecMult.Size = New System.Drawing.Size(75, 23)
        Me.btnDecMult.TabIndex = 4
        Me.btnDecMult.Text = "9.0 * 2 / 5"
        Me.btnDecMult.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(12, 143)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(75, 23)
        Me.btnDiv.TabIndex = 5
        Me.btnDiv.Text = "7 / 2"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnIntDiv
        '
        Me.btnIntDiv.Location = New System.Drawing.Point(12, 172)
        Me.btnIntDiv.Name = "btnIntDiv"
        Me.btnIntDiv.Size = New System.Drawing.Size(75, 23)
        Me.btnIntDiv.TabIndex = 6
        Me.btnIntDiv.Text = "7 \ 2"
        Me.btnIntDiv.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(12, 201)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 23)
        Me.btnMod.TabIndex = 7
        Me.btnMod.Text = "7 Mod 2"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'lblAdd
        '
        Me.lblAdd.Location = New System.Drawing.Point(93, 27)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(100, 23)
        Me.lblAdd.TabIndex = 8
        Me.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblParentheses
        '
        Me.lblParentheses.Location = New System.Drawing.Point(93, 56)
        Me.lblParentheses.Name = "lblParentheses"
        Me.lblParentheses.Size = New System.Drawing.Size(100, 23)
        Me.lblParentheses.TabIndex = 9
        Me.lblParentheses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMult
        '
        Me.lblMult.Location = New System.Drawing.Point(93, 85)
        Me.lblMult.Name = "lblMult"
        Me.lblMult.Size = New System.Drawing.Size(100, 23)
        Me.lblMult.TabIndex = 10
        Me.lblMult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDecMult
        '
        Me.lblDecMult.Location = New System.Drawing.Point(93, 114)
        Me.lblDecMult.Name = "lblDecMult"
        Me.lblDecMult.Size = New System.Drawing.Size(100, 23)
        Me.lblDecMult.TabIndex = 11
        Me.lblDecMult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiv
        '
        Me.lblDiv.Location = New System.Drawing.Point(93, 143)
        Me.lblDiv.Name = "lblDiv"
        Me.lblDiv.Size = New System.Drawing.Size(100, 23)
        Me.lblDiv.TabIndex = 12
        Me.lblDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIntDiv
        '
        Me.lblIntDiv.Location = New System.Drawing.Point(93, 174)
        Me.lblIntDiv.Name = "lblIntDiv"
        Me.lblIntDiv.Size = New System.Drawing.Size(100, 23)
        Me.lblIntDiv.TabIndex = 13
        Me.lblIntDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMod
        '
        Me.lblMod.Location = New System.Drawing.Point(93, 201)
        Me.lblMod.Name = "lblMod"
        Me.lblMod.Size = New System.Drawing.Size(100, 23)
        Me.lblMod.TabIndex = 14
        Me.lblMod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 273)
        Me.Controls.Add(Me.lblMod)
        Me.Controls.Add(Me.lblIntDiv)
        Me.Controls.Add(Me.lblDiv)
        Me.Controls.Add(Me.lblDecMult)
        Me.Controls.Add(Me.lblMult)
        Me.Controls.Add(Me.lblParentheses)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnIntDiv)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnDecMult)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnParentheses)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMath"
        Me.Text = "Math"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnParentheses As System.Windows.Forms.Button
    Friend WithEvents btnMult As System.Windows.Forms.Button
    Friend WithEvents btnDecMult As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnIntDiv As System.Windows.Forms.Button
    Friend WithEvents btnMod As System.Windows.Forms.Button
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblParentheses As System.Windows.Forms.Label
    Friend WithEvents lblMult As System.Windows.Forms.Label
    Friend WithEvents lblDecMult As System.Windows.Forms.Label
    Friend WithEvents lblDiv As System.Windows.Forms.Label
    Friend WithEvents lblIntDiv As System.Windows.Forms.Label
    Friend WithEvents lblMod As System.Windows.Forms.Label

End Class
