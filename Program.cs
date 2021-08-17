using MyBankyStuff;
using System;
using Humanizer;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
             var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} for {account.Balance}");

            
            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            account.MakeWithdrawal(5, DateTime.Now, "Coffee");
            account.MakeWithdrawal(5, DateTime.Now, "Diet Coke");
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(7, DateTime.Now, "Tea");
            account.MakeWithdrawal(8, DateTime.Now, "Pants");

            Console.WriteLine(account.GetAccountHistory());

           
        }
    }
}
