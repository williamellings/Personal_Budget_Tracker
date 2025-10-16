using System;
using System.Collections.Generic;


namespace Personal_Budget_Tracker
{
    public class Budgetconverter
    {
        private BudgetData _data; // gemensam data för transaktioner och saldo

        public Budgetconverter(BudgetData data)
        {
            _data = data; // sätter data-objektet
        }

        public void CalulateBalance()
        {
            Console.WriteLine($"In the bank: {_data.InTheBank} kr");
            
            decimal sekToUsd = 0.09m; // 1 SEK = 0.09 USD
            decimal sekToEur = 0.085m; // 1 SEK = 0.085 EUR 
            decimal sekToGbp = 0.073m; // 1 SEK = 0.073 GBP 

            Console.WriteLine($"In the bank: {_data.InTheBank * sekToUsd} USD"); // visar i dollar
            Console.WriteLine($"In the bank: {_data.InTheBank * sekToEur} EUR"); // visar i euro
            Console.WriteLine($"In the bank: {_data.InTheBank * sekToGbp} GBP"); // visar i pund

        }

    }
}
