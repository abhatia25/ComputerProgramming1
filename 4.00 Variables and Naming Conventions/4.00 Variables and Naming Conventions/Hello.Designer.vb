<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHello
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
        Me.grpLanguageHello = New System.Windows.Forms.GroupBox()
        Me.radKorean = New System.Windows.Forms.RadioButton()
        Me.radItalian = New System.Windows.Forms.RadioButton()
        Me.radSwedish = New System.Windows.Forms.RadioButton()
        Me.radDutch = New System.Windows.Forms.RadioButton()
        Me.radNorwegian = New System.Windows.Forms.RadioButton()
        Me.radGerman = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.grpLanguageGoodbye = New System.Windows.Forms.GroupBox()
        Me.chkKorean = New System.Windows.Forms.CheckBox()
        Me.chkItalian = New System.Windows.Forms.CheckBox()
        Me.chkSwedish = New System.Windows.Forms.CheckBox()
        Me.chkDutch = New System.Windows.Forms.CheckBox()
        Me.chkNorwegian = New System.Windows.Forms.CheckBox()
        Me.chkGerman = New System.Windows.Forms.CheckBox()
        Me.chkFrench = New System.Windows.Forms.CheckBox()
        Me.chkEnglish = New System.Windows.Forms.CheckBox()
        Me.mnuMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemperatureConversionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.btnGoodbye = New System.Windows.Forms.Button()
        Me.lblGoodbye = New System.Windows.Forms.Label()
        Me.grpLanguageHello.SuspendLayout()
        Me.grpLanguageGoodbye.SuspendLayout()
        Me.mnuMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLanguageHello
        '
        Me.grpLanguageHello.Controls.Add(Me.radKorean)
        Me.grpLanguageHello.Controls.Add(Me.radItalian)
        Me.grpLanguageHello.Controls.Add(Me.radSwedish)
        Me.grpLanguageHello.Controls.Add(Me.radDutch)
        Me.grpLanguageHello.Controls.Add(Me.radNorwegian)
        Me.grpLanguageHello.Controls.Add(Me.radGerman)
        Me.grpLanguageHello.Controls.Add(Me.radFrench)
        Me.grpLanguageHello.Controls.Add(Me.radEnglish)
        Me.grpLanguageHello.Location = New System.Drawing.Point(12, 27)
        Me.grpLanguageHello.Name = "grpLanguageHello"
        Me.grpLanguageHello.Size = New System.Drawing.Size(229, 216)
        Me.grpLanguageHello.TabIndex = 0
        Me.grpLanguageHello.TabStop = False
        Me.grpLanguageHello.Text = "Language Hello"
        '
        'radKorean
        '
        Me.radKorean.AutoCheck = False
        Me.radKorean.AutoSize = True
        Me.radKorean.Location = New System.Drawing.Point(133, 176)
        Me.radKorean.Name = "radKorean"
        Me.radKorean.Size = New System.Drawing.Size(59, 17)
        Me.radKorean.TabIndex = 7
        Me.radKorean.TabStop = True
        Me.radKorean.Text = "Korean"
        Me.radKorean.UseVisualStyleBackColor = True
        '
        'radItalian
        '
        Me.radItalian.AutoCheck = False
        Me.radItalian.AutoSize = True
        Me.radItalian.Location = New System.Drawing.Point(133, 125)
        Me.radItalian.Name = "radItalian"
        Me.radItalian.Size = New System.Drawing.Size(53, 17)
        Me.radItalian.TabIndex = 6
        Me.radItalian.TabStop = True
        Me.radItalian.Text = "Italian"
        Me.radItalian.UseVisualStyleBackColor = True
        '
        'radSwedish
        '
        Me.radSwedish.AutoCheck = False
        Me.radSwedish.AutoSize = True
        Me.radSwedish.Location = New System.Drawing.Point(133, 76)
        Me.radSwedish.Name = "radSwedish"
        Me.radSwedish.Size = New System.Drawing.Size(65, 17)
        Me.radSwedish.TabIndex = 5
        Me.radSwedish.TabStop = True
        Me.radSwedish.Text = "Swedish"
        Me.radSwedish.UseVisualStyleBackColor = True
        '
        'radDutch
        '
        Me.radDutch.AutoCheck = False
        Me.radDutch.AutoSize = True
        Me.radDutch.Location = New System.Drawing.Point(133, 24)
        Me.radDutch.Name = "radDutch"
        Me.radDutch.Size = New System.Drawing.Size(54, 17)
        Me.radDutch.TabIndex = 4
        Me.radDutch.TabStop = True
        Me.radDutch.Text = "Dutch"
        Me.radDutch.UseVisualStyleBackColor = True
        '
        'radNorwegian
        '
        Me.radNorwegian.AutoCheck = False
        Me.radNorwegian.AutoSize = True
        Me.radNorwegian.Location = New System.Drawing.Point(6, 176)
        Me.radNorwegian.Name = "radNorwegian"
        Me.radNorwegian.Size = New System.Drawing.Size(76, 17)
        Me.radNorwegian.TabIndex = 3
        Me.radNorwegian.TabStop = True
        Me.radNorwegian.Text = "Norwegian"
        Me.radNorwegian.UseVisualStyleBackColor = True
        '
        'radGerman
        '
        Me.radGerman.AutoCheck = False
        Me.radGerman.AutoSize = True
        Me.radGerman.Location = New System.Drawing.Point(6, 125)
        Me.radGerman.Name = "radGerman"
        Me.radGerman.Size = New System.Drawing.Size(62, 17)
        Me.radGerman.TabIndex = 2
        Me.radGerman.TabStop = True
        Me.radGerman.Text = "German"
        Me.radGerman.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoCheck = False
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(6, 76)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(58, 17)
        Me.radFrench.TabIndex = 1
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radEnglish
        '
        Me.radEnglish.AutoCheck = False
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Location = New System.Drawing.Point(6, 24)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(59, 17)
        Me.radEnglish.TabIndex = 0
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(69, 262)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(102, 41)
        Me.btnHello.TabIndex = 1
        Me.btnHello.Text = "Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'grpLanguageGoodbye
        '
        Me.grpLanguageGoodbye.Controls.Add(Me.chkKorean)
        Me.grpLanguageGoodbye.Controls.Add(Me.chkItalian)
        Me.grpLanguageGoodbye.Controls.Add(Me.chkSwedish)
        Me.grpLanguageGoodbye.Controls.Add(Me.chkDutch)
        Me.grpLanguageGoodbye.Controls.Add(Me.chkNorwegian)
        Me.grpLanguageGoodbye.Controls.Add(Me.chkGerman)
        Me.grpLanguageGoodbye.Controls.Add(Me.chkFrench)
        Me.grpLanguageGoodbye.Controls.Add(Me.chkEnglish)
        Me.grpLanguageGoodbye.Location = New System.Drawing.Point(275, 27)
        Me.grpLanguageGoodbye.Name = "grpLanguageGoodbye"
        Me.grpLanguageGoodbye.Size = New System.Drawing.Size(229, 216)
        Me.grpLanguageGoodbye.TabIndex = 1
        Me.grpLanguageGoodbye.TabStop = False
        Me.grpLanguageGoodbye.Text = "Language Goodbye"
        '
        'chkKorean
        '
        Me.chkKorean.AutoSize = True
        Me.chkKorean.Location = New System.Drawing.Point(142, 176)
        Me.chkKorean.Name = "chkKorean"
        Me.chkKorean.Size = New System.Drawing.Size(60, 17)
        Me.chkKorean.TabIndex = 7
        Me.chkKorean.Text = "Korean"
        Me.chkKorean.UseVisualStyleBackColor = True
        '
        'chkItalian
        '
        Me.chkItalian.AutoSize = True
        Me.chkItalian.Location = New System.Drawing.Point(142, 125)
        Me.chkItalian.Name = "chkItalian"
        Me.chkItalian.Size = New System.Drawing.Size(54, 17)
        Me.chkItalian.TabIndex = 6
        Me.chkItalian.Text = "Italian"
        Me.chkItalian.UseVisualStyleBackColor = True
        '
        'chkSwedish
        '
        Me.chkSwedish.AutoSize = True
        Me.chkSwedish.Location = New System.Drawing.Point(142, 76)
        Me.chkSwedish.Name = "chkSwedish"
        Me.chkSwedish.Size = New System.Drawing.Size(66, 17)
        Me.chkSwedish.TabIndex = 5
        Me.chkSwedish.Text = "Swedish"
        Me.chkSwedish.UseVisualStyleBackColor = True
        '
        'chkDutch
        '
        Me.chkDutch.AutoSize = True
        Me.chkDutch.Location = New System.Drawing.Point(142, 24)
        Me.chkDutch.Name = "chkDutch"
        Me.chkDutch.Size = New System.Drawing.Size(55, 17)
        Me.chkDutch.TabIndex = 4
        Me.chkDutch.Text = "Dutch"
        Me.chkDutch.UseVisualStyleBackColor = True
        '
        'chkNorwegian
        '
        Me.chkNorwegian.AutoSize = True
        Me.chkNorwegian.Location = New System.Drawing.Point(19, 176)
        Me.chkNorwegian.Name = "chkNorwegian"
        Me.chkNorwegian.Size = New System.Drawing.Size(77, 17)
        Me.chkNorwegian.TabIndex = 3
        Me.chkNorwegian.Text = "Norwegian"
        Me.chkNorwegian.UseVisualStyleBackColor = True
        '
        'chkGerman
        '
        Me.chkGerman.AutoSize = True
        Me.chkGerman.Location = New System.Drawing.Point(19, 125)
        Me.chkGerman.Name = "chkGerman"
        Me.chkGerman.Size = New System.Drawing.Size(63, 17)
        Me.chkGerman.TabIndex = 2
        Me.chkGerman.Text = "German"
        Me.chkGerman.UseVisualStyleBackColor = True
        '
        'chkFrench
        '
        Me.chkFrench.AutoSize = True
        Me.chkFrench.Location = New System.Drawing.Point(19, 77)
        Me.chkFrench.Name = "chkFrench"
        Me.chkFrench.Size = New System.Drawing.Size(59, 17)
        Me.chkFrench.TabIndex = 1
        Me.chkFrench.Text = "French"
        Me.chkFrench.UseVisualStyleBackColor = True
        '
        'chkEnglish
        '
        Me.chkEnglish.AutoSize = True
        Me.chkEnglish.Location = New System.Drawing.Point(19, 24)
        Me.chkEnglish.Name = "chkEnglish"
        Me.chkEnglish.Size = New System.Drawing.Size(60, 17)
        Me.chkEnglish.TabIndex = 0
        Me.chkEnglish.Text = "English"
        Me.chkEnglish.UseVisualStyleBackColor = True
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.OtherProgramsToolStripMenuItem})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(516, 24)
        Me.mnuMenuStrip.TabIndex = 2
        Me.mnuMenuStrip.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OtherProgramsToolStripMenuItem
        '
        Me.OtherProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemperatureConversionToolStripMenuItem})
        Me.OtherProgramsToolStripMenuItem.Name = "OtherProgramsToolStripMenuItem"
        Me.OtherProgramsToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.OtherProgramsToolStripMenuItem.Text = "&Other Programs"
        '
        'TemperatureConversionToolStripMenuItem
        '
        Me.TemperatureConversionToolStripMenuItem.Name = "TemperatureConversionToolStripMenuItem"
        Me.TemperatureConversionToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.TemperatureConversionToolStripMenuItem.Text = "&Temperature Conversion"
        '
        'lblHello
        '
        Me.lblHello.Location = New System.Drawing.Point(15, 342)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(226, 52)
        Me.lblHello.TabIndex = 3
        Me.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGoodbye
        '
        Me.btnGoodbye.Location = New System.Drawing.Point(337, 262)
        Me.btnGoodbye.Name = "btnGoodbye"
        Me.btnGoodbye.Size = New System.Drawing.Size(102, 41)
        Me.btnGoodbye.TabIndex = 4
        Me.btnGoodbye.Text = "Goodbye"
        Me.btnGoodbye.UseVisualStyleBackColor = True
        '
        'lblGoodbye
        '
        Me.lblGoodbye.Location = New System.Drawing.Point(278, 342)
        Me.lblGoodbye.Name = "lblGoodbye"
        Me.lblGoodbye.Size = New System.Drawing.Size(226, 52)
        Me.lblGoodbye.TabIndex = 5
        Me.lblGoodbye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHello
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 423)
        Me.Controls.Add(Me.lblGoodbye)
        Me.Controls.Add(Me.btnGoodbye)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.grpLanguageGoodbye)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.grpLanguageHello)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.MainMenuStrip = Me.mnuMenuStrip
        Me.Name = "frmHello"
        Me.Text = "Hello"
        Me.grpLanguageHello.ResumeLayout(False)
        Me.grpLanguageHello.PerformLayout()
        Me.grpLanguageGoodbye.ResumeLayout(False)
        Me.grpLanguageGoodbye.PerformLayout()
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpLanguageHello As System.Windows.Forms.GroupBox
    Friend WithEvents radKorean As System.Windows.Forms.RadioButton
    Friend WithEvents radItalian As System.Windows.Forms.RadioButton
    Friend WithEvents radSwedish As System.Windows.Forms.RadioButton
    Friend WithEvents radDutch As System.Windows.Forms.RadioButton
    Friend WithEvents radNorwegian As System.Windows.Forms.RadioButton
    Friend WithEvents radGerman As System.Windows.Forms.RadioButton
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents radEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents btnHello As System.Windows.Forms.Button
    Friend WithEvents grpLanguageGoodbye As System.Windows.Forms.GroupBox
    Friend WithEvents mnuMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemperatureConversionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblHello As System.Windows.Forms.Label
    Friend WithEvents btnGoodbye As System.Windows.Forms.Button
    Friend WithEvents chkKorean As System.Windows.Forms.CheckBox
    Friend WithEvents chkItalian As System.Windows.Forms.CheckBox
    Friend WithEvents chkSwedish As System.Windows.Forms.CheckBox
    Friend WithEvents chkDutch As System.Windows.Forms.CheckBox
    Friend WithEvents chkNorwegian As System.Windows.Forms.CheckBox
    Friend WithEvents chkGerman As System.Windows.Forms.CheckBox
    Friend WithEvents chkFrench As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnglish As System.Windows.Forms.CheckBox
    Friend WithEvents lblGoodbye As System.Windows.Forms.Label
End Class
