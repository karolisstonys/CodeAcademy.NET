using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L029_OOP_Microsoft_Tutorial
{
    public class BankAccount
    {

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get
            { 
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static long accountNumberSeed = 140028003000;
        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name)
        {
            accountNumberSeed++;
            this.Number = "LT" + accountNumberSeed.ToString();
            this.Owner = name;
            MakeDeposit(800, "Initial balance");
        }

        public void MakeDeposit(decimal amount, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, DateTime.Now, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, DateTime.Now, note);
            allTransactions.Add(withdrawal);
        }




    }
}
