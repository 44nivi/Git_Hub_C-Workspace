using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class school
    {   
        private int id;
        private String location;

        private string name;

        public school()
        {
        }

        public school(int id, string location)
        {
            this.id = id;
            this.location = location;
        }

        public int Id { get => id; set => id = value; }             // getter and setter to take the value from private
        public string Location { get => location; set => location = value; }
        public string Name { get => name; set => name = value; }    // properties to access private variable  
    }
    internal class Private_Access_Specifier
    {
        static void Main(string[] args)
        {
            school obj = new school(45, "gudalur") { Name="nivi"};    // pass the property value 
            Console.WriteLine(obj.Id+ "\t"+ obj.Location+"\t"+obj.Name);
            Console.ReadLine();


        }
    }
}
