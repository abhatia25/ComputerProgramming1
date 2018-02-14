<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmButtonpractice
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
        Me.btnStep1 = New System.Windows.Forms.Button()
        Me.btnStep2 = New System.Windows.Forms.Button()
        Me.btnStep3 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblStep1 = New System.Windows.Forms.Label()
        Me.lblStep2 = New System.Windows.Forms.Label()
        Me.lblStep3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStep1
        '
        Me.btnStep1.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnStep1.Cursor = System.Windows.Forms.Cursors.No
        Me.btnStep1.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep1.Location = New System.Drawing.Point(16, 55)
        Me.btnStep1.Name = "btnStep1"
        Me.btnStep1.Size = New System.Drawing.Size(75, 30)
        Me.btnStep1.TabIndex = 0
        Me.btnStep1.Text = "Step 1"
        Me.btnStep1.UseVisualStyleBackColor = False
        '
        'btnStep2
        '
        Me.btnStep2.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnStep2.Cursor = System.Windows.Forms.Cursors.No
        Me.btnStep2.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep2.Location = New System.Drawing.Point(16, 111)
        Me.btnStep2.Name = "btnStep2"
        Me.btnStep2.Size = New System.Drawing.Size(75, 30)
        Me.btnStep2.TabIndex = 1
        Me.btnStep2.Text = "Step 2"
        Me.btnStep2.UseVisualStyleBackColor = False
        '
        'btnStep3
        '
        Me.btnStep3.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnStep3.Cursor = System.Windows.Forms.Cursors.No
        Me.btnStep3.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep3.Location = New System.Drawing.Point(16, 167)
        Me.btnStep3.Name = "btnStep3"
        Me.btnStep3.Size = New System.Drawing.Size(75, 30)
        Me.btnStep3.TabIndex = 2
        Me.btnStep3.Text = "Step 3"
        Me.btnStep3.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.No
        Me.btnClear.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(16, 227)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.No
        Me.btnExit.Font = New System.Drawing.Font("Poor Richard", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(262, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblHeader.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(109, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(147, 28)
        Me.lblHeader.TabIndex = 5
        Me.lblHeader.Text = "Three Steps"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStep1
        '
        Me.lblStep1.AutoSize = True
        Me.lblStep1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep1.Location = New System.Drawing.Point(201, 61)
        Me.lblStep1.Name = "lblStep1"
        Me.lblStep1.Size = New System.Drawing.Size(0, 18)
        Me.lblStep1.TabIndex = 6
        '
        'lblStep2
        '
        Me.lblStep2.AutoSize = True
        Me.lblStep2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep2.Location = New System.Drawing.Point(201, 121)
        Me.lblStep2.Name = "lblStep2"
        Me.lblStep2.Size = New System.Drawing.Size(0, 18)
        Me.lblStep2.TabIndex = 7
        '
        'lblStep3
        '
        Me.lblStep3.AutoSize = True
        Me.lblStep3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep3.Location = New System.Drawing.Point(201, 177)
        Me.lblStep3.Name = "lblStep3"
        Me.lblStep3.Size = New System.Drawing.Size(0, 18)
        Me.lblStep3.TabIndex = 8
        '
        'frmButtonpractice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(384, 362)
        Me.Controls.Add(Me.lblStep3)
        Me.Controls.Add(Me.lblStep2)
        Me.Controls.Add(Me.lblStep1)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStep3)
        Me.Controls.Add(Me.btnStep2)
        Me.Controls.Add(Me.btnStep1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Name = "frmButtonpractice"
        Me.Text = "Three Steps"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStep1 As System.Windows.Forms.Button
    Friend WithEvents btnStep2 As System.Windows.Forms.Button
    Friend WithEvents btnStep3 As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblStep1 As System.Windows.Forms.Label
    Friend WithEvents lblStep2 As System.Windows.Forms.Label
    Friend WithEvents lblStep3 As System.Windows.Forms.Label

End Class
