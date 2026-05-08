using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Implement_Interface : Interface1
    {
        public int id;
        public string name;
        public void Display()
        {
            Console.WriteLine("id"+id+"name"+name);
            Console.ReadLine();
        }

        public void getData()
        {   
            Console.WriteLine(id);
        }

        public void setData()
        {
            Console.WriteLine("Give the value for id");

            id = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Give the value for name");

            name = Console.ReadLine();
        }
    }
}
