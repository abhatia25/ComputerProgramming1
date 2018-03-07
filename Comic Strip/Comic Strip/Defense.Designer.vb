<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefense
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.radRight = New System.Windows.Forms.RadioButton()
        Me.radCenter = New System.Windows.Forms.RadioButton()
        Me.radLeft = New System.Windows.Forms.RadioButton()
        Me.grpDefense = New System.Windows.Forms.GroupBox()
        Me.chkPass = New System.Windows.Forms.CheckBox()
        Me.chkRun = New System.Windows.Forms.CheckBox()
        Me.btnKickoff = New System.Windows.Forms.Button()
        Me.grpKickoff = New System.Windows.Forms.GroupBox()
        Me.btnOffense = New System.Windows.Forms.Button()
        Me.picFootballField = New System.Windows.Forms.PictureBox()
        Me.picFootball = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.grpDefense.SuspendLayout()
        Me.grpKickoff.SuspendLayout()
        CType(Me.picFootballField, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFootball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(12, 40)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(503, 32)
        Me.lblMessage.TabIndex = 7
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(527, 24)
        Me.MenuStrip1.TabIndex = 6
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
        'radRight
        '
        Me.radRight.AutoSize = True
        Me.radRight.Location = New System.Drawing.Point(6, 77)
        Me.radRight.Name = "radRight"
        Me.radRight.Size = New System.Drawing.Size(74, 17)
        Me.radRight.TabIndex = 2
        Me.radRight.Text = "Kick Right"
        Me.radRight.UseVisualStyleBackColor = True
        Me.radRight.Visible = False
        '
        'radCenter
        '
        Me.radCenter.AutoSize = True
        Me.radCenter.Location = New System.Drawing.Point(6, 48)
        Me.radCenter.Name = "radCenter"
        Me.radCenter.Size = New System.Drawing.Size(80, 17)
        Me.radCenter.TabIndex = 1
        Me.radCenter.Text = "Kick Center"
        Me.radCenter.UseVisualStyleBackColor = True
        Me.radCenter.Visible = False
        '
        'radLeft
        '
        Me.radLeft.AutoSize = True
        Me.radLeft.Location = New System.Drawing.Point(6, 19)
        Me.radLeft.Name = "radLeft"
        Me.radLeft.Size = New System.Drawing.Size(67, 17)
        Me.radLeft.TabIndex = 0
        Me.radLeft.Text = "Kick Left"
        Me.radLeft.UseVisualStyleBackColor = True
        Me.radLeft.Visible = False
        '
        'grpDefense
        '
        Me.grpDefense.Controls.Add(Me.chkPass)
        Me.grpDefense.Controls.Add(Me.chkRun)
        Me.grpDefense.Location = New System.Drawing.Point(172, 313)
        Me.grpDefense.Name = "grpDefense"
        Me.grpDefense.Size = New System.Drawing.Size(200, 100)
        Me.grpDefense.TabIndex = 11
        Me.grpDefense.TabStop = False
        Me.grpDefense.Text = "What would you like to do?"
        Me.grpDefense.Visible = False
        '
        'chkPass
        '
        Me.chkPass.AutoSize = True
        Me.chkPass.Location = New System.Drawing.Point(6, 71)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(87, 17)
        Me.chkPass.TabIndex = 3
        Me.chkPass.Text = "Defend Pass"
        Me.chkPass.UseVisualStyleBackColor = True
        Me.chkPass.Visible = False
        '
        'chkRun
        '
        Me.chkRun.AutoSize = True
        Me.chkRun.Location = New System.Drawing.Point(6, 19)
        Me.chkRun.Name = "chkRun"
        Me.chkRun.Size = New System.Drawing.Size(84, 17)
        Me.chkRun.TabIndex = 2
        Me.chkRun.Text = "Defend Run"
        Me.chkRun.UseVisualStyleBackColor = True
        Me.chkRun.Visible = False
        '
        'btnKickoff
        '
        Me.btnKickoff.Location = New System.Drawing.Point(216, 284)
        Me.btnKickoff.Name = "btnKickoff"
        Me.btnKickoff.Size = New System.Drawing.Size(91, 23)
        Me.btnKickoff.TabIndex = 9
        Me.btnKickoff.Text = "Done"
        Me.btnKickoff.UseVisualStyleBackColor = True
        Me.btnKickoff.Visible = False
        '
        'grpKickoff
        '
        Me.grpKickoff.Controls.Add(Me.radRight)
        Me.grpKickoff.Controls.Add(Me.radCenter)
        Me.grpKickoff.Controls.Add(Me.radLeft)
        Me.grpKickoff.Location = New System.Drawing.Point(172, 178)
        Me.grpKickoff.Name = "grpKickoff"
        Me.grpKickoff.Size = New System.Drawing.Size(200, 100)
        Me.grpKickoff.TabIndex = 10
        Me.grpKickoff.TabStop = False
        Me.grpKickoff.Text = "What would you like to do?"
        Me.grpKickoff.Visible = False
        '
        'btnOffense
        '
        Me.btnOffense.Location = New System.Drawing.Point(216, 419)
        Me.btnOffense.Name = "btnOffense"
        Me.btnOffense.Size = New System.Drawing.Size(91, 23)
        Me.btnOffense.TabIndex = 12
        Me.btnOffense.Text = "Done"
        Me.btnOffense.UseVisualStyleBackColor = True
        Me.btnOffense.Visible = False
        '
        'picFootballField
        '
        Me.picFootballField.BackgroundImage = Global.Comic_Strip.My.Resources.Resources.footballfield
        Me.picFootballField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFootballField.Location = New System.Drawing.Point(12, 138)
        Me.picFootballField.Name = "picFootballField"
        Me.picFootballField.Size = New System.Drawing.Size(154, 169)
        Me.picFootballField.TabIndex = 14
        Me.picFootballField.TabStop = False
        Me.picFootballField.Visible = False
        '
        'picFootball
        '
        Me.picFootball.BackgroundImage = Global.Comic_Strip.My.Resources.Resources.football
        Me.picFootball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFootball.Location = New System.Drawing.Point(216, 75)
        Me.picFootball.Name = "picFootball"
        Me.picFootball.Size = New System.Drawing.Size(96, 97)
        Me.picFootball.TabIndex = 8
        Me.picFootball.TabStop = False
        Me.picFootball.Visible = False
        '
        'frmDefense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 448)
        Me.Controls.Add(Me.picFootballField)
        Me.Controls.Add(Me.picFootball)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grpDefense)
        Me.Controls.Add(Me.btnKickoff)
        Me.Controls.Add(Me.grpKickoff)
        Me.Controls.Add(Me.btnOffense)
        Me.Name = "frmDefense"
        Me.Text = "Defense"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpDefense.ResumeLayout(False)
        Me.grpDefense.PerformLayout()
        Me.grpKickoff.ResumeLayout(False)
        Me.grpKickoff.PerformLayout()
        CType(Me.picFootballField, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFootball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFootball As PictureBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents radRight As RadioButton
    Friend WithEvents radCenter As RadioButton
    Friend WithEvents radLeft As RadioButton
    Friend WithEvents grpDefense As GroupBox
    Friend WithEvents chkPass As CheckBox
    Friend WithEvents chkRun As CheckBox
    Friend WithEvents btnKickoff As Button
    Friend WithEvents grpKickoff As GroupBox
    Friend WithEvents btnOffense As Button
    Friend WithEvents picFootballField As System.Windows.Forms.PictureBox
End Class
