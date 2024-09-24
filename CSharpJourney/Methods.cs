using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CSharpJourney
{
    internal class Methods
    {

        // Method without parameters
        public void Greet()
        {
            Console.WriteLine("Hello, Welcome to the CsharpJourney");
        }

        // Method with parameters
        public void PrintName(string name)
        {
            Console.WriteLine($"Your name is: {name}");
        }

        // Method with a return type
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // Method with multiple parameters
        public int MultiplyNumbers(int a, int b, int c)
        {
            return a * b * c;
        }

        // Method overloading - same method name, different parameters
        public int AddNumbers(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method with an optional parameter
        public void DisplayMessage(string message = "No message")
        {
            Console.WriteLine(message);
        }

        // Static method - can be called without creating an object
        public static void StaticGreet()
        {
            Console.WriteLine("Hello from a static method");
        }
    }
}

