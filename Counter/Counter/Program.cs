using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int x = 1; x < 20; x++)
            {
                if(x < 10)
                {
                    Console.WriteLine(x.ToString("D2"));
                }
                else
                {
                    Console.WriteLine(x);
                }
                
            }
            
            
            Console.ReadKey();
        }
    }
}
