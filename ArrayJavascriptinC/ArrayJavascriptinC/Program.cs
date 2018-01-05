using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayJavascriptinC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] {3, 2, 6, 5, 6};
            int i;
            for(i=0; i < 5; i++)
            {
                Console.WriteLine("Element [{0}]", i); 
            }
            Console.ReadKey();
        }
    }
}
