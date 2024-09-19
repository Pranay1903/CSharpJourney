using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney
{
    internal class ConditionalStatments
    {
        public ConditionalStatments()
        {
            int age;
            Console.WriteLine("Enter Your Age:");
            age = Convert.ToInt32(Console.ReadLine());

            // if statement
            if (age < 13)
            {
                Console.WriteLine("You are a child.");
            }

            // else statement
            else
            {
                Console.WriteLine("You are not a child.");
            }

            // else if statement
            if (age >= 13 && age < 20)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (age >= 20 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }

            // Short hand if.. else (Ternary Operator)

            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}
