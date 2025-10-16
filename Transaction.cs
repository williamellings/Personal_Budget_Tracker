using System; // använder system
using System.Collections.Generic; // använder listor

namespace Personal_Budget_Tracker
{
    public class Transaction
    {
        public DateTime Date { get; set; } // datum för transaktionen
        public string Description { get; set; } // beskrivning av transaktionen
        public string Category { get; set; } // kategori för transaktionen
        public decimal Amount { get; set; } // belopp för transaktionen

        public Transaction()
        {
        }

        public Transaction(string description, string category, decimal amount, DateTime date)
        {
            Description = description; // sätter beskrivning
            Category = category; // sätter kategori
            Amount = amount; // sätter belopp
            Date = date; // sätter datum
        }

        public void ShowTransactionInfo()
        {
            if (Amount >= 0)
                Console.ForegroundColor = ConsoleColor.Green; // income
            else
                Console.ForegroundColor = ConsoleColor.Red;   // expense

            Console.WriteLine($"{Date:yyyy-MM-dd HH:mm} {Description} {Category}: {Amount} kr");
        }
    }
}
