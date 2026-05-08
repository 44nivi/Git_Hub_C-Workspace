using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Conditional_Iterative
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I am from Class A");

            int num1, num2, num3,total;
            Console.WriteLine("enter the value for num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value for num2");

            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value for num3");
            num3 = int.Parse(Console.ReadLine());
            
            if (num1> num2 && num1>num3)
            {
                Console.WriteLine($"{num1} is greater");
            }
            else if (num2> num1 && num2>num3) { Console.WriteLine($"{num2} is greater"); }
            else { Console.WriteLine($"{num3} is greater"); }

            Console.ReadLine();
        }
    }
}
