using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual__Overriding_and_New___Practice
{
    internal class CheckingAccount: BankAccount
    {
        double _overdraftFee;
        public CheckingAccount(string name, double balance, double overdraftFee = 50) : base(name, balance)
        {
            _overdraftFee = overdraftFee;
        }

        public double OverdraftFee { get => _overdraftFee; set => _overdraftFee = value; }
        private bool IsAmountPositive(double amount)
        {
            return (amount > 0);

        }
        private bool IsEnoughMoneyInAcc(double amount)
        {
            return amount < Balance;
        }
        public override void Withdraw(double amount)
        {
            if (!IsEnoughMoneyInAcc(amount))
            {
                Balance -= _overdraftFee;
            }
            else if (IsAmountPositive(amount) && IsEnoughMoneyInAcc(amount)) 
            {
                Balance -= amount;
            }
            
        }
        public override void Deposit(double amount)
        { 
            if (IsAmountPositive(amount)) 
            {
                Balance += amount;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
       
    }//namesapce
}//calss
