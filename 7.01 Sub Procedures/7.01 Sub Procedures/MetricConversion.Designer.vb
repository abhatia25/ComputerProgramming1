<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetricConversion
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNumberPrompt = New System.Windows.Forms.Label()
        Me.btnInToCent = New System.Windows.Forms.Button()
        Me.btnCentToIn = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnFtToCent = New System.Windows.Forms.Button()
        Me.btnYdToMt = New System.Windows.Forms.Button()
        Me.btnMiToKi = New System.Windows.Forms.Button()
        Me.btnKiToMi = New System.Windows.Forms.Button()
        Me.btnMtToYd = New System.Windows.Forms.Button()
        Me.btnCentToFeet = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(306, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'lblNumberPrompt
        '
        Me.lblNumberPrompt.AutoSize = True
        Me.lblNumberPrompt.Location = New System.Drawing.Point(71, 40)
        Me.lblNumberPrompt.Name = "lblNumberPrompt"
        Me.lblNumberPrompt.Size = New System.Drawing.Size(79, 13)
        Me.lblNumberPrompt.TabIndex = 1
        Me.lblNumberPrompt.Text = "Enter a number"
        '
        'btnInToCent
        '
        Me.btnInToCent.Location = New System.Drawing.Point(12, 67)
        Me.btnInToCent.Name = "btnInToCent"
        Me.btnInToCent.Size = New System.Drawing.Size(139, 23)
        Me.btnInToCent.TabIndex = 2
        Me.btnInToCent.Text = "Inches to Centimeters"
        Me.btnInToCent.UseVisualStyleBackColor = True
        '
        'btnCentToIn
        '
        Me.btnCentToIn.Location = New System.Drawing.Point(157, 67)
        Me.btnCentToIn.Name = "btnCentToIn"
        Me.btnCentToIn.Size = New System.Drawing.Size(139, 23)
        Me.btnCentToIn.TabIndex = 3
        Me.btnCentToIn.Text = "Centimeters to Inches"
        Me.btnCentToIn.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(159, 37)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(58, 20)
        Me.txtNumber.TabIndex = 4
        '
        'btnFtToCent
        '
        Me.btnFtToCent.Location = New System.Drawing.Point(12, 96)
        Me.btnFtToCent.Name = "btnFtToCent"
        Me.btnFtToCent.Size = New System.Drawing.Size(139, 23)
        Me.btnFtToCent.TabIndex = 5
        Me.btnFtToCent.Text = "Feet to Centimeters"
        Me.btnFtToCent.UseVisualStyleBackColor = True
        '
        'btnYdToMt
        '
        Me.btnYdToMt.Location = New System.Drawing.Point(12, 125)
        Me.btnYdToMt.Name = "btnYdToMt"
        Me.btnYdToMt.Size = New System.Drawing.Size(139, 23)
        Me.btnYdToMt.TabIndex = 6
        Me.btnYdToMt.Text = "Yards to Meters"
        Me.btnYdToMt.UseVisualStyleBackColor = True
        '
        'btnMiToKi
        '
        Me.btnMiToKi.Location = New System.Drawing.Point(12, 154)
        Me.btnMiToKi.Name = "btnMiToKi"
        Me.btnMiToKi.Size = New System.Drawing.Size(139, 23)
        Me.btnMiToKi.TabIndex = 7
        Me.btnMiToKi.Text = "Miles to Kilometers"
        Me.btnMiToKi.UseVisualStyleBackColor = True
        '
        'btnKiToMi
        '
        Me.btnKiToMi.Location = New System.Drawing.Point(157, 154)
        Me.btnKiToMi.Name = "btnKiToMi"
        Me.btnKiToMi.Size = New System.Drawing.Size(139, 23)
        Me.btnKiToMi.TabIndex = 8
        Me.btnKiToMi.Text = "Kilometers to Miles"
        Me.btnKiToMi.UseVisualStyleBackColor = True
        '
        'btnMtToYd
        '
        Me.btnMtToYd.Location = New System.Drawing.Point(157, 125)
        Me.btnMtToYd.Name = "btnMtToYd"
        Me.btnMtToYd.Size = New System.Drawing.Size(139, 23)
        Me.btnMtToYd.TabIndex = 9
        Me.btnMtToYd.Text = "Meters to Yards"
        Me.btnMtToYd.UseVisualStyleBackColor = True
        '
        'btnCentToFeet
        '
        Me.btnCentToFeet.Location = New System.Drawing.Point(157, 96)
        Me.btnCentToFeet.Name = "btnCentToFeet"
        Me.btnCentToFeet.Size = New System.Drawing.Size(139, 23)
        Me.btnCentToFeet.TabIndex = 10
        Me.btnCentToFeet.Text = "Centimeters to Feet"
        Me.btnCentToFeet.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 196)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(282, 29)
        Me.lblAnswer.TabIndex = 11
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMetricConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 234)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCentToFeet)
        Me.Controls.Add(Me.btnMtToYd)
        Me.Controls.Add(Me.btnKiToMi)
        Me.Controls.Add(Me.btnMiToKi)
        Me.Controls.Add(Me.btnYdToMt)
        Me.Controls.Add(Me.btnFtToCent)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnCentToIn)
        Me.Controls.Add(Me.btnInToCent)
        Me.Controls.Add(Me.lblNumberPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMetricConversion"
        Me.Text = "Metric Conversion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNumberPrompt As Label
    Friend WithEvents btnInToCent As Button
    Friend WithEvents btnCentToIn As Button
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnFtToCent As Button
    Friend WithEvents btnYdToMt As Button
    Friend WithEvents btnMiToKi As Button
    Friend WithEvents btnKiToMi As Button
    Friend WithEvents btnMtToYd As Button
    Friend WithEvents btnCentToFeet As Button
    Friend WithEvents lblAnswer As Label
End Class
