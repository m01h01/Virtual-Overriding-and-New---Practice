using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual__Overriding_and_New___Practice
{
    internal class SavingAccount:BankAccount
    {
        double _interest;

        public SavingAccount(string name, double balance, double interest = .2) : base(name, balance)
        {
            _interest = interest;
        }

        public double Interest { get => _interest; set => _interest = value; }
        public override bool Deposit(double amount)
        {
            bool DepositAmount = base.Deposit(amount);
            if (DepositAmount)
            {
                Balance += (amount * _interest);

            }
            return DepositAmount;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }//namespace
}//class
