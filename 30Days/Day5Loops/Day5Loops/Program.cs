using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Loops
{
    class Program
    {
        /*Given an integer n, print its first 10 multiples. Each multiple n x i(where 1 <=i<=10)
        * should be printed on a new line in the form: n x i = result
        * */
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a multiple");
            int n = Convert.ToInt32(Console.ReadLine());
            int result;
            for(int i=1;i <=10 ; i++)
            {
                result = n * i;
                Console.WriteLine(n + " x " + i + " = " + result);
            }
            Console.ReadKey();
        }
    }
}
