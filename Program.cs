using System;
using System.Collections.Generic;

namespace Personal_Budget_Tracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool start = true;


            BudgetManager budgetManager = new BudgetManager(); 
            
            
            while (start) // så länge start är true körs loopen
            {
                Console.WriteLine("\nMeny"); // skriver ut meny

                Console.WriteLine("1. Add transaction"); // menyval 1
                Console.WriteLine("2. Calculate balance"); // menyval 2
                Console.WriteLine("3. Show transaction history and info"); // menyval 3
                Console.WriteLine("4. Remove an transaction"); // menyval 4
                Console.WriteLine("5. Quit program"); // menyval 5
                Console.WriteLine("6. Filter by category");
                Console.WriteLine("7. total income and spending");

                string val = Console.ReadLine(); // läser in användarens val

                switch (val) // kollar vilket val användaren gjorde
                {
                    case "1":
                        budgetManager.AddTransaction(); // lägger till transaktion
                        break;

                    case "2":
                        budgetManager.CalculateBalance(); // visar saldo
                        break;

                    case "3":
                        Console.WriteLine("All transactions info:");
                        foreach (var t in budgetManager.Transactions) // använd det gemensamma BudgetData-objektet
                        {
                            t.ShowTransactionInfo(); // visar info om varje transaktion
                        }
                        break;

                    case "4":
                        budgetManager.RemoveTransaction(); // tar bort en transaktion
                        break;

                    case "5":
                        Console.WriteLine("Programmet avslutas"); // avslutar programmet
                        start = false; // sätter start till false så loopen slutar
                        break;


                    case "6":
                        Console.Write("Filtrera transaktioner på kategori: ");
                        string category = Console.ReadLine();
                        var filtered = budgetManager.FilterByCategory(category);
                        foreach (var t in filtered)
                            t.ShowTransactionInfo();
                        break;

                    case "7":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Total Income: " + budgetManager.TotalIncome());
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Total Spending: " + budgetManager.TotalSpending());
                        Console.ResetColor();

                        break;



                    default:
                        Console.WriteLine("Wrong choice pick a number between (1-5)"); // felmeddelande om man skriver fel
                        break;
                }
            }
        }
    }
}
