using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    internal class Thread_sample
    {
        public static void DoSomeHeavyLifting()
        {
            Console.WriteLine("I'm lifting a truck!!");
            Thread.Sleep(1000);
            Console.WriteLine("Tired! Need a 3 sec nap.");
            Thread.Sleep(1000);
            Console.WriteLine("1....");
            Thread.Sleep(1000);
            Console.WriteLine("2....");
            Thread.Sleep(1000);
            Console.WriteLine("3....");
            Console.WriteLine("I'm awake.");
        }

             Task MyAsyncFunction()
        {
            await Task.Run(() => DoSomething());
            await Task.Run(() => DoSomeHeavyLifting());
        }

        public static void DoSomething()
        {
            
                Console.WriteLine("Hey! DoSomething here!");
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write($" {i} ");
                    Console.WriteLine();
                }
            Console.WriteLine("I'm done.");
        }

       /* public static void anything()
        {
            Console.WriteLine("Hey! anything here!");
            for (int i = 0; i < 5; i++)
                Console.Write($"its me anything {i} ");
            Console.WriteLine();
            Console.WriteLine("I'm anything done.");
        }
*/

        static void Main(string[] args)
        {
            Thread_sample obj = new Thread_sample();
            // Main execution starts here
            Console.WriteLine("Main thread starts here.");
            obj.MyAsyncFunction();

          
            Console.WriteLine("Main thread ends here.");
            Console.ReadKey();
        }
           
        }
    }



/*// This method takes 4 seconds to finish.
          *//*  Thread backgroundThread = new Thread(new ThreadStart(Thread_sample.DoSomething));

            backgroundThread.Start();       // this is background thread
          */


/*Thread background_thread_2 = new Thread(new ThreadStart(obj.DoSomething));
background_thread_2.Start();

 *//*

// This method doesn't take anytime at all.

// Execution ends here*/