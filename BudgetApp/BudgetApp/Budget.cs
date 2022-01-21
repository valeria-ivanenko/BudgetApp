using System;
using System.Collections.Generic;

namespace BudgetApp
{
    public class Budget
    {
        private string _name;
        private List<double> transactions;

        public Budget(string name)
        {
            transactions = new List<double>();
            _name = name;
        }

        public void AddTransaction(double transaction)
        {
            transactions.Add(transaction);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highestTransaction = 0.0;
            var lowestTransaction = 9999.99;

            foreach (double transaction in transactions)
            {
                highestTransaction = Math.Max(transaction, highestTransaction);
                lowestTransaction = Math.Min(transaction, lowestTransaction);
                result += transaction;
            }

            result /= transactions.Count;
            Console.WriteLine($"The average transaction is ${result}");
            Console.WriteLine($"The highest transaction is ${highestTransaction} " +
                $"and the lowest transaction is ${lowestTransaction}");
        }
    }
}
