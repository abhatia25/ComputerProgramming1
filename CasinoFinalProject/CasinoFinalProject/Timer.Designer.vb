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
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrTimeLeft
        '
        Me.tmrTimeLeft.Interval = 10000
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(12, 9)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(467, 213)
        Me.lblTimer.TabIndex = 0
        Me.lblTimer.Text = "00:00:00"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 231)
        Me.Controls.Add(Me.lblTimer)
        Me.Name = "Timer"
        Me.Text = "Timer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrTimeLeft As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As Label
End Class
