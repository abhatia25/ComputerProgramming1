<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelloWorldInternational
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
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.grpLanguage = New System.Windows.Forms.GroupBox()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.radSpanish = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.radChinese = New System.Windows.Forms.RadioButton()
        Me.radGerman = New System.Windows.Forms.RadioButton()
        Me.grpLanguage.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.Location = New System.Drawing.Point(204, 46)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(0, 31)
        Me.lblGreeting.TabIndex = 0
        Me.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpLanguage
        '
        Me.grpLanguage.Controls.Add(Me.radGerman)
        Me.grpLanguage.Controls.Add(Me.radChinese)
        Me.grpLanguage.Controls.Add(Me.radEnglish)
        Me.grpLanguage.Controls.Add(Me.radSpanish)
        Me.grpLanguage.Controls.Add(Me.radFrench)
        Me.grpLanguage.Location = New System.Drawing.Point(12, 277)
        Me.grpLanguage.Name = "grpLanguage"
        Me.grpLanguage.Size = New System.Drawing.Size(630, 144)
        Me.grpLanguage.TabIndex = 1
        Me.grpLanguage.TabStop = False
        Me.grpLanguage.Text = "Select a language"
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Location = New System.Drawing.Point(6, 39)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(59, 17)
        Me.radEnglish.TabIndex = 2
        Me.radEnglish.Text = "English"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'radSpanish
        '
        Me.radSpanish.AutoSize = True
        Me.radSpanish.Location = New System.Drawing.Point(279, 39)
        Me.radSpanish.Name = "radSpanish"
        Me.radSpanish.Size = New System.Drawing.Size(63, 17)
        Me.radSpanish.TabIndex = 3
        Me.radSpanish.Text = "Spanish"
        Me.radSpanish.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(566, 39)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(58, 17)
        Me.radFrench.TabIndex = 4
        Me.radFrench.Text = "French"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(653, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'radChinese
        '
        Me.radChinese.AutoSize = True
        Me.radChinese.Location = New System.Drawing.Point(132, 94)
        Me.radChinese.Name = "radChinese"
        Me.radChinese.Size = New System.Drawing.Size(63, 17)
        Me.radChinese.TabIndex = 5
        Me.radChinese.Text = "Chinese"
        Me.radChinese.UseVisualStyleBackColor = True
        '
        'radGerman
        '
        Me.radGerman.AutoSize = True
        Me.radGerman.Location = New System.Drawing.Point(431, 94)
        Me.radGerman.Name = "radGerman"
        Me.radGerman.Size = New System.Drawing.Size(62, 17)
        Me.radGerman.TabIndex = 6
        Me.radGerman.Text = "German"
        Me.radGerman.UseVisualStyleBackColor = True
        '
        'frmHelloWorldInternational
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 426)
        Me.Controls.Add(Me.grpLanguage)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmHelloWorldInternational"
        Me.Text = "Hello World International"
        Me.grpLanguage.ResumeLayout(False)
        Me.grpLanguage.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents grpLanguage As System.Windows.Forms.GroupBox
    Friend WithEvents radEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents radSpanish As System.Windows.Forms.RadioButton
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents radGerman As System.Windows.Forms.RadioButton
    Friend WithEvents radChinese As System.Windows.Forms.RadioButton

End Class
