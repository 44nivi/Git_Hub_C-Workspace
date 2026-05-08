using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Hashtable_collection
    {
        public static void Main(String[] args)
        {
            Hashtable obj=new Hashtable();
            obj.Add("sno_1",01);
            obj.Add("sno_2", 02);
            obj.Add("sno_3", 03);
            obj.Add("sno_4", 04);

            Console.WriteLine(obj["sno_3"]);

            foreach(object key in obj.Keys) { 
            Console.WriteLine(obj[key]);
            Console.WriteLine($"these are the keys {key}");
            Console.WriteLine("this is the key hashcode "+key.GetHashCode());
            }

            foreach(object values in obj.Values) {
            Console.WriteLine($"these are the values {values}");
            }
            Console.ReadLine();


        }
    }
}
