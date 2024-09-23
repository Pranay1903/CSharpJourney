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

        public Methods()
        {
            // Calling methods without parameters
            Greet();

            // Calling method with a parameter
            PrintName("Pranay Patel");

            // Calling method with return type
            int sum = AddNumbers(5, 10);
            Console.WriteLine($"Sum of two numbers: {sum}");

            // Calling overloaded method
            int sum3 = AddNumbers(5, 10, 15);
            Console.WriteLine($"Sum of three numbers: {sum3}");

            // Calling method with multiple parameters
            int product = MultiplyNumbers(2, 3, 4);
            Console.WriteLine($"Product of three numbers: {product}");

            // Calling method with an optional parameter
            DisplayMessage();
            DisplayMessage("Hello, There");

            // Calling static method
            Methods.StaticGreet();
        }
    }
}

