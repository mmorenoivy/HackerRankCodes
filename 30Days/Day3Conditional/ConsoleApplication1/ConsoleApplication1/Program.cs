using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /*Task 
Given an integer, N, perform the following conditional actions:

If N is odd, print Weird
If N is even and in the inclusive range of  to , print Not Weird
If N is even and in the inclusive range of  to , print Weird
If N is even and greater than , print Not Weird
         * 
         * */

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1 || (N > 5 && N <= 20))
            {

                Console.WriteLine("Weird - Odd Number");
            }
            else
            {
                Console.WriteLine("Not Weird - Even Number");
            }
            Console.ReadKey();
        }
    }
}
