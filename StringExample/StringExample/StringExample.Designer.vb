<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStringExample
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
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.txtWord1 = New System.Windows.Forms.TextBox()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.txtWord2 = New System.Windows.Forms.TextBox()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnConcat = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnIndexOf = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnToLower = New System.Windows.Forms.Button()
        Me.btnToUpper = New System.Windows.Forms.Button()
        Me.btnTrimStart = New System.Windows.Forms.Button()
        Me.btnTrimEnd = New System.Windows.Forms.Button()
        Me.btnTrim = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt1
        '
        Me.lblPrompt1.AutoSize = True
        Me.lblPrompt1.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(72, 13)
        Me.lblPrompt1.TabIndex = 0
        Me.lblPrompt1.Text = "Enter a string:"
        '
        'txtWord1
        '
        Me.txtWord1.Location = New System.Drawing.Point(90, 6)
        Me.txtWord1.Name = "txtWord1"
        Me.txtWord1.Size = New System.Drawing.Size(100, 20)
        Me.txtWord1.TabIndex = 1
        '
        'lblPrompt2
        '
        Me.lblPrompt2.AutoSize = True
        Me.lblPrompt2.Location = New System.Drawing.Point(12, 46)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(72, 13)
        Me.lblPrompt2.TabIndex = 2
        Me.lblPrompt2.Text = "Enter a string:"
        '
        'txtWord2
        '
        Me.txtWord2.Location = New System.Drawing.Point(90, 43)
        Me.txtWord2.Name = "txtWord2"
        Me.txtWord2.Size = New System.Drawing.Size(100, 20)
        Me.txtWord2.TabIndex = 3
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(12, 76)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(75, 23)
        Me.btnCompare.TabIndex = 4
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(118, 76)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 5
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnConcat
        '
        Me.btnConcat.Location = New System.Drawing.Point(12, 105)
        Me.btnConcat.Name = "btnConcat"
        Me.btnConcat.Size = New System.Drawing.Size(75, 23)
        Me.btnConcat.TabIndex = 6
        Me.btnConcat.Text = "Concat"
        Me.btnConcat.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Location = New System.Drawing.Point(12, 134)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(75, 23)
        Me.btnEquals.TabIndex = 7
        Me.btnEquals.Text = "Equals"
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnIndexOf
        '
        Me.btnIndexOf.Location = New System.Drawing.Point(12, 163)
        Me.btnIndexOf.Name = "btnIndexOf"
        Me.btnIndexOf.Size = New System.Drawing.Size(75, 23)
        Me.btnIndexOf.TabIndex = 8
        Me.btnIndexOf.Text = "IndexOf"
        Me.btnIndexOf.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(12, 192)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 9
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(12, 221)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnToLower
        '
        Me.btnToLower.Location = New System.Drawing.Point(118, 105)
        Me.btnToLower.Name = "btnToLower"
        Me.btnToLower.Size = New System.Drawing.Size(75, 23)
        Me.btnToLower.TabIndex = 11
        Me.btnToLower.Text = "ToLower"
        Me.btnToLower.UseVisualStyleBackColor = True
        '
        'btnToUpper
        '
        Me.btnToUpper.Location = New System.Drawing.Point(118, 134)
        Me.btnToUpper.Name = "btnToUpper"
        Me.btnToUpper.Size = New System.Drawing.Size(75, 23)
        Me.btnToUpper.TabIndex = 12
        Me.btnToUpper.Text = "ToUpper"
        Me.btnToUpper.UseVisualStyleBackColor = True
        '
        'btnTrimStart
        '
        Me.btnTrimStart.Location = New System.Drawing.Point(118, 221)
        Me.btnTrimStart.Name = "btnTrimStart"
        Me.btnTrimStart.Size = New System.Drawing.Size(75, 23)
        Me.btnTrimStart.TabIndex = 13
        Me.btnTrimStart.Text = "TrimStart"
        Me.btnTrimStart.UseVisualStyleBackColor = True
        '
        'btnTrimEnd
        '
        Me.btnTrimEnd.Location = New System.Drawing.Point(118, 192)
        Me.btnTrimEnd.Name = "btnTrimEnd"
        Me.btnTrimEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnTrimEnd.TabIndex = 14
        Me.btnTrimEnd.Text = "TrimEnd"
        Me.btnTrimEnd.UseVisualStyleBackColor = True
        '
        'btnTrim
        '
        Me.btnTrim.Location = New System.Drawing.Point(118, 163)
        Me.btnTrim.Name = "btnTrim"
        Me.btnTrim.Size = New System.Drawing.Size(75, 23)
        Me.btnTrim.TabIndex = 15
        Me.btnTrim.Text = "Trim"
        Me.btnTrim.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 247)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(181, 63)
        Me.lblAnswer.TabIndex = 16
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStringExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 319)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnTrim)
        Me.Controls.Add(Me.btnTrimEnd)
        Me.Controls.Add(Me.btnTrimStart)
        Me.Controls.Add(Me.btnToUpper)
        Me.Controls.Add(Me.btnToLower)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnIndexOf)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnConcat)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.txtWord2)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.txtWord1)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Name = "frmStringExample"
        Me.Text = "String Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt1 As System.Windows.Forms.Label
    Friend WithEvents txtWord1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPrompt2 As System.Windows.Forms.Label
    Friend WithEvents txtWord2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCompare As System.Windows.Forms.Button
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents btnConcat As System.Windows.Forms.Button
    Friend WithEvents btnEquals As System.Windows.Forms.Button
    Friend WithEvents btnIndexOf As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnToLower As System.Windows.Forms.Button
    Friend WithEvents btnToUpper As System.Windows.Forms.Button
    Friend WithEvents btnTrimStart As System.Windows.Forms.Button
    Friend WithEvents btnTrimEnd As System.Windows.Forms.Button
    Friend WithEvents btnTrim As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
