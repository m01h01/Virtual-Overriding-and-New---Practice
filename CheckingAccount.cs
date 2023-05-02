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

        public override bool Withdraw(double amount)
        {
            bool withdrewamount = base.Withdraw(amount);
            if (!withdrewamount)
            {
                Balance -= _overdraftFee;
            }
            return withdrewamount;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }//namesapce
}//calss
