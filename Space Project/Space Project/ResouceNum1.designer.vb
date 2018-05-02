<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResouceNum1
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnLeave = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.White
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Location = New System.Drawing.Point(456, 232)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(111, 33)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go to main Building"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'btnLeave
        '
        Me.btnLeave.BackColor = System.Drawing.Color.White
        Me.btnLeave.Location = New System.Drawing.Point(-1, 390)
        Me.btnLeave.Name = "btnLeave"
        Me.btnLeave.Size = New System.Drawing.Size(824, 32)
        Me.btnLeave.TabIndex = 1
        Me.btnLeave.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(12, 12)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(75, 23)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'frmResouceNum1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Space_Project.My.Resources.Resources.Crystal_Planet
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(821, 421)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnLeave)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "frmResouceNum1"
        Me.Text = "Crystal Planet"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnLeave As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
End Class
