<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTryCatchPractice
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
        Me.lstListBox = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstListBox
        '
        Me.lstListBox.FormattingEnabled = True
        Me.lstListBox.Location = New System.Drawing.Point(12, 12)
        Me.lstListBox.Name = "lstListBox"
        Me.lstListBox.Size = New System.Drawing.Size(160, 238)
        Me.lstListBox.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(178, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(145, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add All"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmTryCatchPractice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 268)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstListBox)
        Me.Name = "frmTryCatchPractice"
        Me.Text = "Try Catch Practice"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstListBox As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button

End Class
