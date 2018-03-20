<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuickCuts
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
        Me.grpCutChoice = New System.Windows.Forms.GroupBox()
        Me.chkMassage = New System.Windows.Forms.CheckBox()
        Me.chkStyle = New System.Windows.Forms.CheckBox()
        Me.chkShampoo = New System.Windows.Forms.CheckBox()
        Me.chkHairCut = New System.Windows.Forms.CheckBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grpCutChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(224, 24)
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
        'grpCutChoice
        '
        Me.grpCutChoice.Controls.Add(Me.chkMassage)
        Me.grpCutChoice.Controls.Add(Me.chkStyle)
        Me.grpCutChoice.Controls.Add(Me.chkShampoo)
        Me.grpCutChoice.Controls.Add(Me.chkHairCut)
        Me.grpCutChoice.Location = New System.Drawing.Point(12, 47)
        Me.grpCutChoice.Name = "grpCutChoice"
        Me.grpCutChoice.Size = New System.Drawing.Size(200, 143)
        Me.grpCutChoice.TabIndex = 1
        Me.grpCutChoice.TabStop = False
        Me.grpCutChoice.Text = "Choose your options"
        '
        'chkMassage
        '
        Me.chkMassage.AutoSize = True
        Me.chkMassage.Location = New System.Drawing.Point(6, 120)
        Me.chkMassage.Name = "chkMassage"
        Me.chkMassage.Size = New System.Drawing.Size(131, 17)
        Me.chkMassage.TabIndex = 3
        Me.chkMassage.Text = "Neck Massage, $2.95"
        Me.chkMassage.UseVisualStyleBackColor = True
        '
        'chkStyle
        '
        Me.chkStyle.AutoSize = True
        Me.chkStyle.Location = New System.Drawing.Point(6, 82)
        Me.chkStyle.Name = "chkStyle"
        Me.chkStyle.Size = New System.Drawing.Size(82, 17)
        Me.chkStyle.TabIndex = 2
        Me.chkStyle.Text = "Style, $5.95"
        Me.chkStyle.UseVisualStyleBackColor = True
        '
        'chkShampoo
        '
        Me.chkShampoo.AutoSize = True
        Me.chkShampoo.Location = New System.Drawing.Point(6, 48)
        Me.chkShampoo.Name = "chkShampoo"
        Me.chkShampoo.Size = New System.Drawing.Size(104, 17)
        Me.chkShampoo.TabIndex = 1
        Me.chkShampoo.Text = "Shampoo, $3.95"
        Me.chkShampoo.UseVisualStyleBackColor = True
        '
        'chkHairCut
        '
        Me.chkHairCut.AutoSize = True
        Me.chkHairCut.Location = New System.Drawing.Point(6, 19)
        Me.chkHairCut.Name = "chkHairCut"
        Me.chkHairCut.Size = New System.Drawing.Size(97, 17)
        Me.chkHairCut.TabIndex = 0
        Me.chkHairCut.Text = "Hair Cut, $9.95"
        Me.chkHairCut.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 206)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(200, 65)
        Me.lblAnswer.TabIndex = 4
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(74, 274)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Total Cost"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmQuickCuts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 308)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.grpCutChoice)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmQuickCuts"
        Me.Text = "Quick Cuts"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpCutChoice.ResumeLayout(False)
        Me.grpCutChoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpCutChoice As GroupBox
    Friend WithEvents chkMassage As CheckBox
    Friend WithEvents chkStyle As CheckBox
    Friend WithEvents chkShampoo As CheckBox
    Friend WithEvents chkHairCut As CheckBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents btnSubmit As Button
End Class
