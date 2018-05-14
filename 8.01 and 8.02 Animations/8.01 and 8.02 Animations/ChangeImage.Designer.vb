<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeImage
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
        Me.btnStar = New System.Windows.Forms.Button()
        Me.btnClock = New System.Windows.Forms.Button()
        Me.btnHeart = New System.Windows.Forms.Button()
        Me.btnHappyFace = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
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
        'btnStar
        '
        Me.btnStar.Location = New System.Drawing.Point(12, 27)
        Me.btnStar.Name = "btnStar"
        Me.btnStar.Size = New System.Drawing.Size(75, 23)
        Me.btnStar.TabIndex = 1
        Me.btnStar.Tag = "Star"
        Me.btnStar.Text = "Star"
        Me.btnStar.UseVisualStyleBackColor = True
        '
        'btnClock
        '
        Me.btnClock.Location = New System.Drawing.Point(197, 27)
        Me.btnClock.Name = "btnClock"
        Me.btnClock.Size = New System.Drawing.Size(75, 23)
        Me.btnClock.TabIndex = 2
        Me.btnClock.Tag = "Clock"
        Me.btnClock.Text = "Clock"
        Me.btnClock.UseVisualStyleBackColor = True
        '
        'btnHeart
        '
        Me.btnHeart.Location = New System.Drawing.Point(12, 71)
        Me.btnHeart.Name = "btnHeart"
        Me.btnHeart.Size = New System.Drawing.Size(75, 23)
        Me.btnHeart.TabIndex = 3
        Me.btnHeart.Tag = "Heart"
        Me.btnHeart.Text = "Heart"
        Me.btnHeart.UseVisualStyleBackColor = True
        '
        'btnHappyFace
        '
        Me.btnHappyFace.Location = New System.Drawing.Point(197, 71)
        Me.btnHappyFace.Name = "btnHappyFace"
        Me.btnHappyFace.Size = New System.Drawing.Size(75, 23)
        Me.btnHappyFace.TabIndex = 4
        Me.btnHappyFace.Tag = "HappyFace"
        Me.btnHappyFace.Text = "Happy Face"
        Me.btnHappyFace.UseVisualStyleBackColor = True
        '
        'frmChangeImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnHappyFace)
        Me.Controls.Add(Me.btnHeart)
        Me.Controls.Add(Me.btnClock)
        Me.Controls.Add(Me.btnStar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmChangeImage"
        Me.Text = "Change Image"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnStar As Button
    Friend WithEvents btnClock As Button
    Friend WithEvents btnHeart As Button
    Friend WithEvents btnHappyFace As Button
End Class
