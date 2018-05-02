<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOver
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
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Location = New System.Drawing.Point(12, 399)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(208, 23)
        Me.btnPlayAgain.TabIndex = 0
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(307, 399)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(208, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Space_Project.My.Resources.Resources.game_over
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(527, 434)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Name = "frmGameOver"
        Me.Text = "Game Over"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPlayAgain As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
