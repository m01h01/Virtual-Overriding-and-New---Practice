using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual__Overriding_and_New___Practice
{
    internal class RetirementAccount:SavingAccount
    {
        string _printout;

        public string Printout { get => _printout; set => _printout = value; }

        public RetirementAccount(string name, double balance, double interest = 0.3) : base(name, balance, interest)
        {

        }

        public override bool Withdraw(double amount)
        {
            _printout = "Cannot withdraw from Retirement account";
            return false;
        }
        public override string ToString()
        {
            return base.ToString() + $"\n{_printout}";
        }
    }
}
