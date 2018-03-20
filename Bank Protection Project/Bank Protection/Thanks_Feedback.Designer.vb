<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThanksFeedback
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
        Me.grpFeedback = New System.Windows.Forms.GroupBox()
        Me.chkGood = New System.Windows.Forms.CheckBox()
        Me.chkAverage = New System.Windows.Forms.CheckBox()
        Me.chkBad = New System.Windows.Forms.CheckBox()
        Me.btnEndSubmit = New System.Windows.Forms.Button()
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFeedback.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(21, 119)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(347, 43)
        Me.lblWelcome.TabIndex = 11
        Me.lblWelcome.Text = "Welcome to Wells Fargo"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picWelcome
        '
        Me.picWelcome.BackgroundImage = Global.Bank_Protection.My.Resources.Resources.wells_fargo_logo_transparent
        Me.picWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picWelcome.Location = New System.Drawing.Point(138, 12)
        Me.picWelcome.Name = "picWelcome"
        Me.picWelcome.Size = New System.Drawing.Size(108, 87)
        Me.picWelcome.TabIndex = 10
        Me.picWelcome.TabStop = False
        '
        'grpFeedback
        '
        Me.grpFeedback.Controls.Add(Me.chkBad)
        Me.grpFeedback.Controls.Add(Me.chkAverage)
        Me.grpFeedback.Controls.Add(Me.chkGood)
        Me.grpFeedback.Location = New System.Drawing.Point(46, 165)
        Me.grpFeedback.Name = "grpFeedback"
        Me.grpFeedback.Size = New System.Drawing.Size(294, 147)
        Me.grpFeedback.TabIndex = 12
        Me.grpFeedback.TabStop = False
        Me.grpFeedback.Text = "Feedback"
        '
        'chkGood
        '
        Me.chkGood.AutoSize = True
        Me.chkGood.Location = New System.Drawing.Point(6, 70)
        Me.chkGood.Name = "chkGood"
        Me.chkGood.Size = New System.Drawing.Size(52, 17)
        Me.chkGood.TabIndex = 0
        Me.chkGood.Text = "Good"
        Me.chkGood.UseVisualStyleBackColor = True
        '
        'chkAverage
        '
        Me.chkAverage.AutoSize = True
        Me.chkAverage.Location = New System.Drawing.Point(107, 70)
        Me.chkAverage.Name = "chkAverage"
        Me.chkAverage.Size = New System.Drawing.Size(66, 17)
        Me.chkAverage.TabIndex = 1
        Me.chkAverage.Text = "Average"
        Me.chkAverage.UseVisualStyleBackColor = True
        '
        'chkBad
        '
        Me.chkBad.AutoSize = True
        Me.chkBad.Location = New System.Drawing.Point(207, 70)
        Me.chkBad.Name = "chkBad"
        Me.chkBad.Size = New System.Drawing.Size(45, 17)
        Me.chkBad.TabIndex = 2
        Me.chkBad.Text = "Bad"
        Me.chkBad.UseVisualStyleBackColor = True
        '
        'btnEndSubmit
        '
        Me.btnEndSubmit.Location = New System.Drawing.Point(153, 328)
        Me.btnEndSubmit.Name = "btnEndSubmit"
        Me.btnEndSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnEndSubmit.TabIndex = 3
        Me.btnEndSubmit.Text = "Submit"
        Me.btnEndSubmit.UseVisualStyleBackColor = True
        '
        'frmThanksFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 381)
        Me.Controls.Add(Me.btnEndSubmit)
        Me.Controls.Add(Me.grpFeedback)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picWelcome)
        Me.Name = "frmThanksFeedback"
        Me.Text = "Wells Fargo"
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFeedback.ResumeLayout(False)
        Me.grpFeedback.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents picWelcome As System.Windows.Forms.PictureBox
    Friend WithEvents grpFeedback As System.Windows.Forms.GroupBox
    Friend WithEvents chkBad As System.Windows.Forms.CheckBox
    Friend WithEvents chkAverage As System.Windows.Forms.CheckBox
    Friend WithEvents chkGood As System.Windows.Forms.CheckBox
    Friend WithEvents btnEndSubmit As System.Windows.Forms.Button
End Class
