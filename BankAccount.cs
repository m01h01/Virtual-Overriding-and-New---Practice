using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual__Overriding_and_New___Practice
{
    internal class BankAccount
    {
        string _name;
        int _accountNumber;
        double _balance;

        public BankAccount(string name, double balance)
        {
            _name = name;

            Random rand = new Random();
            int num = rand.Next(1000, 100000);
            _accountNumber = num;

            _balance = balance;
        }

        public string Name { get => _name; set => _name = value; }
        public int AccountNumber { get => _accountNumber; }
        public double Balance { get => _balance; protected set => _balance = value; }

        private bool IsAmountPositive(double amount)
        {
            return amount > 0;
        }
        private bool IsEnoughMoneyInAcc(double amount)
        {
            return amount <= _balance;
        }
        public virtual bool Deposit(double amount)
        {
            if (IsAmountPositive(amount))
            {
                _balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool Withdraw(double amount)
        {
            if (IsAmountPositive(amount) && IsEnoughMoneyInAcc(amount))
            {
                _balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return this.GetType() + $" Name: {_name} - Account Number: {_accountNumber} - Balance: {_balance.ToString("C")}";
        }
    }//namespace
}//class
