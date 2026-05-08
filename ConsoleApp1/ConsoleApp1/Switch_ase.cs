using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Switch_ase
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I am from Class A");

            Console.WriteLine("enter the value for Character");
            char num1 = Convert.ToChar(Console.Read());
            switch (num1)
            {
                case 'A':    // statements
                    Console.WriteLine($"your choice is {num1}");

                    break;

                case 'B':
                    Console.WriteLine($"your choice is {num1}");                    // statements
                    break;

                case 'C':    // statements
                    Console.WriteLine($"your choice is {num1}");
                    break;

                default:

                    Console.WriteLine("Invalid entry ");// default statements

                    break;
            }

            Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            

            int X = 0;
            while (X > 5)
            {
                Console.WriteLine(X);
                X++;
            }
            Console.ReadLine();


        }
    }
}
