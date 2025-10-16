namespace Personal_Budget_Tracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool start = true; // variabel för att hålla igång loopen

            BudgetManager budgetManager = new BudgetManager(); // skapar ett budget-objekt
            ADDtransaction aDDtransaction = new ADDtransaction(); // skapar ett transaktions-objekt

            while (start) // så länge start är true körs loopen
            {
                Console.WriteLine("\nMeny"); // skriver ut meny

                Console.WriteLine("1. Add transaction"); // menyval 1
                Console.WriteLine("2. Calculate balance"); // menyval 2
                Console.WriteLine("3. Show transaction history and info"); // menyval 3
                Console.WriteLine("4. Remove an transaction"); // menyval 4
                Console.WriteLine("5. Quit program"); // menyval 5

                string val = Console.ReadLine(); // läser in användarens val

                switch (val) // kollar vilket val användaren gjorde
                {
                    case "1":
                        aDDtransaction.AddTransaction(); // lägger till transaktion
                        break;

                    case "2":
                        budgetManager.CalulateBalance(); // visar saldo
                        break;

                    case "3":
                        Console.WriteLine("All transactions info:"); // skriver ut alla transaktioner
                        foreach (var t in budgetManager.transactions)
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

                    default:
                        Console.WriteLine("Wrong choice pick a number between (1-5)"); // felmeddelande om man skriver fel
                        break;
                }
            }
        }
    }
}
