using System;

namespace myApp{
    public class Transaction{
        public decimal Amount {get;}
        public DateTime date {get;}
        public string notes {get;}

        public Transaction(decimal amount, DateTime date, string note){
            this.Amount = amount;
            this.date = date;
            this.notes = note;
        }
    }
}