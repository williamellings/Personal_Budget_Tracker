using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Personal_Budget_Tracker
{
    public class ADDtransaction
    {

        public List<Transaction> transactions = new List<Transaction>();
        public decimal InTheBank { get; private set; } = 0;
        public void AddTransaction()
        {
            Console.WriteLine("Do you want to add spending or salary?");
            Console.WriteLine("1. Salary: ");
            Console.WriteLine("2. Spending: ");
            string option = Console.ReadLine();


            switch (option)
            {
                case "1":

                    Console.WriteLine("How much do you want to add? (in kr): ");

                    string input = Console.ReadLine();
                    if (decimal.TryParse(input, out decimal amount))
                    {


                        Console.WriteLine("Description?: ");
                        string desc = Console.ReadLine();

                        Console.WriteLine("category?: ");
                        string cat = Console.ReadLine();



                        Transaction trans = new Transaction(desc, cat, amount, DateTime.Now);

                        transactions.Add(trans);
                        InTheBank += amount; //lägger till apengarna i banken
                        Console.WriteLine("Transaction added.");
                    }
                    else
                    {
                        Console.WriteLine("Wrong sum.");
                    }
                    break;
                case "2":

                    Console.WriteLine("Spendings? (in kr): ");

                    string spendinginput = Console.ReadLine();
                    if (decimal.TryParse(spendinginput, out decimal spendingamount))
                    {


                        Console.WriteLine("Description?: ");
                        string desc = Console.ReadLine();

                        Console.WriteLine("category?: ");
                        string cat = Console.ReadLine();



                        Transaction trans = new Transaction(desc, cat, spendingamount, DateTime.Now);

                        transactions.Add(trans);
                        InTheBank -= spendingamount; //tar bort pengar från banken
                        Console.WriteLine("Transaction added.");
                    }
                    else
                    {
                        Console.WriteLine("Wrong sum.");
                    }
                    break;
            }
        }

    }
}
