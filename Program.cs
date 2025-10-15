namespace Personal_Budget_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool start = true;

            BudgetManager budgetManager = new BudgetManager();
            Transaction transaction = new Transaction();

            while (start)
            {
                Console.WriteLine("\nMeny");

                Console.WriteLine("1. Add transaction");
                Console.WriteLine("2. Show all transactions");
                Console.WriteLine("3. Show total balance and info");
                Console.WriteLine("4. Remove an transaction");
                Console.WriteLine("5. Quit program");

                string val = Console.ReadLine();

                switch(val)
                {
                    case "1":
                    budgetManager.AddTransaction();
                        break;

                    case "2":
                        budgetManager.ShowAll();
                        break;

                    case "3":
                        transaction.ShowInfo();
                        break;

                    case "4":
                        budgetManager.RemoveTransaction();
                        break;

                    case "5":
                        Console.WriteLine("Programmet avslutas");
                        start = false;
                        break;

                    default:
                        Console.WriteLine("Wrong choice pick a number between (1-5)");
                        break;
                }


            }
        }
    }
}
