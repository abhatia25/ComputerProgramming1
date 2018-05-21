<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Timer
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrTimeLeft = New System.Windows.Forms.Timer(Me.components)
        Me.prgTimeLeft = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'tmrTimeLeft
        '
        Me.tmrTimeLeft.Interval = 5000
        '
        'prgTimeLeft
        '
        Me.prgTimeLeft.Location = New System.Drawing.Point(12, 12)
        Me.prgTimeLeft.Name = "prgTimeLeft"
        Me.prgTimeLeft.Size = New System.Drawing.Size(467, 207)
        Me.prgTimeLeft.TabIndex = 0
        Me.prgTimeLeft.Value = 100
        '
        'Timer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 231)
        Me.Controls.Add(Me.prgTimeLeft)
        Me.Name = "Timer"
        Me.Text = "Timer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrTimeLeft As System.Windows.Forms.Timer
    Friend WithEvents prgTimeLeft As ProgressBar
End Class
