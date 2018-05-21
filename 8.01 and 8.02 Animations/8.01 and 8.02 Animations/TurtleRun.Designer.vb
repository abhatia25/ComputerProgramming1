<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTurtleRun
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTurtleRun))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSlow = New System.Windows.Forms.Button()
        Me.btnFast = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.tmrTurtleSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.picTurtle3 = New System.Windows.Forms.PictureBox()
        Me.picTurtle2 = New System.Windows.Forms.PictureBox()
        Me.picTurtle1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picTurtle3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTurtle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTurtle1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(364, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'btnSlow
        '
        Me.btnSlow.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSlow.Location = New System.Drawing.Point(28, 176)
        Me.btnSlow.Name = "btnSlow"
        Me.btnSlow.Size = New System.Drawing.Size(75, 23)
        Me.btnSlow.TabIndex = 4
        Me.btnSlow.Text = "Slow"
        Me.btnSlow.UseVisualStyleBackColor = False
        '
        'btnFast
        '
        Me.btnFast.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnFast.Location = New System.Drawing.Point(264, 176)
        Me.btnFast.Name = "btnFast"
        Me.btnFast.Size = New System.Drawing.Size(75, 23)
        Me.btnFast.TabIndex = 5
        Me.btnFast.Text = "Fast"
        Me.btnFast.UseVisualStyleBackColor = False
        '
        'btnAverage
        '
        Me.btnAverage.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAverage.Location = New System.Drawing.Point(145, 176)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(75, 23)
        Me.btnAverage.TabIndex = 6
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = False
        '
        'tmrTurtleSpeed
        '
        '
        'picTurtle3
        '
        Me.picTurtle3.Image = CType(resources.GetObject("picTurtle3.Image"), System.Drawing.Image)
        Me.picTurtle3.Location = New System.Drawing.Point(242, 27)
        Me.picTurtle3.Name = "picTurtle3"
        Me.picTurtle3.Size = New System.Drawing.Size(109, 143)
        Me.picTurtle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTurtle3.TabIndex = 3
        Me.picTurtle3.TabStop = False
        Me.picTurtle3.Visible = False
        '
        'picTurtle2
        '
        Me.picTurtle2.Image = CType(resources.GetObject("picTurtle2.Image"), System.Drawing.Image)
        Me.picTurtle2.Location = New System.Drawing.Point(127, 27)
        Me.picTurtle2.Name = "picTurtle2"
        Me.picTurtle2.Size = New System.Drawing.Size(109, 143)
        Me.picTurtle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTurtle2.TabIndex = 2
        Me.picTurtle2.TabStop = False
        Me.picTurtle2.Visible = False
        '
        'picTurtle1
        '
        Me.picTurtle1.Image = Global._8._01_and_8._02_Animations.My.Resources.Resources.turtle
        Me.picTurtle1.Location = New System.Drawing.Point(12, 27)
        Me.picTurtle1.Name = "picTurtle1"
        Me.picTurtle1.Size = New System.Drawing.Size(109, 143)
        Me.picTurtle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTurtle1.TabIndex = 1
        Me.picTurtle1.TabStop = False
        Me.picTurtle1.Visible = False
        '
        'frmTurtleRun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(364, 207)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnFast)
        Me.Controls.Add(Me.btnSlow)
        Me.Controls.Add(Me.picTurtle3)
        Me.Controls.Add(Me.picTurtle2)
        Me.Controls.Add(Me.picTurtle1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTurtleRun"
        Me.Text = "Turtle Run"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picTurtle3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTurtle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTurtle1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picTurtle1 As System.Windows.Forms.PictureBox
    Friend WithEvents picTurtle2 As System.Windows.Forms.PictureBox
    Friend WithEvents picTurtle3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSlow As System.Windows.Forms.Button
    Friend WithEvents btnFast As System.Windows.Forms.Button
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents tmrTurtleSpeed As System.Windows.Forms.Timer
End Class
