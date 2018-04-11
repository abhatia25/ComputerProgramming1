'Aditya Bhatia
'End Form
'4/9/2018
Public Class frmEnd
    Private Sub frmEnd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'When form loads
        lblCandyCounter.Text = "Candy Counter" & vbCrLf & GlobalVariables.CandyCounter 'Display current candy counter in label
        Randomize() 'Initialize randomizer
        GlobalVariables.ExtraCandyCorrect = Rnd() * 10 'Randomize a value less than 10 and assign it to a variable
        If GlobalVariables.ExtraCandyCorrect = GlobalVariables.ExtraCandyInput Then 'If the user's chosen number matches the random number then 
            MessageBox.Show("You have correctly guessed the magic number, and so you will recieve one extra candy!") 'Display a message box that notifies the user of the outcome
            GlobalVariables.CandyCounter += 1 'Add a candy to the candy counter
            lblCandyCounter.Text = "Candy Counter" & vbCrLf & GlobalVariables.CandyCounter 'display new candy count in label
        Else
            MessageBox.Show("You did not correctly guess the magic number") 'Display a message box that notifies user of outcome
        End If
        lblFinalCandyCount.Text = "Final Candy Count: " & GlobalVariables.CandyCounter & " candies!" 'Show final candy count in label
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End 'Stop the running of the program
    End Sub

    Private Sub btnPlayAgain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlayAgain.Click
        Me.Visible = False 'Hide current form
        GlobalVariables.CandyCounter = 0 'Clear variable
        GlobalVariables.ExtraCandyCorrect = 0
        GlobalVariables.ExtraCandyInput = 0
        GlobalVariables.UserName = Nothing
        frmInstructions.Visible = True 'Show instructions form
    End Sub
End Class