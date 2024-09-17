using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney
{
    internal class Operator
    {
        
        public Operator() { 
        int a = 10;
        int b = 5;
        
        // Arithmetic Operators
        Console.WriteLine($"a + b = {a + b}");  // Addition
        Console.WriteLine($"a - b = {a - b}");  // Subtraction
        Console.WriteLine($"a * b = {a * b}");  // Multiplication
        Console.WriteLine($"a / b = {a / b}");  // Division
        Console.WriteLine($"a % b = {a % b}");  // Modulas

        // Relational Operators
        Console.WriteLine($"a == b: {a == b}"); // Equal to
        Console.WriteLine($"a != b: {a != b}"); // Not equal to
        Console.WriteLine($"a > b: {a > b}");   // Greater than
        Console.WriteLine($"a < b: {a < b}");   // Less than
        Console.WriteLine($"a >= b: {a >= b}"); // Greater than or equal to
        Console.WriteLine($"a <= b: {a <= b}"); // Less than or equal to


        // Logical Operators
        bool x = true;
        bool y = false;

        Console.WriteLine($"x && y: {x && y}"); // Logical AND
        Console.WriteLine($"x || y: {x || y}"); // Logical OR
        Console.WriteLine($"!x: {!x}"); // Logical NOT


        // Increment/decrement Operators
        int count = 0;
        Console.WriteLine($"intial Count value:{count}");    
        // Post-increment
        Console.WriteLine($"count++: {count++}"); 
        Console.WriteLine($"After count++: {count}");
        // Pre-increment
        Console.WriteLine($"++count: {++count}");
        // Post-decrement
        Console.WriteLine($"count--: {count--}"); 
        Console.WriteLine($"After count--: {count}");
        // Pre-decrement
        Console.WriteLine($"--count: {--count}");


        //Ternary Operator/Conditional Operator (?)
        int max = (a > b) ? a : b;
        Console.WriteLine($"The maximum of a and b is: {max}");


        }

    }
}
