<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClickIt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClickIt))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.tmrShowShape = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLength = New System.Windows.Forms.Timer(Me.components)
        Me.picShape5 = New System.Windows.Forms.PictureBox()
        Me.picshape4 = New System.Windows.Forms.PictureBox()
        Me.picShape3 = New System.Windows.Forms.PictureBox()
        Me.picShape2 = New System.Windows.Forms.PictureBox()
        Me.picShape1 = New System.Windows.Forms.PictureBox()
        Me.picShape0 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picShape5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picshape4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(392, 24)
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
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(155, 63)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 7
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'tmrShowShape
        '
        Me.tmrShowShape.Interval = 1000
        '
        'tmrGameLength
        '
        Me.tmrGameLength.Interval = 60000
        '
        'picShape5
        '
        Me.picShape5.Image = CType(resources.GetObject("picShape5.Image"), System.Drawing.Image)
        Me.picShape5.Location = New System.Drawing.Point(322, 27)
        Me.picShape5.Name = "picShape5"
        Me.picShape5.Size = New System.Drawing.Size(56, 30)
        Me.picShape5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape5.TabIndex = 6
        Me.picShape5.TabStop = False
        Me.picShape5.Tag = "5"
        '
        'picshape4
        '
        Me.picshape4.Image = CType(resources.GetObject("picshape4.Image"), System.Drawing.Image)
        Me.picshape4.Location = New System.Drawing.Point(260, 27)
        Me.picshape4.Name = "picshape4"
        Me.picshape4.Size = New System.Drawing.Size(56, 30)
        Me.picshape4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picshape4.TabIndex = 5
        Me.picshape4.TabStop = False
        Me.picshape4.Tag = "4"
        '
        'picShape3
        '
        Me.picShape3.Image = CType(resources.GetObject("picShape3.Image"), System.Drawing.Image)
        Me.picShape3.Location = New System.Drawing.Point(198, 27)
        Me.picShape3.Name = "picShape3"
        Me.picShape3.Size = New System.Drawing.Size(56, 30)
        Me.picShape3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape3.TabIndex = 4
        Me.picShape3.TabStop = False
        Me.picShape3.Tag = "3"
        '
        'picShape2
        '
        Me.picShape2.Image = CType(resources.GetObject("picShape2.Image"), System.Drawing.Image)
        Me.picShape2.Location = New System.Drawing.Point(136, 27)
        Me.picShape2.Name = "picShape2"
        Me.picShape2.Size = New System.Drawing.Size(56, 30)
        Me.picShape2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape2.TabIndex = 3
        Me.picShape2.TabStop = False
        Me.picShape2.Tag = "2"
        '
        'picShape1
        '
        Me.picShape1.Image = CType(resources.GetObject("picShape1.Image"), System.Drawing.Image)
        Me.picShape1.Location = New System.Drawing.Point(74, 27)
        Me.picShape1.Name = "picShape1"
        Me.picShape1.Size = New System.Drawing.Size(56, 30)
        Me.picShape1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape1.TabIndex = 2
        Me.picShape1.TabStop = False
        Me.picShape1.Tag = "1"
        '
        'picShape0
        '
        Me.picShape0.Image = CType(resources.GetObject("picShape0.Image"), System.Drawing.Image)
        Me.picShape0.Location = New System.Drawing.Point(12, 27)
        Me.picShape0.Name = "picShape0"
        Me.picShape0.Size = New System.Drawing.Size(56, 30)
        Me.picShape0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape0.TabIndex = 1
        Me.picShape0.TabStop = False
        Me.picShape0.Tag = "0"
        '
        'frmClickIt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 97)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.picShape5)
        Me.Controls.Add(Me.picshape4)
        Me.Controls.Add(Me.picShape3)
        Me.Controls.Add(Me.picShape2)
        Me.Controls.Add(Me.picShape1)
        Me.Controls.Add(Me.picShape0)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmClickIt"
        Me.Text = "Click It!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picShape5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picshape4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picShape0 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape1 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape2 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape3 As System.Windows.Forms.PictureBox
    Friend WithEvents picshape4 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents tmrShowShape As System.Windows.Forms.Timer
    Friend WithEvents tmrGameLength As System.Windows.Forms.Timer
End Class
