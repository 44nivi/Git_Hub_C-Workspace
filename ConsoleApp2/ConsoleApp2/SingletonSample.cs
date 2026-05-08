using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SingletonSample
    {   
       public  void getvalue()
        {
            Console.WriteLine("hello world");
        }

    }

    class SimpleSingleton
    {
        public static void main(string[] args)
        {
            SingletonSample obj = new SingletonSample();
            obj.getvalue();
        }
    }

    
}
