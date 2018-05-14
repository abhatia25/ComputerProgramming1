<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrawAFace
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
        Me.btnHappy = New System.Windows.Forms.Button()
        Me.btnSad = New System.Windows.Forms.Button()
        Me.picFrame = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
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
        'btnHappy
        '
        Me.btnHappy.Location = New System.Drawing.Point(12, 27)
        Me.btnHappy.Name = "btnHappy"
        Me.btnHappy.Size = New System.Drawing.Size(75, 23)
        Me.btnHappy.TabIndex = 1
        Me.btnHappy.Text = "Happy"
        Me.btnHappy.UseVisualStyleBackColor = True
        '
        'btnSad
        '
        Me.btnSad.Location = New System.Drawing.Point(197, 27)
        Me.btnSad.Name = "btnSad"
        Me.btnSad.Size = New System.Drawing.Size(75, 23)
        Me.btnSad.TabIndex = 2
        Me.btnSad.Text = "Sad"
        Me.btnSad.UseVisualStyleBackColor = True
        '
        'picFrame
        '
        Me.picFrame.Location = New System.Drawing.Point(12, 56)
        Me.picFrame.Name = "picFrame"
        Me.picFrame.Size = New System.Drawing.Size(260, 193)
        Me.picFrame.TabIndex = 3
        Me.picFrame.TabStop = False
        '
        'frmDrawAFace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.picFrame)
        Me.Controls.Add(Me.btnSad)
        Me.Controls.Add(Me.btnHappy)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDrawAFace"
        Me.Text = "Draw A Face"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnHappy As Button
    Friend WithEvents btnSad As Button
    Friend WithEvents picFrame As PictureBox
End Class
