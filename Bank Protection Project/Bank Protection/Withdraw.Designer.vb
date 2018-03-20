<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWithdraw
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
        Me.btnWithdrawSubmit = New System.Windows.Forms.Button()
        Me.txtWithdraw = New System.Windows.Forms.TextBox()
        Me.lblWithdrawPrompt = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.picWelcome = New System.Windows.Forms.PictureBox()
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnWithdrawSubmit
        '
        Me.btnWithdrawSubmit.Location = New System.Drawing.Point(167, 218)
        Me.btnWithdrawSubmit.Name = "btnWithdrawSubmit"
        Me.btnWithdrawSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnWithdrawSubmit.TabIndex = 12
        Me.btnWithdrawSubmit.Text = "Submit"
        Me.btnWithdrawSubmit.UseVisualStyleBackColor = True
        '
        'txtWithdraw
        '
        Me.txtWithdraw.Location = New System.Drawing.Point(214, 177)
        Me.txtWithdraw.Name = "txtWithdraw"
        Me.txtWithdraw.Size = New System.Drawing.Size(134, 20)
        Me.txtWithdraw.TabIndex = 11
        '
        'lblWithdrawPrompt
        '
        Me.lblWithdrawPrompt.Location = New System.Drawing.Point(12, 176)
        Me.lblWithdrawPrompt.Name = "lblWithdrawPrompt"
        Me.lblWithdrawPrompt.Size = New System.Drawing.Size(196, 20)
        Me.lblWithdrawPrompt.TabIndex = 10
        Me.lblWithdrawPrompt.Text = "How much would you like to withdraw?"
        Me.lblWithdrawPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(31, 122)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(347, 43)
        Me.lblWelcome.TabIndex = 9
        Me.lblWelcome.Text = "Welcome to Wells Fargo"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picWelcome
        '
        Me.picWelcome.BackgroundImage = Global.Bank_Protection.My.Resources.Resources.wells_fargo_logo_transparent
        Me.picWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picWelcome.Location = New System.Drawing.Point(148, 15)
        Me.picWelcome.Name = "picWelcome"
        Me.picWelcome.Size = New System.Drawing.Size(108, 87)
        Me.picWelcome.TabIndex = 8
        Me.picWelcome.TabStop = False
        '
        'frmWithdraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 268)
        Me.Controls.Add(Me.btnWithdrawSubmit)
        Me.Controls.Add(Me.txtWithdraw)
        Me.Controls.Add(Me.lblWithdrawPrompt)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picWelcome)
        Me.Name = "frmWithdraw"
        Me.Text = "Withdraw"
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnWithdrawSubmit As System.Windows.Forms.Button
    Friend WithEvents txtWithdraw As System.Windows.Forms.TextBox
    Friend WithEvents lblWithdrawPrompt As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents picWelcome As System.Windows.Forms.PictureBox
End Class
