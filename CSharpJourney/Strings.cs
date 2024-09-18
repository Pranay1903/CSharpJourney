using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpJourney
{
    internal class Strings
    {
        public Strings() {

            // String are used to storing text
            string greet1 = "Hello";
            string greet2 = "How Are You?";

            string firstName = "Pranay";
            string lastName = "Patel";

            // String Concatination - operator(+) can be used between strings to combine them
            string name = firstName + lastName;
            Console.WriteLine(name); 
            // only strings are concated numbers are not concated they will be added

            // String Interpolation (alternate way of Concatination) - substitutes values of variables into placeholders in a string
            name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            // Access Strings
            // You can access the characters in a string by referring to its index number inside square brackets[]
            // Note: String indexes start with 0
            Console.WriteLine(greet1[0]); // Outputs "H"

            // IndexOf() - find the index position of a specific character in a string
            Console.WriteLine(greet1.IndexOf("e"));

            // String length
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            // Some methods of string
            // ToUpper() - returns a copy of the string converted to uppercase
            Console.WriteLine(greet1.ToUpper() + ", " + greet2.ToUpper());

            // ToLower() - returns a copy of the string converted to lowercase
            Console.WriteLine(greet1.ToLower() + ", " + greet2.ToLower());

            // Special Characters
            // Strings must be written within quotes
            // To include quotes in a string use escape sequences

            // sequence \' - inserts a single quote in a string
            string singleQuote = "It\'s a nice day!"; 
            Console.WriteLine(singleQuote);

            // sequence \" - inserts a double quote in a string
            string doubleQuote = "He said, \"Hello!\""; 
            Console.WriteLine(doubleQuote);

            // sequence \\ - inserts a single backslash in a string
            string backslash = "This is a backslash: \\"; 
            Console.WriteLine(backslash);

            // \n - inserts a new line in a string
            string newLineExample = "This is the first line.\nThis is the second line."; // New line
            Console.WriteLine(newLineExample);

            // \t - inserts a tab space in a string
            string tabExample = "Column 1\tColumn 2"; // Tab
            Console.WriteLine(tabExample);

            // \b - performs a backspace in a string (removes the last character)
            string backspaceExample = "Hel\blo World"; // Backspace
            Console.WriteLine(backspaceExample);
        }
    }
}
