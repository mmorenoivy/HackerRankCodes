using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string timeConversion(string s)
        {
            // Complete this function
            DateTime dt = DateTime.Parse(s);
            return dt.ToString("HH:mm:ss");
        }

        
        
        
    }
}
