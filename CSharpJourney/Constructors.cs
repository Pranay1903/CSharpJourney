using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney
{
    internal class Constructors
    {
        // Instance variable
        private string name;
        private int age;

        // Default constructor
        public Constructors()
        {
            name = "Unknown";
            age = 0;
            Console.WriteLine("Default Constructor called");
        }

        // Parameterized constructor
        public Constructors(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine($"Parameterized Constructor called");
        }

        // Copy constructor
        public Constructors(Constructors obj)
        {
            name = obj.name;
            age = obj.age;
            Console.WriteLine("Copy Constructor called");
        }

        // Method to display information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}

