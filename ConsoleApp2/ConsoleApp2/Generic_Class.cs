using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{   public class Genric_Assigner<T>         //Generic class that refer the data types dynamically ,once data type is declared
                                            // then the whole method occur the same data types
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }

        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
    }
    internal class Generic_Class
    {
        public static void Main(string[] args)
        {
            Genric_Assigner <int>obj = new Genric_Assigner<int>();
            obj.Add(10, 20);
            obj.sub(30, 40);
            obj.Mul(4, 6);
            Console.ReadLine();
        }
    }
}
