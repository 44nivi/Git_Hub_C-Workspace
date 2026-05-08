using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    delegate int Calculator(int n);//declaring delegate  

    internal class DeligateExample
    {
        static int number = 100;
        public static int add(int n)
        {
            number = number + n;
            return number;
        }
        public static int mul(int n)
        {
            number = number * n;
            return number;
        }
        public static int getNumber()
        {
            return number;
        }
        public static void Main(string[] args)
        {
            Calculator c1 ;//instantiating delegate  
            c1 = DeligateExample.add;
            //c1=c1+mul

            Console.WriteLine("After c1 delegate, Number is: " + getNumber());
                                 
            c1 += mul;

            c1(20);
            //calling method using delegate  
            Console.WriteLine("After c1 delegate, Number is: " + getNumber());


            Calculator c2 = new Calculator(mul);

            Calculator c3 = delegate(int n)
            {
                int number=300;    // new variable -> number not the static variable 
                return number;
            };
            c2(3);
            int total =c3(4);

            Console.WriteLine("After c2 delegate, Number is: " + getNumber());
            Console.WriteLine("After c3 delegate, Number is: " + total);

            Console.ReadLine();
        }
    }
}
// Deligates is type safe .
// Deligate is used to take a method and assign to a variable , pass it as a parameter
//it can be invoked using "invoke"
//Anonymous deligates can be created .
//but c3 does not change the static value .