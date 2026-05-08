using ConsoleApp1.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Inheritance_Class : objectclass
    {
       

  
        static void Main(string[] args)
        {

            Inheritance_Class obj = new Inheritance_Class();
            obj.Set_Data();    // if this method is private it wont inherit in this class 

            obj.Get_Data();

                      

        }
    }
}
