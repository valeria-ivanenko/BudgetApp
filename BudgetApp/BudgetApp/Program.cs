using System;
using System.Collections.Generic;

namespace BudgetApp
{

    class Program
    {
        static void Main(string[] args)
        {
           
            var budget = new Budget("Car expenses");
            budget.AddTransaction(89.1);
            budget.AddTransaction(4.8);
            budget.AddTransaction(35.2);
            budget.ShowStatistics();
           
        }
        

    }
}
