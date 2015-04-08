using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbcBank
{
    public class Account
    {

        public const int CHECKING = 0;
        public const int SAVINGS = 1;
        public const int MAXI_SAVINGS = 2;

        private readonly int accountType;
        public List<Transaction> transactions;

        public Account(int accountType)
        {
            this.accountType = accountType;
            this.transactions = new List<Transaction>();
        }

        public void deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("amount must be greater than zero");
            }
            else
            {
                transactions.Add(new Transaction(amount));
            }
        }

        public void withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("amount must be greater than zero");
            }
            else
            {
                transactions.Add(new Transaction(-amount));
            }
        }

        public double interestEarned()
        {
            {
                double amount = SumTransactions();
                return (amount * 0.001)/365;
            }
        }
        public double SumTransactions()
        {
            double amount = 0.0;
            foreach (Transaction t in transactions)
                amount += t.amount;
            return amount * 0.01;
        }

        public int getAccountType()
        {
            return accountType;
        }

    }
}
