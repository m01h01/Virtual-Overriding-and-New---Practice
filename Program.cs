namespace Virtual__Overriding_and_New___Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            CheckingAccount ca = new CheckingAccount("Amanda", 10000);
            accounts.Add(ca);

            SavingAccount sa = new SavingAccount("Kristie", 20000);
            accounts.Add(sa);

            RetirementAccount ra = new RetirementAccount("Ben", 30000);
            accounts.Add(ra);

            double deposit1 = 500;
            callDeposit(accounts, deposit1);

            double deposit2 = -5000;
            callDeposit(accounts, deposit2);

            double withdraw1 = 200;
            callWithdraw(accounts, withdraw1);

            double withdraw2 = -2000;
            callWithdraw(accounts, withdraw2);

            double overDraw = 50000;
            callWithdraw(accounts, overDraw);

        }
        public static void callDeposit(List<BankAccount> accounts, double amount)
        {
            Console.WriteLine($"Deposit {amount.ToString("")}");
            foreach (BankAccount account in accounts)
            {
                account.Deposit(amount);
                Console.WriteLine(account);
            }
        }

        public static void callWithdraw(List<BankAccount> accounts, double amount)
        {
            Console.WriteLine($"Withdraw {amount.ToString("")}");

            foreach (BankAccount account in accounts)
            {
                account.Withdraw(amount);
                Console.WriteLine(account);

            }
        }
    }//namespace
}//class