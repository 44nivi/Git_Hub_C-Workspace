using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2   
{
    internal class Genric_List
    {
        public static void Main(String[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(1, 56);
            list.Remove(3);
            foreach (int i in list)
            {
                Console.WriteLine("the updated values " + i);
               
            }
            Console.ReadLine();
        }

    }
}
