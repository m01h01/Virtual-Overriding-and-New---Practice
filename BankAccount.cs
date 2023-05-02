using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual__Overriding_and_New___Practice
{
    abstract class BankAccount
    {
        string _name;
        int _accountNumber;
        double _balance;

        protected BankAccount(string name, double balance)
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

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        
        public override string ToString()
        {
            return this.GetType() + $" Name: {_name} - Account Number: {_accountNumber} - Balance: {_balance.ToString("C")}";
        }
    }//namespace
}//class
