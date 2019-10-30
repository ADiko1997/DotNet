using System;
using System.Collections.Generic;

namespace myApp{
    public class BankAccount {
        public string Number { get;}
        public string Owner {get; set;}
        public decimal Balance {get
                {
                    decimal balance = 0;
                    foreach (var item in allTransactions){
                            balance+=item.Amount;
                    }
                    return balance ; 
                }
            }
        private static int accountNumberSeed = 1234567890;

        //Constructor
        public BankAccount(string name, decimal initialBalance){
            this.Owner = name;
            makeDeposti(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        private List<Transaction> allTransactions = new List<Transaction>(); //we are adding a transaction list to the bank account class

        
        public void makeDeposti(decimal amount, DateTime date, string notes){
            if (amount <=0){
                throw new ArgumentOutOfRangeException(nameof(amount), "The amount of makeDeposit should be always positive");
            }
            var deposit  = new Transaction(amount, date, notes);
            allTransactions.Add(deposit);

        }

        public void withDraw(decimal amount, DateTime date, string notes){
            if (amount <=0){
                throw new ArgumentOutOfRangeException(nameof(amount), "The amount of withdraw should be always positive");

            }
            else if (Balance - amount < 0){
                throw new InvalidOperationException("The amount of balance can not be negative");
            }

            else {
                var withDrawl = new Transaction(-amount, date, notes);
                allTransactions.Add(withDrawl);
            }

        }

        public string getAccountHistory(){
            var report =  new System.Text.StringBuilder();

            report.AppendLine("Date\tAmount\tNote");

            foreach (var item in allTransactions){
                report.AppendLine($"{item.date}\t{item.Amount}\t{item.notes}");
            }
            return report.ToString();
        }


    }
}