<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForLoop
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnForLoop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(12, 12)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(187, 368)
        Me.lstData.TabIndex = 0
        '
        'btnForLoop
        '
        Me.btnForLoop.Location = New System.Drawing.Point(205, 12)
        Me.btnForLoop.Name = "btnForLoop"
        Me.btnForLoop.Size = New System.Drawing.Size(178, 23)
        Me.btnForLoop.TabIndex = 1
        Me.btnForLoop.Text = "For Loop"
        Me.btnForLoop.UseVisualStyleBackColor = True
        '
        'frmForLoop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 395)
        Me.Controls.Add(Me.btnForLoop)
        Me.Controls.Add(Me.lstData)
        Me.Name = "frmForLoop"
        Me.Text = "For Loop"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents btnForLoop As System.Windows.Forms.Button

End Class
