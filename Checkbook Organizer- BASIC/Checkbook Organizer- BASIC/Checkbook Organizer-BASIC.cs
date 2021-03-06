﻿//Mohamed Khan
//12/21/2012
//Pos 409
//CheckBook Organizer
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

            //Makes sure input is valid format
            if (!Relations.ValBalance(TransAmtBox.Text, out transamount))
            
            {
                MessageBox.Show("Invalid Starting Balance, must be decimal or numeric.");
                TransAmtBox.Clear();
                
                return;
            }
            else
            {
                //First option
                if (OptionsBox.SelectedIndex == 0)
                
                {
                    //Debit Calculation
                    Relations.DEBIT = System.Convert.ToDouble(TransAmtBox.Text);
                    Currencybx2.Text = Relations.FRMDBT();
                }
               
                //Second option
                if (OptionsBox.SelectedIndex == 1)
                
                {
                   
                    //Credit Calculation
                    Relations.CREDIT = System.Convert.ToDouble(TransAmtBox.Text);
                    Currencybx1.Text = Relations.FRMCRD();
                }
               
                //Retrieves Current Balance
                Currencybx3.Text = Relations.FRMACCT();
               
                //Clears Trans Amt box after every entry
                TransAmtBox.Clear();


            }

        }

        private void StartoverBttn_Click(object sender, EventArgs e)
        {
            //Reset Values
            STBalancebox.Enabled = true;
            Balancesbox.Enabled = false;
            Transactionbox.Enabled = false;
            Balancetxt.Clear();
            Currencybx1.Text = "$0.00";
            Currencybx2.Text = "$0.00";
            Currencybx3.Text = "$0.00";
            

        }

        private void ClrBttn2_Click(object sender, EventArgs e)
        {
            //Clear button for trans amt
            TransAmtBox.Clear();

        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            //Exit
            Application.Exit();
        }
    }
}


    

        

       

        
    

