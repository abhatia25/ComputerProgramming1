<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFriends
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
        Me.lblNamePrompt = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnGetInfo = New System.Windows.Forms.Button()
        Me.lblFriendInfo = New System.Windows.Forms.Label()
        Me.picFriendPhoto = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picFriendPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(369, 24)
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
        'lblNamePrompt
        '
        Me.lblNamePrompt.AutoSize = True
        Me.lblNamePrompt.Location = New System.Drawing.Point(12, 34)
        Me.lblNamePrompt.Name = "lblNamePrompt"
        Me.lblNamePrompt.Size = New System.Drawing.Size(142, 13)
        Me.lblNamePrompt.TabIndex = 1
        Me.lblNamePrompt.Text = "Enter the first name of friend:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(160, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(90, 20)
        Me.txtName.TabIndex = 2
        '
        'btnGetInfo
        '
        Me.btnGetInfo.Location = New System.Drawing.Point(282, 29)
        Me.btnGetInfo.Name = "btnGetInfo"
        Me.btnGetInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnGetInfo.TabIndex = 3
        Me.btnGetInfo.Text = "Get Info"
        Me.btnGetInfo.UseVisualStyleBackColor = True
        '
        'lblFriendInfo
        '
        Me.lblFriendInfo.Location = New System.Drawing.Point(12, 78)
        Me.lblFriendInfo.Name = "lblFriendInfo"
        Me.lblFriendInfo.Size = New System.Drawing.Size(168, 174)
        Me.lblFriendInfo.TabIndex = 4
        Me.lblFriendInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picFriendPhoto
        '
        Me.picFriendPhoto.Location = New System.Drawing.Point(227, 102)
        Me.picFriendPhoto.Name = "picFriendPhoto"
        Me.picFriendPhoto.Size = New System.Drawing.Size(100, 100)
        Me.picFriendPhoto.TabIndex = 5
        Me.picFriendPhoto.TabStop = False
        '
        'frmFriends
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 261)
        Me.Controls.Add(Me.picFriendPhoto)
        Me.Controls.Add(Me.lblFriendInfo)
        Me.Controls.Add(Me.btnGetInfo)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblNamePrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFriends"
        Me.Text = "Friends"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picFriendPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNamePrompt As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnGetInfo As Button
    Friend WithEvents lblFriendInfo As Label
    Friend WithEvents picFriendPhoto As PictureBox
End Class
