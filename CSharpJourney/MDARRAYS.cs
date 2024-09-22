using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney
{
    internal class Mdarrays
    {
        public Mdarrays() {
            // Creating a 2D array
            int[,] matrix = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Accessing and displaying elements
            Console.WriteLine("Element at (1,1): " + matrix[1, 1]); // Accessing the element at 2nd row, 2nd column
            Console.WriteLine("All elements in the 2D array:");

            // Loop through the 2D array using nested loops
            for (int i = 0; i < matrix.GetLength(0); i++) // Rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Columns
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(); // New line after each row
            }

            // Modifying an element
            matrix[0, 0] = 10;
            Console.WriteLine("After modifying (0,0):");
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
