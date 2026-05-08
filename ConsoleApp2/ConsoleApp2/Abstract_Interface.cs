    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp2
    {
        public class Employee
        {
            public void EmployeeDetails()
            {
                Console.WriteLine();
            }
            public void EMS()
            {
                Console.WriteLine();
            }
        }
        public class Trainee : Abs_class
        {
     
            public new void EmployeeDetails()
            {

            }
            public override void Salary()
            {
                throw new NotImplementedException();
            }


            public override void Work()
            {
                throw new NotImplementedException();
            }
        }
        public class TL : IEmployeeworks
        {
            public void Salary()
            {
                Console.WriteLine();
            }

            public void Work()
            {
                Console.WriteLine();
            }
        }
        public class Manager : IEmployeeworks
        {
            public void Salary()
            {
                Console.WriteLine();
            }

            public void Work()
            {
                Console.WriteLine();
            }
        }

        // Assume gona implement work and salary to all the three classes 
        /*
         *  work -Same function name but different in implementation 
         *  salary - same function name but different in implementation 
         *  
         *  hence it can be implemented by abstract class or interface 
         *  if the common features to be mentioned for the all given class abstract is better option 
         *  if any special feature to be mentioned individually then interface is better .
         *  Interface even support multiple inheritance 
         */

        public interface IEmployeeworks
        {
            void Work();
            void Salary();
        }
        public abstract class Abs_class{

            public void EmployeeDetails()
            {
                Console.WriteLine();
            }
            public void EMS()
            {
                Console.WriteLine();
            }
            public abstract void Work();
            public abstract void Salary();
        }
        internal class Abstract_Interface
        {

        }
    }
