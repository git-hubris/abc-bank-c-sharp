using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcBank
{
    public class Savings : Account
    {
        public override double interestEarned()
        {
            double amount = SumTransactions();
            if (amount <= 1000)
                return (amount * 0.001)/365;
            else
                return (1 + (amount - 1000) * 0.002)/365;
        }
    }
}
