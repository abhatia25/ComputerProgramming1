<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHurricaneWindSpeeds
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
        Me.lblMPHPrompt = New System.Windows.Forms.Label()
        Me.txtMPH = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMPHPrompt
        '
        Me.lblMPHPrompt.AutoSize = True
        Me.lblMPHPrompt.Location = New System.Drawing.Point(12, 40)
        Me.lblMPHPrompt.Name = "lblMPHPrompt"
        Me.lblMPHPrompt.Size = New System.Drawing.Size(177, 13)
        Me.lblMPHPrompt.TabIndex = 0
        Me.lblMPHPrompt.Text = "Please enter a wind speed (In MPH)"
        Me.lblMPHPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMPH
        '
        Me.txtMPH.Location = New System.Drawing.Point(195, 37)
        Me.txtMPH.Name = "txtMPH"
        Me.txtMPH.Size = New System.Drawing.Size(100, 20)
        Me.txtMPH.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(320, 24)
        Me.MenuStrip1.TabIndex = 2
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
        'btnCategory
        '
        Me.btnCategory.Location = New System.Drawing.Point(111, 73)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(75, 23)
        Me.btnCategory.TabIndex = 3
        Me.btnCategory.Text = "Category"
        Me.btnCategory.UseVisualStyleBackColor = True
        '
        'lblCategory
        '
        Me.lblCategory.Location = New System.Drawing.Point(12, 111)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(283, 143)
        Me.lblCategory.TabIndex = 4
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHurricaneWindSpeeds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 298)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.btnCategory)
        Me.Controls.Add(Me.txtMPH)
        Me.Controls.Add(Me.lblMPHPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHurricaneWindSpeeds"
        Me.Text = "Hurricane Wind Speeds"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMPHPrompt As System.Windows.Forms.Label
    Friend WithEvents txtMPH As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCategory As System.Windows.Forms.Button
    Friend WithEvents lblCategory As System.Windows.Forms.Label
End Class
