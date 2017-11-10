using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letandconst
{
    class Program
    {
        /**print the area of a circle having radius
         * print the perimeter of a circle having radius**/
        static void Main(string[] args)
        {
            double radius;
            Console.WriteLine("Enter radius");
            radius = double.Parse(Console.ReadLine());
            Circle(radius);
            Console.ReadLine();
        }

        static double Circle(double radius)
        {
            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("Area is {0:F1}", area);
            Console.WriteLine("Perimeter is {0:F1}", perimeter);
            return radius;
        }
    }
}
