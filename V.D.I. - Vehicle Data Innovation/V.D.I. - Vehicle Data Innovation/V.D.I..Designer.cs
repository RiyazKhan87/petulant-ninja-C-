namespace V.D.I.__Vehicle_Data_Innovation
{
    partial class VDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateBttn = new System.Windows.Forms.Button();
            this.resultsTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTxtbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalMiles = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.milesdrivenTxtbx = new System.Windows.Forms.MaskedTextBox();
            this.odoTxtbx = new System.Windows.Forms.MaskedTextBox();
            this.gallonsTxt = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gallonsTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateBttn
            // 
            this.calculateBttn.Location = new System.Drawing.Point(97, 319);
            this.calculateBttn.Name = "calculateBttn";
            this.calculateBttn.Size = new System.Drawing.Size(75, 23);
            this.calculateBttn.TabIndex = 2;
            this.calculateBttn.Text = "Calculate";
            this.calculateBttn.UseVisualStyleBackColor = true;
            this.calculateBttn.Click += new System.EventHandler(this.calculateBttn_Click);
            // 
            // resultsTxt
            // 
            this.resultsTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.resultsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultsTxt.Location = new System.Drawing.Point(195, 261);
            this.resultsTxt.Multiline = true;
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.Size = new System.Drawing.Size(91, 20);
            this.resultsTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter miles on ODO before fill-up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter total miles driven since previous fill-up";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(239, 183);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter total number of gallons";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estimated MPG is:";
            // 
            // dateTxtbx
            // 
            this.dateTxtbx.BackColor = System.Drawing.SystemColors.Menu;
            this.dateTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTxtbx.Location = new System.Drawing.Point(302, 261);
            this.dateTxtbx.Multiline = true;
            this.dateTxtbx.Name = "dateTxtbx";
            this.dateTxtbx.Size = new System.Drawing.Size(91, 20);
            this.dateTxtbx.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estimate Days:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total ODO miles on the Engine:";
            // 
            // totalMiles
            // 
            this.totalMiles.BackColor = System.Drawing.SystemColors.Menu;
            this.totalMiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalMiles.Location = new System.Drawing.Point(178, 357);
            this.totalMiles.Name = "totalMiles";
            this.totalMiles.Size = new System.Drawing.Size(100, 13);
            this.totalMiles.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fuel Efficiency";
            // 
            // milesdrivenTxtbx
            // 
            this.milesdrivenTxtbx.Location = new System.Drawing.Point(33, 183);
            this.milesdrivenTxtbx.Name = "milesdrivenTxtbx";
            this.milesdrivenTxtbx.Size = new System.Drawing.Size(100, 20);
            this.milesdrivenTxtbx.TabIndex = 21;
            // 
            // odoTxtbx
            // 
            this.odoTxtbx.Location = new System.Drawing.Point(33, 92);
            this.odoTxtbx.Name = "odoTxtbx";
            this.odoTxtbx.Size = new System.Drawing.Size(100, 20);
            this.odoTxtbx.TabIndex = 22;
            // 
            // gallonsTxt
            // 
            this.gallonsTxt.Location = new System.Drawing.Point(33, 261);
            this.gallonsTxt.Name = "gallonsTxt";
            this.gallonsTxt.Size = new System.Drawing.Size(100, 20);
            this.gallonsTxt.TabIndex = 23;
            // 
            // VDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 379);
            this.Controls.Add(this.gallonsTxt);
            this.Controls.Add(this.odoTxtbx);
            this.Controls.Add(this.milesdrivenTxtbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalMiles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTxtbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultsTxt);
            this.Controls.Add(this.calculateBttn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VDI";
            this.Text = "V.D.I.";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gallonsTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBttn;
        private System.Windows.Forms.TextBox resultsTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dateTxtbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalMiles;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox milesdrivenTxtbx;
        private System.Windows.Forms.MaskedTextBox odoTxtbx;
        private System.Windows.Forms.NumericUpDown gallonsTxt;
    }
}

