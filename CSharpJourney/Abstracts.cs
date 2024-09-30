using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney
{
    internal class Abstracts
    {
        // Data abstraction is the process of hiding certain details and showing only essential information to the user

        // Abstract class:
        // is a restricted class that cannot be used to create objects
        // to access it, it must be inherited from another class

        // Abstract method:
        // can only be used in an abstract class, and it does not have a body
        // The body is provided by the derived class (inherited from)

        // Abstract class
        abstract class Animal
        {
            // Abstract method (does not have a body)
            public abstract void animalSound();
            // Regular method
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        // Derived class (inherit from Animal)
        class Pig : Animal
        {
            public override void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Pig myPig = new Pig();
                myPig.animalSound();
                myPig.sleep();
            }
        }
    }
}
