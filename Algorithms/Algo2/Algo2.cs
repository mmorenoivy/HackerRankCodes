using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgSolve2
{
   
    /* 
     * This simple program takes size of an array, takes 
     * the elements and outputs the sum of the elements in the array */
    class Program
    {
        static void Main(string[] args)
        {
            int sumArray = 0;
            int n;
            Console.WriteLine("Enter size of Array");
      
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Values");  
            for (int i = 0; i < n; i++)
            {
                sumArray = sumArray + (Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Sum of elements is {0}", sumArray);
            Console.ReadKey();
        }

   }
}
