using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        // Factorialize a number
        // 5! = 5 * 4 * 3 * 2 * 1 = 120(factorial of 5)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to factorialize: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = factorialize(num);
            Console.WriteLine("Factorial of number entered is " + fact);
            Console.ReadKey();
        }

        static int factorialize(int num)
        {
                        
            if(num<0)
            {
                return -1;
            }
            else if(num.Equals(0))
            {
                return 1;
            }
            else
            {
              return (num * factorialize(num - 1));
            }
            
        }
    }
}
