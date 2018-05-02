<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaserRoom
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
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRetry
        '
        Me.btnRetry.BackColor = System.Drawing.Color.Black
        Me.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetry.ForeColor = System.Drawing.Color.White
        Me.btnRetry.Location = New System.Drawing.Point(12, 366)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(132, 43)
        Me.btnRetry.TabIndex = 0
        Me.btnRetry.Text = "Go to Gameover screen"
        Me.btnRetry.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Black
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(712, 366)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(107, 43)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'frmLaserRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Space_Project.My.Resources.Resources.Laser_Room
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 421)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRetry)
        Me.DoubleBuffered = True
        Me.Name = "frmLaserRoom"
        Me.Text = "LaserRoom"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRetry As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
End Class
