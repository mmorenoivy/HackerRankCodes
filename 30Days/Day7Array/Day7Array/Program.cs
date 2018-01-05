using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Array
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ReverseString("1234"));
            Console.WriteLine(ReverseString("samuel"));
            Console.WriteLine(ReverseString("example string"));
            Console.ReadKey();
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

    }
}
