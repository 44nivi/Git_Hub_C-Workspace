using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Enum_Datatype  //An enumeration is a set of named constants representing integral numeric values.
    {
        public enum Country
        {
            Unknown,
            Canada,
            UnitedStates
        }
        static void Main(string[] args)
        {
            foreach (var country in Enum.GetValues(typeof(Country)))
            {
                Console.WriteLine(country.ToString() + ' ' + (int)country);
            }
            Console.ReadLine();
        }
    }
}


