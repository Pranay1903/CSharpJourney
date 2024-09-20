using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney
{
    internal class Loops
    {
        public Loops()
        {
            // While loop
            int i = 0;
            Console.WriteLine("\nPrinting using While Loop");
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }


            // Do/while loop
            Console.WriteLine("\nPrinting using Do/while Loop");
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);


            // For Loop
            Console.WriteLine("\nEnter A Number to print that table");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{n} * {j} = {n * j}");
            }

            // Foreach Loop - used exclusively to loop through elements in an array (or other data sets)
            Console.WriteLine("\nPrinting using Foreach Loop");
            string[] cars = { "Volvo", "BMW", "Ford", "Audi" };
            foreach (string c in cars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
