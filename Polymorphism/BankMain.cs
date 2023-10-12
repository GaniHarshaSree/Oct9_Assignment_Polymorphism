using System;
using BankLib;

namespace Polymorphism
{
    internal class BankMain
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.Amount = 2000;
            b.AccountNo = 999999999999;
            b.BranchName = "Kurnool";
            b.DDate = DateTime.Now;
            b.Deposit(b.AccountNo, b.Amount, b.DDate, b.BranchName);
            b.Deposit(b.AccountNo, 2000, b.DDate);
            b.Withdraw(500, b.DDate, b.BranchName, b.AccountNo);
            Console.ReadLine();
        }

    }
}
