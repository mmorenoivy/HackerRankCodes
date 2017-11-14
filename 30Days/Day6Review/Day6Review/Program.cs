using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Review
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = int.Parse(Console.In.ReadLine()); i > 0; i--)
            {
                string[] s = { "", "" };
                for(int j=0; j < s[0].Length; j++)
                {
                    if(j%2==0)
                    {
                        s[1] += s[j];
                    }
                    else
                    {
                        s[2] += s[j];
                    }
                    Console.WriteLine(s[1] + " " + s[2]);
                }
            }
                        

                


            }
        }
}
