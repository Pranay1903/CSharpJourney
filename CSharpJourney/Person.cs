using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney
{
    internal class Person
    {
         string name;
         int age;

        // Constructor
        public Person(string name, int age)
        {
            this.name = name; // 'this' refers to the current instance
            this.age = age;
        }

        // Method to display person information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    // Program class to demonstrate object creation
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create an object of the Person class
            Person person1 = new Person("Pranay", 20);
            Person person2 = new Person("Neel", 25);

            // Call the DisplayInfo method
            person1.DisplayInfo();
            person2.DisplayInfo();
        }
    }
}