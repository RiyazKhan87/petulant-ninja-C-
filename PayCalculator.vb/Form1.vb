Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtTotal.Text = nudOne.Value * nudTwo.Value
        If nudTwo.Value > 40 Then txtTotal.Text = (nudOne.Value * 40) + (nudOne.Value + 37.5)
        txtTotal2.Text = nudThree.Value * nudFour.Value
        If nudFour.Value > 40 Then txtTotal2.Text = (nudThree.Value * 40) + (nudThree.Value + 26)
        txtTotal3.Text = nudFive.Value * nudSix.Value
        If nudSix.Value > 40 Then txtTotal3.Text = (nudFive.Value * 40) + (nudFive.Value + 40)
        txtTotal4.Text = nudSeven.Value * nudEight.Value
        If nudEight.Value > 40 Then txtTotal4.Text = (nudSeven.Value * 40) + (nudSeven.Value + 30)
        txtTotal5.Text = nudNine.Value * nudTen.Value
        If nudTen.Value > 40 Then txtTotal5.Text = (nudNine.Value * 40) + (nudNine.Value + 42.5)
        txtTotal6.Text = nudEleven.Value * nudTwelve.Value
        If nudTwelve.Value > 40 Then txtTotal6.Text = (nudEleven.Value * 40) + (nudEleven.Value + 7)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtTotal.Clear()
        txtTotal2.Clear()
        txtTotal3.Clear()
        txtTotal4.Clear()
        txtTotal5.Clear()
        txtTotal6.Clear()


    End Sub

    


    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        Dim TextBoxData As String

        TextBoxData = Trim(TextBox1.Text)

        MsgBox("This program is intented to calculate the weekly pay rates for 007 agents. To use this program, simply enter in the number of hours worked for each agent. The program only accepts positive decegers. For example, 5, 28, 40, 45, etc. For 40 hours or less, the program will multiply the Hours Entered by hourly rate shown to calculate weekly pay. For any overtime hours worked, over 40hrs, time and 1/2 will be used, and the weekly pay will turn Green for the agent. The hours Worked will only allow positive integers.")
    End Sub
End Class
