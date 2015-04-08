using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcBank
{
    public class MaxiSavings : Account
    {
        public override double InterestEarned()
        {
            double amount = SumTransactions();
            if (amount <= 1000)
                return amount * 0.02;
            if (amount <= 2000)
                return (20 + (amount - 1000) * 0.05)/365;
            return (70 + (amount - 2000) * 0.1)/365;
        }

    }
}
