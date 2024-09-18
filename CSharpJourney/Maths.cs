using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney
{
    internal class Maths
    {
        public Maths() { 
            int a = 10;
            int b = 30;

            // Math.Max(x,y) - to find highest value from x and y(returns value)
            Console.WriteLine(Math.Max(a, b));

            // Math.Min(x, y) - to find highest value from x and y(returns value)
            Console.WriteLine(Math.Min(a, b));

            // Math.Sqrt(x) - it returns the square root of x
            Console.WriteLine(Math.Sqrt(a));

            // Math.Abs(x) - it returns the absolute(positive) value of x
            Console.WriteLine(Math.Abs(-4.7)); // it will return 4.7

            // Math.Round() - rounds a number to the nearest whole number
            Console.WriteLine(Math.Round(9.98));



        }
    }
}
