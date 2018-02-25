<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectCasePractice
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
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstName
        '
        Me.lstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstName.FormattingEnabled = True
        Me.lstName.ItemHeight = 18
        Me.lstName.Items.AddRange(New Object() {"Bryan", "Sam", "Julia", "Robert", "Christian"})
        Me.lstName.Location = New System.Drawing.Point(12, 12)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(496, 112)
        Me.lstName.TabIndex = 0
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(140, 165)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(245, 23)
        Me.btnHello.TabIndex = 1
        Me.btnHello.Text = "Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'frmSelectCasePractice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 200)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.lstName)
        Me.Name = "frmSelectCasePractice"
        Me.Text = "Select Case"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents btnHello As System.Windows.Forms.Button

End Class
