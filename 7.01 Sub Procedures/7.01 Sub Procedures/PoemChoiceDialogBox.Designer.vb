<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoemChoiceDialogBox
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
        Me.grpPoemChoice = New System.Windows.Forms.GroupBox()
        Me.radTwinkleTwinkle = New System.Windows.Forms.RadioButton()
        Me.radFrost = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.grpPoemChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPoemChoice
        '
        Me.grpPoemChoice.Controls.Add(Me.radFrost)
        Me.grpPoemChoice.Controls.Add(Me.radTwinkleTwinkle)
        Me.grpPoemChoice.Location = New System.Drawing.Point(12, 12)
        Me.grpPoemChoice.Name = "grpPoemChoice"
        Me.grpPoemChoice.Size = New System.Drawing.Size(260, 186)
        Me.grpPoemChoice.TabIndex = 0
        Me.grpPoemChoice.TabStop = False
        Me.grpPoemChoice.Text = "Choose a Poem"
        '
        'radTwinkleTwinkle
        '
        Me.radTwinkleTwinkle.AutoSize = True
        Me.radTwinkleTwinkle.Location = New System.Drawing.Point(6, 84)
        Me.radTwinkleTwinkle.Name = "radTwinkleTwinkle"
        Me.radTwinkleTwinkle.Size = New System.Drawing.Size(102, 17)
        Me.radTwinkleTwinkle.TabIndex = 0
        Me.radTwinkleTwinkle.TabStop = True
        Me.radTwinkleTwinkle.Text = "Twinkle Twinkle"
        Me.radTwinkleTwinkle.UseVisualStyleBackColor = True
        '
        'radFrost
        '
        Me.radFrost.AutoSize = True
        Me.radFrost.Location = New System.Drawing.Point(164, 84)
        Me.radFrost.Name = "radFrost"
        Me.radFrost.Size = New System.Drawing.Size(81, 17)
        Me.radFrost.TabIndex = 1
        Me.radFrost.TabStop = True
        Me.radFrost.Text = "Fire and Ice"
        Me.radFrost.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(12, 227)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(260, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmPoemChoiceDialogBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpPoemChoice)
        Me.Name = "frmPoemChoiceDialogBox"
        Me.Text = "Poem Choice Dialog Box"
        Me.grpPoemChoice.ResumeLayout(False)
        Me.grpPoemChoice.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPoemChoice As System.Windows.Forms.GroupBox
    Friend WithEvents radFrost As System.Windows.Forms.RadioButton
    Friend WithEvents radTwinkleTwinkle As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
