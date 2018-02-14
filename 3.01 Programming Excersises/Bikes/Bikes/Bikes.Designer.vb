<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBikes
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
        Me.grpBikeType = New System.Windows.Forms.GroupBox()
        Me.radHybrid = New System.Windows.Forms.RadioButton()
        Me.radMountain = New System.Windows.Forms.RadioButton()
        Me.radRoad = New System.Windows.Forms.RadioButton()
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.chkSeat = New System.Windows.Forms.CheckBox()
        Me.chkFrame = New System.Windows.Forms.CheckBox()
        Me.chkPaint = New System.Windows.Forms.CheckBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.grpBikeType.SuspendLayout()
        Me.grpExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBikeType
        '
        Me.grpBikeType.Controls.Add(Me.radHybrid)
        Me.grpBikeType.Controls.Add(Me.radMountain)
        Me.grpBikeType.Controls.Add(Me.radRoad)
        Me.grpBikeType.Location = New System.Drawing.Point(12, 12)
        Me.grpBikeType.Name = "grpBikeType"
        Me.grpBikeType.Size = New System.Drawing.Size(200, 100)
        Me.grpBikeType.TabIndex = 0
        Me.grpBikeType.TabStop = False
        Me.grpBikeType.Text = "Type of Bike"
        '
        'radHybrid
        '
        Me.radHybrid.AutoSize = True
        Me.radHybrid.Location = New System.Drawing.Point(6, 77)
        Me.radHybrid.Name = "radHybrid"
        Me.radHybrid.Size = New System.Drawing.Size(55, 17)
        Me.radHybrid.TabIndex = 2
        Me.radHybrid.TabStop = True
        Me.radHybrid.Text = "Hybrid"
        Me.radHybrid.UseVisualStyleBackColor = True
        '
        'radMountain
        '
        Me.radMountain.AutoSize = True
        Me.radMountain.Location = New System.Drawing.Point(6, 49)
        Me.radMountain.Name = "radMountain"
        Me.radMountain.Size = New System.Drawing.Size(69, 17)
        Me.radMountain.TabIndex = 1
        Me.radMountain.TabStop = True
        Me.radMountain.Text = "Mountain"
        Me.radMountain.UseVisualStyleBackColor = True
        '
        'radRoad
        '
        Me.radRoad.AutoSize = True
        Me.radRoad.Location = New System.Drawing.Point(6, 22)
        Me.radRoad.Name = "radRoad"
        Me.radRoad.Size = New System.Drawing.Size(51, 17)
        Me.radRoad.TabIndex = 0
        Me.radRoad.TabStop = True
        Me.radRoad.Text = "Road"
        Me.radRoad.UseVisualStyleBackColor = True
        '
        'grpExtras
        '
        Me.grpExtras.Controls.Add(Me.chkSeat)
        Me.grpExtras.Controls.Add(Me.chkFrame)
        Me.grpExtras.Controls.Add(Me.chkPaint)
        Me.grpExtras.Location = New System.Drawing.Point(248, 12)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Size = New System.Drawing.Size(289, 100)
        Me.grpExtras.TabIndex = 0
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Extras"
        '
        'chkSeat
        '
        Me.chkSeat.AutoSize = True
        Me.chkSeat.Location = New System.Drawing.Point(11, 77)
        Me.chkSeat.Name = "chkSeat"
        Me.chkSeat.Size = New System.Drawing.Size(86, 17)
        Me.chkSeat.TabIndex = 2
        Me.chkSeat.Text = "Custom Seat"
        Me.chkSeat.UseVisualStyleBackColor = True
        '
        'chkFrame
        '
        Me.chkFrame.AutoSize = True
        Me.chkFrame.Location = New System.Drawing.Point(11, 49)
        Me.chkFrame.Name = "chkFrame"
        Me.chkFrame.Size = New System.Drawing.Size(114, 17)
        Me.chkFrame.TabIndex = 1
        Me.chkFrame.Text = "Heavy Duty Frame"
        Me.chkFrame.UseVisualStyleBackColor = True
        '
        'chkPaint
        '
        Me.chkPaint.AutoSize = True
        Me.chkPaint.Location = New System.Drawing.Point(11, 22)
        Me.chkPaint.Name = "chkPaint"
        Me.chkPaint.Size = New System.Drawing.Size(88, 17)
        Me.chkPaint.TabIndex = 0
        Me.chkPaint.Text = "Custom Paint"
        Me.chkPaint.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Goudy Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(12, 132)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(525, 61)
        Me.btnAbout.TabIndex = 1
        Me.btnAbout.Text = "About the Bike Shop"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 223)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(525, 203)
        Me.lblInfo.TabIndex = 2
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBikes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 447)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.grpExtras)
        Me.Controls.Add(Me.grpBikeType)
        Me.Name = "frmBikes"
        Me.Text = "Bike Shop"
        Me.grpBikeType.ResumeLayout(False)
        Me.grpBikeType.PerformLayout()
        Me.grpExtras.ResumeLayout(False)
        Me.grpExtras.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBikeType As System.Windows.Forms.GroupBox
    Friend WithEvents radHybrid As System.Windows.Forms.RadioButton
    Friend WithEvents radMountain As System.Windows.Forms.RadioButton
    Friend WithEvents radRoad As System.Windows.Forms.RadioButton
    Friend WithEvents grpExtras As System.Windows.Forms.GroupBox
    Friend WithEvents chkSeat As System.Windows.Forms.CheckBox
    Friend WithEvents chkFrame As System.Windows.Forms.CheckBox
    Friend WithEvents chkPaint As System.Windows.Forms.CheckBox
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label

End Class
