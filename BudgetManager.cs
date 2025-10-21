using System;
using System.Collections.Generic;

namespace Personal_Budget_Tracker
{
    public class BudgetManager
    {
        // Lista som lagrar alla transaktioner
        public List<Transaction> Transactions { get; private set; } = new List<Transaction>();

        // Den aktuella summan pengar på kontot
        public decimal InTheBank { get; private set; } = 0;

        // Metod för att lägga till en ny transaktion (lön eller utgift)
        public void AddTransaction()
        {
            Console.WriteLine("Do you want to add salary or spending?");
            Console.WriteLine("1. Salary");
            Console.WriteLine("2. Spending");
            string option = Console.ReadLine(); // Tar emot användarens val

            decimal amount;
            string desc, cat;

            if (option == "1") // Om användaren vill lägga till lön
            {
                Console.Write("How much do you want to add? (in kr): ");
                if (!decimal.TryParse(Console.ReadLine(), out amount)) // Felkontroll på inmatningen
                {
                    Console.WriteLine("Invalid sum.");
                    return;
                }
                Console.Write("Description?: ");
                desc = Console.ReadLine(); // Tar emot beskrivning
                Console.Write("Category?: ");
                cat = Console.ReadLine(); // Tar emot kategori

                // Skapar och lägger till transaktion, ökar saldo
                Transactions.Add(new Transaction(desc, cat, amount, DateTime.Now)); // Lägg till transaktionen
                InTheBank += amount; // Uppdatera saldo
                Console.WriteLine("Salary transaction added.");
            }
            else if (option == "2") // Om användaren vill lägga till utgift
            {
                Console.Write("How much did you spend? (in kr): ");
                if (!decimal.TryParse(Console.ReadLine(), out amount)) // Felkontroll på inmatningen
                {
                    Console.WriteLine("Invalid sum.");
                    return;
                }
                Console.Write("Description?: ");
                desc = Console.ReadLine(); // Tar emot beskrivning
                Console.Write("Category?: ");
                cat = Console.ReadLine(); // Tar emot kategori

                // Skapar och lägger till transaktion, minskar saldo
                Transactions.Add(new Transaction(desc, cat, -amount, DateTime.Now)); // Lägg till utgift (negativt belopp)
                InTheBank -= amount; // Uppdatera saldo
                Console.WriteLine("Spending transaction added.");
            }
            else // Om felaktigt val
            {
                Console.WriteLine("Invalid option."); // Visa felmeddelande
            }
        }

        // Skriver ut nuvarande saldo
        public void CalculateBalance()
        {
            Console.WriteLine($"In the bank: {InTheBank} kr");
        }

        // Här kan information om enskild transaktion visas (inte implementerad)
        public void ShowTransactionInfo()
        {
            // Tom metod – behöver implementeras
        }

        // Metod för att ta bort vald transaktion
        public void RemoveTransaction()
        {
            if (Transactions.Count == 0) // Om inga transaktioner finns
            {
                Console.WriteLine("No transaction to remove.");
                return;
            }

            // Lista alla transaktioner med index
            Console.WriteLine("Transactions:");
            for (int i = 0; i < Transactions.Count; i++)
            {
                Console.Write($"{i}: ");
                Transactions[i].ShowTransactionInfo(); // Visa info om varje transaktion
            }

            Console.Write("Which transaction do you want to remove? Enter index: ");
            // Tar emot index från användaren
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < Transactions.Count)
            {
                InTheBank -= Transactions[index].Amount; // Uppdaterar saldo
                Transactions.RemoveAt(index); // Tar bort transaktionen från listan
                Console.WriteLine("Transaction removed.");
            }
            else
            {
                Console.WriteLine("Wrong index."); // Om indexet är fel
            }
        }
    }
}
