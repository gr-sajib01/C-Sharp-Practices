using System;

namespace BankAccountSystem
{
    class BankAccount
    {
        public string AccountNumber;
        public double Balance;

        public virtual void ShowAccount()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }

    class SavingsAccount : BankAccount
    {
        public double InterestRate;

        public override void ShowAccount()
        {
            Console.WriteLine("Savings Account");
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("Interest Rate: " + InterestRate + "%");
        }
    }

    class FixedDeposit : BankAccount
    {
        public int Years;

        public override void ShowAccount()
        {
            Console.WriteLine("Fixed Deposit");
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("Deposit Years: " + Years);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            account1.AccountNumber = "1001";
            account1.Balance = 5000;

            SavingsAccount savings1 = new SavingsAccount();
            savings1.AccountNumber = "2001";
            savings1.Balance = 10000;
            savings1.InterestRate = 6;

            FixedDeposit fd1 = new FixedDeposit();
            fd1.AccountNumber = "3001";
            fd1.Balance = 50000;
            fd1.Years = 5;

            account1.ShowAccount();
            Console.WriteLine();

            savings1.ShowAccount();
            Console.WriteLine();

            fd1.ShowAccount();
        }
    }
}