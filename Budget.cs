using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetLib
{
    public class Budget
    {
        public decimal GetAvailableBalance(List<IMoney> monies)
        {
            decimal result = 0;

            foreach (IMoney money in monies)
            {
                result += money.GetValue();
            }
            return result;
        }
    }
}
