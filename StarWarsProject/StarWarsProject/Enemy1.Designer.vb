<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnemy1
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picEnemy = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.prgEnemyHealth = New System.Windows.Forms.ProgressBar()
        Me.prgPlayerHealth = New System.Windows.Forms.ProgressBar()
        CType(Me.picEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(447, 427)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'picEnemy
        '
        Me.picEnemy.BackgroundImage = Global.StarWarsProject.My.Resources.Resources.Darth_Vader
        Me.picEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEnemy.Location = New System.Drawing.Point(410, 70)
        Me.picEnemy.Name = "picEnemy"
        Me.picEnemy.Size = New System.Drawing.Size(112, 254)
        Me.picEnemy.TabIndex = 1
        Me.picEnemy.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BackgroundImage = Global.StarWarsProject.My.Resources.Resources.ObiWan
        Me.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPlayer.Location = New System.Drawing.Point(22, 70)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(112, 254)
        Me.picPlayer.TabIndex = 2
        Me.picPlayer.TabStop = False
        '
        'prgEnemyHealth
        '
        Me.prgEnemyHealth.Location = New System.Drawing.Point(410, 41)
        Me.prgEnemyHealth.Name = "prgEnemyHealth"
        Me.prgEnemyHealth.Size = New System.Drawing.Size(112, 23)
        Me.prgEnemyHealth.TabIndex = 3
        '
        'prgPlayerHealth
        '
        Me.prgPlayerHealth.Location = New System.Drawing.Point(22, 41)
        Me.prgPlayerHealth.Name = "prgPlayerHealth"
        Me.prgPlayerHealth.Size = New System.Drawing.Size(112, 23)
        Me.prgPlayerHealth.TabIndex = 4
        '
        'frmEnemy1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.StarWarsProject.My.Resources.Resources.star_wars_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(534, 462)
        Me.Controls.Add(Me.prgPlayerHealth)
        Me.Controls.Add(Me.prgEnemyHealth)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picEnemy)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "frmEnemy1"
        Me.Text = "Enemy 1"
        CType(Me.picEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents picEnemy As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents prgEnemyHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents prgPlayerHealth As System.Windows.Forms.ProgressBar

End Class
