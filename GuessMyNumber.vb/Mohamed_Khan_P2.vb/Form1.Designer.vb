<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GameInstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.mskTxt1 = New System.Windows.Forms.MaskedTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.txtBox3 = New System.Windows.Forms.TextBox
        Me.msktxt2 = New System.Windows.Forms.MaskedTextBox
        Me.msktxt3 = New System.Windows.Forms.MaskedTextBox
        Me.msktxt4 = New System.Windows.Forms.MaskedTextBox
        Me.msktxt5 = New System.Windows.Forms.MaskedTextBox
        Me.msktxt6 = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 137)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(249, 40)
        Me.ProgressBar1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(458, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameInstructionsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GameInstructionsToolStripMenuItem
        '
        Me.GameInstructionsToolStripMenuItem.Name = "GameInstructionsToolStripMenuItem"
        Me.GameInstructionsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.GameInstructionsToolStripMenuItem.Text = "Game Instructions"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 22)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Guess My Number"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(22, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 14)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "Enter Your Guess"
        '
        'mskTxt1
        '
        Me.mskTxt1.Location = New System.Drawing.Point(176, 63)
        Me.mskTxt1.Name = "mskTxt1"
        Me.mskTxt1.Size = New System.Drawing.Size(36, 20)
        Me.mskTxt1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Guess"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(276, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(276, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Show Answer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(276, 154)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtBox3
        '
        Me.txtBox3.BackColor = System.Drawing.SystemColors.Menu
        Me.txtBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBox3.Location = New System.Drawing.Point(372, 32)
        Me.txtBox3.Name = "txtBox3"
        Me.txtBox3.ReadOnly = True
        Me.txtBox3.Size = New System.Drawing.Size(74, 13)
        Me.txtBox3.TabIndex = 9
        Me.txtBox3.Text = "Guess History:"
        '
        'msktxt2
        '
        Me.msktxt2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.msktxt2.Location = New System.Drawing.Point(369, 51)
        Me.msktxt2.Name = "msktxt2"
        Me.msktxt2.ReadOnly = True
        Me.msktxt2.Size = New System.Drawing.Size(77, 13)
        Me.msktxt2.TabIndex = 10
        '
        'msktxt3
        '
        Me.msktxt3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.msktxt3.Location = New System.Drawing.Point(369, 77)
        Me.msktxt3.Name = "msktxt3"
        Me.msktxt3.ReadOnly = True
        Me.msktxt3.Size = New System.Drawing.Size(77, 13)
        Me.msktxt3.TabIndex = 11
        '
        'msktxt4
        '
        Me.msktxt4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.msktxt4.Location = New System.Drawing.Point(369, 103)
        Me.msktxt4.Name = "msktxt4"
        Me.msktxt4.ReadOnly = True
        Me.msktxt4.Size = New System.Drawing.Size(77, 13)
        Me.msktxt4.TabIndex = 12
        '
        'msktxt5
        '
        Me.msktxt5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.msktxt5.Location = New System.Drawing.Point(369, 129)
        Me.msktxt5.Name = "msktxt5"
        Me.msktxt5.ReadOnly = True
        Me.msktxt5.Size = New System.Drawing.Size(77, 13)
        Me.msktxt5.TabIndex = 13
        '
        'msktxt6
        '
        Me.msktxt6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.msktxt6.Location = New System.Drawing.Point(369, 157)
        Me.msktxt6.Name = "msktxt6"
        Me.msktxt6.ReadOnly = True
        Me.msktxt6.Size = New System.Drawing.Size(77, 13)
        Me.msktxt6.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(22, 89)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(165, 13)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(193, 115)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(59, 13)
        Me.TextBox4.TabIndex = 17
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(31, 115)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(156, 13)
        Me.TextBox5.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 189)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.msktxt6)
        Me.Controls.Add(Me.msktxt5)
        Me.Controls.Add(Me.msktxt4)
        Me.Controls.Add(Me.msktxt3)
        Me.Controls.Add(Me.msktxt2)
        Me.Controls.Add(Me.txtBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mskTxt1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Program 2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameInstructionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents mskTxt1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msktxt2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msktxt3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msktxt4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msktxt5 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msktxt6 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox

End Class
