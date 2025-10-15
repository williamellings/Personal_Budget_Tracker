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

        
        public void ShowInfo()
        {
            Console.WriteLine($"{Date.ToShortDateString()} {Description} {Category}: {Amount} kr");
        }
    }
}



/*-Description(t.ex. “Lön”, “Matinköp”)
- Amount(decimal, positivt = inkomst, negativt = utgift)
- Category(t.ex. “Mat”, “Transport”, “Hyra”, “Inkomst”)
- Date(skrivs som text, t.ex. “2025 - 10 - 10”)
💬 Metod:

-ShowInfo() – skriver ut all information om transaktionen. */

