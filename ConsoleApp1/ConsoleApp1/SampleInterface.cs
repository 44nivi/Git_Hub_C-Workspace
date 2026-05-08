using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface SampleInterface
    {
         void GetDetails();
        int CalculateSalary();

        void DisplayDetails();
        
    }


    class EmployeeDetails: SampleAbstract, SampleInterface 
    {
        public static void Main(string[] args)
        {
            EmployeeDetails demo = new EmployeeDetails();
            Console.WriteLine("enter the id and name");
            int Id =Convert.ToInt32(Console.ReadLine());
            string Name=Console.ReadLine();
            List<int> demoList =new List<int> { 34, 54, 65 };

            demo.GetEmployeeDetails(Id, Name,demoList);
            Console.WriteLine("this is main function "+Id+"and "+Name+"my List is"+demoList);
            foreach (int de in demoList)
            {
                Console.WriteLine("my list in mainfunction" + de);

            }
            Console.ReadLine();


        }

        public int CalculateSalary()
        {
            return 0;
        }

        public void DisplayDetails()
        {
            throw new NotImplementedException();
        }

        public void GetEmployeeDetails(int Id,string Name,List<int> dem)
        {
            List<int> demoList = dem;
            demoList.Add(888);
            int str_id=Id;
            str_id = 105;
            string name = Name;
            name = "nivi";
            Console.WriteLine("the id is "+str_id+"the name is "+name+"my list");
            foreach (int demo in demoList) { 
            Console.WriteLine("my list in method"+demo);
            
            }
            Console.ReadLine();
        }


        public override void EmployeePF()
        {
            throw new NotImplementedException();
        }

        public override void EMS()
        {
            Console.WriteLine();
        }

        public void GetDetails()
        {
            throw new NotImplementedException();
        }
    }
}
