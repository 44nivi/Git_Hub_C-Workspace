using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            // Program for Type casting 


            Console.WriteLine("I am from Class A");
           
            int p, r, t, si;
            Console.WriteLine("enter the value for p");
            p=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value for r");

            r = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value for t");
            t = int.Parse(Console.ReadLine()); 
            si=(p*r*t)/100;
            Console.WriteLine($"the value for interest is {si}");
            Console.ReadLine();
        }
    }
}
