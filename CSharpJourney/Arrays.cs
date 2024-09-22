using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney
{
    internal class Arrays
    {
        public Arrays() {
            // array - used to store multiple values in a single variable
            // syntax - datatype[] array_name

            //creating array
            int[] myNum = { 10, 20, 30, 40 };

            // access the elements of array
            // you can access array element by referring to the index number
            // Note - array indexes start with 0

            Console.WriteLine($"Secend element of array: {myNum[1]}");

            // Changine array element
            myNum[1] = 50;
            Console.WriteLine($"After changing the secend element of array: {myNum[1]}");

            // other ways to create an array
            string[] cars;
            cars = new string[] { "Audi", "Volvo", "BMW", "Ford" };

            // Loop through an array
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            // using foreach loop
            Console.WriteLine("Using Foreach Loop:");
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sorting the array

            // Sorting a string
            Array.Sort(cars);
            Console.WriteLine("Sorted cars array:");
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sorting a int
            Array.Sort(myNum);
            foreach (int i in myNum)
            {
                Console.WriteLine(i);
            }

            // System.Linq Namespace
            // Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace

            Console.WriteLine($"largest value of mynum array: {myNum.Max()}");  // returns the largest value
            Console.WriteLine($"Smallest value of mynum array: {myNum.Min()}");  // returns the smallest value
            Console.WriteLine($"Sum of mynum array elements: {myNum.Sum()}");  // returns the sum of elements



        }
    }
}
