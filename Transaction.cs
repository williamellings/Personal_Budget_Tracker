using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Personal_Budget_Tracker
{
    public class Transaction
    {
        public string Descritption { get; set; }
        
        public decimal Amount { get; set; }

        public string Category { get; set; }

        public string Date { get; set; }

        public Transaction(string descritption, decimal amount, string category, string date)
        {
            Descritption = descritption;
            Amount = amount;
            Category = category;
            Date = date;
        }
     }
}


/*-Description(t.ex. “Lön”, “Matinköp”)
- Amount(decimal, positivt = inkomst, negativt = utgift)
- Category(t.ex. “Mat”, “Transport”, “Hyra”, “Inkomst”)
- Date(skrivs som text, t.ex. “2025 - 10 - 10”)
💬 Metod:

-ShowInfo() – skriver ut all information om transaktionen. */

