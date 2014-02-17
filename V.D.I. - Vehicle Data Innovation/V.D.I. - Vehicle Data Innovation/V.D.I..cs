using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace V.D.I.__Vehicle_Data_Innovation
{
    public partial class VDI : Form
    {
        public VDI()
        {
            InitializeComponent();
        }

        public void ConvertStringDecimal(string stringVal)
        {
            decimal decimalVal = 0;

            try
            {
                decimalVal = System.Convert.ToDecimal(stringVal);
                System.Console.WriteLine(
                    "The string as a decimal is {0}.", decimalVal);
            }
            catch (System.OverflowException)
            {
                System.Console.WriteLine(
                    "The conversion from string to decimal overflowed.");
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine(
                    "The string is not formatted as a decimal.");
            }
            catch (System.ArgumentNullException)
            {
                System.Console.WriteLine(
                    "The string is null.");
            }

            // Decimal to string conversion will not overflow.
            stringVal = System.Convert.ToString(decimalVal);
            System.Console.WriteLine(
                "The decimal as a string is {0}.", stringVal);
        }	
        private void calculateBttn_Click(object sender, EventArgs e)
        {
            
           
            //Calculation for MPG             
            int val1 = Int32.Parse(milesdrivenTxtbx.Text);                     
            int val2 = Int32.Parse(gallonsTxt.Text);
            int result = val1 / val2;

            resultsTxt.Text = result.ToString();




            //Calculation for days
            DateTime StartDate= dateTimePicker1.Value;
            DateTime EndDate = dateTimePicker2.Value;
            TimeSpan span = EndDate - StartDate;

            double daysDiff = span.TotalDays;
            dateTxtbx.Text = daysDiff.ToString();

            //Calculates total miles on engine
            totalMiles.Text = odoTxtbx.Text + milesdrivenTxtbx.Text;

                      
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear all Fields
            odoTxtbx.Text = String.Empty ;
            milesdrivenTxtbx.Text = String.Empty;
            gallonsTxt.Text = String.Empty;
            resultsTxt.Text = string.Empty;
            dateTxtbx.Text = string.Empty;
            totalMiles.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit
            Application.Exit();

        }

      

       

            
        }
    }

