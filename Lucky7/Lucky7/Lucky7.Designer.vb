<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLucky7
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
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.lblNumber3 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWinner1 = New System.Windows.Forms.Label()
        Me.lblWinner2 = New System.Windows.Forms.Label()
        Me.lblWinner3 = New System.Windows.Forms.Label()
        Me.picMoney = New System.Windows.Forms.PictureBox()
        CType(Me.picMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSpin
        '
        Me.btnSpin.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSpin.Location = New System.Drawing.Point(12, 12)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(75, 23)
        Me.btnSpin.TabIndex = 0
        Me.btnSpin.Text = "Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnEnd.Location = New System.Drawing.Point(12, 41)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 1
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'lblNumber1
        '
        Me.lblNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumber1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber1.Location = New System.Drawing.Point(141, 9)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(60, 52)
        Me.lblNumber1.TabIndex = 2
        Me.lblNumber1.Text = "0"
        Me.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumber2
        '
        Me.lblNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumber2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber2.Location = New System.Drawing.Point(244, 9)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(62, 52)
        Me.lblNumber2.TabIndex = 3
        Me.lblNumber2.Text = "0"
        Me.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumber3
        '
        Me.lblNumber3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumber3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber3.Location = New System.Drawing.Point(349, 9)
        Me.lblNumber3.Name = "lblNumber3"
        Me.lblNumber3.Size = New System.Drawing.Size(61, 52)
        Me.lblNumber3.TabIndex = 4
        Me.lblNumber3.Text = "0"
        Me.lblNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Purple
        Me.lblTitle.Location = New System.Drawing.Point(12, 80)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(159, 29)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Lucky Seven"
        '
        'lblWinner1
        '
        Me.lblWinner1.AutoSize = True
        Me.lblWinner1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner1.ForeColor = System.Drawing.Color.Lime
        Me.lblWinner1.Location = New System.Drawing.Point(12, 136)
        Me.lblWinner1.Name = "lblWinner1"
        Me.lblWinner1.Size = New System.Drawing.Size(0, 24)
        Me.lblWinner1.TabIndex = 7
        '
        'lblWinner2
        '
        Me.lblWinner2.AutoSize = True
        Me.lblWinner2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner2.ForeColor = System.Drawing.Color.Lime
        Me.lblWinner2.Location = New System.Drawing.Point(13, 176)
        Me.lblWinner2.Name = "lblWinner2"
        Me.lblWinner2.Size = New System.Drawing.Size(0, 24)
        Me.lblWinner2.TabIndex = 8
        '
        'lblWinner3
        '
        Me.lblWinner3.AutoSize = True
        Me.lblWinner3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner3.ForeColor = System.Drawing.Color.Lime
        Me.lblWinner3.Location = New System.Drawing.Point(13, 223)
        Me.lblWinner3.Name = "lblWinner3"
        Me.lblWinner3.Size = New System.Drawing.Size(0, 24)
        Me.lblWinner3.TabIndex = 9
        '
        'picMoney
        '
        Me.picMoney.Image = Global.WindowsApplication1.My.Resources.Resources.PayCoins
        Me.picMoney.Location = New System.Drawing.Point(251, 80)
        Me.picMoney.Name = "picMoney"
        Me.picMoney.Size = New System.Drawing.Size(149, 164)
        Me.picMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMoney.TabIndex = 6
        Me.picMoney.TabStop = False
        Me.picMoney.Visible = False
        '
        'frmLucky7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 256)
        Me.Controls.Add(Me.lblWinner3)
        Me.Controls.Add(Me.lblWinner2)
        Me.Controls.Add(Me.lblWinner1)
        Me.Controls.Add(Me.picMoney)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblNumber3)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.lblNumber1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnSpin)
        Me.Name = "frmLucky7"
        Me.Text = "Lucky Seven"
        CType(Me.picMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSpin As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents lblNumber1 As System.Windows.Forms.Label
    Friend WithEvents lblNumber2 As System.Windows.Forms.Label
    Friend WithEvents lblNumber3 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picMoney As System.Windows.Forms.PictureBox
    Friend WithEvents lblWinner1 As System.Windows.Forms.Label
    Friend WithEvents lblWinner2 As System.Windows.Forms.Label
    Friend WithEvents lblWinner3 As System.Windows.Forms.Label

End Class
