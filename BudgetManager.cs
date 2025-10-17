using System;
using System.Collections.Generic;
using System.Transactions;

namespace Personal_Budget_Tracker 
{
    public class BudgetManager
    {
        public List<Transaction> Transactions { get; private set; } = new List<Transaction>();
        public decimal InTheBank { get; private set; } = 0;

        public void AddTransaction()
        {
            Console.WriteLine("Do you want to add salary or spending?");
            Console.WriteLine("1. Salary");
            Console.WriteLine("2. Spending");
            string option = Console.ReadLine();

            decimal amount;
            string desc, cat;

            if (option == "1")
            {
                Console.Write("How much do you want to add? (in kr): ");
                if (!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid sum.");
                    return;
                }
                Console.Write("Description?: ");
                desc = Console.ReadLine();
                Console.Write("Category?: ");
                cat = Console.ReadLine();

                Transactions.Add(new Transaction(desc, cat, amount, DateTime.Now)); // FIX: lägger till transaktionen
                InTheBank += amount;
                Console.WriteLine("Salary transaction added.");
            }
            else if (option == "2")
            {
                Console.Write("How much did you spend? (in kr): ");
                if (!decimal.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid sum.");
                    return;
                }
                Console.Write("Description?: ");
                desc = Console.ReadLine();
                Console.Write("Category?: ");
                cat = Console.ReadLine();

                Transactions.Add(new Transaction(desc, cat, -amount, DateTime.Now));
                InTheBank -= amount;
                Console.WriteLine("Spending transaction added.");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        public void CalculateBalance()
        {
            Console.WriteLine($"In the bank: {InTheBank} kr");
        }

        public void RemoveTransaction()
        {
            if (Transactions.Count == 0)
            {
                Console.WriteLine("No transaction to remove.");
                return;
            }

            Console.WriteLine("Transactions:");
            for (int i = 0; i < Transactions.Count; i++)
            {
                Console.Write($"{i}: ");
                Transactions[i].ShowTransactionInfo();
            }

            Console.Write("Which transaction do you want to remove? Enter index: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < Transactions.Count)
            {
                InTheBank -= Transactions[index].Amount;
                Transactions.RemoveAt(index);
                Console.WriteLine("Transaction removed.");
            }
            else
            {
                Console.WriteLine("Wrong index.");
            }
        }
    }
}

