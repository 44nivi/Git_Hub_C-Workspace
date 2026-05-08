using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Deli_gates
    {
        private int sid;
        private String name;
        private String std;
        private int mark;

        public int Sid { get => sid; set => sid = value; }
        public string Name { get => name; set => name = value; }
        public string Std { get => std; set => std = value; }
        public int Mark { get => mark; set => mark = value; }


    }

    public class Testclass{
        public Testclass() { }

        public static int CompareNames(Deli_gates x, Deli_gates y)
        {
            return x.Name.CompareTo(y.Name);
                

        }

    }
    internal class Deligates_pgm
    {
        static void Main(string[] args)
        {
            Testclass test = new Testclass();

            Deli_gates obj = new Deli_gates { Sid = 101, Name = "nivi", Std = "iv", Mark = 89 };
            Deli_gates obj2 = new Deli_gates { Sid = 103, Name = "dinu", Std = "v", Mark = 75 };
            Deli_gates obj3 = new Deli_gates { Sid = 104, Name = "pravee", Std = "vi", Mark = 34 };
            Deli_gates obj4 = new Deli_gates { Sid = 108, Name = "venu", Std = "iv", Mark = 74 };
            List<Deli_gates> deli_Gates = new List<Deli_gates>() { obj, obj2, obj3, obj4 };
            
            Comparison<Deli_gates> newobj = new Comparison<Deli_gates>(Testclass.CompareNames);   // passing the deligate method

            // here the method is passed as deligates
            /* we can able to pass the deligates in different ways
             *  i) if we doesnt declare Comparison<Deli_gates> newobj = new Comparison<Deli_gates>(Testclass.CompareNames),it will create deligates internally
             * ii) write through anonymous method 
             *      eg:  deli_Gates.Sort(delegate(Deli_gates x,Deligates y){ return x.Name.CompareTo(y.Name);})
             *      writing the above method directly as given 
             * iii) Using Lamda operator
             *      eg:  deli_Gates.Sort((x,y)=>x.Name.CompareTo(y.Name))
             * 
            */

            deli_Gates.Sort(newobj);


            foreach (var value in deli_Gates)
            {

                Console.WriteLine($"{value.Name}, {value.Sid}");

            }
            Console.ReadLine();
        }

        
    }
}
