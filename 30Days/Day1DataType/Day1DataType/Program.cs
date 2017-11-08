using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int j;
            double e;
            string r;
            int sum;
            double sumDouble;

            // Read and save an integer, double, and String to your variables.
            Console.WriteLine("Enter an integer");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a double number");
            e = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a string");
            r = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            sum = i + j;
            Console.WriteLine("The sum of integers is: " + Convert.ToInt32(sum));
            // Print the sum of the double variables on a new line.
            sumDouble = d + e;
            Console.WriteLine("The sum of double numbers is: {0:F1}", sumDouble);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            //test
            Console.WriteLine(s + r);
            Console.ReadKey();
        }
    }
}
