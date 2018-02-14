<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventsPractice
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
        Me.btnButton1 = New System.Windows.Forms.Button()
        Me.btnButton2 = New System.Windows.Forms.Button()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnButton1
        '
        Me.btnButton1.Location = New System.Drawing.Point(12, 30)
        Me.btnButton1.Name = "btnButton1"
        Me.btnButton1.Size = New System.Drawing.Size(75, 23)
        Me.btnButton1.TabIndex = 0
        Me.btnButton1.Text = "1"
        Me.btnButton1.UseVisualStyleBackColor = True
        '
        'btnButton2
        '
        Me.btnButton2.Location = New System.Drawing.Point(12, 94)
        Me.btnButton2.Name = "btnButton2"
        Me.btnButton2.Size = New System.Drawing.Size(75, 23)
        Me.btnButton2.TabIndex = 1
        Me.btnButton2.Text = "2"
        Me.btnButton2.UseVisualStyleBackColor = True
        '
        'lblLabel1
        '
        Me.lblLabel1.Location = New System.Drawing.Point(82, 185)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(142, 23)
        Me.lblLabel1.TabIndex = 2
        '
        'EventsPractice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.btnButton2)
        Me.Controls.Add(Me.btnButton1)
        Me.Name = "EventsPractice"
        Me.Text = "Events Practice"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnButton1 As System.Windows.Forms.Button
    Friend WithEvents btnButton2 As System.Windows.Forms.Button
    Friend WithEvents lblLabel1 As System.Windows.Forms.Label

End Class
