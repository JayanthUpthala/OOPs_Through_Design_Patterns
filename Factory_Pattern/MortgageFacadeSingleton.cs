﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern_1216098
{
    internal class MortgageFacadeSingleton
    {
        Bank bk = new Bank();
        Loan ln = new Loan();
        Credit cr = new Credit();
        static readonly MortgageFacadeSingleton instance = new
        MortgageFacadeSingleton();
        public static MortgageFacadeSingleton Instance
        {
            get { return instance; }
        }
        MortgageFacadeSingleton() { } // private constructor
        public bool MortgageApproval(MortgageApplicant mapp, ref string reason)
        {
            bool approved = false;
            double bal = bk.GetCurrentCheckingBalance(mapp.BankAccountNum);
            bal = bal + bk.GetSavingBalance(mapp.BankAccountNum);
            bal = bal - ln.GetOutstandingLoans(mapp.LoanAccountNum);
            if (bal < 0)
            {
                approved = false;
                reason = "negative balances ";
            }
            else
            {
                if (bal < 0.2 * mapp.LoanAmountAsked)
                {
                    approved = false;
                    reason = "Not enough balances";
                }
                else
                {
                    if (cr.CheckCredit(mapp.SSNum) < CreditRating.GOOD)
                    {
                        approved = false;
                        reason = "not good credit rating..";
                    }
                    else
                        approved = true;
                }
            }
            return approved;
        }
    }
}
