<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestSounds
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
        Me.btnApplause = New System.Windows.Forms.Button()
        Me.btnAhem = New System.Windows.Forms.Button()
        Me.btnAirRaid = New System.Windows.Forms.Button()
        Me.btnArrow = New System.Windows.Forms.Button()
        Me.btnBabyCrying = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(259, 24)
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
        'btnApplause
        '
        Me.btnApplause.Location = New System.Drawing.Point(12, 27)
        Me.btnApplause.Name = "btnApplause"
        Me.btnApplause.Size = New System.Drawing.Size(75, 23)
        Me.btnApplause.TabIndex = 1
        Me.btnApplause.Text = "Applause"
        Me.btnApplause.UseVisualStyleBackColor = True
        '
        'btnAhem
        '
        Me.btnAhem.Location = New System.Drawing.Point(93, 27)
        Me.btnAhem.Name = "btnAhem"
        Me.btnAhem.Size = New System.Drawing.Size(75, 23)
        Me.btnAhem.TabIndex = 2
        Me.btnAhem.Text = "Ahem"
        Me.btnAhem.UseVisualStyleBackColor = True
        '
        'btnAirRaid
        '
        Me.btnAirRaid.Location = New System.Drawing.Point(174, 27)
        Me.btnAirRaid.Name = "btnAirRaid"
        Me.btnAirRaid.Size = New System.Drawing.Size(75, 23)
        Me.btnAirRaid.TabIndex = 3
        Me.btnAirRaid.Text = "Air Raid"
        Me.btnAirRaid.UseVisualStyleBackColor = True
        '
        'btnArrow
        '
        Me.btnArrow.Location = New System.Drawing.Point(56, 56)
        Me.btnArrow.Name = "btnArrow"
        Me.btnArrow.Size = New System.Drawing.Size(75, 23)
        Me.btnArrow.TabIndex = 4
        Me.btnArrow.Text = "Arrow"
        Me.btnArrow.UseVisualStyleBackColor = True
        '
        'btnBabyCrying
        '
        Me.btnBabyCrying.Location = New System.Drawing.Point(137, 56)
        Me.btnBabyCrying.Name = "btnBabyCrying"
        Me.btnBabyCrying.Size = New System.Drawing.Size(75, 23)
        Me.btnBabyCrying.TabIndex = 5
        Me.btnBabyCrying.Text = "Baby Crying"
        Me.btnBabyCrying.UseVisualStyleBackColor = True
        '
        'frmTestSounds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 89)
        Me.Controls.Add(Me.btnBabyCrying)
        Me.Controls.Add(Me.btnArrow)
        Me.Controls.Add(Me.btnAirRaid)
        Me.Controls.Add(Me.btnAhem)
        Me.Controls.Add(Me.btnApplause)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTestSounds"
        Me.Text = "Test Sounds"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnApplause As Button
    Friend WithEvents btnAhem As Button
    Friend WithEvents btnAirRaid As Button
    Friend WithEvents btnArrow As Button
    Friend WithEvents btnBabyCrying As Button
End Class
