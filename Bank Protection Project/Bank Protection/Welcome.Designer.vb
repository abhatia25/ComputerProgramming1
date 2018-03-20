<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.mtxAccountNumber = New System.Windows.Forms.MaskedTextBox()
        Me.mtxPin = New System.Windows.Forms.MaskedTextBox()
        Me.lblAccountNumberPrompt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.radDeposit = New System.Windows.Forms.RadioButton()
        Me.radWithdraw = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.picWelcome = New System.Windows.Forms.PictureBox()
        Me.grpOptions.SuspendLayout()
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 119)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(347, 43)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome to Wells Fargo"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mtxAccountNumber
        '
        Me.mtxAccountNumber.Location = New System.Drawing.Point(184, 165)
        Me.mtxAccountNumber.Mask = "000000000"
        Me.mtxAccountNumber.Name = "mtxAccountNumber"
        Me.mtxAccountNumber.Size = New System.Drawing.Size(100, 20)
        Me.mtxAccountNumber.TabIndex = 2
        '
        'mtxPin
        '
        Me.mtxPin.Location = New System.Drawing.Point(184, 191)
        Me.mtxPin.Mask = "00000"
        Me.mtxPin.Name = "mtxPin"
        Me.mtxPin.Size = New System.Drawing.Size(100, 20)
        Me.mtxPin.TabIndex = 3
        Me.mtxPin.ValidatingType = GetType(Integer)
        '
        'lblAccountNumberPrompt
        '
        Me.lblAccountNumberPrompt.Location = New System.Drawing.Point(40, 165)
        Me.lblAccountNumberPrompt.Name = "lblAccountNumberPrompt"
        Me.lblAccountNumberPrompt.Size = New System.Drawing.Size(138, 20)
        Me.lblAccountNumberPrompt.TabIndex = 4
        Me.lblAccountNumberPrompt.Text = "Account Number"
        Me.lblAccountNumberPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.radDeposit)
        Me.grpOptions.Controls.Add(Me.radWithdraw)
        Me.grpOptions.Location = New System.Drawing.Point(57, 229)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(250, 100)
        Me.grpOptions.TabIndex = 6
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "What would you like to do?"
        '
        'radDeposit
        '
        Me.radDeposit.AutoSize = True
        Me.radDeposit.Location = New System.Drawing.Point(72, 77)
        Me.radDeposit.Name = "radDeposit"
        Me.radDeposit.Size = New System.Drawing.Size(96, 17)
        Me.radDeposit.TabIndex = 1
        Me.radDeposit.TabStop = True
        Me.radDeposit.Text = "Deposit Money"
        Me.radDeposit.UseVisualStyleBackColor = True
        '
        'radWithdraw
        '
        Me.radWithdraw.AutoSize = True
        Me.radWithdraw.Location = New System.Drawing.Point(72, 19)
        Me.radWithdraw.Name = "radWithdraw"
        Me.radWithdraw.Size = New System.Drawing.Size(105, 17)
        Me.radWithdraw.TabIndex = 0
        Me.radWithdraw.TabStop = True
        Me.radWithdraw.Text = "Withdraw Money"
        Me.radWithdraw.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(150, 335)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'picWelcome
        '
        Me.picWelcome.BackgroundImage = Global.Bank_Protection.My.Resources.Resources.wells_fargo_logo_transparent
        Me.picWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picWelcome.Location = New System.Drawing.Point(129, 12)
        Me.picWelcome.Name = "picWelcome"
        Me.picWelcome.Size = New System.Drawing.Size(108, 87)
        Me.picWelcome.TabIndex = 0
        Me.picWelcome.TabStop = False
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 367)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAccountNumberPrompt)
        Me.Controls.Add(Me.mtxPin)
        Me.Controls.Add(Me.mtxAccountNumber)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picWelcome)
        Me.Name = "frmWelcome"
        Me.Text = "Welcome to Wells Fargo"
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picWelcome As System.Windows.Forms.PictureBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents mtxAccountNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxPin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAccountNumberPrompt As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpOptions As System.Windows.Forms.GroupBox
    Friend WithEvents radDeposit As System.Windows.Forms.RadioButton
    Friend WithEvents radWithdraw As System.Windows.Forms.RadioButton
    Friend WithEvents btnSubmit As System.Windows.Forms.Button

End Class
