using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1
{
    internal class rectangle:Shape_abstract
    {
       
        public override void area()
        {
            int d1 = 4, d2 = 5;
            Console.WriteLine( d1 * d2);
            Console.ReadLine();
        }

        public int get_peri()
        {
            return 2*(d1+d2);
        }
    }
}
