<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrayPractice
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
        Me.lstArrays = New System.Windows.Forms.ListBox()
        Me.btnAddArrays = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstArrays
        '
        Me.lstArrays.FormattingEnabled = True
        Me.lstArrays.Location = New System.Drawing.Point(12, 12)
        Me.lstArrays.Name = "lstArrays"
        Me.lstArrays.Size = New System.Drawing.Size(336, 251)
        Me.lstArrays.TabIndex = 0
        '
        'btnAddArrays
        '
        Me.btnAddArrays.Location = New System.Drawing.Point(354, 12)
        Me.btnAddArrays.Name = "btnAddArrays"
        Me.btnAddArrays.Size = New System.Drawing.Size(204, 23)
        Me.btnAddArrays.TabIndex = 1
        Me.btnAddArrays.Text = "Add Array Elements"
        Me.btnAddArrays.UseVisualStyleBackColor = True
        '
        'frmArrayPractice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 278)
        Me.Controls.Add(Me.btnAddArrays)
        Me.Controls.Add(Me.lstArrays)
        Me.Name = "frmArrayPractice"
        Me.Text = "Array Practice"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstArrays As System.Windows.Forms.ListBox
    Friend WithEvents btnAddArrays As System.Windows.Forms.Button

End Class
