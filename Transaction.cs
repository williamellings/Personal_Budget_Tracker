using System;
using System.Collections.Generic;


namespace Personal_Budget_Tracker
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }


        

        public Transaction()
        {
        }

        public Transaction(string description, string category, decimal amount, DateTime date)
        {
            Description = description;
            Category = category;
            Amount = amount;
            Date = date;
        }

        public void ShowTransactionInfo()
        {
            // .ToString() med format för både datum och tid
            Console.WriteLine($"{Date.ToString("yyyy-MM-dd HH:mm")} {Description} {Category}: {Amount} kr");
        }



    }
}



/*-Description(t.ex. “Lön”, “Matinköp”)
- Amount(decimal, positivt = inkomst, negativt = utgift)
- Category(t.ex. “Mat”, “Transport”, “Hyra”, “Inkomst”)
- Date(skrivs som text, t.ex. “2025 - 10 - 10”)
💬 Metod:

-ShowInfo() – skriver ut all information om transaktionen. */

