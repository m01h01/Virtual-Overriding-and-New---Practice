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
        private bool IsAmountPositive(double amount)
        {
            return (amount > 0);

        }
        private bool IsEnoughMoneyInAcc(double amount)
        {
            return amount < Balance;
        }
        public override void Deposit(double amount)
        {
            if (IsAmountPositive(amount)) 
            {
                Balance += amount + (amount * _interest);

            }
        }
        public override void Withdraw(double amount)
        {
            if (IsAmountPositive(amount) && IsEnoughMoneyInAcc(amount))
            {
                Balance -= amount;
            }
            
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }//namespace
}//class
