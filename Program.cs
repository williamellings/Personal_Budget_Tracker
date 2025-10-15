namespace Personal_Budget_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool start = true;

            BudgetManager budgetManager = new BudgetManager();

            while (start)
            {
                Console.WriteLine("\nMeny");

                Console.WriteLine("1. Add transaction");
                Console.WriteLine("2. Show all transactions");
                Console.WriteLine("3. Show total balance");
                Console.WriteLine("4. Remove an transaction");
                Console.WriteLine("5. Quit program");

                string val = Console.ReadLine();

                switch(val)
                {
                    case "1":
                    budgetManager.AddTransaction();
                        break;
                }


            }
        }
    }
}
