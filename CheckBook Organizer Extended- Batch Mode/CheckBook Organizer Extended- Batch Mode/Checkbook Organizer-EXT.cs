//Mohamed Khan
//12/24/2012
//Pos 409
//CheckBook Organizer-EXT
//John Becton

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Checkbook_Organizer__BASIC
{
    public partial class CheckbookOrganizer : Form
    {
        public CheckbookOrganizer()
        {
            InitializeComponent();
        }
        private void SetDefaultValues()
        {   // Formats credit, debit, amount boxes to 0
            Currencybx1.Text = Relations.FRMVAL();
            Currencybx2.Text = Relations.FRMVAL();
            Currencybx3.Text = Relations.FRMVAL();
        }

        private void AddBttn1_Click(object sender, EventArgs e)
        {
            //Declare variable
            double startingBalance;

            //Makes sure input is valid format
            if (!Relations.ValBalance(Balancetxt.Text, out startingBalance))
            {
                MessageBox.Show("Invalid Starting Balance, must be decimal or numeric.");
                Balancetxt.Text = string.Empty;
                return;
            }
            else
            {
                //Retrieves and displays beginning balance
                Relations.Acct = startingBalance;
                Currencybx3.Text = Relations.FRMACCT();
                //Clears starting balance after each entry
                Balancetxt.Clear();
                //Disables starting balance group 
                STBalancebox.Enabled = false;
            }

        }

        private void ClrBttn1_Click(object sender, EventArgs e)
        {
            //Clear button for starting balance
            Balancetxt.Clear();

        }

        private void AddBttn2_Click(object sender, EventArgs e)
        {

            //Declare variable
            double transamount;
            Double ID;
            DateTime Date;
            string Description;

            //Columns for DataGrid
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Date";
            dataGridView1.Columns[2].Name = "Type";
            dataGridView1.Columns[3].Name = "Amount";
            dataGridView1.Columns[4].Name = "Description";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            ID = double.Parse(TrnID.Text);
            Date = dateTimePicker1.Value;
            Description = TrnDes.Text;


            //Makes sure input is valid format
            if (!Relations.ValBalance(TrnAmt.Text, out transamount))
            {
                MessageBox.Show("Invalid Starting Balance, must be decimal or numeric.");
                TrnDes.Clear();

                return;
            }
            else
            {
                //First option
                if (OptionsBox.SelectedIndex == 0)
                {
                    //Debit Calculation
                    Relations.DEBIT = System.Convert.ToDouble(TrnAmt.Text);
                    Currencybx2.Text = Relations.FRMDBT();

                    //Display row Information
                    string[] row = new string[] { ID.ToString(), Date.ToString(), "DR", transamount.ToString("C"), Description.ToString() };
                    dataGridView1.Rows.Add(row);
                }

                //Second option
                if (OptionsBox.SelectedIndex == 1)
                {

                    //Credit Calculation
                    Relations.CREDIT = System.Convert.ToDouble(TrnAmt.Text);
                    Currencybx1.Text = Relations.FRMCRD();

                    //Display row Information
                    string[] row = new string[] { ID.ToString(), Date.ToString(), "CR", transamount.ToString("C"), Description.ToString() };
                    dataGridView1.Rows.Add(row);
                }

                //Retrieves Current Balance
                Currencybx3.Text = Relations.FRMACCT();

                //Clears Trans Amt, Des, & ID Box after every entry
                TrnAmt.Clear();
                TrnDes.Clear();
                TrnID.Clear();



            }

        }

        private void StartoverBttn_Click(object sender, EventArgs e)
        {
            //Reset Values
            STBalancebox.Enabled = true;
            Balancesbox.Enabled = false;
            Transactionbox.Enabled = false;
            Balancetxt.Clear();
            TrnID.Clear();
            TrnDes.Clear();
            TrnAmt.Clear();
            Currencybx1.Text = "$0.00";
            Currencybx2.Text = "$0.00";
            Currencybx3.Text = "$0.00";
            dataGridView1.RowCount = 1;
            dataGridView1.Rows.Clear();

        }

        private void ClrBttn2_Click(object sender, EventArgs e)
        {
            //Clear button for trans amt
            TrnDes.Clear();
            TrnID.Clear();
            TrnAmt.Clear();

        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            //Exit
            Application.Exit();
        }

        private void loadBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() != DialogResult.Cancel)
            {

                String sLine = "";

                try
                {
                    //the StreamReader Constructor.
                    System.IO.StreamReader FileStream = new System.IO.StreamReader(OFD.FileName);
                    //You must set the value to false when you are programatically adding rows to
                    //a DataGridView.  
                    dataGridView1.AllowUserToAddRows = false;

                    //Read the first line of the text file
                    sLine = FileStream.ReadLine();

                    //The Split Command splits a string into an array, based on the delimiter you pass.
                    string[] s = sLine.Split(';');


                    //The for loop below is used to create the columns and use the text values in
                    //the first row for the column headings.
                    for (int i = 0; i <= s.Count() - 1; i++)
                    {
                        DataGridViewColumn colHold = new DataGridViewTextBoxColumn();
                        colHold.Name = "col" + System.Convert.ToString(i);
                        colHold.HeaderText = s[i].ToString();
                        dataGridView1.Columns.Add(colHold);
                    }

                    //Read the next line in the text file in order to pass it to the
                    //while loop below
                    sLine = FileStream.ReadLine();

                    //The while loop reads each line of text.
                    while (sLine != null)
                    {
                        //Adds a new row to the DataGridView for each line of text.
                        dataGridView1.Rows.Add();

                        //This for loops through the array in order to retrieve each
                        //line of text.
                        for (int i = 0; i <= s.Count() - 1; i++)
                        {
                            //Splits each line in the text file into a string array
                            s = sLine.Split(';');
                            //Sets the value of the cell to the value of the text retreived from the text file.
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = s[i].ToString();
                        }
                        sLine = FileStream.ReadLine();
                    }
                    //Close the selected text file.
                    FileStream.Close();




                }
                catch (Exception err)
                {
                    //Display any errors in a Message Box.
                    System.Windows.Forms.MessageBox.Show("You must select a batch file to parse " + err.Message, "File Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

        

       

        
    

