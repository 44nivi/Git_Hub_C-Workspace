using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program_Arrays
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Declare the array");
            int[] sales = new int[3];
            String[] months = { "jan", "feb", "march" };
            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine(i + ": " + months[i]);
            }
            Console.ReadLine();

            foreach(String i in months)
            {
                Console.WriteLine(i);
               
            }
            Console.ReadLine();
        }
        
    }

    
}
