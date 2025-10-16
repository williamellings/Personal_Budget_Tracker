using System; // använder system
using System.Collections.Generic; // använder listor

namespace Personal_Budget_Tracker
{
    public class BudgetManager
    {
        private BudgetData _data; // gemensam data för transaktioner och saldo

        public BudgetManager(BudgetData data)
        {
            _data = data; // sätter data-objektet
        }

        public void RemoveTransaction()
        {
            if (_data.Transactions.Count == 0) // kollar om det finns några transaktioner
            {
                Console.WriteLine("No transaction to remove."); // skriver ut om det inte finns någon
                return; // avslutar metoden
            }

            for (int i = 0; i < _data.Transactions.Count; i++) // loopar igenom alla transaktioner
            {
                Console.Write($"{i}: "); // skriver ut index
                _data.Transactions[i].ShowTransactionInfo(); // visar info om transaktionen
            }

            Console.WriteLine("What trans do you want to remove? Choice index: "); // fråga vilken som ska tas bort
            string input = Console.ReadLine(); // läser in index

            if (int.TryParse(input, out int index) && index >= 0 && index < _data.Transactions.Count) // kollar om index är giltigt
            {
                _data.InTheBank -= _data.Transactions[index].Amount; // tar bort summan från banken
                _data.Transactions.RemoveAt(index); // tar bort transaktionen från listan
                Console.WriteLine("Transaction removed."); // skriver ut att den är borttagen
            }
            else
            {
                Console.WriteLine("Wrong index."); // felmeddelande om index är fel
            }
        }
    }
}
