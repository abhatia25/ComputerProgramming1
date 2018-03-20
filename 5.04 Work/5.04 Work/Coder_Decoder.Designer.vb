<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoder_Decoder
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
        Me.btnEnterMessage = New System.Windows.Forms.Button()
        Me.grpEncodeDecode = New System.Windows.Forms.GroupBox()
        Me.radDecode = New System.Windows.Forms.RadioButton()
        Me.radEncode = New System.Windows.Forms.RadioButton()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpEncodeDecode.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(346, 24)
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
        'btnEnterMessage
        '
        Me.btnEnterMessage.Location = New System.Drawing.Point(117, 44)
        Me.btnEnterMessage.Name = "btnEnterMessage"
        Me.btnEnterMessage.Size = New System.Drawing.Size(92, 45)
        Me.btnEnterMessage.TabIndex = 1
        Me.btnEnterMessage.Text = "Enter Message"
        Me.btnEnterMessage.UseVisualStyleBackColor = True
        '
        'grpEncodeDecode
        '
        Me.grpEncodeDecode.Controls.Add(Me.radDecode)
        Me.grpEncodeDecode.Controls.Add(Me.radEncode)
        Me.grpEncodeDecode.Location = New System.Drawing.Point(63, 117)
        Me.grpEncodeDecode.Name = "grpEncodeDecode"
        Me.grpEncodeDecode.Size = New System.Drawing.Size(200, 100)
        Me.grpEncodeDecode.TabIndex = 2
        Me.grpEncodeDecode.TabStop = False
        Me.grpEncodeDecode.Text = "Choose One"
        '
        'radDecode
        '
        Me.radDecode.AutoSize = True
        Me.radDecode.Location = New System.Drawing.Point(54, 77)
        Me.radDecode.Name = "radDecode"
        Me.radDecode.Size = New System.Drawing.Size(63, 17)
        Me.radDecode.TabIndex = 1
        Me.radDecode.TabStop = True
        Me.radDecode.Text = "Decode"
        Me.radDecode.UseVisualStyleBackColor = True
        '
        'radEncode
        '
        Me.radEncode.AutoSize = True
        Me.radEncode.Location = New System.Drawing.Point(56, 19)
        Me.radEncode.Name = "radEncode"
        Me.radEncode.Size = New System.Drawing.Size(62, 17)
        Me.radEncode.TabIndex = 0
        Me.radEncode.TabStop = True
        Me.radEncode.Text = "Encode"
        Me.radEncode.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 231)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(322, 101)
        Me.lblAnswer.TabIndex = 2
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCoder_Decoder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 341)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.grpEncodeDecode)
        Me.Controls.Add(Me.btnEnterMessage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCoder_Decoder"
        Me.Text = "Coder/Decoder"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpEncodeDecode.ResumeLayout(False)
        Me.grpEncodeDecode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEnterMessage As System.Windows.Forms.Button
    Friend WithEvents grpEncodeDecode As System.Windows.Forms.GroupBox
    Friend WithEvents radDecode As System.Windows.Forms.RadioButton
    Friend WithEvents radEncode As System.Windows.Forms.RadioButton
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
