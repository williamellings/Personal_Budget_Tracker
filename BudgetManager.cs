using System; 
using System.Collections.Generic;

namespace Personal_Budget_Tracker
{
    public class BudgetManager
    {
        private List<Transaction> transactions = new List<Transaction>();
        public decimal InTheBank { get; private set; } = 0;

      
        public void AddTransaction()
        {
            Console.WriteLine("How much du you want to add?: (i kr)?");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal amount))
            {
                Transaction trans = new Transaction
                {
                    Date = DateTime.Now,
                    Description = "Transaction",
                    Category = "Category",
                    Amount = amount
                };
                transactions.Add(trans);
                InTheBank += amount;
                Console.WriteLine("Transaktionen har lagts till.");
            }
            else
            {
                Console.WriteLine("Wrong sum.");
            }
        }

        
        public void ShowAll()
        {
            if (transactions.Count == 0)
            {
                Console.WriteLine("No transactions");
                return;
            }

            foreach (Transaction t in transactions)
            {
                t.ShowInfo();
            }
            Console.WriteLine($"In the bank: {InTheBank} kr");
        }
    }
}
