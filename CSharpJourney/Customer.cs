using System;

namespace CSharpJourney
{
    // Encapsulation - Hides sensitive data by making fields private
    internal class Customer
    {
        // Private backing fields
        private string name;
        private int age;

        // Property for Name with get and set accessors
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Property for Age with get and set accessors
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Automatic property example for Email
        public string Email { get; set; }

        // Public method to display information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Email: {Email}");
        }
    }
}