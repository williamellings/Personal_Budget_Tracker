using System; 
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Personal_Budget_Tracker
{
    public class BudgetManager
    {
        public List<Transaction> transactions = new List<Transaction>();
        public decimal InTheBank { get; private set; } = 0;


        public void AddTransaction()
        {
            Console.WriteLine("How much do you want to add?: (i kr)?");
            string input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal amount))
            {
                // Fråga efter beskrivning och kategori från användaren
                Console.WriteLine("Salary?");
                string desc = Console.ReadLine();
                
                
                Console.WriteLine("category?");

                string cat = Console.ReadLine();       

                

                Transaction trans = new Transaction(desc, cat, amount, DateTime.Now);

                transactions.Add(trans);
                InTheBank += amount;
                Console.WriteLine("Transaktionen har lagts till.");
            }
            else
            {
                Console.WriteLine("Wrong sum.");
            }
        }

    
        public void CalulateBalance()
        {
            
            Console.WriteLine($"In the bank: {InTheBank} kr");
        }

        public void RemoveTransaction()
        {
            if (transactions.Count == 0)
            {
                Console.WriteLine("No transaction to remove.");
                return;
            }

          
            for (int i = 0; i < transactions.Count; i++)
            {
                Console.Write($"{i}: ");
                transactions[i].ShowTransactionInfo();
            }

            Console.WriteLine("What trans do you want to remove? Choice index: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int index) && index >= 0 && index < transactions.Count)
            {
                InTheBank -= transactions[index].Amount;        // Uppdatera saldot
                transactions.RemoveAt(index);            // Tar bort transaktionen
                Console.WriteLine("Transaction removed.");
            }
            else
            {
                Console.WriteLine("Wrong index.");
            }

        }
    }
}
