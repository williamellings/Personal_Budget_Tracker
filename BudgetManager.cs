using System; // använder system
using System.Collections.Generic; // använder listor


namespace Personal_Budget_Tracker
{
    public class BudgetManager
    {
        public List<Transaction> transactions = new List<Transaction>(); // lista med transaktioner
        public decimal InTheBank { get; private set; } = 0; // pengar i banken

        public void CalulateBalance()
        {
            Console.WriteLine($"In the bank: {InTheBank} kr"); // skriver ut hur mycket pengar som finns
        }

        public void RemoveTransaction()
        {
            if (transactions.Count == 0) // kollar om det finns några transaktioner
            {
                Console.WriteLine("No transaction to remove."); // skriver ut om det inte finns någon
                return; // avslutar metoden
            }

            for (int i = 0; i < transactions.Count; i++) // loopar igenom alla transaktioner
            {
                Console.Write($"{i}: "); // skriver ut index
                transactions[i].ShowTransactionInfo(); // visar info om transaktionen
            }

            Console.WriteLine("What trans do you want to remove? Choice index: "); // fråga vilken som ska tas bort
            string input = Console.ReadLine(); // läser in index

            if (int.TryParse(input, out int index) && index >= 0 && index < transactions.Count) // kollar om index är giltigt
            {
                InTheBank -= transactions[index].Amount; // tar bort summan från banken
                transactions.RemoveAt(index); // tar bort transaktionen från listan
                Console.WriteLine("Transaction removed."); // skriver ut att den är borttagen
            }
            else
            {
                Console.WriteLine("Wrong index."); // felmeddelande om index är fel
            }
        }
    }
}
