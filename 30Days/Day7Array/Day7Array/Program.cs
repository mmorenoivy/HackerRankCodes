using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers");
            int n = int.Parse(Console.In.ReadLine());
            st(n);
        }
        static int st(int n)
        {
            int[] arr;
            for (n=0; n > 0; --n)
            {
               Console.WriteLine("{0}" + arr[n] + " ");
            }
            Console.WriteLine("");
            return n;
        }
        
}
}
