Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub GameInstructionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameInstructionsToolStripMenuItem.Click
        Dim TextBoxData As String

        TextBoxData = Trim(TextBox1.Text)

        MsgBox("Enter a number between 1 and 900. Select the Guess Button to enter a number, You have 5 guesses before the game ends!Select the Show Answer Button to show the answer and continue playing the game.The Reset button will clear the form and clear previous game history. The Exit will close the program.")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mskTxt1.Clear()
        msktxt2.Clear()
        msktxt3.Clear()
        msktxt4.Clear()
        msktxt5.Clear()
        msktxt6.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If mskTxt1.Text = "" Then TextBox3.Text = "You must input a number!"
        If IsNumeric(mskTxt1.Text) Then msktxt2.Text = CInt(mskTxt1.Text)
        If mskTxt1.Text < Button3.Text Then TextBox3.Text = "Your number is too low"
        If mskTxt1.Text > Button3.Text Then TextBox3.Text = "Your number is too high"


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub msktxt2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles msktxt2.MaskInputRejected
        If mskTxt1.Text < 1 Then

            txtBox3.Text = "Guess must be more than zero!"

        ElseIf mskTxt1.Text > 900 Then

            mskTxt1.Text = "Guess must be less than 901!"

        End If

    End Sub

  
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox5.Text = "Your Random Number Is:"

        Dim rand As New Random

        TextBox4.Text = rand.Next(901)

    End Sub





End Class
