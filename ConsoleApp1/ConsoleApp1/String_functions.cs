using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class String_functions
    {
        static void Main()
        {
            // Concatenation
            string str1 = "Hello";
            string str2 = "World";
            string result = str1 + " " + str2;
            Console.WriteLine("Concatenation: " + result);

            // Substring
            string str = "Hello World";
            string sub = str.Substring(6);
            Console.WriteLine("Substring: " + sub);

            // Length
            int length = str.Length;
            Console.WriteLine("Length: " + length);

            // Indexing
            char firstChar = str[0];
            Console.WriteLine("First character: " + firstChar);

            // Splitting
            string fruitsStr = "apple,banana,orange";
            string[] fruits = fruitsStr.Split(',');
            Console.WriteLine("Splitting: ");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Trimming
            string trimmedStr = "  Hello World  ".Trim();
            Console.WriteLine("Trimming: " + trimmedStr);

            // ToLower / ToUpper
            string lowerCase = str.ToLower();
            string upperCase = str.ToUpper();
            Console.WriteLine("ToLower: " + lowerCase);
            Console.WriteLine("ToUpper: " + upperCase);

            // Replace
            string replacedStr = str.Replace("Hello", "Hi");
            Console.WriteLine("Replace: " + replacedStr);

            // Contains
            bool contains = str.Contains("World");
            Console.WriteLine("Contains 'World': " + contains);

            // StartsWith / EndsWith
            bool startsWithHello = str.StartsWith("Hello");
            bool endsWithWorld = str.EndsWith("World");
            Console.WriteLine("StartsWith 'Hello': " + startsWithHello);
            Console.WriteLine("EndsWith 'World': " + endsWithWorld);

            Console.ReadLine();
        }
    }
}
