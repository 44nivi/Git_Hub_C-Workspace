using ConsoleApp1.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Objectoreinted
    {
        static void Main(string[] args)
        {
            objectclass obj = new objectclass();
            obj.name = "nivi";
            obj.rollno = 4;
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.rollno);
            Console.ReadLine();

            objectclass obj2 = new objectclass("vivi", 5);
            obj2.Get_Data();

            objectclass obj3 = new objectclass();
            obj3.Set_Data();
            obj3.Get_Data();

            // to display the details of the object use override ToString 
            Console.WriteLine(obj);
          
            Console.ReadLine();
        }
        }
        
    
    
}
