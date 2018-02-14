<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class helloworld
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
        Me.btnButton1 = New System.Windows.Forms.Button()
        Me.mnuMenustrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mnuMenustrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(302, 205)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 20)
        Me.lblMessage.TabIndex = 0
        '
        'btnButton1
        '
        Me.btnButton1.Cursor = System.Windows.Forms.Cursors.No
        Me.btnButton1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton1.Location = New System.Drawing.Point(282, 118)
        Me.btnButton1.Name = "btnButton1"
        Me.btnButton1.Padding = New System.Windows.Forms.Padding(20)
        Me.btnButton1.Size = New System.Drawing.Size(135, 107)
        Me.btnButton1.TabIndex = 1
        Me.btnButton1.Text = "Push Me!"
        Me.btnButton1.UseVisualStyleBackColor = True
        '
        'mnuMenustrip1
        '
        Me.mnuMenustrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.mnuMenustrip1.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenustrip1.Name = "mnuMenustrip1"
        Me.mnuMenustrip1.Size = New System.Drawing.Size(723, 24)
        Me.mnuMenustrip1.TabIndex = 2
        Me.mnuMenustrip1.Text = "Exit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(304, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'helloworld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 407)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnButton1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.mnuMenustrip1)
        Me.MainMenuStrip = Me.mnuMenustrip1
        Me.Name = "helloworld"
        Me.Text = "Message"
        Me.mnuMenustrip1.ResumeLayout(False)
        Me.mnuMenustrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnButton1 As System.Windows.Forms.Button
    Friend WithEvents mnuMenustrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
