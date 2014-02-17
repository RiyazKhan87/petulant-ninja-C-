Public Class Mohamed_Khan_P3

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub
    'This allows the program to exit from the file menu
    Private Sub EToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EToolStripMenuItem.Click
        Application.Exit()
    End Sub
    'This allows the program to exit from the exit button
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
    'This is the help info menu
    Private Sub HelpInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpInfoToolStripMenuItem.Click
        MsgBox("Program 3" & vbCrLf & "This program displays the box office tools, per movie, for 007 Agents." + "In the Work History Area, you can select one of the employees from the dropdown list to see all Missions and the box office amounts." & vbCrLf & "In the Summary area, you may select one or more check boxes to see the highest average box office take and the employee the average is associated with." & vbCrLf & "You can click on the [Clear] button to reset the window.  ")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Sean Connery" Then
            RichTextBox1.Text = "Year" & vbTab & "Mission" & vbTab & vbTab & vbTab & vbTab & vbTab & "Box Office" & vbNewLine & vbNewLine & "1962" & vbTab & "Dr." & "No" & vbTab & vbTab & vbTab & vbTab & vbTab & "$425,488,741.00" & vbNewLine & "1963" & vbTab & "From Russia with Love" & vbTab & vbTab & vbTab & "$555,909,803.00" & vbNewLine & "1964" & vbTab & "Goldfinger" & vbTab & vbTab & vbTab & vbTab & "$868,659,354.00" & vbNewLine & "1965" & vbTab & "Thunderball" & vbTab & vbTab & vbTab & vbTab & "$966,435,555.00" & vbNewLine & "1967" & vbTab & "You Only Live Twice" & vbTab & vbTab & vbTab & "$720,388,023.00" & vbNewLine & "1971" & vbTab & "Diamonds Are Forever" & vbTab & vbTab & vbTab & "$617,520,987.00"
        End If
        If ComboBox1.SelectedItem = "George Lazenby" Then
            RichTextBox1.Text = "Year" & vbTab & "Mission" & vbTab & vbTab & vbTab & vbTab & vbTab & "Box Office" & vbNewLine & vbNewLine & "1969" & vbTab & "On Her Majesty's Secret Service" & vbTab & vbTab & "$513,445,231.00"
        End If
        If ComboBox1.SelectedItem = "Roger Moore" Then
            RichTextBox1.Text = "Year" & vbTab & "Mission" & vbTab & vbTab & vbTab & vbTab & vbTab & "Box Office" & vbNewLine & vbNewLine & "1973" & vbTab & "Live and Let Die" & vbTab & vbTab & vbTab & vbTab & "$785,677,477.00" & vbNewLine & "1974" & vbTab & "The Man with the Golden Gun" & vbTab & vbTab & vbTab & "$426,826,774.00" & vbNewLine & "1977" & vbTab & "The Spy Who Loved Me" & vbTab & vbTab & vbTab & "$666,367,656.00" & vbNewLine & "1979" & vbTab & "Moonraker" & vbTab & vbTab & vbTab & vbTab & "$624,527,272.00" & vbNewLine & "1981" & vbTab & "Four Your Eyes Only" & vbTab & vbTab & vbTab & "$481,005,579.00" & vbNewLine & "1983" & vbTab & "Octopussy" & vbTab & vbTab & vbTab & vbTab & "$405,873,493.00" & vbNewLine & "1985" & vbTab & "A View to a Kill" & vbTab & vbTab & vbTab & vbTab & "$316,186,616.00"
        End If
        If ComboBox1.SelectedItem = "Timothy Dalton" Then
            RichTextBox1.Text = "Year" & vbTab & "Mission" & vbTab & vbTab & vbTab & vbTab & vbTab & "Box Office" & vbNewLine & vbNewLine & "1987" & vbTab & "The Living Daylights" & vbTab & vbTab & vbTab & "$362,876,056.00" & vbNewLine & "1989" & vbTab & "License to kill" & vbTab & vbTab & vbTab & vbTab & "$271,586,451.00"
        End If
        If ComboBox1.SelectedItem = "Pierce Brosnon" Then
            RichTextBox1.Text = "Year" & vbTab & "Mission" & vbTab & vbTab & vbTab & vbTab & vbTab & "Box Office" & vbNewLine & vbNewLine & "1995" & vbTab & "GoldenEye" & vbTab & vbTab & vbTab & vbTab & "$499,954,330.00" & vbNewLine & "1997" & vbTab & "Tommorow Never Dies" & vbTab & vbTab & vbTab & "$465,588,535.00" & vbNewLine & "1999" & vbTab & "The World Is Not Enough" & vbTab & vbTab & vbTab & "$504,705,882.00" & vbNewLine & "2002" & vbTab & "Die Another Day" & vbTab & vbTab & vbTab & vbTab & "$546,490,272.00"
        End If
        If ComboBox1.SelectedItem = "Daniel Craig" Then
            RichTextBox1.Text = "Year" & vbTab & "Mission" & vbTab & vbTab & vbTab & vbTab & vbTab & "Box Office" & vbNewLine & vbNewLine & "2006" & vbTab & "Casino Royale" & vbTab & vbTab & vbTab & vbTab & "$640,803,677.00" & vbNewLine & "2008" & vbTab & "Quantum of Solace" & vbTab & vbTab & vbTab & vbTab & "$586,090,727.00"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ComboBox1.SelectedItem = Nothing
        RichTextBox1.Clear()
        TextBox12.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then TextBox12.Text = "Sean Connery $692,400,410.50"
        TextBox12.Font = New Font(ListView1.Font, FontStyle.Bold)
        If CheckBox1.CheckState = CheckState.Unchecked Then TextBox12.Clear()
        
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then TextBox12.Text = "George Lazenby $513,445,231.00"
        TextBox12.Font = New Font(ListView1.Font, FontStyle.Bold)
        If CheckBox2.CheckState = CheckState.Unchecked Then TextBox12.Clear()

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.CheckState = CheckState.Checked Then TextBox12.Text = "Roger Moore $529,494,981.00"
        TextBox12.Font = New Font(ListView1.Font, FontStyle.Bold)
        If CheckBox3.CheckState = CheckState.Unchecked Then TextBox12.Clear()

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.CheckState = CheckState.Checked Then TextBox12.Text = "Tomothy Dalton $317,231,253.50"
        TextBox12.Font = New Font(ListView1.Font, FontStyle.Bold)
        If CheckBox4.CheckState = CheckState.Unchecked Then TextBox12.Clear()

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.CheckState = CheckState.Checked Then TextBox12.Text = "Pierce Brosnan $504,184,754.75"
        TextBox12.Font = New Font(ListView1.Font, FontStyle.Bold)
        If CheckBox5.CheckState = CheckState.Unchecked Then TextBox12.Clear()

    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.CheckState = CheckState.Checked Then TextBox12.Text = "Daniel Craig $613,447,202,00"
        TextBox12.Font = New Font(ListView1.Font, FontStyle.Bold)
        If CheckBox6.CheckState = CheckState.Unchecked Then TextBox12.Clear()

    End Sub
End Class
