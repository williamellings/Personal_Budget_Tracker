using System; // använder system
using System.Collections.Generic; // använder listor

namespace Personal_Budget_Tracker
{
    public class ADDtransaction
    {
        private BudgetData _data; // gemensam data för transaktioner och saldo

        public ADDtransaction(BudgetData data)
        {
            _data = data; // sätter data-objektet
        }

        public void AddTransaction()
        {
            Console.WriteLine("Do you want to add spending or salary?"); // fråga vad man vill göra
            Console.WriteLine("1. Salary: "); // lön
            Console.WriteLine("2. Spending: "); // utgift
            string option = Console.ReadLine(); // läser inval

            switch (option)
            {
                case "1": // om man väljer lön
                    Console.WriteLine("How much do you want to add? (in kr): "); // fråga hur mycket
                    string input = Console.ReadLine(); // läser in summan
                    if (decimal.TryParse(input, out decimal amount)) // kollar om det är ett tal
                    {
                        Console.WriteLine("Description?: "); // fråga om beskrivning
                        string desc = Console.ReadLine(); // läser in beskrivning

                        Console.WriteLine("category?: "); // fråga om kategori
                        string cat = Console.ReadLine(); // läser in kategori

                        Transaction trans = new Transaction(desc, cat, amount, DateTime.Now); // skapar transaktion

                        _data.Transactions.Add(trans); // lägger till i listan
                        _data.InTheBank += amount; // lägger till pengar i banken
                        Console.WriteLine("Transaction added."); // skriver ut att det är klart
                    }
                    else
                    {
                        Console.WriteLine("Wrong sum."); // fel om det inte är ett tal
                    }
                    break;
                case "2": // om man väljer utgift
                    Console.WriteLine("Spendings? (in kr): "); // fråga hur mycket man spenderat
                    string spendinginput = Console.ReadLine(); // läser in summan
                    if (decimal.TryParse(spendinginput, out decimal spendingamount)) // kollar om det är ett tal
                    {
                        Console.WriteLine("Description?: "); // fråga om beskrivning
                        string desc = Console.ReadLine(); // läser in beskrivning

                        Console.WriteLine("category?: "); // fråga om kategori
                        string cat = Console.ReadLine(); // läser in kategori

                        Transaction trans = new Transaction(desc, cat, -spendingamount, DateTime.Now); // utgift som negativt tal
                        _data.Transactions.Add(trans);
                        _data.InTheBank -= spendingamount; // tar bort pengar från banken
                       
                        Console.WriteLine("Transaction added."); // skriver ut att det är klart
                    }
                    else
                    {
                        Console.WriteLine("Wrong sum."); // fel om det inte är ett tal
                    }
                    break;
            }
        }
    }
}
