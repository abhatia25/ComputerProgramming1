<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDone
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
        Me.picBauld = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCongrats = New System.Windows.Forms.Label()
        CType(Me.picBauld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBauld
        '
        Me.picBauld.Image = Global.CasinoFinalProject.My.Resources.Resources.bauld
        Me.picBauld.Location = New System.Drawing.Point(12, 70)
        Me.picBauld.Name = "picBauld"
        Me.picBauld.Size = New System.Drawing.Size(260, 194)
        Me.picBauld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBauld.TabIndex = 0
        Me.picBauld.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblCongrats
        '
        Me.lblCongrats.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCongrats.Location = New System.Drawing.Point(12, 9)
        Me.lblCongrats.Name = "lblCongrats"
        Me.lblCongrats.Size = New System.Drawing.Size(260, 58)
        Me.lblCongrats.TabIndex = 2
        Me.lblCongrats.Text = "Congratulations, you have defeated the Bauld!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmDone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 302)
        Me.Controls.Add(Me.lblCongrats)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picBauld)
        Me.Name = "frmDone"
        Me.Text = "Done"
        CType(Me.picBauld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBauld As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblCongrats As System.Windows.Forms.Label
End Class
