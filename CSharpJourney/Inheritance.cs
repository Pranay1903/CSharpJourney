using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CSharpJourney
{
    // Inheritance (Derived and Base Class)
    // inheritance allows one class to inherit fields and methods from another class 
    // This concept is organized into two categories:
    // Derived Class (Child): The class that inherits from another class
    // Base Class (Parent): The class being inherited from

    // You can implement inheritance using the `:` symbol
    
    // Why and when to use inheritance
    // - for code reusability
    // - reuse fields and methods of an existing class when creating a new class.

    // Base class
    internal class People
    {
        protected string name;
        protected int age;

        public People()
        {
            name = "Unknown";
            age = 0;
        }

        public People(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    // Derived class
    internal class Student : People
    {
        private string studentID;

        public Student() : base()
        {
            studentID = "Unknown";
        }

        public Student(string name, int age, string studentID) : base(name, age)
        {
            this.studentID = studentID;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Student ID: {studentID}");
        }
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            People person = new People("Pranay", 22);
            person.DisplayInfo();

            Student student = new Student("Krishna", 20, "S123");
            student.DisplayInfo();
        }
    }
}
