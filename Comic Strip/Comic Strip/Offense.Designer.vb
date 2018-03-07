<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffense
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.grpKickoff = New System.Windows.Forms.GroupBox()
        Me.radTouchback = New System.Windows.Forms.RadioButton()
        Me.radFairCatch = New System.Windows.Forms.RadioButton()
        Me.radRun = New System.Windows.Forms.RadioButton()
        Me.grpOffense = New System.Windows.Forms.GroupBox()
        Me.chkPass = New System.Windows.Forms.CheckBox()
        Me.chkRun = New System.Windows.Forms.CheckBox()
        Me.btnOffense = New System.Windows.Forms.Button()
        Me.btnKickoff = New System.Windows.Forms.Button()
        Me.picFootball = New System.Windows.Forms.PictureBox()
        Me.picFootballField = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.grpKickoff.SuspendLayout()
        Me.grpOffense.SuspendLayout()
        CType(Me.picFootball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFootballField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(527, 24)
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
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(12, 34)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(503, 32)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpKickoff
        '
        Me.grpKickoff.Controls.Add(Me.radTouchback)
        Me.grpKickoff.Controls.Add(Me.radFairCatch)
        Me.grpKickoff.Controls.Add(Me.radRun)
        Me.grpKickoff.Location = New System.Drawing.Point(172, 172)
        Me.grpKickoff.Name = "grpKickoff"
        Me.grpKickoff.Size = New System.Drawing.Size(200, 100)
        Me.grpKickoff.TabIndex = 3
        Me.grpKickoff.TabStop = False
        Me.grpKickoff.Text = "What would you like to do?"
        Me.grpKickoff.Visible = False
        '
        'radTouchback
        '
        Me.radTouchback.AutoSize = True
        Me.radTouchback.Location = New System.Drawing.Point(6, 77)
        Me.radTouchback.Name = "radTouchback"
        Me.radTouchback.Size = New System.Drawing.Size(170, 17)
        Me.radTouchback.TabIndex = 2
        Me.radTouchback.Text = "Let the ball go for a touchback"
        Me.radTouchback.UseVisualStyleBackColor = True
        Me.radTouchback.Visible = False
        '
        'radFairCatch
        '
        Me.radFairCatch.AutoSize = True
        Me.radFairCatch.Location = New System.Drawing.Point(6, 48)
        Me.radFairCatch.Name = "radFairCatch"
        Me.radFairCatch.Size = New System.Drawing.Size(113, 17)
        Me.radFairCatch.TabIndex = 1
        Me.radFairCatch.Text = "Call for a fair catch"
        Me.radFairCatch.UseVisualStyleBackColor = True
        Me.radFairCatch.Visible = False
        '
        'radRun
        '
        Me.radRun.AutoSize = True
        Me.radRun.Location = New System.Drawing.Point(6, 19)
        Me.radRun.Name = "radRun"
        Me.radRun.Size = New System.Drawing.Size(129, 17)
        Me.radRun.TabIndex = 0
        Me.radRun.Text = "Catch the ball and run"
        Me.radRun.UseVisualStyleBackColor = True
        Me.radRun.Visible = False
        '
        'grpOffense
        '
        Me.grpOffense.Controls.Add(Me.chkPass)
        Me.grpOffense.Controls.Add(Me.chkRun)
        Me.grpOffense.Location = New System.Drawing.Point(172, 307)
        Me.grpOffense.Name = "grpOffense"
        Me.grpOffense.Size = New System.Drawing.Size(200, 100)
        Me.grpOffense.TabIndex = 4
        Me.grpOffense.TabStop = False
        Me.grpOffense.Text = "What would you like to do?"
        Me.grpOffense.Visible = False
        '
        'chkPass
        '
        Me.chkPass.AutoSize = True
        Me.chkPass.Location = New System.Drawing.Point(6, 71)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(49, 17)
        Me.chkPass.TabIndex = 3
        Me.chkPass.Text = "Pass"
        Me.chkPass.UseVisualStyleBackColor = True
        Me.chkPass.Visible = False
        '
        'chkRun
        '
        Me.chkRun.AutoSize = True
        Me.chkRun.Location = New System.Drawing.Point(6, 19)
        Me.chkRun.Name = "chkRun"
        Me.chkRun.Size = New System.Drawing.Size(46, 17)
        Me.chkRun.TabIndex = 2
        Me.chkRun.Text = "Run"
        Me.chkRun.UseVisualStyleBackColor = True
        Me.chkRun.Visible = False
        '
        'btnOffense
        '
        Me.btnOffense.Location = New System.Drawing.Point(216, 413)
        Me.btnOffense.Name = "btnOffense"
        Me.btnOffense.Size = New System.Drawing.Size(91, 23)
        Me.btnOffense.TabIndex = 5
        Me.btnOffense.Text = "Done"
        Me.btnOffense.UseVisualStyleBackColor = True
        Me.btnOffense.Visible = False
        '
        'btnKickoff
        '
        Me.btnKickoff.Location = New System.Drawing.Point(216, 278)
        Me.btnKickoff.Name = "btnKickoff"
        Me.btnKickoff.Size = New System.Drawing.Size(91, 23)
        Me.btnKickoff.TabIndex = 3
        Me.btnKickoff.Text = "Done"
        Me.btnKickoff.UseVisualStyleBackColor = True
        Me.btnKickoff.Visible = False
        '
        'picFootball
        '
        Me.picFootball.BackgroundImage = Global.Comic_Strip.My.Resources.Resources.football
        Me.picFootball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFootball.Location = New System.Drawing.Point(216, 69)
        Me.picFootball.Name = "picFootball"
        Me.picFootball.Size = New System.Drawing.Size(96, 97)
        Me.picFootball.TabIndex = 2
        Me.picFootball.TabStop = False
        Me.picFootball.Visible = False
        '
        'picFootballField
        '
        Me.picFootballField.BackgroundImage = Global.Comic_Strip.My.Resources.Resources.footballfield
        Me.picFootballField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFootballField.Location = New System.Drawing.Point(12, 115)
        Me.picFootballField.Name = "picFootballField"
        Me.picFootballField.Size = New System.Drawing.Size(154, 169)
        Me.picFootballField.TabIndex = 14
        Me.picFootballField.TabStop = False
        Me.picFootballField.Visible = False
        '
        'frmOffense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 448)
        Me.Controls.Add(Me.picFootballField)
        Me.Controls.Add(Me.grpOffense)
        Me.Controls.Add(Me.btnOffense)
        Me.Controls.Add(Me.btnKickoff)
        Me.Controls.Add(Me.grpKickoff)
        Me.Controls.Add(Me.picFootball)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmOffense"
        Me.Text = "Offense"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpKickoff.ResumeLayout(False)
        Me.grpKickoff.PerformLayout()
        Me.grpOffense.ResumeLayout(False)
        Me.grpOffense.PerformLayout()
        CType(Me.picFootball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFootballField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblMessage As Label
    Friend WithEvents picFootball As PictureBox
    Friend WithEvents grpKickoff As GroupBox
    Friend WithEvents radTouchback As RadioButton
    Friend WithEvents radFairCatch As RadioButton
    Friend WithEvents radRun As RadioButton
    Friend WithEvents btnKickoff As Button
    Friend WithEvents grpOffense As GroupBox
    Friend WithEvents btnOffense As Button
    Friend WithEvents chkRun As CheckBox
    Friend WithEvents chkPass As CheckBox
    Friend WithEvents picFootballField As System.Windows.Forms.PictureBox
End Class
