using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSolve1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int val2 = Convert.ToInt32(Console.ReadLine());
            solveme(val1, val2);
            Console.ReadKey();
        }
       
        static int solveme(int x, int y)
        {
            int xy = x + y;
            Console.WriteLine("The sum is {0}", xy);
            return xy;
        }
    }
}
