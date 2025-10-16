using System;
using System.Collections.Generic;


namespace Personal_Budget_Tracker
{
    public class BudgetData
    {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public decimal InTheBank { get; set; } = 0;
    }
}
