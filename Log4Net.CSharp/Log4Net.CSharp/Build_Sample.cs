using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetCSharp
{
    internal class Build_Sample
    {
        public int X;
        private int Y;
        public int P1 { get; set; }
        private int P2 { get; set; }
        public void Method1()
        {
            Console.WriteLine("Method1 Invoked");
        }
        private void Method2()
        {
            Console.WriteLine("Method2 Invoked");
        }
    }
}
