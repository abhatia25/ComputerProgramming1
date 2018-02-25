<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColleges
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
        Me.grpColleges = New System.Windows.Forms.GroupBox()
        Me.radCarnegieMellon = New System.Windows.Forms.RadioButton()
        Me.radCalTech = New System.Windows.Forms.RadioButton()
        Me.radUPenn = New System.Windows.Forms.RadioButton()
        Me.radMIT = New System.Windows.Forms.RadioButton()
        Me.radTexas = New System.Windows.Forms.RadioButton()
        Me.radMichigan = New System.Windows.Forms.RadioButton()
        Me.radStanford = New System.Windows.Forms.RadioButton()
        Me.radGeorgiaTech = New System.Windows.Forms.RadioButton()
        Me.lblCollegeInfo = New System.Windows.Forms.Label()
        Me.picMascot = New System.Windows.Forms.PictureBox()
        Me.grpColleges.SuspendLayout()
        CType(Me.picMascot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpColleges
        '
        Me.grpColleges.Controls.Add(Me.radCarnegieMellon)
        Me.grpColleges.Controls.Add(Me.radCalTech)
        Me.grpColleges.Controls.Add(Me.radUPenn)
        Me.grpColleges.Controls.Add(Me.radMIT)
        Me.grpColleges.Controls.Add(Me.radTexas)
        Me.grpColleges.Controls.Add(Me.radMichigan)
        Me.grpColleges.Controls.Add(Me.radStanford)
        Me.grpColleges.Controls.Add(Me.radGeorgiaTech)
        Me.grpColleges.Location = New System.Drawing.Point(12, 12)
        Me.grpColleges.Name = "grpColleges"
        Me.grpColleges.Size = New System.Drawing.Size(237, 222)
        Me.grpColleges.TabIndex = 0
        Me.grpColleges.TabStop = False
        Me.grpColleges.Text = "Select a College"
        '
        'radCarnegieMellon
        '
        Me.radCarnegieMellon.AutoSize = True
        Me.radCarnegieMellon.Location = New System.Drawing.Point(130, 199)
        Me.radCarnegieMellon.Name = "radCarnegieMellon"
        Me.radCarnegieMellon.Size = New System.Drawing.Size(101, 17)
        Me.radCarnegieMellon.TabIndex = 7
        Me.radCarnegieMellon.Text = "Carnegie Mellon"
        Me.radCarnegieMellon.UseVisualStyleBackColor = True
        '
        'radCalTech
        '
        Me.radCalTech.AutoSize = True
        Me.radCalTech.Location = New System.Drawing.Point(130, 138)
        Me.radCalTech.Name = "radCalTech"
        Me.radCalTech.Size = New System.Drawing.Size(68, 17)
        Me.radCalTech.TabIndex = 6
        Me.radCalTech.Text = "Cal Tech"
        Me.radCalTech.UseVisualStyleBackColor = True
        '
        'radUPenn
        '
        Me.radUPenn.AutoSize = True
        Me.radUPenn.Location = New System.Drawing.Point(130, 76)
        Me.radUPenn.Name = "radUPenn"
        Me.radUPenn.Size = New System.Drawing.Size(58, 17)
        Me.radUPenn.TabIndex = 5
        Me.radUPenn.Text = "UPenn"
        Me.radUPenn.UseVisualStyleBackColor = True
        '
        'radMIT
        '
        Me.radMIT.AutoSize = True
        Me.radMIT.Location = New System.Drawing.Point(130, 19)
        Me.radMIT.Name = "radMIT"
        Me.radMIT.Size = New System.Drawing.Size(44, 17)
        Me.radMIT.TabIndex = 4
        Me.radMIT.Text = "MIT"
        Me.radMIT.UseVisualStyleBackColor = True
        '
        'radTexas
        '
        Me.radTexas.AutoSize = True
        Me.radTexas.Location = New System.Drawing.Point(6, 199)
        Me.radTexas.Name = "radTexas"
        Me.radTexas.Size = New System.Drawing.Size(54, 17)
        Me.radTexas.TabIndex = 3
        Me.radTexas.Text = "Texas"
        Me.radTexas.UseVisualStyleBackColor = True
        '
        'radMichigan
        '
        Me.radMichigan.AutoSize = True
        Me.radMichigan.Location = New System.Drawing.Point(6, 138)
        Me.radMichigan.Name = "radMichigan"
        Me.radMichigan.Size = New System.Drawing.Size(68, 17)
        Me.radMichigan.TabIndex = 2
        Me.radMichigan.Text = "Michigan"
        Me.radMichigan.UseVisualStyleBackColor = True
        '
        'radStanford
        '
        Me.radStanford.AutoSize = True
        Me.radStanford.Location = New System.Drawing.Point(6, 76)
        Me.radStanford.Name = "radStanford"
        Me.radStanford.Size = New System.Drawing.Size(65, 17)
        Me.radStanford.TabIndex = 1
        Me.radStanford.Text = "Stanford"
        Me.radStanford.UseVisualStyleBackColor = True
        '
        'radGeorgiaTech
        '
        Me.radGeorgiaTech.AutoSize = True
        Me.radGeorgiaTech.Location = New System.Drawing.Point(6, 19)
        Me.radGeorgiaTech.Name = "radGeorgiaTech"
        Me.radGeorgiaTech.Size = New System.Drawing.Size(90, 17)
        Me.radGeorgiaTech.TabIndex = 0
        Me.radGeorgiaTech.Text = "Georgia Tech"
        Me.radGeorgiaTech.UseVisualStyleBackColor = True
        '
        'lblCollegeInfo
        '
        Me.lblCollegeInfo.Location = New System.Drawing.Point(353, 31)
        Me.lblCollegeInfo.Name = "lblCollegeInfo"
        Me.lblCollegeInfo.Size = New System.Drawing.Size(180, 136)
        Me.lblCollegeInfo.TabIndex = 1
        '
        'picMascot
        '
        Me.picMascot.Location = New System.Drawing.Point(449, 178)
        Me.picMascot.Name = "picMascot"
        Me.picMascot.Size = New System.Drawing.Size(179, 144)
        Me.picMascot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMascot.TabIndex = 2
        Me.picMascot.TabStop = False
        '
        'frmColleges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 359)
        Me.Controls.Add(Me.picMascot)
        Me.Controls.Add(Me.lblCollegeInfo)
        Me.Controls.Add(Me.grpColleges)
        Me.Name = "frmColleges"
        Me.Text = "Colleges"
        Me.grpColleges.ResumeLayout(False)
        Me.grpColleges.PerformLayout()
        CType(Me.picMascot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpColleges As System.Windows.Forms.GroupBox
    Friend WithEvents radCarnegieMellon As System.Windows.Forms.RadioButton
    Friend WithEvents radCalTech As System.Windows.Forms.RadioButton
    Friend WithEvents radUPenn As System.Windows.Forms.RadioButton
    Friend WithEvents radMIT As System.Windows.Forms.RadioButton
    Friend WithEvents radTexas As System.Windows.Forms.RadioButton
    Friend WithEvents radMichigan As System.Windows.Forms.RadioButton
    Friend WithEvents radStanford As System.Windows.Forms.RadioButton
    Friend WithEvents radGeorgiaTech As System.Windows.Forms.RadioButton
    Friend WithEvents lblCollegeInfo As System.Windows.Forms.Label
    Friend WithEvents picMascot As System.Windows.Forms.PictureBox

End Class
