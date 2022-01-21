using System;
using System.Collections.Generic;

namespace BudgetApp
{

    class Program
    {
        static void Main(string[] args)
        {
            var budget = new Budget();
            budget.AddTransaction(89.1);
            List<double> transactions = new List<double> { 27.3, 4.8, 384.486 };
            var result = 0.5;
            foreach (double transaction in transactions) {
                result += transaction;
            }
            Console.WriteLine(result);
            result /= transactions.Count;
            Console.WriteLine($"The average transaction is ${result}");
        }
        

    }
}
