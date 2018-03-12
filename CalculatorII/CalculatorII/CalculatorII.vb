'Aditya Bhatia
'Calculator II
'3/12/2018
Public Class frmCalculatorII
    Dim dblFirstOperand As Double = 0
    Dim dblSecondOperand As Double = 0
    Dim op As String = Nothing
    Dim newOperand As Boolean = True

    Private Sub btnNumber_Click(sender, e) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim btnNumberClicked As Button = sender
        If newOperand Then
            Me.lblAnswer.Text = btnNumberClicked.ToString
            newOperand = False
        Else
            Me.lblAnswer.Text &= btnNumberClicked.ToString
        End If
    End Sub

    Sub btnClear_Click(sender, e)
        Me.lblAnswer.Text = "0"
        dblFirstOperand = 0
        dblSecondOperand = 0
        op = Nothing
        newOperand = True
    End Sub

    Private Sub btnOff_Click(sender As Object, e As EventArgs) Handles btnOff.Click
        End
    End Sub
End Class
