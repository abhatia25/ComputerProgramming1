'Aditya Bhatia
'Click It!
'5/17/2018
Public Class frmClickIt

    Structure Shape
        Dim Image As String
        Dim Points As Integer
    End Structure
    Const intBOXES As Integer = 6
    Const intIMAGES As Integer = 3
    Dim imageArray(intIMAGES - 1) As Shape
    Dim intScore As Integer
    Dim intPicBox As Integer
    Dim intImage As Integer

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmTurtleRun.Show()
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        imageArray(0).Image = "blue_triangle.bmp"
        imageArray(0).Points = 5
        imageArray(1).Image = "red_diamond.bmp"
        imageArray(1).Points = -3
        imageArray(2).Image = "pink_circle.bmp"
        imageArray(2).Points = 10

        Me.btnGo.Enabled = False
        Me.tmrShowShape.Start()
        Me.tmrGameLength.Start()
    End Sub

    Private Sub tmrShowShape_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShowShape.Tick
        Call ClearBoxes()
        Randomize()
        intPicBox = Int(intBOXES * Rnd())
        intImage = Int(intIMAGES * Rnd())
        Call DisplayShape(intPicBox, intImage)
    End Sub

    Sub ClearBoxes()
        Me.picShape0.Image = My.Resources.greensquare
        Me.picShape1.Image = My.Resources.greensquare
        Me.picShape2.Image = My.Resources.greensquare
        Me.picShape3.Image = My.Resources.greensquare
        Me.picshape4.Image = My.Resources.greensquare
        Me.picShape5.Image = My.Resources.greensquare
    End Sub

    Sub DisplayShape(ByVal intSelectedBox As Integer, ByVal intShape As Integer)
        Select Case intSelectedBox
            Case 0
                Me.picShape0.Image = Image.FromFile(imageArray(intShape).Image)
            Case 1
                Me.picShape1.Image = Image.FromFile(imageArray(intShape).Image)
            Case 2
                Me.picShape2.Image = Image.FromFile(imageArray(intShape).Image)
            Case 3
                Me.picShape3.Image = Image.FromFile(imageArray(intShape).Image)
            Case 4
                Me.picshape4.Image = Image.FromFile(imageArray(intShape).Image)
            Case 5
                Me.picShape5.Image = Image.FromFile(imageArray(intShape).Image)
        End Select
    End Sub

    Private Sub tmrGameLength_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGameLength.Tick
        Me.tmrGameLength.Stop()
        Me.tmrShowShape.Stop()
        MessageBox.Show("Score: " & intScore)
    End Sub

    Private Sub PictureClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picShape0.MouseDown, picShape1.MouseDown, picShape2.MouseDown, picShape3.MouseDown, picshape4.MouseDown, picShape5.MouseDown
        Dim picClicked As PictureBox = sender
        If picClicked.Tag = intPicBox Then
            intScore = intScore + imageArray(intImage).Points
        End If
    End Sub
End Class