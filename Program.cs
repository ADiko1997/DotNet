using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)

        {
            var account = new BankAccount("Anxhelo", 1000);
            account.withDraw(200, DateTime.Now, "First Withdraw");
            account.makeDeposti(100, DateTime.Now, "Second Deposit");

            Console.WriteLine($"Owner: {account.Owner} Number {account.Number} Balance: {account.Balance}");

            var account2 = new BankAccount("Klodian Diko", 200);
            account2.withDraw(150, DateTime.Now, "First Withdraw for Klodi");
            account2.makeDeposti(50, DateTime.Now, "Second Deposit for Klodi");
            Console.WriteLine($"Owner: {account2.Owner} Number: {account2.Number} Balance: {account2.Balance}");

            Console.WriteLine($"Klodi transaction history is: {account2.getAccountHistory()}");
            Console.WriteLine($"Anxhelo transaction history is: {account.getAccountHistory()}");

        }

    }
}
