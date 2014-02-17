using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Checkbook_Organizer__BASIC
{
    class Relations
    {
        private static double credit;
        private static double debit;
        private static double acct;

        public static Double CREDIT
        {
           set
            {
                Acct += value;
                credit += value;
                
            }
        }

        public static double DEBIT
        {
           set
            {
                 Acct -= value;
                debit -= value;
            }
        }

        public static double Acct
        {
            get
            {
                return acct;
            }
            set
            {
                acct = value;
            }
        }

        public static string FRMACCT()
        {
            return acct.ToString("$0.00");
        }

        public static string FRMCRD()
        {
            return credit.ToString("$0.00");
        }

        public static string FRMDBT()
        {
            return debit.ToString("$0.00");
        }

        public static string FRMVAL()
        {
            double DVAL = 0.00;
            return DVAL.ToString("C");
        }

        public static bool ValBalance(string value, out double num)
        {
            
            bool isNum = double.TryParse(value, out num);

            return isNum;
        }
    }

       
       
    }
    

