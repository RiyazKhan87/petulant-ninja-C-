namespace Checkbook_Organizer__BASIC
{
    partial class CheckbookOrganizer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StartoverBttn = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitBttn = new System.Windows.Forms.ToolStripMenuItem();
            this.STBalancebox = new System.Windows.Forms.TextBox();
            this.StartingBalanceLBL = new System.Windows.Forms.Label();
            this.Balancetxt = new System.Windows.Forms.TextBox();
            this.EnterLBL = new System.Windows.Forms.Label();
            this.AddBttn1 = new System.Windows.Forms.Button();
            this.ClrBttn1 = new System.Windows.Forms.Button();
            this.Balancesbox = new System.Windows.Forms.TextBox();
            this.Transactionbox = new System.Windows.Forms.TextBox();
            this.BalanceLBL = new System.Windows.Forms.Label();
            this.TransactionsLBL = new System.Windows.Forms.Label();
            this.CreditLBL = new System.Windows.Forms.Label();
            this.DebitLBL = new System.Windows.Forms.Label();
            this.AccountLBL = new System.Windows.Forms.Label();
            this.Currencybx1 = new System.Windows.Forms.TextBox();
            this.Currencybx2 = new System.Windows.Forms.TextBox();
            this.Currencybx3 = new System.Windows.Forms.TextBox();
            this.TransTLBL = new System.Windows.Forms.Label();
            this.TransALBL = new System.Windows.Forms.Label();
            this.OptionsBox = new System.Windows.Forms.ComboBox();
            this.TrnDes = new System.Windows.Forms.TextBox();
            this.AddBttn2 = new System.Windows.Forms.Button();
            this.ClrBttn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TrnAmt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TrnID = new System.Windows.Forms.TextBox();
            this.LBF = new System.Windows.Forms.ToolStripMenuItem();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartoverBttn,
            this.ExitBttn,
            this.LBF});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StartoverBttn
            // 
            this.StartoverBttn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartoverBttn.Name = "StartoverBttn";
            this.StartoverBttn.Size = new System.Drawing.Size(89, 20);
            this.StartoverBttn.Text = "Start Over";
            this.StartoverBttn.Click += new System.EventHandler(this.StartoverBttn_Click);
            // 
            // ExitBttn
            // 
            this.ExitBttn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBttn.Name = "ExitBttn";
            this.ExitBttn.Size = new System.Drawing.Size(43, 20);
            this.ExitBttn.Text = "Exit";
            this.ExitBttn.Click += new System.EventHandler(this.ExitBttn_Click);
            // 
            // STBalancebox
            // 
            this.STBalancebox.BackColor = System.Drawing.Color.Khaki;
            this.STBalancebox.Location = new System.Drawing.Point(12, 36);
            this.STBalancebox.Multiline = true;
            this.STBalancebox.Name = "STBalancebox";
            this.STBalancebox.Size = new System.Drawing.Size(447, 87);
            this.STBalancebox.TabIndex = 1;
            // 
            // StartingBalanceLBL
            // 
            this.StartingBalanceLBL.AutoSize = true;
            this.StartingBalanceLBL.BackColor = System.Drawing.Color.Khaki;
            this.StartingBalanceLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingBalanceLBL.ForeColor = System.Drawing.Color.Navy;
            this.StartingBalanceLBL.Location = new System.Drawing.Point(23, 39);
            this.StartingBalanceLBL.Name = "StartingBalanceLBL";
            this.StartingBalanceLBL.Size = new System.Drawing.Size(106, 16);
            this.StartingBalanceLBL.TabIndex = 2;
            this.StartingBalanceLBL.Text = "Starting Balance";
            // 
            // Balancetxt
            // 
            this.Balancetxt.Location = new System.Drawing.Point(26, 84);
            this.Balancetxt.Multiline = true;
            this.Balancetxt.Name = "Balancetxt";
            this.Balancetxt.Size = new System.Drawing.Size(95, 22);
            this.Balancetxt.TabIndex = 3;
            // 
            // EnterLBL
            // 
            this.EnterLBL.AutoSize = true;
            this.EnterLBL.BackColor = System.Drawing.Color.Khaki;
            this.EnterLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterLBL.Location = new System.Drawing.Point(23, 63);
            this.EnterLBL.Name = "EnterLBL";
            this.EnterLBL.Size = new System.Drawing.Size(166, 16);
            this.EnterLBL.TabIndex = 4;
            this.EnterLBL.Text = "Enter Starting Balance:";
            // 
            // AddBttn1
            // 
            this.AddBttn1.BackColor = System.Drawing.Color.PaleGreen;
            this.AddBttn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBttn1.Location = new System.Drawing.Point(139, 84);
            this.AddBttn1.Name = "AddBttn1";
            this.AddBttn1.Size = new System.Drawing.Size(75, 23);
            this.AddBttn1.TabIndex = 5;
            this.AddBttn1.Text = "Add";
            this.AddBttn1.UseVisualStyleBackColor = false;
            this.AddBttn1.Click += new System.EventHandler(this.AddBttn1_Click);
            // 
            // ClrBttn1
            // 
            this.ClrBttn1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClrBttn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrBttn1.Location = new System.Drawing.Point(234, 84);
            this.ClrBttn1.Name = "ClrBttn1";
            this.ClrBttn1.Size = new System.Drawing.Size(75, 23);
            this.ClrBttn1.TabIndex = 6;
            this.ClrBttn1.Text = "Clear";
            this.ClrBttn1.UseVisualStyleBackColor = false;
            this.ClrBttn1.Click += new System.EventHandler(this.ClrBttn1_Click);
            // 
            // Balancesbox
            // 
            this.Balancesbox.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Balancesbox.Location = new System.Drawing.Point(12, 129);
            this.Balancesbox.Multiline = true;
            this.Balancesbox.Name = "Balancesbox";
            this.Balancesbox.Size = new System.Drawing.Size(447, 87);
            this.Balancesbox.TabIndex = 7;
            // 
            // Transactionbox
            // 
            this.Transactionbox.BackColor = System.Drawing.Color.Tan;
            this.Transactionbox.Location = new System.Drawing.Point(12, 222);
            this.Transactionbox.Multiline = true;
            this.Transactionbox.Name = "Transactionbox";
            this.Transactionbox.Size = new System.Drawing.Size(447, 134);
            this.Transactionbox.TabIndex = 8;
            // 
            // BalanceLBL
            // 
            this.BalanceLBL.AutoSize = true;
            this.BalanceLBL.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BalanceLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLBL.ForeColor = System.Drawing.Color.Navy;
            this.BalanceLBL.Location = new System.Drawing.Point(23, 130);
            this.BalanceLBL.Name = "BalanceLBL";
            this.BalanceLBL.Size = new System.Drawing.Size(65, 16);
            this.BalanceLBL.TabIndex = 9;
            this.BalanceLBL.Text = "Balances";
            // 
            // TransactionsLBL
            // 
            this.TransactionsLBL.AutoSize = true;
            this.TransactionsLBL.BackColor = System.Drawing.Color.Tan;
            this.TransactionsLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsLBL.ForeColor = System.Drawing.Color.Navy;
            this.TransactionsLBL.Location = new System.Drawing.Point(23, 223);
            this.TransactionsLBL.Name = "TransactionsLBL";
            this.TransactionsLBL.Size = new System.Drawing.Size(86, 16);
            this.TransactionsLBL.TabIndex = 10;
            this.TransactionsLBL.Text = "Transactions";
            // 
            // CreditLBL
            // 
            this.CreditLBL.AutoSize = true;
            this.CreditLBL.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.CreditLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditLBL.Location = new System.Drawing.Point(35, 156);
            this.CreditLBL.Name = "CreditLBL";
            this.CreditLBL.Size = new System.Drawing.Size(64, 16);
            this.CreditLBL.TabIndex = 11;
            this.CreditLBL.Text = "CREDIT";
            // 
            // DebitLBL
            // 
            this.DebitLBL.AutoSize = true;
            this.DebitLBL.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.DebitLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebitLBL.Location = new System.Drawing.Point(125, 156);
            this.DebitLBL.Name = "DebitLBL";
            this.DebitLBL.Size = new System.Drawing.Size(53, 16);
            this.DebitLBL.TabIndex = 12;
            this.DebitLBL.Text = "DEBIT";
            // 
            // AccountLBL
            // 
            this.AccountLBL.AutoSize = true;
            this.AccountLBL.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.AccountLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLBL.Location = new System.Drawing.Point(221, 156);
            this.AccountLBL.Name = "AccountLBL";
            this.AccountLBL.Size = new System.Drawing.Size(81, 16);
            this.AccountLBL.TabIndex = 13;
            this.AccountLBL.Text = "ACCOUNT";
            // 
            // Currencybx1
            // 
            this.Currencybx1.Location = new System.Drawing.Point(26, 177);
            this.Currencybx1.Name = "Currencybx1";
            this.Currencybx1.ReadOnly = true;
            this.Currencybx1.Size = new System.Drawing.Size(49, 20);
            this.Currencybx1.TabIndex = 14;
            // 
            // Currencybx2
            // 
            this.Currencybx2.Location = new System.Drawing.Point(115, 177);
            this.Currencybx2.Name = "Currencybx2";
            this.Currencybx2.ReadOnly = true;
            this.Currencybx2.Size = new System.Drawing.Size(49, 20);
            this.Currencybx2.TabIndex = 15;
            // 
            // Currencybx3
            // 
            this.Currencybx3.Location = new System.Drawing.Point(224, 177);
            this.Currencybx3.Name = "Currencybx3";
            this.Currencybx3.ReadOnly = true;
            this.Currencybx3.Size = new System.Drawing.Size(49, 20);
            this.Currencybx3.TabIndex = 16;
            // 
            // TransTLBL
            // 
            this.TransTLBL.AutoSize = true;
            this.TransTLBL.BackColor = System.Drawing.Color.Tan;
            this.TransTLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransTLBL.ForeColor = System.Drawing.Color.SaddleBrown;
            this.TransTLBL.Location = new System.Drawing.Point(125, 240);
            this.TransTLBL.Name = "TransTLBL";
            this.TransTLBL.Size = new System.Drawing.Size(104, 16);
            this.TransTLBL.TabIndex = 17;
            this.TransTLBL.Text = "TRANS TYPE";
            // 
            // TransALBL
            // 
            this.TransALBL.AutoSize = true;
            this.TransALBL.BackColor = System.Drawing.Color.Tan;
            this.TransALBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransALBL.ForeColor = System.Drawing.Color.SaddleBrown;
            this.TransALBL.Location = new System.Drawing.Point(259, 240);
            this.TransALBL.Name = "TransALBL";
            this.TransALBL.Size = new System.Drawing.Size(96, 16);
            this.TransALBL.TabIndex = 18;
            this.TransALBL.Text = "TRANS AMT";
            // 
            // OptionsBox
            // 
            this.OptionsBox.FormattingEnabled = true;
            this.OptionsBox.Items.AddRange(new object[] {
            "Withdrawal (DR)",
            "Deposit (CR)"});
            this.OptionsBox.Location = new System.Drawing.Point(115, 261);
            this.OptionsBox.Name = "OptionsBox";
            this.OptionsBox.Size = new System.Drawing.Size(121, 21);
            this.OptionsBox.TabIndex = 19;
            // 
            // TrnDes
            // 
            this.TrnDes.Location = new System.Drawing.Point(139, 313);
            this.TrnDes.Multiline = true;
            this.TrnDes.Name = "TrnDes";
            this.TrnDes.Size = new System.Drawing.Size(198, 25);
            this.TrnDes.TabIndex = 20;
            // 
            // AddBttn2
            // 
            this.AddBttn2.BackColor = System.Drawing.Color.PaleGreen;
            this.AddBttn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBttn2.Location = new System.Drawing.Point(361, 261);
            this.AddBttn2.Name = "AddBttn2";
            this.AddBttn2.Size = new System.Drawing.Size(75, 23);
            this.AddBttn2.TabIndex = 21;
            this.AddBttn2.Text = "Add";
            this.AddBttn2.UseVisualStyleBackColor = false;
            this.AddBttn2.Click += new System.EventHandler(this.AddBttn2_Click);
            // 
            // ClrBttn2
            // 
            this.ClrBttn2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClrBttn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrBttn2.Location = new System.Drawing.Point(361, 313);
            this.ClrBttn2.Name = "ClrBttn2";
            this.ClrBttn2.Size = new System.Drawing.Size(75, 23);
            this.ClrBttn2.TabIndex = 22;
            this.ClrBttn2.Text = "Clear";
            this.ClrBttn2.UseVisualStyleBackColor = false;
            this.ClrBttn2.Click += new System.EventHandler(this.ClrBttn2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(23, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "TRANS ID";
            // 
            // TrnAmt
            // 
            this.TrnAmt.Location = new System.Drawing.Point(262, 262);
            this.TrnAmt.Name = "TrnAmt";
            this.TrnAmt.Size = new System.Drawing.Size(75, 20);
            this.TrnAmt.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(143, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "TRANS DESCRIPTION";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 316);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(23, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "TRANS DATE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(468, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 317);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Register";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(461, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // TrnID
            // 
            this.TrnID.Location = new System.Drawing.Point(26, 261);
            this.TrnID.Name = "TrnID";
            this.TrnID.Size = new System.Drawing.Size(75, 20);
            this.TrnID.TabIndex = 30;
            // 
            // LBF
            // 
            this.LBF.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBF.Name = "LBF";
            this.LBF.Size = new System.Drawing.Size(92, 20);
            this.LBF.Text = "Load Batch";
            this.LBF.Click += new System.EventHandler(this.loadBatchToolStripMenuItem_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog";
            // 
            // CheckbookOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(950, 368);
            this.Controls.Add(this.TrnID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrnAmt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClrBttn2);
            this.Controls.Add(this.AddBttn2);
            this.Controls.Add(this.TrnDes);
            this.Controls.Add(this.OptionsBox);
            this.Controls.Add(this.TransALBL);
            this.Controls.Add(this.TransTLBL);
            this.Controls.Add(this.Currencybx3);
            this.Controls.Add(this.Currencybx2);
            this.Controls.Add(this.Currencybx1);
            this.Controls.Add(this.AccountLBL);
            this.Controls.Add(this.DebitLBL);
            this.Controls.Add(this.CreditLBL);
            this.Controls.Add(this.TransactionsLBL);
            this.Controls.Add(this.BalanceLBL);
            this.Controls.Add(this.Transactionbox);
            this.Controls.Add(this.Balancesbox);
            this.Controls.Add(this.ClrBttn1);
            this.Controls.Add(this.AddBttn1);
            this.Controls.Add(this.EnterLBL);
            this.Controls.Add(this.Balancetxt);
            this.Controls.Add(this.StartingBalanceLBL);
            this.Controls.Add(this.STBalancebox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CheckbookOrganizer";
            this.Text = "Checkbook Organizer-BASIC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StartoverBttn;
        private System.Windows.Forms.ToolStripMenuItem ExitBttn;
        private System.Windows.Forms.TextBox STBalancebox;
        private System.Windows.Forms.Label StartingBalanceLBL;
        private System.Windows.Forms.TextBox Balancetxt;
        private System.Windows.Forms.Label EnterLBL;
        private System.Windows.Forms.Button AddBttn1;
        private System.Windows.Forms.Button ClrBttn1;
        private System.Windows.Forms.TextBox Balancesbox;
        private System.Windows.Forms.TextBox Transactionbox;
        private System.Windows.Forms.Label BalanceLBL;
        private System.Windows.Forms.Label TransactionsLBL;
        private System.Windows.Forms.Label CreditLBL;
        private System.Windows.Forms.Label DebitLBL;
        private System.Windows.Forms.Label AccountLBL;
        private System.Windows.Forms.TextBox Currencybx1;
        private System.Windows.Forms.TextBox Currencybx2;
        private System.Windows.Forms.TextBox Currencybx3;
        private System.Windows.Forms.Label TransTLBL;
        private System.Windows.Forms.Label TransALBL;
        private System.Windows.Forms.ComboBox OptionsBox;
        private System.Windows.Forms.TextBox TrnDes;
        private System.Windows.Forms.Button AddBttn2;
        private System.Windows.Forms.Button ClrBttn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TrnAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TrnID;
        private System.Windows.Forms.ToolStripMenuItem LBF;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

