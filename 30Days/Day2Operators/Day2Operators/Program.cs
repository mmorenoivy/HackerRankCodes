using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Operators
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.WriteLine("Enter meal cost: ");
            double mealCost = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter tip Percent: ");
            double tipPercent = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter tax Percent: ");
            double taxPercent = double.Parse(Console.ReadLine());
            Cost(mealCost, tipPercent, taxPercent);
            Console.ReadKey();
        }
        static double Cost(double mealCost, double tipPercent, double taxPercent)
        {
            double tip;
            double tax;
            double totalCost;

            tip = mealCost * (tipPercent / 100.0);
            tax = mealCost * (taxPercent / 100.0);
            totalCost = mealCost + tip + tax;

            Console.WriteLine("The total meal cost is {0:F0} dollars.", totalCost);
            return totalCost;
        }
        
    }
}
