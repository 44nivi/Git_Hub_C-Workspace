using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Customer{
     public int custid { get; set; }
    public string Name { get; set; }
    public string city { get; set; }
    public int Balance { get; set; }
        }

    /* class  Employee
    {
        private string name;
        private int age;
        private double salary;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public double Salary { get => salary; set => salary = value; }
    }*/
    public class Seller
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
    internal class Class_Datatype
    {
        public static void Main(String[] args)
        { 

            /*List<Employee> obj2 = new List<Employee>();
            Employee var= new Employee {Name="nivi",Age=12,Salary=1000 };

            Employee var2 = new Employee { Name = "ALEX", Age = 24, Salary = 10000 };


            Employee var3 = new Employee { Name = "SUBA", Age = 30, Salary = 12000 };

            obj2.Add(var);
            obj2.Add(var2);
*/


            List<Seller> obj = new List<Seller>();

            Seller ob1 = new Seller { Id = 110, Name = "vini" };
            obj.Add(ob1);

            foreach (Seller c in obj)
            {
                Console.WriteLine("Customer name " + c.Name);
                Console.WriteLine("Customer Balance" + c.Id);
            }

            List<Customer> list = new List<Customer>();
            Customer c1 = new Customer { custid = 101, Name = "NIVI", city = "CBE", Balance = 25000 };
            Customer c2 = new Customer { custid = 101, Name = "VIVI", city = "CBE", Balance = 25000 };
            Customer C3 = new Customer { custid = 101, Name = "PONNU", city = "CBE", Balance = 25000 };

            list.Add(c1);
            list.Add(c2);
            list.Add(C3);

            foreach (Customer c in list)
            {
                Console.WriteLine("Customer name " + c.Name);
                Console.WriteLine("Customer Balance" + c.Balance);
            }
            Console.ReadLine();
        }
    }

    
}

