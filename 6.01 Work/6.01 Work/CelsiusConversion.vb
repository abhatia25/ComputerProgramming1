'Aditya Bhatia
'Celsius Conversion
'4/19/2018
Public Class frmCelsiusConversion

    Private Sub frmCelciusConversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FTemp As Double
        Dim Celsius As Double
        Dim strFTemp As String
        Dim Prompt As String = "Enter a Fahrenheit temperature."

        Do
            strFTemp = InputBox(Prompt, "Farenheit to Celsius")
            If Double.TryParse(strFTemp, FTemp) Then
                Celsius = Int((FTemp + 40) * 5 / 9 - 40)
                MsgBox(Celsius, , "Temperature in Celsius")
            Else
                MessageBox.Show("Please enter a numeric value")
            End If
        Loop While strFTemp <> ""
        End
    End Sub

    Private Sub EXitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXitToolStripMenuItem.Click
        End
    End Sub
End Class