using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class LinQ_Sample1
    {
        static void Main(string[] args)
        {
            // Data source
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;
            Console.WriteLine(myLinqQuery.GetType());
            // Query execution
            foreach (var name in myLinqQuery)
                Console.Write(name + " ");

        }
    }
}
