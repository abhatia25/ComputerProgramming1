'Aditya Bhatia
'Unlock
'3/21/2018
Public Class frmUnlock
    Dim correctPasscode As Integer
    Dim userEnteredPasscode As Integer
    Dim tries As Integer = 0

    Private Sub btnEnterPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterPassword.Click
        userEnteredPasscode = InputBox("Please enter your password", "User Password", "*****")
        Do While correctPasscode <> userEnteredPasscode
            MessageBox.Show("Password incorrect. Please enter the correct password to unlock", "Password Incorrect")
            tries += 1
            userEnteredPasscode = InputBox("Please enter your password", "User Password", "*****")
        Loop
        MessageBox.Show("Password entered matches actual password. It took you " & tries & " tries.", "Password Correct")
    End Sub

    Private Sub frmUnlock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        correctPasscode = InputBox("Please enter a 5-Digit PIN", "Create Password", "*****")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Have a nice day!")
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        Me.Visible = False
        frmAvgGrade.Visible = True
    End Sub
End Class