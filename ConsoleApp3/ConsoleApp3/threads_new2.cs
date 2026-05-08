using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class threads_new2
    {
        static void Main(string[] args)
        {
            // A thread created here to run Method1 Parallely
            Thread thread1 = new Thread(Method1)
            {
            };
            Console.WriteLine($"Thread1 is a Background thread:  {thread1.IsBackground}");
            thread1.Start();

            Thread thread3 = new Thread(Method3)
            {

            };

            thread3.start();
            //The control will come here and will exit 
            //the main thread or main application
            Console.WriteLine("Main Thread Exited");
            //As the Main thread (i.e. foreground thread exits the application)
            //Automatically, the background thread quits the application
        }
        // Static method
        static void Method1()
        {
            Console.WriteLine("Method1 Started");
            Thread thread2 = new Thread(Method2)
            {
                IsBackground = true
            };
            thread2.Start();
            Thread.Sleep(3000);

            
            Console.WriteLine("Method1 Exited");
        }
        // Static method
        static void Method2()
        {
            Console.WriteLine("Method2 Started");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method2 is in Progress!!");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Method2 Exited");
            Console.WriteLine("Press any key to Exit.");
        }


        static void method3()
        {
            Console.WriteLine("hi i am in thread 3");
            Console.ReadLine();

        }
    }
}
