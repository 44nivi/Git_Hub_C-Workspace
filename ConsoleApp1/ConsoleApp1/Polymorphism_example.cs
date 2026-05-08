using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee                          // constructor overloading polymorphism 
    {
        public int id;
        public string name;
        public int salary;

        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            Console.WriteLine(id+"\t"+ name+"\t"+ salary);
        }

        public Employee(int id, int salary)
        {
            this.id = id;
            this.salary = salary;
            Console.WriteLine(id + "\t"  + salary);

        }

        public Employee()
        {
            Console.WriteLine("hi am empty constructor");
        }

        public void setdata()                   // method overloading polymorphism
        {
            Console.Write("enter id");
            id = int.Parse(Console.ReadLine());
            Console.Write("enter name");
            name = Console.ReadLine();
            Console.Write("enter salary");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine(id+"\t"+ name + " " + salary);
            Console.ReadLine();
        }

        public void setdata(int id,int salary)                   // method overloading polymorphism
        {
            this.id = id;
            this.salary = salary;
            Console.WriteLine(salary + " " + id);   
            Console.ReadLine() ;    
            
        }

        public virtual void  display()                          // normal method is overrided
        {
            Console.WriteLine(id + "\t" + name);
        }
    }
    class TempEmployee:Employee
    {
        public TempEmployee(int id,int salary):base(id, salary) 
        {

        }
        public override void display()                          // inherit from Employee and override the above display
        {
            base.display();
            Console.WriteLine("tem-"+id+"\t"+salary);
        } 

    }
    internal class Polymorphism_example
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp2 = new Employee(2,3450);
            Employee emp3 = new Employee(3,"nivi",5464);
            TempEmployee obj = new TempEmployee(4,5000);

            emp.setdata();
            emp.setdata(4,45000);
            emp.display();
            obj.display();


            Console.ReadLine();

        }
    }
}
