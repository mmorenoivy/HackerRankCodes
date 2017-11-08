using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        /*
         * This displays # in following:
         *      #
         *     ##
         *    ###
         *   ####
         *  #####
         * ######
         * */
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int x;
            for (x = 0; x < n; x++)
            {
               Console.WriteLine(new String('#', x+1).PadLeft(n, ' '));
            }
                           
            Console.ReadKey();
        }
    }
}
