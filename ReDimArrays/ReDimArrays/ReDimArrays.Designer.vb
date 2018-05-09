<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReDimArrays
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
        Me.lstArray = New System.Windows.Forms.ListBox()
        Me.btnReDim = New System.Windows.Forms.Button()
        Me.lstNewArray = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstArray
        '
        Me.lstArray.FormattingEnabled = True
        Me.lstArray.Location = New System.Drawing.Point(12, 12)
        Me.lstArray.Name = "lstArray"
        Me.lstArray.Size = New System.Drawing.Size(96, 173)
        Me.lstArray.TabIndex = 0
        '
        'btnReDim
        '
        Me.btnReDim.Location = New System.Drawing.Point(216, 12)
        Me.btnReDim.Name = "btnReDim"
        Me.btnReDim.Size = New System.Drawing.Size(108, 23)
        Me.btnReDim.TabIndex = 1
        Me.btnReDim.Text = "ReDim"
        Me.btnReDim.UseVisualStyleBackColor = True
        '
        'lstNewArray
        '
        Me.lstNewArray.FormattingEnabled = True
        Me.lstNewArray.Location = New System.Drawing.Point(114, 12)
        Me.lstNewArray.Name = "lstNewArray"
        Me.lstNewArray.Size = New System.Drawing.Size(96, 173)
        Me.lstNewArray.TabIndex = 2
        '
        'frmReDimArrays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 208)
        Me.Controls.Add(Me.lstNewArray)
        Me.Controls.Add(Me.btnReDim)
        Me.Controls.Add(Me.lstArray)
        Me.Name = "frmReDimArrays"
        Me.Text = "Re Dim Arrays"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstArray As System.Windows.Forms.ListBox
    Friend WithEvents btnReDim As System.Windows.Forms.Button
    Friend WithEvents lstNewArray As System.Windows.Forms.ListBox

End Class
