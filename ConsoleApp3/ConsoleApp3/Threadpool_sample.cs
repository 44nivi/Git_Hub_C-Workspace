using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public Person(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
    }
    internal class Threadpool_sample
    {   

        static void BackgroundTask(Object stateInfo)
        {
            Console.WriteLine("Hello! I'm a worker from ThreadPool");
            Thread.Sleep(1000);
        }
        static void BackgroundTaskWithObject(Object stateInfo)
        {
            Person data = (Person)stateInfo;
            Console.WriteLine($"Hi {data.Name} from ThreadPool.");
            Thread.Sleep(1000);
        }


        static void Main(string[] args)
        {
            // Use ThreadPool for a worker thread
            ThreadPool.QueueUserWorkItem(BackgroundTask);
            Console.WriteLine("Main thread does some work, then sleeps.");
            Thread.Sleep(500);
            Console.WriteLine("Main thread exits.");

            Person p = new Person("Mahesh Chand", 40, "Male");
            ThreadPool.QueueUserWorkItem(BackgroundTaskWithObject, p);

            Console.ReadKey();
        }


    }
}
