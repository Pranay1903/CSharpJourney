using System;

namespace CSharpJourney
{
    internal class AccessModifiers
    {
        // Private instance variables
        private string name;
        private int age;

        // Public method to set default values
        public void SetDefaultValues()
        {
            name = "Unknown";
            age = 0;
            Console.WriteLine("Default values set");
        }

        // Public method to set parameterized values
        public void SetValues(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("Parameterized values set");
        }

        // Protected method (only accessible in derived classes)
        protected void SetName(string name)
        {
            this.name = name;
            Console.WriteLine("Name set");
        }

        // Internal method (accessible within the same assembly)
        internal void SetAge(int age)
        {
            this.age = age;
            Console.WriteLine("Age set via internal method");
        }

        // Public method to display information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}