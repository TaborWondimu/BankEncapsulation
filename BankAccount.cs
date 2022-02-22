using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
   public class BankAccount
    {
        public BankAccount()
        {
            // Default Constructor
        }
        private double balance = 0;
    public void Deposit(double myDeposit)
        {
            balance += myDeposit;
        }
    public double GetBalance()
        {
          return balance;
        }
    }
}
