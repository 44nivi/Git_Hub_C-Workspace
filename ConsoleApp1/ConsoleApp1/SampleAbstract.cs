using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class SampleAbstract
    {
        string Name;
        int Salary;
       public  abstract void  EmployeePF();

        public virtual void EMS()
        {
            Console.WriteLine();
        }

    }
}
