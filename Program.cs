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

            double deposit = 500;
            callDeposit(accounts, deposit);

            double withdraw = 200;
            bool isWithdrawFromRA = ra.Withdraw(withdraw);
            if (isWithdrawFromRA == false)
            {
                callWithdraw(accounts, withdraw);
            }

        }
        public static void callDeposit(List<BankAccount> accounts, double amount)
        {
            Console.WriteLine($"Deposit {amount.ToString("C")}");
            foreach (BankAccount account in accounts)
            {
                account.Deposit(amount);
                Console.WriteLine(account);
            }
        }

        public static void callWithdraw(List<BankAccount> accounts, double amount)
        {
            Console.WriteLine($"Withdraw {amount.ToString("C")}");

            foreach (BankAccount account in accounts)
            {
                account.Withdraw(amount);
                Console.WriteLine(account);

            }
        }
    }//namespace
}//class