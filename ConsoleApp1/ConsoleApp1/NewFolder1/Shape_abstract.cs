using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1
{
    internal abstract class Shape_abstract
    {
        public int d1, d2;

        public Shape_abstract()
        {
        }

        public Shape_abstract(int d1, int d2)
        {
            this.d1 = d1;
            this.d2 = d2;
        }

        public override string ToString()
        {
            return "d1" +d1+"\t"+"D2"+ d2;

        }

        abstract public void area();     // abstract cannot be private to override
                                        

    }
}
