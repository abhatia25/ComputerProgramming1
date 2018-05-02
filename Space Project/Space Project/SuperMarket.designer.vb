<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuperMarket
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
        Me.btnNothing = New System.Windows.Forms.Button()
        Me.btnTalk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNothing
        '
        Me.btnNothing.BackColor = System.Drawing.Color.White
        Me.btnNothing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNothing.Location = New System.Drawing.Point(-4, 397)
        Me.btnNothing.Name = "btnNothing"
        Me.btnNothing.Size = New System.Drawing.Size(826, 24)
        Me.btnNothing.TabIndex = 0
        Me.btnNothing.UseVisualStyleBackColor = False
        '
        'btnTalk
        '
        Me.btnTalk.BackColor = System.Drawing.Color.Transparent
        Me.btnTalk.FlatAppearance.BorderSize = 0
        Me.btnTalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTalk.Location = New System.Drawing.Point(462, 102)
        Me.btnTalk.Name = "btnTalk"
        Me.btnTalk.Size = New System.Drawing.Size(179, 137)
        Me.btnTalk.TabIndex = 1
        Me.btnTalk.Text = "Talk"
        Me.btnTalk.UseVisualStyleBackColor = False
        '
        'frmSuperMarket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Space_Project.My.Resources.Resources.Super_Market
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(821, 423)
        Me.Controls.Add(Me.btnTalk)
        Me.Controls.Add(Me.btnNothing)
        Me.Name = "frmSuperMarket"
        Me.Text = "SuperMarket"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNothing As System.Windows.Forms.Button
    Friend WithEvents btnTalk As System.Windows.Forms.Button
End Class
