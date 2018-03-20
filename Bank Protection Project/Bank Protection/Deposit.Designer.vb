<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeposit
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.picWelcome = New System.Windows.Forms.PictureBox()
        Me.lblDepositPrompt = New System.Windows.Forms.Label()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.btnDepositSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(25, 119)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(347, 43)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Welcome to Wells Fargo"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picWelcome
        '
        Me.picWelcome.BackgroundImage = Global.Bank_Protection.My.Resources.Resources.wells_fargo_logo_transparent
        Me.picWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picWelcome.Location = New System.Drawing.Point(142, 12)
        Me.picWelcome.Name = "picWelcome"
        Me.picWelcome.Size = New System.Drawing.Size(108, 87)
        Me.picWelcome.TabIndex = 2
        Me.picWelcome.TabStop = False
        '
        'lblDepositPrompt
        '
        Me.lblDepositPrompt.Location = New System.Drawing.Point(12, 173)
        Me.lblDepositPrompt.Name = "lblDepositPrompt"
        Me.lblDepositPrompt.Size = New System.Drawing.Size(190, 20)
        Me.lblDepositPrompt.TabIndex = 5
        Me.lblDepositPrompt.Text = "How much would you like to deposit?"
        Me.lblDepositPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(208, 174)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(134, 20)
        Me.txtDeposit.TabIndex = 6
        '
        'btnDepositSubmit
        '
        Me.btnDepositSubmit.Location = New System.Drawing.Point(161, 215)
        Me.btnDepositSubmit.Name = "btnDepositSubmit"
        Me.btnDepositSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnDepositSubmit.TabIndex = 7
        Me.btnDepositSubmit.Text = "Submit"
        Me.btnDepositSubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Account Balance : $0.00"
        '
        'frmDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 272)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDepositSubmit)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.lblDepositPrompt)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picWelcome)
        Me.Name = "frmDeposit"
        Me.Text = "Deposit"
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents picWelcome As System.Windows.Forms.PictureBox
    Friend WithEvents lblDepositPrompt As System.Windows.Forms.Label
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents btnDepositSubmit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
