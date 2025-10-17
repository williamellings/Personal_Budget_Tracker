using System; // använder system
using System.Collections.Generic; // använder listor

namespace Personal_Budget_Tracker
{
    public class Transaction(string description, string category, decimal amount, DateTime date)
    {
        public DateTime Date { get; set; } = date; // sätter datum
        public string Description { get; set; } = description; // sätter beskrivning
        public string Category { get; set; } = category; // sätter kategori
        public decimal Amount { get; set; } = amount; // sätter belopp

        public void ShowTransactionInfo()
        {
            // skriver ut info om transaktionen med datum och tid
            Console.WriteLine($"{Date.ToString("yyyy-MM-dd HH:mm")} {Description} {Category}: {Amount} kr");
        }
    }
}
