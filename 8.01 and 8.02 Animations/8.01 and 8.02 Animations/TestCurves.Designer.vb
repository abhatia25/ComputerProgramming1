<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestCurves
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
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDrawCurve = New System.Windows.Forms.Label()
        Me.lblDrawClosedCurve = New System.Windows.Forms.Label()
        Me.lblFillCurve = New System.Windows.Forms.Label()
        Me.lblDrawPolygon = New System.Windows.Forms.Label()
        Me.lblFillPolygon = New System.Windows.Forms.Label()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NextToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(500, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NextToolStripMenuItem.Text = "&Next"
        '
        'lblDrawCurve
        '
        Me.lblDrawCurve.Location = New System.Drawing.Point(12, 24)
        Me.lblDrawCurve.Name = "lblDrawCurve"
        Me.lblDrawCurve.Size = New System.Drawing.Size(156, 152)
        Me.lblDrawCurve.TabIndex = 1
        Me.lblDrawCurve.Text = "DrawCurve"
        Me.lblDrawCurve.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDrawClosedCurve
        '
        Me.lblDrawClosedCurve.Location = New System.Drawing.Point(174, 24)
        Me.lblDrawClosedCurve.Name = "lblDrawClosedCurve"
        Me.lblDrawClosedCurve.Size = New System.Drawing.Size(156, 152)
        Me.lblDrawClosedCurve.TabIndex = 2
        Me.lblDrawClosedCurve.Text = "DrawClosedCurve"
        Me.lblDrawClosedCurve.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFillCurve
        '
        Me.lblFillCurve.Location = New System.Drawing.Point(336, 24)
        Me.lblFillCurve.Name = "lblFillCurve"
        Me.lblFillCurve.Size = New System.Drawing.Size(156, 152)
        Me.lblFillCurve.TabIndex = 3
        Me.lblFillCurve.Text = "DrawCurve"
        Me.lblFillCurve.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDrawPolygon
        '
        Me.lblDrawPolygon.Location = New System.Drawing.Point(12, 198)
        Me.lblDrawPolygon.Name = "lblDrawPolygon"
        Me.lblDrawPolygon.Size = New System.Drawing.Size(156, 152)
        Me.lblDrawPolygon.TabIndex = 4
        Me.lblDrawPolygon.Text = "DrawPolygon"
        Me.lblDrawPolygon.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFillPolygon
        '
        Me.lblFillPolygon.Location = New System.Drawing.Point(174, 198)
        Me.lblFillPolygon.Name = "lblFillPolygon"
        Me.lblFillPolygon.Size = New System.Drawing.Size(156, 152)
        Me.lblFillPolygon.TabIndex = 5
        Me.lblFillPolygon.Text = "FillPolygon"
        Me.lblFillPolygon.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(382, 271)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(75, 23)
        Me.btnDraw.TabIndex = 6
        Me.btnDraw.Text = "Draw"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'frmTestCurves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 404)
        Me.Controls.Add(Me.btnDraw)
        Me.Controls.Add(Me.lblFillPolygon)
        Me.Controls.Add(Me.lblDrawPolygon)
        Me.Controls.Add(Me.lblFillCurve)
        Me.Controls.Add(Me.lblDrawClosedCurve)
        Me.Controls.Add(Me.lblDrawCurve)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTestCurves"
        Me.Text = "Test Curves"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDrawCurve As System.Windows.Forms.Label
    Friend WithEvents lblDrawClosedCurve As System.Windows.Forms.Label
    Friend WithEvents lblFillCurve As System.Windows.Forms.Label
    Friend WithEvents lblDrawPolygon As System.Windows.Forms.Label
    Friend WithEvents lblFillPolygon As System.Windows.Forms.Label
    Friend WithEvents btnDraw As System.Windows.Forms.Button
End Class
