<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFavoriteSportsTeams
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
        Me.btnDone = New System.Windows.Forms.Button()
        Me.grpFootball = New System.Windows.Forms.GroupBox()
        Me.chkOther1 = New System.Windows.Forms.CheckBox()
        Me.chkChiefs = New System.Windows.Forms.CheckBox()
        Me.chkJags = New System.Windows.Forms.CheckBox()
        Me.chkVikings = New System.Windows.Forms.CheckBox()
        Me.chkPats = New System.Windows.Forms.CheckBox()
        Me.chkSteelers = New System.Windows.Forms.CheckBox()
        Me.chkSaints = New System.Windows.Forms.CheckBox()
        Me.chkEagles = New System.Windows.Forms.CheckBox()
        Me.grpBasketball = New System.Windows.Forms.GroupBox()
        Me.chkWarriors = New System.Windows.Forms.CheckBox()
        Me.chkThunder = New System.Windows.Forms.CheckBox()
        Me.chkCeltics = New System.Windows.Forms.CheckBox()
        Me.chkOther = New System.Windows.Forms.CheckBox()
        Me.chk76ers = New System.Windows.Forms.CheckBox()
        Me.chkSpurs = New System.Windows.Forms.CheckBox()
        Me.chkRockets = New System.Windows.Forms.CheckBox()
        Me.chkCavs = New System.Windows.Forms.CheckBox()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpFootball.SuspendLayout()
        Me.grpBasketball.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(245, 414)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 0
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'grpFootball
        '
        Me.grpFootball.Controls.Add(Me.chkOther1)
        Me.grpFootball.Controls.Add(Me.chkChiefs)
        Me.grpFootball.Controls.Add(Me.chkJags)
        Me.grpFootball.Controls.Add(Me.chkVikings)
        Me.grpFootball.Controls.Add(Me.chkPats)
        Me.grpFootball.Controls.Add(Me.chkSteelers)
        Me.grpFootball.Controls.Add(Me.chkSaints)
        Me.grpFootball.Controls.Add(Me.chkEagles)
        Me.grpFootball.Location = New System.Drawing.Point(12, 114)
        Me.grpFootball.Name = "grpFootball"
        Me.grpFootball.Size = New System.Drawing.Size(213, 229)
        Me.grpFootball.TabIndex = 1
        Me.grpFootball.TabStop = False
        Me.grpFootball.Text = "Favorite Football Teams"
        '
        'chkOther1
        '
        Me.chkOther1.AutoSize = True
        Me.chkOther1.Location = New System.Drawing.Point(126, 206)
        Me.chkOther1.Name = "chkOther1"
        Me.chkOther1.Size = New System.Drawing.Size(52, 17)
        Me.chkOther1.TabIndex = 7
        Me.chkOther1.Text = "Other"
        Me.chkOther1.UseVisualStyleBackColor = True
        '
        'chkChiefs
        '
        Me.chkChiefs.AutoSize = True
        Me.chkChiefs.Location = New System.Drawing.Point(11, 206)
        Me.chkChiefs.Name = "chkChiefs"
        Me.chkChiefs.Size = New System.Drawing.Size(55, 17)
        Me.chkChiefs.TabIndex = 6
        Me.chkChiefs.Text = "Chiefs"
        Me.chkChiefs.UseVisualStyleBackColor = True
        '
        'chkJags
        '
        Me.chkJags.AutoSize = True
        Me.chkJags.Location = New System.Drawing.Point(126, 142)
        Me.chkJags.Name = "chkJags"
        Me.chkJags.Size = New System.Drawing.Size(63, 17)
        Me.chkJags.TabIndex = 5
        Me.chkJags.Text = "Jaguars"
        Me.chkJags.UseVisualStyleBackColor = True
        '
        'chkVikings
        '
        Me.chkVikings.AutoSize = True
        Me.chkVikings.Location = New System.Drawing.Point(126, 84)
        Me.chkVikings.Name = "chkVikings"
        Me.chkVikings.Size = New System.Drawing.Size(60, 17)
        Me.chkVikings.TabIndex = 4
        Me.chkVikings.Text = "Vikings"
        Me.chkVikings.UseVisualStyleBackColor = True
        '
        'chkPats
        '
        Me.chkPats.AutoSize = True
        Me.chkPats.Location = New System.Drawing.Point(126, 32)
        Me.chkPats.Name = "chkPats"
        Me.chkPats.Size = New System.Drawing.Size(61, 17)
        Me.chkPats.TabIndex = 3
        Me.chkPats.Text = "Patriots"
        Me.chkPats.UseVisualStyleBackColor = True
        '
        'chkSteelers
        '
        Me.chkSteelers.AutoSize = True
        Me.chkSteelers.Location = New System.Drawing.Point(11, 142)
        Me.chkSteelers.Name = "chkSteelers"
        Me.chkSteelers.Size = New System.Drawing.Size(64, 17)
        Me.chkSteelers.TabIndex = 2
        Me.chkSteelers.Text = "Steelers"
        Me.chkSteelers.UseVisualStyleBackColor = True
        '
        'chkSaints
        '
        Me.chkSaints.AutoSize = True
        Me.chkSaints.Location = New System.Drawing.Point(11, 84)
        Me.chkSaints.Name = "chkSaints"
        Me.chkSaints.Size = New System.Drawing.Size(55, 17)
        Me.chkSaints.TabIndex = 1
        Me.chkSaints.Text = "Saints"
        Me.chkSaints.UseVisualStyleBackColor = True
        '
        'chkEagles
        '
        Me.chkEagles.AutoSize = True
        Me.chkEagles.Location = New System.Drawing.Point(11, 32)
        Me.chkEagles.Name = "chkEagles"
        Me.chkEagles.Size = New System.Drawing.Size(58, 17)
        Me.chkEagles.TabIndex = 0
        Me.chkEagles.Text = "Eagles"
        Me.chkEagles.UseVisualStyleBackColor = True
        '
        'grpBasketball
        '
        Me.grpBasketball.Controls.Add(Me.chkWarriors)
        Me.grpBasketball.Controls.Add(Me.chkThunder)
        Me.grpBasketball.Controls.Add(Me.chkCeltics)
        Me.grpBasketball.Controls.Add(Me.chkOther)
        Me.grpBasketball.Controls.Add(Me.chk76ers)
        Me.grpBasketball.Controls.Add(Me.chkSpurs)
        Me.grpBasketball.Controls.Add(Me.chkRockets)
        Me.grpBasketball.Controls.Add(Me.chkCavs)
        Me.grpBasketball.Location = New System.Drawing.Point(335, 114)
        Me.grpBasketball.Name = "grpBasketball"
        Me.grpBasketball.Size = New System.Drawing.Size(205, 229)
        Me.grpBasketball.TabIndex = 0
        Me.grpBasketball.TabStop = False
        Me.grpBasketball.Text = "Favorite Basketball Teams"
        '
        'chkWarriors
        '
        Me.chkWarriors.AutoSize = True
        Me.chkWarriors.Location = New System.Drawing.Point(19, 206)
        Me.chkWarriors.Name = "chkWarriors"
        Me.chkWarriors.Size = New System.Drawing.Size(65, 17)
        Me.chkWarriors.TabIndex = 7
        Me.chkWarriors.Text = "Warriors"
        Me.chkWarriors.UseVisualStyleBackColor = True
        '
        'chkThunder
        '
        Me.chkThunder.AutoSize = True
        Me.chkThunder.Location = New System.Drawing.Point(19, 142)
        Me.chkThunder.Name = "chkThunder"
        Me.chkThunder.Size = New System.Drawing.Size(66, 17)
        Me.chkThunder.TabIndex = 6
        Me.chkThunder.Text = "Thunder"
        Me.chkThunder.UseVisualStyleBackColor = True
        '
        'chkCeltics
        '
        Me.chkCeltics.AutoSize = True
        Me.chkCeltics.Location = New System.Drawing.Point(19, 84)
        Me.chkCeltics.Name = "chkCeltics"
        Me.chkCeltics.Size = New System.Drawing.Size(57, 17)
        Me.chkCeltics.TabIndex = 5
        Me.chkCeltics.Text = "Celtics"
        Me.chkCeltics.UseVisualStyleBackColor = True
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Location = New System.Drawing.Point(118, 206)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(52, 17)
        Me.chkOther.TabIndex = 4
        Me.chkOther.Text = "Other"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'chk76ers
        '
        Me.chk76ers.AutoSize = True
        Me.chk76ers.Location = New System.Drawing.Point(118, 142)
        Me.chk76ers.Name = "chk76ers"
        Me.chk76ers.Size = New System.Drawing.Size(52, 17)
        Me.chk76ers.TabIndex = 3
        Me.chk76ers.Text = "76ers"
        Me.chk76ers.UseVisualStyleBackColor = True
        '
        'chkSpurs
        '
        Me.chkSpurs.AutoSize = True
        Me.chkSpurs.Location = New System.Drawing.Point(118, 84)
        Me.chkSpurs.Name = "chkSpurs"
        Me.chkSpurs.Size = New System.Drawing.Size(53, 17)
        Me.chkSpurs.TabIndex = 2
        Me.chkSpurs.Text = "Spurs"
        Me.chkSpurs.UseVisualStyleBackColor = True
        '
        'chkRockets
        '
        Me.chkRockets.AutoSize = True
        Me.chkRockets.Location = New System.Drawing.Point(118, 19)
        Me.chkRockets.Name = "chkRockets"
        Me.chkRockets.Size = New System.Drawing.Size(66, 17)
        Me.chkRockets.TabIndex = 1
        Me.chkRockets.Text = "Rockets"
        Me.chkRockets.UseVisualStyleBackColor = True
        '
        'chkCavs
        '
        Me.chkCavs.AutoSize = True
        Me.chkCavs.Location = New System.Drawing.Point(19, 19)
        Me.chkCavs.Name = "chkCavs"
        Me.chkCavs.Size = New System.Drawing.Size(69, 17)
        Me.chkCavs.TabIndex = 0
        Me.chkCavs.Text = "Cavaliers"
        Me.chkCavs.UseVisualStyleBackColor = True
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.Location = New System.Drawing.Point(225, 372)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(0, 13)
        Me.lblResponse.TabIndex = 8
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.Location = New System.Drawing.Point(188, 51)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(193, 13)
        Me.lblDirections.TabIndex = 9
        Me.lblDirections.Text = "Please select your favorite sports teams"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(552, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "Exit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'frmFavoriteSportsTeams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 449)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.lblResponse)
        Me.Controls.Add(Me.grpBasketball)
        Me.Controls.Add(Me.grpFootball)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFavoriteSportsTeams"
        Me.Text = "Favorite Sports Teams"
        Me.grpFootball.ResumeLayout(False)
        Me.grpFootball.PerformLayout()
        Me.grpBasketball.ResumeLayout(False)
        Me.grpBasketball.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents grpFootball As System.Windows.Forms.GroupBox
    Friend WithEvents grpBasketball As System.Windows.Forms.GroupBox
    Friend WithEvents chkWarriors As System.Windows.Forms.CheckBox
    Friend WithEvents chkThunder As System.Windows.Forms.CheckBox
    Friend WithEvents chkCeltics As System.Windows.Forms.CheckBox
    Friend WithEvents chkOther As System.Windows.Forms.CheckBox
    Friend WithEvents chk76ers As System.Windows.Forms.CheckBox
    Friend WithEvents chkSpurs As System.Windows.Forms.CheckBox
    Friend WithEvents chkRockets As System.Windows.Forms.CheckBox
    Friend WithEvents chkCavs As System.Windows.Forms.CheckBox
    Friend WithEvents chkOther1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkChiefs As System.Windows.Forms.CheckBox
    Friend WithEvents chkJags As System.Windows.Forms.CheckBox
    Friend WithEvents chkVikings As System.Windows.Forms.CheckBox
    Friend WithEvents chkPats As System.Windows.Forms.CheckBox
    Friend WithEvents chkSteelers As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaints As System.Windows.Forms.CheckBox
    Friend WithEvents chkEagles As System.Windows.Forms.CheckBox
    Friend WithEvents lblResponse As System.Windows.Forms.Label
    Friend WithEvents lblDirections As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
