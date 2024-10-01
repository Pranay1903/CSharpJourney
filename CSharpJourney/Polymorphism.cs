using System;

namespace CSharpJourney
{
    // Polymorphism and Overriding Methods
    // Polymorphism means 'many forms'
    // It occurs when we have many classes that are related to each other by inheritance

    class Animal // Base class
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal // Derived class
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal // Derived class
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Polymorphism 
    {
        //public static void Main(string[] args) 
        //{
            //Animal myAnimal = new Animal(); // Create an Animal object
            //Animal myPig = new Pig(); // Create a Pig object
            //Animal myDog = new Dog(); // Create a Dog object

            //myAnimal.AnimalSound();
            //myPig.AnimalSound(); 
            //myDog.AnimalSound(); 
        //}
    }
}
