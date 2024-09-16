using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpJourney
{
    internal class Datatypes
    {

         static void Main(string[] args) {

            //integer size-4 bytes 
            int num = 10;
            Console.WriteLine(num);

            //long size-8 bytes
            long numl = 15000000000L;
            Console.WriteLine(numl);

            //float size-4 bytes
            float numf = 5.75F;
            Console.WriteLine(numf);

            //double size-8 bytes
            double numd = 19.99D;
            Console.Write(numd);


            //  Use float or double?
            // The precision of a floating point value indicates how many digits the value can have after the decimal point.
            // The precision of float is only six or seven decimal digits, while double variables have a precision of about 15 digits.
            // Therefore it is safer to use double for most calculations.


            // A floating point number can also be a scientific number with an "e" to indicate the power of 10
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            //bool size-1 bit 
            bool b1=true;
            bool b2=false; 
            Console.WriteLine(b1);
            Console.WriteLine(b2);

            //char size-2 bytes
            char Grade = 'B';
            Console.WriteLine(Grade);

            //string size-2 bytes per character
            string greet = "Hello World";
            Console.WriteLine(greet);


            //type casting

            // Implicit Casting(automatically) -converting a smaller type to a larger type size
            // char -> int -> long -> float -> double

            // Explicit Casting (manually) - converting a larger type to a smaller size type
            // double -> float -> long -> int -> char


            int myInt = 9;
            double myDouble = myInt; // Automatic casting: int to double

            Console.WriteLine("Int value:" + myInt);     
            Console.WriteLine("Double value:" + myDouble);


            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble1;    // Manual casting: double to int

            Console.WriteLine(myDouble1);
            Console.WriteLine(myInt1);

            // User Input 
            Console.WriteLine("Enter Your Name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Welcome to CSharpJourney: " + Name);

        }

    }
}
