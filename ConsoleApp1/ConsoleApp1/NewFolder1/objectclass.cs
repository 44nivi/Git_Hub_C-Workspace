using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder1
{
    internal class objectclass
    {
        public String name;
        public int rollno;

        public objectclass()
        {
        }

        public objectclass(string name, int rollno)
        {
            this.name = name;
            this.rollno = rollno;
        }


        public  void Set_Data() {
            this.name = "dachu";
            this.rollno = 3;
        
        }

        public void Get_Data()
        {
            
            Console.WriteLine("name" + this.name);
            Console.WriteLine("rollno" + this.rollno);
            Console.ReadLine();
        }

        public override string ToString()
        {
            return $"{rollno}\t{name}";
        }
    }
}
