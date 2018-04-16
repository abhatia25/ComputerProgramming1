<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlignmentDialogBox
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
        Me.grpAlignmentOptions = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.radLeft = New System.Windows.Forms.RadioButton()
        Me.radCenter = New System.Windows.Forms.RadioButton()
        Me.radRight = New System.Windows.Forms.RadioButton()
        Me.grpAlignmentOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAlignmentOptions
        '
        Me.grpAlignmentOptions.Controls.Add(Me.radRight)
        Me.grpAlignmentOptions.Controls.Add(Me.radCenter)
        Me.grpAlignmentOptions.Controls.Add(Me.radLeft)
        Me.grpAlignmentOptions.Location = New System.Drawing.Point(12, 12)
        Me.grpAlignmentOptions.Name = "grpAlignmentOptions"
        Me.grpAlignmentOptions.Size = New System.Drawing.Size(286, 224)
        Me.grpAlignmentOptions.TabIndex = 0
        Me.grpAlignmentOptions.TabStop = False
        Me.grpAlignmentOptions.Text = "Choose Alignment"
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(12, 259)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(121, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(177, 259)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(121, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'radLeft
        '
        Me.radLeft.AutoSize = True
        Me.radLeft.Location = New System.Drawing.Point(6, 19)
        Me.radLeft.Name = "radLeft"
        Me.radLeft.Size = New System.Drawing.Size(43, 17)
        Me.radLeft.TabIndex = 0
        Me.radLeft.TabStop = True
        Me.radLeft.Text = "Left"
        Me.radLeft.UseVisualStyleBackColor = True
        '
        'radCenter
        '
        Me.radCenter.AutoSize = True
        Me.radCenter.Location = New System.Drawing.Point(6, 103)
        Me.radCenter.Name = "radCenter"
        Me.radCenter.Size = New System.Drawing.Size(56, 17)
        Me.radCenter.TabIndex = 1
        Me.radCenter.TabStop = True
        Me.radCenter.Text = "Center"
        Me.radCenter.UseVisualStyleBackColor = True
        '
        'radRight
        '
        Me.radRight.AutoSize = True
        Me.radRight.Location = New System.Drawing.Point(6, 186)
        Me.radRight.Name = "radRight"
        Me.radRight.Size = New System.Drawing.Size(50, 17)
        Me.radRight.TabIndex = 2
        Me.radRight.TabStop = True
        Me.radRight.Text = "Right"
        Me.radRight.UseVisualStyleBackColor = True
        '
        'frmAlignmentDialogBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 294)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpAlignmentOptions)
        Me.Name = "frmAlignmentDialogBox"
        Me.Text = "Alignment"
        Me.grpAlignmentOptions.ResumeLayout(False)
        Me.grpAlignmentOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpAlignmentOptions As System.Windows.Forms.GroupBox
    Friend WithEvents radRight As System.Windows.Forms.RadioButton
    Friend WithEvents radCenter As System.Windows.Forms.RadioButton
    Friend WithEvents radLeft As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
