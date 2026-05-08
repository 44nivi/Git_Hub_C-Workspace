using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Arraylist_Collection
    {
        public static void Main(String[] args)
        {
            ArrayList obj= new ArrayList(10);
            obj.Add(5);
            obj.Add(20);
            obj.Add(30);
            obj.Add(40);
            Console.WriteLine("the capacity is "+obj.Capacity);
            foreach(object i in obj) { 
            Console.WriteLine(i);

            }
            obj.Insert(2,99);

            foreach (object i in obj)
            {
                Console.WriteLine("the updated values "+ i);
            }

            // obj.Remove(30);                                    //to remove by element 
            obj.RemoveAt(3);                                       // to remove by index 

            foreach (object i in obj)
            {
                Console.WriteLine("the updated values " + i);
            }

            Console.ReadLine();
    
        }

    }

}
