using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class student {


        static public int total_student ;
        static public int value;

        public int roll;
        public String name;
        public int score;
        

        public student(int roll,String name,int score)
        {this.roll = roll;
        this.name = name;
            this.score = score;
            total_student++;

        }

        public static void Area(int r)
        {
            Console.WriteLine("enter the value for area and perimeter");
            value = int.Parse(Console.ReadLine());
            value = value * r;
            Console.WriteLine("area"+value);
        }
        public  void peri(int r)
        {
            int peri = value * r;
            Console.WriteLine("peri" + peri);
        }


    }
    internal class Static_Example
    {
        static void Main(string[] args)
        {
            student s1 = new student(1, "nivi", 450);
            student s2 = new student(2, "vini", 504);
            student s3 = new student(3, "mani", 453);
            Console.WriteLine(s1.score); Console.WriteLine(s1.name);Console.WriteLine(student.total_student);
           
            student.Area(6); // you cannot access the static method with the object , instead you can call them using class name
            s1.peri(4); // you can access normal method with object 
            Console.ReadLine();


        }
    }
}
