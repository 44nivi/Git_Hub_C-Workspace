using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Generic_Type_function
    {
        public bool compare(object a, object b)
        {   if (a == b)
                return true;
            return false;
        }
        public bool compare<T>(T a, T b)        
        {
            if (a.Equals(b))
                return true;
            return false;

        }


        public static void Main(String[] args)
        {
            Generic_Type_function obj = new Generic_Type_function();
            object var=obj.compare(4.5f, 4.5);
            Generic_Type_function obj2 = new Generic_Type_function();
            object var2 = obj2.compare<float>(3.5f, 3.5f);
            Console.WriteLine("the value of "+var);
            Console.WriteLine("the value of " + var2);
            Console.ReadLine();
        }
    }
}
