<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComboBox
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
        Me.cmbComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnPictureBox = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbComboBox1
        '
        Me.cmbComboBox1.FormattingEnabled = True
        Me.cmbComboBox1.Items.AddRange(New Object() {"Item One", "Item Two", "Item Three", "Item Four", "Item Five"})
        Me.cmbComboBox1.Location = New System.Drawing.Point(130, 144)
        Me.cmbComboBox1.Name = "cmbComboBox1"
        Me.cmbComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.cmbComboBox1.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(155, 217)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnPictureBox
        '
        Me.btnPictureBox.Location = New System.Drawing.Point(155, 29)
        Me.btnPictureBox.Name = "btnPictureBox"
        Me.btnPictureBox.Size = New System.Drawing.Size(75, 23)
        Me.btnPictureBox.TabIndex = 2
        Me.btnPictureBox.Text = "Picture Box"
        Me.btnPictureBox.UseVisualStyleBackColor = True
        '
        'frmComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 381)
        Me.Controls.Add(Me.btnPictureBox)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.cmbComboBox1)
        Me.Name = "frmComboBox"
        Me.Text = "Combo Box"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnPictureBox As System.Windows.Forms.Button

End Class
