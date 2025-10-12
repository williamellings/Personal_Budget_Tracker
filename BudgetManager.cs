using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Budget_Tracker
{
    public class BudgetManager
    {
        private List<Transaction> transaction = new List<Transaction>();

        public void AddTransaction(Transaction cash)
        {
            transaction.Add(cash);
        }

        
    }
}
