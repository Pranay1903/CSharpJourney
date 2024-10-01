using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJourney
{
    // Interface
    // Another way to achieve abstraction
    // is a completely "abstract class"
    // Note: Interfaces can contain properties and methods, but not fields

    // Why And When To Use
    // To achieve security - hide certain details and only show the important details of an object (interface)
    // C# does not support multiple inheritance. However, it can be achieved with interfaces
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("First Interface method");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Second interface method");
        }
    }

    internal class Interfaces
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();
            myObj.myOtherMethod();
        }
    }
}
